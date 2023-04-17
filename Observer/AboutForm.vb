Imports System
Imports System.Diagnostics
Imports System.Windows.Forms

Namespace Observer
    Public Partial Class AboutForm
        Inherits Form
        Public Sub New()
            InitializeComponent()
            Options.ApplyTheme(Me)
            CheckForIllegalCrossThreadCalls = False
        End Sub

        Private Sub AboutForm_Load(ByVal sender As Object, ByVal e As EventArgs)
            t1.Interval = 50
            t2.Interval = 50
            t1.Start()
        End Sub

        Private Sub button7_Click(ByVal sender As Object, ByVal e As EventArgs)
            Close()
        End Sub

        Private Sub l2_LinkClicked(ByVal sender As Object, ByVal e As LinkLabelLinkClickedEventArgs)
            Process.Start("https://carcinos.eu/deadmoon")
        End Sub

        Private Sub t2_Tick(ByVal sender As Object, ByVal e As EventArgs)
            Dim s0 = ""
            Dim s1 = "d"
            Dim s2 = "de"
            Dim s3 = "dea"
            Dim s4 = "dead"
            Dim s5 = "deadm"
            Dim s6 = "deadmo"
            Dim s7 = "deadmoo"
            Dim s8 = "deadmoon"
            Dim s9 = "deadmoon © "
            Dim s10 = "deadmoon © 2"
            Dim s11 = "deadmoon © 20"
            Dim s12 = "deadmoon © 201"
            Dim s13 = "deadmoon © 2017"

            Select Case l2.Text
                Case ""
                    l2.Text = s1
                Case "d"
                    l2.Text = s2
                Case "de"
                    l2.Text = s3
                Case "dea"
                    l2.Text = s4
                Case "dead"
                    l2.Text = s5
                Case "deadm"
                    l2.Text = s6
                Case "deadmo"
                    l2.Text = s7
                Case "deadmoo"
                    l2.Text = s8
                Case "deadmoon"
                    l2.Text = s9
                Case "deadmoon © "
                    l2.Text = s10
                Case "deadmoon © 2"
                    l2.Text = s11
                Case "deadmoon © 20"
                    l2.Text = s12
                Case "deadmoon © 201"
                    l2.Text = s13
                    't1.Start();
                    t2.Stop()
                Case "deadmoon © 2017"
                    l2.Text = s0
            End Select
        End Sub

        Private Sub t1_Tick(ByVal sender As Object, ByVal e As EventArgs)
            Const s0 = ""
            Const s1 = "O"
            Const s2 = "Ob"
            Const s3 = "Obs"
            Const s4 = "Obse"
            Const s5 = "Obser"
            Const s6 = "Observ"
            Const s7 = "Observe"
            Const s8 = "Observer"

            Select Case l1.Text
                Case s0
                    l1.Text = s1
                Case s1
                    l1.Text = s2
                Case s2
                    l1.Text = s3
                Case s3
                    l1.Text = s4
                Case s4
                    l1.Text = s5
                Case s5
                    l1.Text = s6
                Case s6
                    l1.Text = s7
                Case s7
                    l1.Text = s8
                    t1.Stop()
                    t2.Start()
                Case s8
                    l1.Text = s0
            End Select
        End Sub
    End Class
End Namespace
