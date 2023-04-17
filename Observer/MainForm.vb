Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.IO
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Namespace Observer
    Public Partial Class MainForm
        Inherits Form
        Private _folderBrowserDialog As FolderBrowserDialog
        Private _columnSorter As ListViewColumnSorter
        Private _exclusions As List(Of Exclusion)

        Private _lockObject As Object

        Public Sub New()
            InitializeComponent()
            CheckForIllegalCrossThreadCalls = False
            Options.ApplyTheme(Me)

            _columnSorter = New ListViewColumnSorter()
            eventList.ListViewItemSorter = _columnSorter

            _folderBrowserDialog = New FolderBrowserDialog()
            _folderBrowserDialog.Description = "Choose your desired path to observe"
            _folderBrowserDialog.RootFolder = Environment.SpecialFolder.MyComputer

            _exclusions = New List(Of Exclusion)()
            _lockObject = New Object()

            txtPath.Text = Options.CurrentOptions.Path

            LoadExclusions()

            checkCreated.Checked = Options.CurrentOptions.FileCreatedEvent
            checkDeleted.Checked = Options.CurrentOptions.FileDeletedEvent
            checkModified.Checked = Options.CurrentOptions.FileModifiedEvent
            checkRenamed.Checked = Options.CurrentOptions.FileRenamedEvent
            chkExclusions.Checked = Options.CurrentOptions.ExclusionsEnabled

            Text = "Observer " & GetCurrentVersionToString()
        End Sub

        Private Sub LoadExclusions()
            _exclusions.Clear()

            For Each x In Options.CurrentOptions.Exclusions
                Dim pf As Exclusion = New Exclusion(x)
                _exclusions.Add(pf)
            Next
        End Sub

        Private Sub HandleButtonState()
            btnStart.Enabled = Not btnStart.Enabled
            btnStop.Enabled = Not btnStop.Enabled
            btnExclusions.Enabled = Not btnExclusions.Enabled
            txtPath.Enabled = Not txtPath.Enabled
        End Sub

        Private Sub ExportLog()
            If eventList.Items.Count > 0 Then
                Dim sb As StringBuilder = New StringBuilder()
                sb.AppendFormat("Observer log - {0}, {1}" & Microsoft.VisualBasic.Constants.vbLf & Microsoft.VisualBasic.Constants.vbLf, Date.Now.ToLongDateString(), Date.Now.ToLongTimeString())

                For Each i As ListViewItem In eventList.Items
                    sb.AppendFormat("Object: {0}" & Microsoft.VisualBasic.Constants.vbLf, i.Text)
                    sb.AppendFormat("Last accessed: {0}" & Microsoft.VisualBasic.Constants.vbLf, i.SubItems(CInt(1)).Text)
                    sb.AppendFormat("Access count: {0}" & Microsoft.VisualBasic.Constants.vbLf, i.SubItems(CInt(2)).Text)
                    sb.AppendFormat("Access type: {0}" & Microsoft.VisualBasic.Constants.vbLf & Microsoft.VisualBasic.Constants.vbLf, i.Tag.ToString())
                Next

                Dim dialog As SaveFileDialog = New SaveFileDialog()
                dialog.InitialDirectory = Application.StartupPath
                dialog.DefaultExt = ".log"
                dialog.Filter = "Observer log files|*.log"

                If dialog.ShowDialog() = DialogResult.OK Then
                    Call File.WriteAllText(dialog.FileName, sb.ToString())
                End If
            End If
        End Sub

        Private Function CheckExclusions(ByVal path As String) As Boolean
            ' ignore exclusions
            If Not Options.CurrentOptions.ExclusionsEnabled Then Return True

            Dim passed = True

            For Each x In _exclusions
                If path.Contains(x.Filter) Then
                    passed = False
                    Exit For
                End If
            Next

            Return passed
        End Function

        Private Sub HandleFileSystemWatcherUpdate()
            Dim doWorkEventObject As WorkEventArgs = WorkEvents.Instance.GetEventObject()
            If doWorkEventObject IsNot Nothing Then
                Dim fileName = doWorkEventObject.FileName
                If CheckExclusions(Path.GetDirectoryName(fileName)) Then
                    Dim eventTypeString = doWorkEventObject.EventType

                    Dim currItem As ListViewItem = Nothing
                    SyncLock eventList
                        Try
                            For Each lvi As ListViewItem In eventList.Items
                                If Equals(lvi.Text, fileName) AndAlso Equals(lvi.Tag.ToString(), eventTypeString) Then
                                    currItem = lvi
                                    Continue For
                                End If
                            Next

                        Catch
                        End Try
                    End SyncLock

                    Dim wea As WorkEventArgs = New WorkEventArgs(fileName, eventTypeString, currItem)

                    ' DoWorkEventArgs dw = new DoWorkEventArgs(wea);

                    If Not changeEventBackgroundWorker.IsBusy Then
                        changeEventBackgroundWorker.RunWorkerAsync(wea)
                    Else
                        WorkEvents.Instance.Add(wea)
                    End If
                End If
            End If
        End Sub

        Private Sub HandleFileSystemWatcherUpdate(ByVal eventType As EventType, ByVal e As FileSystemEventArgs)
            Dim fileName = fileSystemWatcher.Path & e.Name

            If CheckExclusions(Path.GetDirectoryName(fileName)) Then
                Dim eventTypeString = String.Empty
                Select Case eventType
                    Case EventType.Modified
                        If Not checkModified.Checked Then
                            Return
                        End If
                        eventTypeString = "Modified"

                        Exit Select
                    Case EventType.Created
                        If Not checkCreated.Checked Then
                            Return
                        End If

                        eventTypeString = "Created"
                        Exit Select
                    Case EventType.Deleted
                        If Not checkDeleted.Checked Then
                            Return
                        End If
                        eventTypeString = "Deleted"
                        Exit Select
                    Case EventType.Renamed
                        If Not checkRenamed.Checked Then
                            Return
                        End If

                        eventTypeString = "Renamed"
                        Exit Select
                End Select

                Dim currItem As ListViewItem = Nothing
                SyncLock eventList
                    Try
                        For Each lvi As ListViewItem In eventList.Items
                            If Equals(lvi.Text, fileName) AndAlso Equals(lvi.Tag.ToString(), eventTypeString) Then
                                currItem = lvi
                                Continue For
                            End If
                        Next

                    Catch
                    End Try
                End SyncLock

                Dim wea As WorkEventArgs = New WorkEventArgs(fileName, eventTypeString, currItem)

                ' DoWorkEventArgs dw = new DoWorkEventArgs(wea);

                If Not changeEventBackgroundWorker.IsBusy Then
                    changeEventBackgroundWorker.RunWorkerAsync(wea)
                Else
                    WorkEvents.Instance.Add(wea)
                End If
            End If
        End Sub

        Private Sub StartObserving()
            eventList.Items.Clear()
            fileSystemWatcher.Path = txtPath.Text
            fileSystemWatcher.EnableRaisingEvents = True
            HandleButtonState()
            Text = "Observer " & GetCurrentVersionToString() & " - Observing"
        End Sub

        Private Sub StopObserving()
            fileSystemWatcher.EnableRaisingEvents = False
            HandleButtonState()
            Text = "Observer " & GetCurrentVersionToString()
        End Sub

        Private Sub MainForm_Load(ByVal sender As Object, ByVal e As EventArgs)
            SystemWideHotKey.RegisterHotKey(Me, Keys.Shift Or Keys.F12 Or Keys.Control)
            eventList.Select()
        End Sub

        Private Sub MainForm_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs)
            SystemWideHotKey.UnregisterHotKey(Me)

            Options.CurrentOptions.Path = txtPath.Text
            Options.SaveSettings()
        End Sub

        Private Sub checkModified_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Options.CurrentOptions.FileModifiedEvent = checkModified.Checked
        End Sub

        Private Sub checkCreated_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Options.CurrentOptions.FileCreatedEvent = checkCreated.Checked
        End Sub

        Private Sub checkDeleted_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Options.CurrentOptions.FileDeletedEvent = checkDeleted.Checked
        End Sub

        Private Sub checkRenamed_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Options.CurrentOptions.FileRenamedEvent = checkRenamed.Checked
        End Sub

        Private Sub btnBrowse_Click(ByVal sender As Object, ByVal e As EventArgs)
            If _folderBrowserDialog.ShowDialog() = DialogResult.OK Then
                txtPath.Text = _folderBrowserDialog.SelectedPath
            End If
        End Sub

        Private Sub btnAbout_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim f As AboutForm = New AboutForm()
            f.ShowDialog(Me)
        End Sub

        Private Sub btnStart_Click(ByVal sender As Object, ByVal e As EventArgs)
            If Not String.IsNullOrEmpty(txtPath.Text) Then
                If txtPath.Text.Last() <> "\"c Then txtPath.AppendText("\")
                StartObserving()
            End If
        End Sub

        Private Sub changeEventBackgroundWorker_DoWork(ByVal sender As Object, ByVal e As DoWorkEventArgs)
            SyncLock _lockObject
                Dim wea = CType(e.Argument, WorkEventArgs)

                If wea.CurrentItem IsNot Nothing Then
                    wea.CurrentItem.Text = wea.FileName
                    wea.CurrentItem.SubItems(1).Text = Date.Now.ToLongTimeString()
                    Dim currCount As Long = Convert.ToInt64(wea.CurrentItem.SubItems(2).Text.ToString()) + 1
                    wea.CurrentItem.SubItems(2).Text = currCount.ToString()
                Else
                    Dim mainItem As ListViewItem = New ListViewItem(wea.FileName)
                    mainItem.Tag = wea.EventType
                    mainItem.SubItems.Add(Date.Now.ToLongTimeString())

                    mainItem.SubItems.Add("1")
                    mainItem.SubItems.Add(wea.EventType)
                    eventList.Items.Add(mainItem)
                End If
            End SyncLock
        End Sub

        Private Sub fileSystemWatcher_Changed(ByVal sender As Object, ByVal e As FileSystemEventArgs)
            HandleFileSystemWatcherUpdate(EventType.Modified, e)
        End Sub

        Private Sub fileSystemWatcher_Created(ByVal sender As Object, ByVal e As FileSystemEventArgs)
            HandleFileSystemWatcherUpdate(EventType.Created, e)
        End Sub

        Private Sub fileSystemWatcher_Deleted(ByVal sender As Object, ByVal e As FileSystemEventArgs)
            HandleFileSystemWatcherUpdate(EventType.Deleted, e)
        End Sub

        Private Sub fileSystemWatcher_Renamed(ByVal sender As Object, ByVal e As RenamedEventArgs)
            HandleFileSystemWatcherUpdate(EventType.Renamed, e)
        End Sub

        Private Sub btnStop_Click(ByVal sender As Object, ByVal e As EventArgs)
            StopObserving()
        End Sub

        Private Sub eventList_MouseDoubleClick(ByVal sender As Object, ByVal e As MouseEventArgs)
            Try
                If File.Exists(eventList.SelectedItems(0).SubItems(0).Text) Then
                    Process.Start("explorer.exe", "/select, " & eventList.SelectedItems(0).SubItems(0).Text)
                Else
                    If Directory.Exists(eventList.SelectedItems(0).SubItems(0).Text) Then
                        Process.Start(eventList.SelectedItems(0).SubItems(0).Text)
                    End If
                End If

            Catch
            End Try
        End Sub

        Private Sub eventList_ColumnClick(ByVal sender As Object, ByVal e As ColumnClickEventArgs)
            If e.Column = _columnSorter.SortColumn Then
                If _columnSorter.Order = SortOrder.Ascending Then
                    _columnSorter.Order = SortOrder.Descending
                Else
                    _columnSorter.Order = SortOrder.Ascending
                End If
            Else
                _columnSorter.SortColumn = e.Column
                _columnSorter.Order = SortOrder.Ascending
            End If

            eventList.Sort()
        End Sub

        Protected Overrides Sub WndProc(ByRef m As Message)
            MyBase.WndProc(m)

            If m.Msg = SystemWideHotKey.WM_HOTKEY Then
                StopObserving()
            End If
        End Sub

        Private Sub extraWorkTimer_Tick(ByVal sender As Object, ByVal e As EventArgs)
            extraWorkTimer.Stop()
            HandleFileSystemWatcherUpdate()
            extraWorkTimer.Start()
        End Sub

        Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim f As ExclusionsForm = New ExclusionsForm()
            f.ShowDialog()

            LoadExclusions()
        End Sub

        Private Sub btnOptions_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim f As OptionsForm = New OptionsForm(Me)
            f.ShowDialog()
        End Sub

        Private Sub btnExport_Click(ByVal sender As Object, ByVal e As EventArgs)
            ExportLog()
        End Sub

        Private Sub chkExclusions_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Options.CurrentOptions.ExclusionsEnabled = chkExclusions.Checked
        End Sub
    End Class
End Namespace
