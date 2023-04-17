Imports System
Imports System.Windows.Forms

Namespace Observer
    Public Partial Class OptionsForm
        Inherits Form
        Private _main As MainForm

        Public Sub New(ByVal main As MainForm)
            InitializeComponent()
            CheckForIllegalCrossThreadCalls = False
            _main = main

            LoadSettings()
            Options.ApplyTheme(Me)
        End Sub

        Private Sub LoadSettings()
            Select Case Options.CurrentOptions.Color
                Case Theme.Caramel
                    carameltheme.Checked = True
                Case Theme.Lime
                    limetheme.Checked = True
                Case Theme.Magma
                    magmatheme.Checked = True
                Case Theme.Minimal
                    minimaltheme.Checked = True
                Case Theme.Ocean
                    oceantheme.Checked = True
                Case Theme.Zerg
                    zergtheme.Checked = True
            End Select
        End Sub

        Private Sub OptionsForm_Load(ByVal sender As Object, ByVal e As EventArgs)
            CheckForIllegalCrossThreadCalls = False
        End Sub

        Private Sub okbtn_Click(ByVal sender As Object, ByVal e As EventArgs)
            Close()
        End Sub

        Private Sub oceantheme_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Options.CurrentOptions.Color = Theme.Ocean
            Options.ApplyTheme(Me)
            Options.ApplyTheme(_main)
        End Sub

        Private Sub magmatheme_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Options.CurrentOptions.Color = Theme.Magma
            Options.ApplyTheme(Me)
            Options.ApplyTheme(_main)
        End Sub

        Private Sub zergtheme_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Options.CurrentOptions.Color = Theme.Zerg
            Options.ApplyTheme(Me)
            Options.ApplyTheme(_main)
        End Sub

        Private Sub carameltheme_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Options.CurrentOptions.Color = Theme.Caramel
            Options.ApplyTheme(Me)
            Options.ApplyTheme(_main)
        End Sub

        Private Sub limetheme_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Options.CurrentOptions.Color = Theme.Lime
            Options.ApplyTheme(Me)
            Options.ApplyTheme(_main)
        End Sub

        Private Sub minimaltheme_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Options.CurrentOptions.Color = Theme.Minimal
            Options.ApplyTheme(Me)
            Options.ApplyTheme(_main)
        End Sub
    End Class
End Namespace
