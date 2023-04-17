Imports System

Namespace Observer
    Partial Class OptionsForm
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
            okbtn = New System.Windows.Forms.Button()
            minimaltheme = New System.Windows.Forms.RadioButton()
            carameltheme = New System.Windows.Forms.RadioButton()
            limetheme = New System.Windows.Forms.RadioButton()
            magmatheme = New System.Windows.Forms.RadioButton()
            oceantheme = New System.Windows.Forms.RadioButton()
            zergtheme = New System.Windows.Forms.RadioButton()
            label27 = New System.Windows.Forms.Label()
            SuspendLayout()
            ' 
            ' okbtn
            ' 
            okbtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right
            okbtn.BackColor = Drawing.Color.DodgerBlue
            okbtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
            okbtn.FlatAppearance.BorderColor = Drawing.Color.DodgerBlue
            okbtn.FlatAppearance.MouseDownBackColor = Drawing.Color.RoyalBlue
            okbtn.FlatAppearance.MouseOverBackColor = Drawing.Color.RoyalBlue
            okbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            okbtn.Font = New Drawing.Font("Segoe UI Semibold", 9.0F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            okbtn.ForeColor = Drawing.Color.White
            okbtn.Location = New Drawing.Point(273, 193)
            okbtn.Name = "okbtn"
            okbtn.Size = New Drawing.Size(89, 39)
            okbtn.TabIndex = 70
            okbtn.Tag = "themeable"
            okbtn.Text = "OK"
            okbtn.UseVisualStyleBackColor = False
            AddHandler okbtn.Click, New EventHandler(AddressOf okbtn_Click)
            ' 
            ' minimaltheme
            ' 
            minimaltheme.AutoSize = True
            minimaltheme.Font = New Drawing.Font("Segoe UI Semibold", 12.0F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            minimaltheme.ForeColor = Drawing.Color.Gray
            minimaltheme.Location = New Drawing.Point(153, 135)
            minimaltheme.Name = "minimaltheme"
            minimaltheme.Size = New Drawing.Size(106, 32)
            minimaltheme.TabIndex = 69
            minimaltheme.Text = "Minimal"
            minimaltheme.UseVisualStyleBackColor = True
            AddHandler minimaltheme.CheckedChanged, New EventHandler(AddressOf minimaltheme_CheckedChanged)
            ' 
            ' carameltheme
            ' 
            carameltheme.AutoSize = True
            carameltheme.Font = New Drawing.Font("Segoe UI Semibold", 12.0F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            carameltheme.ForeColor = Drawing.Color.DarkOrange
            carameltheme.Location = New Drawing.Point(153, 59)
            carameltheme.Name = "carameltheme"
            carameltheme.Size = New Drawing.Size(106, 32)
            carameltheme.TabIndex = 68
            carameltheme.Text = "Caramel"
            carameltheme.UseVisualStyleBackColor = True
            AddHandler carameltheme.CheckedChanged, New EventHandler(AddressOf carameltheme_CheckedChanged)
            ' 
            ' limetheme
            ' 
            limetheme.AutoSize = True
            limetheme.Font = New Drawing.Font("Segoe UI Semibold", 12.0F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            limetheme.ForeColor = Drawing.Color.LimeGreen
            limetheme.Location = New Drawing.Point(153, 97)
            limetheme.Name = "limetheme"
            limetheme.Size = New Drawing.Size(77, 32)
            limetheme.TabIndex = 67
            limetheme.Text = "Lime"
            limetheme.UseVisualStyleBackColor = True
            AddHandler limetheme.CheckedChanged, New EventHandler(AddressOf limetheme_CheckedChanged)
            ' 
            ' magmatheme
            ' 
            magmatheme.AutoSize = True
            magmatheme.Font = New Drawing.Font("Segoe UI Semibold", 12.0F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            magmatheme.ForeColor = Drawing.Color.Tomato
            magmatheme.Location = New Drawing.Point(37, 97)
            magmatheme.Name = "magmatheme"
            magmatheme.Size = New Drawing.Size(101, 32)
            magmatheme.TabIndex = 66
            magmatheme.Text = "Magma"
            magmatheme.UseVisualStyleBackColor = True
            AddHandler magmatheme.CheckedChanged, New EventHandler(AddressOf magmatheme_CheckedChanged)
            ' 
            ' oceantheme
            ' 
            oceantheme.AutoSize = True
            oceantheme.Checked = True
            oceantheme.Font = New Drawing.Font("Segoe UI Semibold", 12.0F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            oceantheme.ForeColor = Drawing.Color.DodgerBlue
            oceantheme.Location = New Drawing.Point(37, 59)
            oceantheme.Name = "oceantheme"
            oceantheme.Size = New Drawing.Size(90, 32)
            oceantheme.TabIndex = 65
            oceantheme.TabStop = True
            oceantheme.Text = "Ocean"
            oceantheme.UseVisualStyleBackColor = True
            AddHandler oceantheme.CheckedChanged, New EventHandler(AddressOf oceantheme_CheckedChanged)
            ' 
            ' zergtheme
            ' 
            zergtheme.AutoSize = True
            zergtheme.Font = New Drawing.Font("Segoe UI Semibold", 12.0F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            zergtheme.ForeColor = Drawing.Color.MediumOrchid
            zergtheme.Location = New Drawing.Point(37, 135)
            zergtheme.Name = "zergtheme"
            zergtheme.Size = New Drawing.Size(75, 32)
            zergtheme.TabIndex = 64
            zergtheme.Text = "Zerg"
            zergtheme.UseVisualStyleBackColor = True
            AddHandler zergtheme.CheckedChanged, New EventHandler(AddressOf zergtheme_CheckedChanged)
            ' 
            ' label27
            ' 
            label27.AutoSize = True
            label27.Font = New Drawing.Font("Segoe UI Semibold", 15.0F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            label27.ForeColor = Drawing.Color.DodgerBlue
            label27.Location = New Drawing.Point(12, 10)
            label27.Name = "label27"
            label27.Size = New Drawing.Size(238, 35)
            label27.TabIndex = 63
            label27.Tag = "themeable"
            label27.Text = "Choose your theme"
            ' 
            ' OptionsForm
            ' 
            AcceptButton = okbtn
            AutoScaleDimensions = New Drawing.SizeF(120.0F, 120.0F)
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            BackColor = Drawing.Color.FromArgb(20, 20, 20)
            CancelButton = okbtn
            ClientSize = New Drawing.Size(374, 243)
            Controls.Add(okbtn)
            Controls.Add(minimaltheme)
            Controls.Add(carameltheme)
            Controls.Add(limetheme)
            Controls.Add(magmatheme)
            Controls.Add(oceantheme)
            Controls.Add(zergtheme)
            Controls.Add(label27)
            Font = New Drawing.Font("Segoe UI Semibold", 9.0F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            ForeColor = Drawing.Color.White
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            MaximizeBox = False
            MinimizeBox = False
            Name = "OptionsForm"
            ShowIcon = False
            ShowInTaskbar = False
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            AddHandler Load, New EventHandler(AddressOf OptionsForm_Load)
            ResumeLayout(False)
            PerformLayout()

        End Sub

#End Region

        Private okbtn As System.Windows.Forms.Button
        Private minimaltheme As System.Windows.Forms.RadioButton
        Private carameltheme As System.Windows.Forms.RadioButton
        Private limetheme As System.Windows.Forms.RadioButton
        Private magmatheme As System.Windows.Forms.RadioButton
        Private oceantheme As System.Windows.Forms.RadioButton
        Private zergtheme As System.Windows.Forms.RadioButton
        Private label27 As System.Windows.Forms.Label
    End Class
End Namespace
