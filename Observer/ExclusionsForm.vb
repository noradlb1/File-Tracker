Imports System
Imports System.Windows.Forms

Namespace Observer
    Public Partial Class ExclusionsForm
        Inherits Form
        Private _dialog As FolderBrowserDialog

        Public Sub New()
            InitializeComponent()

            CheckForIllegalCrossThreadCalls = False
            Options.ApplyTheme(Me)

            _dialog = New FolderBrowserDialog()
            _dialog.Description = "Choose your desired path to exclude"
            _dialog.RootFolder = Environment.SpecialFolder.MyComputer
        End Sub

        Private Sub LoadExclusions()
            listExclusions.Items.Clear()

            For Each x In Options.CurrentOptions.Exclusions
                listExclusions.Items.Add(x)
            Next
        End Sub

        Private Sub AddExclusion()
            If Not String.IsNullOrEmpty(txtExcludedPath.Text) Then
                Options.CurrentOptions.Exclusions.Add(txtExcludedPath.Text)
                LoadExclusions()
                txtExcludedPath.Text = String.Empty
            End If
        End Sub

        Private Sub RemoveExclusion()
            If listExclusions.SelectedIndex > -1 Then
                Options.CurrentOptions.Exclusions.RemoveAt(listExclusions.SelectedIndex)
                LoadExclusions()
            End If
        End Sub

        Private Sub RemoveAllExclusions()
            Options.CurrentOptions.Exclusions.Clear()
            LoadExclusions()
        End Sub

        Private Sub ExcludeForm_Load(ByVal sender As Object, ByVal e As EventArgs)
            LoadExclusions()
        End Sub

        Private Sub btnBrowse_Click(ByVal sender As Object, ByVal e As EventArgs)
            If _dialog.ShowDialog() = DialogResult.OK Then
                txtExcludedPath.Text = _dialog.SelectedPath
            End If
        End Sub

        Private Sub btnOK_Click(ByVal sender As Object, ByVal e As EventArgs)
            Options.SaveSettings()
            Close()
        End Sub

        Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As EventArgs)
            AddExclusion()
        End Sub

        Private Sub btnRemove_Click(ByVal sender As Object, ByVal e As EventArgs)
            RemoveExclusion()
        End Sub

        Private Sub btnRemoveAll_Click(ByVal sender As Object, ByVal e As EventArgs)
            RemoveAllExclusions()
        End Sub
    End Class
End Namespace
