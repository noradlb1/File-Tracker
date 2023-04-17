Imports System
Imports System.IO

Namespace Observer
    Partial Class MainForm
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <paramname="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
            Me.txtPath = New System.Windows.Forms.TextBox()
            Me.btnAbout = New System.Windows.Forms.Button()
            Me.btnOptions = New System.Windows.Forms.Button()
            Me.btnBrowse = New System.Windows.Forms.Button()
            Me.checkModified = New System.Windows.Forms.CheckBox()
            Me.checkCreated = New System.Windows.Forms.CheckBox()
            Me.checkDeleted = New System.Windows.Forms.CheckBox()
            Me.checkRenamed = New System.Windows.Forms.CheckBox()
            Me.lblStatus = New System.Windows.Forms.Label()
            Me.eventList = New System.Windows.Forms.ListView()
            Me.columnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.columnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.columnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.columnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.btnStart = New System.Windows.Forms.Button()
            Me.btnStop = New System.Windows.Forms.Button()
            Me.fileSystemWatcher = New System.IO.FileSystemWatcher()
            Me.changeEventBackgroundWorker = New System.ComponentModel.BackgroundWorker()
            Me.extraWorkTimer = New System.Windows.Forms.Timer(Me.components)
            Me.btnExclusions = New System.Windows.Forms.Button()
            Me.btnExport = New System.Windows.Forms.Button()
            Me.chkExclusions = New System.Windows.Forms.CheckBox()
            CType(Me.fileSystemWatcher, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'txtPath
            '
            Me.txtPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtPath.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.txtPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtPath.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtPath.ForeColor = System.Drawing.Color.White
            Me.txtPath.Location = New System.Drawing.Point(56, 10)
            Me.txtPath.Margin = New System.Windows.Forms.Padding(2)
            Me.txtPath.Name = "txtPath"
            Me.txtPath.Size = New System.Drawing.Size(567, 29)
            Me.txtPath.TabIndex = 1
            '
            'btnAbout
            '
            Me.btnAbout.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnAbout.BackColor = System.Drawing.Color.DodgerBlue
            Me.btnAbout.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
            Me.btnAbout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue
            Me.btnAbout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue
            Me.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnAbout.ForeColor = System.Drawing.Color.White
            Me.btnAbout.Location = New System.Drawing.Point(735, 10)
            Me.btnAbout.Margin = New System.Windows.Forms.Padding(2)
            Me.btnAbout.Name = "btnAbout"
            Me.btnAbout.Size = New System.Drawing.Size(69, 27)
            Me.btnAbout.TabIndex = 83
            Me.btnAbout.Tag = "themeable"
            Me.btnAbout.Text = "About"
            Me.btnAbout.UseVisualStyleBackColor = False
            '
            'btnOptions
            '
            Me.btnOptions.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnOptions.BackColor = System.Drawing.Color.DodgerBlue
            Me.btnOptions.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
            Me.btnOptions.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue
            Me.btnOptions.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue
            Me.btnOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnOptions.ForeColor = System.Drawing.Color.White
            Me.btnOptions.Location = New System.Drawing.Point(662, 10)
            Me.btnOptions.Margin = New System.Windows.Forms.Padding(2)
            Me.btnOptions.Name = "btnOptions"
            Me.btnOptions.Size = New System.Drawing.Size(69, 27)
            Me.btnOptions.TabIndex = 82
            Me.btnOptions.Tag = "themeable"
            Me.btnOptions.Text = "Options"
            Me.btnOptions.UseVisualStyleBackColor = False
            '
            'btnBrowse
            '
            Me.btnBrowse.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnBrowse.BackColor = System.Drawing.Color.DodgerBlue
            Me.btnBrowse.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
            Me.btnBrowse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue
            Me.btnBrowse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue
            Me.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnBrowse.ForeColor = System.Drawing.Color.White
            Me.btnBrowse.Location = New System.Drawing.Point(627, 10)
            Me.btnBrowse.Margin = New System.Windows.Forms.Padding(2)
            Me.btnBrowse.Name = "btnBrowse"
            Me.btnBrowse.Size = New System.Drawing.Size(30, 27)
            Me.btnBrowse.TabIndex = 81
            Me.btnBrowse.Tag = "themeable"
            Me.btnBrowse.Text = "..."
            Me.btnBrowse.UseVisualStyleBackColor = False
            '
            'checkModified
            '
            Me.checkModified.AutoSize = True
            Me.checkModified.Checked = True
            Me.checkModified.CheckState = System.Windows.Forms.CheckState.Checked
            Me.checkModified.ForeColor = System.Drawing.Color.DodgerBlue
            Me.checkModified.Location = New System.Drawing.Point(10, 42)
            Me.checkModified.Margin = New System.Windows.Forms.Padding(2)
            Me.checkModified.Name = "checkModified"
            Me.checkModified.Size = New System.Drawing.Size(95, 19)
            Me.checkModified.TabIndex = 84
            Me.checkModified.Tag = "themeable"
            Me.checkModified.Text = "File modified"
            Me.checkModified.UseVisualStyleBackColor = True
            '
            'checkCreated
            '
            Me.checkCreated.AutoSize = True
            Me.checkCreated.Checked = True
            Me.checkCreated.CheckState = System.Windows.Forms.CheckState.Checked
            Me.checkCreated.ForeColor = System.Drawing.Color.DodgerBlue
            Me.checkCreated.Location = New System.Drawing.Point(110, 42)
            Me.checkCreated.Margin = New System.Windows.Forms.Padding(2)
            Me.checkCreated.Name = "checkCreated"
            Me.checkCreated.Size = New System.Drawing.Size(86, 19)
            Me.checkCreated.TabIndex = 85
            Me.checkCreated.Tag = "themeable"
            Me.checkCreated.Text = "File created"
            Me.checkCreated.UseVisualStyleBackColor = True
            '
            'checkDeleted
            '
            Me.checkDeleted.AutoSize = True
            Me.checkDeleted.Checked = True
            Me.checkDeleted.CheckState = System.Windows.Forms.CheckState.Checked
            Me.checkDeleted.ForeColor = System.Drawing.Color.DodgerBlue
            Me.checkDeleted.Location = New System.Drawing.Point(203, 42)
            Me.checkDeleted.Margin = New System.Windows.Forms.Padding(2)
            Me.checkDeleted.Name = "checkDeleted"
            Me.checkDeleted.Size = New System.Drawing.Size(86, 19)
            Me.checkDeleted.TabIndex = 86
            Me.checkDeleted.Tag = "themeable"
            Me.checkDeleted.Text = "File deleted"
            Me.checkDeleted.UseVisualStyleBackColor = True
            '
            'checkRenamed
            '
            Me.checkRenamed.AutoSize = True
            Me.checkRenamed.Checked = True
            Me.checkRenamed.CheckState = System.Windows.Forms.CheckState.Checked
            Me.checkRenamed.ForeColor = System.Drawing.Color.DodgerBlue
            Me.checkRenamed.Location = New System.Drawing.Point(296, 42)
            Me.checkRenamed.Margin = New System.Windows.Forms.Padding(2)
            Me.checkRenamed.Name = "checkRenamed"
            Me.checkRenamed.Size = New System.Drawing.Size(94, 19)
            Me.checkRenamed.TabIndex = 87
            Me.checkRenamed.Tag = "themeable"
            Me.checkRenamed.Text = "File renamed"
            Me.checkRenamed.UseVisualStyleBackColor = True
            '
            'lblStatus
            '
            Me.lblStatus.AutoSize = True
            Me.lblStatus.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblStatus.ForeColor = System.Drawing.Color.DodgerBlue
            Me.lblStatus.Location = New System.Drawing.Point(6, 10)
            Me.lblStatus.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
            Me.lblStatus.Name = "lblStatus"
            Me.lblStatus.Size = New System.Drawing.Size(46, 21)
            Me.lblStatus.TabIndex = 88
            Me.lblStatus.Tag = "themeable"
            Me.lblStatus.Text = "Path:"
            Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'eventList
            '
            Me.eventList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.eventList.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.eventList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.eventList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.columnHeader1, Me.columnHeader2, Me.columnHeader3, Me.columnHeader4})
            Me.eventList.ForeColor = System.Drawing.Color.White
            Me.eventList.FullRowSelect = True
            Me.eventList.HideSelection = False
            Me.eventList.Location = New System.Drawing.Point(10, 66)
            Me.eventList.Margin = New System.Windows.Forms.Padding(2)
            Me.eventList.Name = "eventList"
            Me.eventList.Size = New System.Drawing.Size(795, 371)
            Me.eventList.TabIndex = 89
            Me.eventList.UseCompatibleStateImageBehavior = False
            Me.eventList.View = System.Windows.Forms.View.Details
            '
            'columnHeader1
            '
            Me.columnHeader1.Text = "File/Folder"
            Me.columnHeader1.Width = 489
            '
            'columnHeader2
            '
            Me.columnHeader2.Text = "Last accessed"
            Me.columnHeader2.Width = 106
            '
            'columnHeader3
            '
            Me.columnHeader3.Text = "Access count"
            Me.columnHeader3.Width = 102
            '
            'columnHeader4
            '
            Me.columnHeader4.Text = "Access type"
            Me.columnHeader4.Width = 90
            '
            'btnStart
            '
            Me.btnStart.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.btnStart.BackColor = System.Drawing.Color.DodgerBlue
            Me.btnStart.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
            Me.btnStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue
            Me.btnStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue
            Me.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnStart.ForeColor = System.Drawing.Color.White
            Me.btnStart.Location = New System.Drawing.Point(10, 443)
            Me.btnStart.Margin = New System.Windows.Forms.Padding(2)
            Me.btnStart.Name = "btnStart"
            Me.btnStart.Size = New System.Drawing.Size(69, 27)
            Me.btnStart.TabIndex = 90
            Me.btnStart.Tag = "themeable"
            Me.btnStart.Text = "Start"
            Me.btnStart.UseVisualStyleBackColor = False
            '
            'btnStop
            '
            Me.btnStop.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.btnStop.BackColor = System.Drawing.Color.DodgerBlue
            Me.btnStop.Enabled = False
            Me.btnStop.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
            Me.btnStop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue
            Me.btnStop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue
            Me.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnStop.ForeColor = System.Drawing.Color.White
            Me.btnStop.Location = New System.Drawing.Point(83, 443)
            Me.btnStop.Margin = New System.Windows.Forms.Padding(2)
            Me.btnStop.Name = "btnStop"
            Me.btnStop.Size = New System.Drawing.Size(69, 27)
            Me.btnStop.TabIndex = 93
            Me.btnStop.Tag = "themeable"
            Me.btnStop.Text = "Stop"
            Me.btnStop.UseVisualStyleBackColor = False
            '
            'fileSystemWatcher
            '
            Me.fileSystemWatcher.EnableRaisingEvents = True
            Me.fileSystemWatcher.IncludeSubdirectories = True
            Me.fileSystemWatcher.SynchronizingObject = Me
            '
            'extraWorkTimer
            '
            Me.extraWorkTimer.Enabled = True
            Me.extraWorkTimer.Interval = 1000
            '
            'btnExclusions
            '
            Me.btnExclusions.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.btnExclusions.BackColor = System.Drawing.Color.DodgerBlue
            Me.btnExclusions.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
            Me.btnExclusions.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue
            Me.btnExclusions.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue
            Me.btnExclusions.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnExclusions.ForeColor = System.Drawing.Color.White
            Me.btnExclusions.Location = New System.Drawing.Point(157, 443)
            Me.btnExclusions.Margin = New System.Windows.Forms.Padding(2)
            Me.btnExclusions.Name = "btnExclusions"
            Me.btnExclusions.Size = New System.Drawing.Size(77, 27)
            Me.btnExclusions.TabIndex = 94
            Me.btnExclusions.Tag = "themeable"
            Me.btnExclusions.Text = "Exclusions"
            Me.btnExclusions.UseVisualStyleBackColor = False
            '
            'btnExport
            '
            Me.btnExport.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.btnExport.BackColor = System.Drawing.Color.DodgerBlue
            Me.btnExport.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
            Me.btnExport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue
            Me.btnExport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue
            Me.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnExport.ForeColor = System.Drawing.Color.White
            Me.btnExport.Location = New System.Drawing.Point(238, 443)
            Me.btnExport.Margin = New System.Windows.Forms.Padding(2)
            Me.btnExport.Name = "btnExport"
            Me.btnExport.Size = New System.Drawing.Size(77, 27)
            Me.btnExport.TabIndex = 95
            Me.btnExport.Tag = "themeable"
            Me.btnExport.Text = "Export log"
            Me.btnExport.UseVisualStyleBackColor = False
            '
            'chkExclusions
            '
            Me.chkExclusions.AutoSize = True
            Me.chkExclusions.Checked = True
            Me.chkExclusions.CheckState = System.Windows.Forms.CheckState.Checked
            Me.chkExclusions.ForeColor = System.Drawing.Color.DodgerBlue
            Me.chkExclusions.Location = New System.Drawing.Point(397, 42)
            Me.chkExclusions.Margin = New System.Windows.Forms.Padding(2)
            Me.chkExclusions.Name = "chkExclusions"
            Me.chkExclusions.Size = New System.Drawing.Size(119, 19)
            Me.chkExclusions.TabIndex = 96
            Me.chkExclusions.Tag = "themeable"
            Me.chkExclusions.Text = "Enable exclusions"
            Me.chkExclusions.UseVisualStyleBackColor = True
            '
            'MainForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(814, 478)
            Me.Controls.Add(Me.chkExclusions)
            Me.Controls.Add(Me.btnExport)
            Me.Controls.Add(Me.btnExclusions)
            Me.Controls.Add(Me.btnStop)
            Me.Controls.Add(Me.btnStart)
            Me.Controls.Add(Me.eventList)
            Me.Controls.Add(Me.lblStatus)
            Me.Controls.Add(Me.checkRenamed)
            Me.Controls.Add(Me.checkDeleted)
            Me.Controls.Add(Me.checkCreated)
            Me.Controls.Add(Me.checkModified)
            Me.Controls.Add(Me.btnAbout)
            Me.Controls.Add(Me.btnOptions)
            Me.Controls.Add(Me.btnBrowse)
            Me.Controls.Add(Me.txtPath)
            Me.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ForeColor = System.Drawing.Color.White
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Margin = New System.Windows.Forms.Padding(2)
            Me.Name = "MainForm"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Observer"
            CType(Me.fileSystemWatcher, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region

        Private txtPath As System.Windows.Forms.TextBox
        Private btnAbout As System.Windows.Forms.Button
        Private btnOptions As System.Windows.Forms.Button
        Private btnBrowse As System.Windows.Forms.Button
        Private checkModified As System.Windows.Forms.CheckBox
        Private checkCreated As System.Windows.Forms.CheckBox
        Private checkDeleted As System.Windows.Forms.CheckBox
        Private checkRenamed As System.Windows.Forms.CheckBox
        Private lblStatus As System.Windows.Forms.Label
        Private eventList As System.Windows.Forms.ListView
        Private btnStart As System.Windows.Forms.Button
        Private btnStop As System.Windows.Forms.Button
        Private fileSystemWatcher As FileSystemWatcher
        Private changeEventBackgroundWorker As ComponentModel.BackgroundWorker
        Private extraWorkTimer As System.Windows.Forms.Timer
        Private btnExclusions As System.Windows.Forms.Button
        Private columnHeader1 As System.Windows.Forms.ColumnHeader
        Private columnHeader2 As System.Windows.Forms.ColumnHeader
        Private columnHeader3 As System.Windows.Forms.ColumnHeader
        Private columnHeader4 As System.Windows.Forms.ColumnHeader
        Private btnExport As System.Windows.Forms.Button
        Private chkExclusions As System.Windows.Forms.CheckBox
    End Class
End Namespace
