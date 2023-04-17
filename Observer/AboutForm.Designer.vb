Imports System

Namespace Observer
    Partial Class AboutForm
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
            components = New ComponentModel.Container()
            Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(AboutForm))
            pictureBox1 = New System.Windows.Forms.PictureBox()
            button7 = New System.Windows.Forms.Button()
            t1 = New System.Windows.Forms.Timer(components)
            t2 = New System.Windows.Forms.Timer(components)
            l2 = New System.Windows.Forms.LinkLabel()
            l1 = New System.Windows.Forms.Label()
            CType(pictureBox1, ComponentModel.ISupportInitialize).BeginInit()
            SuspendLayout()
            ' 
            ' pictureBox1
            ' 
            pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), Drawing.Image)
            pictureBox1.Location = New Drawing.Point(12, 12)
            pictureBox1.Name = "pictureBox1"
            pictureBox1.Size = New Drawing.Size(110, 108)
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            pictureBox1.TabIndex = 41
            pictureBox1.TabStop = False
            ' 
            ' button7
            ' 
            button7.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right
            button7.BackColor = Drawing.Color.DodgerBlue
            button7.DialogResult = System.Windows.Forms.DialogResult.Cancel
            button7.FlatAppearance.BorderColor = Drawing.Color.DodgerBlue
            button7.FlatAppearance.MouseDownBackColor = Drawing.Color.RoyalBlue
            button7.FlatAppearance.MouseOverBackColor = Drawing.Color.RoyalBlue
            button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            button7.ForeColor = Drawing.Color.White
            button7.Location = New Drawing.Point(383, 12)
            button7.Name = "button7"
            button7.Size = New Drawing.Size(89, 39)
            button7.TabIndex = 42
            button7.Tag = "themeable"
            button7.Text = "OK"
            button7.UseVisualStyleBackColor = False
            AddHandler button7.Click, New EventHandler(AddressOf button7_Click)
            ' 
            ' t1
            ' 
            t1.Interval = 350
            AddHandler t1.Tick, New EventHandler(AddressOf t1_Tick)
            ' 
            ' t2
            ' 
            t2.Interval = 350
            AddHandler t2.Tick, New EventHandler(AddressOf t2_Tick)
            ' 
            ' l2
            ' 
            l2.ActiveLinkColor = Drawing.Color.RoyalBlue
            l2.AutoSize = True
            l2.Font = New Drawing.Font("Segoe UI Semibold", 13.8F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            l2.LinkColor = Drawing.Color.DodgerBlue
            l2.Location = New Drawing.Point(128, 88)
            l2.Name = "l2"
            l2.Size = New Drawing.Size(0, 32)
            l2.TabIndex = 62
            l2.Tag = "themeable"
            l2.VisitedLinkColor = Drawing.Color.DodgerBlue
            AddHandler l2.LinkClicked, New System.Windows.Forms.LinkLabelLinkClickedEventHandler(AddressOf l2_LinkClicked)
            ' 
            ' l1
            ' 
            l1.AutoSize = True
            l1.Font = New Drawing.Font("Segoe UI Semibold", 14.0F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            l1.ForeColor = Drawing.Color.White
            l1.Location = New Drawing.Point(128, 9)
            l1.Name = "l1"
            l1.Size = New Drawing.Size(0, 32)
            l1.TabIndex = 61
            ' 
            ' AboutForm
            ' 
            AutoScaleDimensions = New Drawing.SizeF(120.0F, 120.0F)
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            BackColor = Drawing.Color.FromArgb(20, 20, 20)
            ClientSize = New Drawing.Size(484, 135)
            Controls.Add(l2)
            Controls.Add(l1)
            Controls.Add(button7)
            Controls.Add(pictureBox1)
            Font = New Drawing.Font("Segoe UI Semibold", 9.0F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            ForeColor = Drawing.Color.White
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            MaximizeBox = False
            MinimizeBox = False
            Name = "AboutForm"
            ShowIcon = False
            ShowInTaskbar = False
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Text = "About"
            AddHandler Load, New EventHandler(AddressOf AboutForm_Load)
            CType(pictureBox1, ComponentModel.ISupportInitialize).EndInit()
            ResumeLayout(False)
            PerformLayout()

        End Sub

#End Region

        Private pictureBox1 As System.Windows.Forms.PictureBox
        Private button7 As System.Windows.Forms.Button
        Private t1 As System.Windows.Forms.Timer
        Private t2 As System.Windows.Forms.Timer
        Private l2 As System.Windows.Forms.LinkLabel
        Private l1 As System.Windows.Forms.Label
    End Class
End Namespace
