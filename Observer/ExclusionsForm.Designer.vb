Imports System

Namespace Observer
    Partial Class ExclusionsForm
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
            lblStatus = New System.Windows.Forms.Label()
            btnBrowse = New System.Windows.Forms.Button()
            txtExcludedPath = New System.Windows.Forms.TextBox()
            btnOK = New System.Windows.Forms.Button()
            btnAdd = New System.Windows.Forms.Button()
            listExclusions = New System.Windows.Forms.ListBox()
            panel1 = New System.Windows.Forms.Panel()
            label1 = New System.Windows.Forms.Label()
            btnRemove = New System.Windows.Forms.Button()
            btnRemoveAll = New System.Windows.Forms.Button()
            panel1.SuspendLayout()
            SuspendLayout()
            ' 
            ' lblStatus
            ' 
            lblStatus.AutoSize = True
            lblStatus.Font = New Drawing.Font("Segoe UI Semibold", 12.0F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            lblStatus.ForeColor = Drawing.Color.DodgerBlue
            lblStatus.Location = New Drawing.Point(12, 9)
            lblStatus.Name = "lblStatus"
            lblStatus.Size = New Drawing.Size(287, 28)
            lblStatus.TabIndex = 89
            lblStatus.Tag = "themeable"
            lblStatus.Text = "Specify new folder to exclude:"
            lblStatus.TextAlign = Drawing.ContentAlignment.MiddleLeft
            ' 
            ' btnBrowse
            ' 
            btnBrowse.BackColor = Drawing.Color.DodgerBlue
            btnBrowse.FlatAppearance.BorderColor = Drawing.Color.DodgerBlue
            btnBrowse.FlatAppearance.MouseDownBackColor = Drawing.Color.RoyalBlue
            btnBrowse.FlatAppearance.MouseOverBackColor = Drawing.Color.RoyalBlue
            btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            btnBrowse.ForeColor = Drawing.Color.White
            btnBrowse.Location = New Drawing.Point(515, 40)
            btnBrowse.Name = "btnBrowse"
            btnBrowse.Size = New Drawing.Size(37, 34)
            btnBrowse.TabIndex = 91
            btnBrowse.Tag = "themeable"
            btnBrowse.Text = "..."
            btnBrowse.UseVisualStyleBackColor = False
            AddHandler btnBrowse.Click, New EventHandler(AddressOf btnBrowse_Click)
            ' 
            ' txtExcludedPath
            ' 
            txtExcludedPath.BackColor = Drawing.Color.FromArgb(20, 20, 20)
            txtExcludedPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            txtExcludedPath.Font = New Drawing.Font("Segoe UI Semibold", 12.0F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            txtExcludedPath.ForeColor = Drawing.Color.White
            txtExcludedPath.Location = New Drawing.Point(17, 40)
            txtExcludedPath.Name = "txtExcludedPath"
            txtExcludedPath.Size = New Drawing.Size(492, 34)
            txtExcludedPath.TabIndex = 90
            ' 
            ' btnOK
            ' 
            btnOK.BackColor = Drawing.Color.DodgerBlue
            btnOK.DialogResult = System.Windows.Forms.DialogResult.OK
            btnOK.FlatAppearance.BorderColor = Drawing.Color.DodgerBlue
            btnOK.FlatAppearance.MouseDownBackColor = Drawing.Color.RoyalBlue
            btnOK.FlatAppearance.MouseOverBackColor = Drawing.Color.RoyalBlue
            btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            btnOK.ForeColor = Drawing.Color.White
            btnOK.Location = New Drawing.Point(412, 459)
            btnOK.Name = "btnOK"
            btnOK.Size = New Drawing.Size(140, 34)
            btnOK.TabIndex = 92
            btnOK.Tag = "themeable"
            btnOK.Text = "OK"
            btnOK.UseVisualStyleBackColor = False
            AddHandler btnOK.Click, New EventHandler(AddressOf btnOK_Click)
            ' 
            ' btnAdd
            ' 
            btnAdd.BackColor = Drawing.Color.DodgerBlue
            btnAdd.FlatAppearance.BorderColor = Drawing.Color.DodgerBlue
            btnAdd.FlatAppearance.MouseDownBackColor = Drawing.Color.RoyalBlue
            btnAdd.FlatAppearance.MouseOverBackColor = Drawing.Color.RoyalBlue
            btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            btnAdd.ForeColor = Drawing.Color.White
            btnAdd.Location = New Drawing.Point(17, 80)
            btnAdd.Name = "btnAdd"
            btnAdd.Size = New Drawing.Size(140, 34)
            btnAdd.TabIndex = 94
            btnAdd.Tag = "themeable"
            btnAdd.Text = "Exclude folder"
            btnAdd.UseVisualStyleBackColor = False
            AddHandler btnAdd.Click, New EventHandler(AddressOf btnAdd_Click)
            ' 
            ' listExclusions
            ' 
            listExclusions.BackColor = Drawing.Color.FromArgb(20, 20, 20)
            listExclusions.BorderStyle = System.Windows.Forms.BorderStyle.None
            listExclusions.Dock = System.Windows.Forms.DockStyle.Fill
            listExclusions.ForeColor = Drawing.Color.White
            listExclusions.FormattingEnabled = True
            listExclusions.ItemHeight = 20
            listExclusions.Location = New Drawing.Point(0, 0)
            listExclusions.Name = "listExclusions"
            listExclusions.Size = New Drawing.Size(533, 293)
            listExclusions.TabIndex = 95
            ' 
            ' panel1
            ' 
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            panel1.Controls.Add(listExclusions)
            panel1.Location = New Drawing.Point(17, 158)
            panel1.Name = "panel1"
            panel1.Size = New Drawing.Size(535, 295)
            panel1.TabIndex = 96
            ' 
            ' label1
            ' 
            label1.AutoSize = True
            label1.Font = New Drawing.Font("Segoe UI Semibold", 12.0F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            label1.ForeColor = Drawing.Color.DodgerBlue
            label1.Location = New Drawing.Point(12, 127)
            label1.Name = "label1"
            label1.Size = New Drawing.Size(172, 28)
            label1.TabIndex = 97
            label1.Tag = "themeable"
            label1.Text = "Active exclusions:"
            label1.TextAlign = Drawing.ContentAlignment.MiddleLeft
            ' 
            ' btnRemove
            ' 
            btnRemove.BackColor = Drawing.Color.DodgerBlue
            btnRemove.FlatAppearance.BorderColor = Drawing.Color.DodgerBlue
            btnRemove.FlatAppearance.MouseDownBackColor = Drawing.Color.RoyalBlue
            btnRemove.FlatAppearance.MouseOverBackColor = Drawing.Color.RoyalBlue
            btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            btnRemove.ForeColor = Drawing.Color.White
            btnRemove.Location = New Drawing.Point(18, 459)
            btnRemove.Name = "btnRemove"
            btnRemove.Size = New Drawing.Size(140, 34)
            btnRemove.TabIndex = 98
            btnRemove.Tag = "themeable"
            btnRemove.Text = "Remove"
            btnRemove.UseVisualStyleBackColor = False
            AddHandler btnRemove.Click, New EventHandler(AddressOf btnRemove_Click)
            ' 
            ' btnRemoveAll
            ' 
            btnRemoveAll.BackColor = Drawing.Color.DodgerBlue
            btnRemoveAll.FlatAppearance.BorderColor = Drawing.Color.DodgerBlue
            btnRemoveAll.FlatAppearance.MouseDownBackColor = Drawing.Color.RoyalBlue
            btnRemoveAll.FlatAppearance.MouseOverBackColor = Drawing.Color.RoyalBlue
            btnRemoveAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            btnRemoveAll.ForeColor = Drawing.Color.White
            btnRemoveAll.Location = New Drawing.Point(164, 459)
            btnRemoveAll.Name = "btnRemoveAll"
            btnRemoveAll.Size = New Drawing.Size(140, 34)
            btnRemoveAll.TabIndex = 99
            btnRemoveAll.Tag = "themeable"
            btnRemoveAll.Text = "Remove all"
            btnRemoveAll.UseVisualStyleBackColor = False
            AddHandler btnRemoveAll.Click, New EventHandler(AddressOf btnRemoveAll_Click)
            ' 
            ' ExcludeForm
            ' 
            AcceptButton = btnOK
            AutoScaleDimensions = New Drawing.SizeF(120.0F, 120.0F)
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            BackColor = Drawing.Color.FromArgb(20, 20, 20)
            CancelButton = btnOK
            ClientSize = New Drawing.Size(568, 507)
            Controls.Add(btnRemoveAll)
            Controls.Add(btnRemove)
            Controls.Add(label1)
            Controls.Add(panel1)
            Controls.Add(btnAdd)
            Controls.Add(btnOK)
            Controls.Add(btnBrowse)
            Controls.Add(txtExcludedPath)
            Controls.Add(lblStatus)
            Font = New Drawing.Font("Segoe UI Semibold", 9.0F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            ForeColor = Drawing.Color.White
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            MaximizeBox = False
            MinimizeBox = False
            Name = "ExcludeForm"
            ShowIcon = False
            ShowInTaskbar = False
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Text = "Exclusions"
            AddHandler Load, New EventHandler(AddressOf ExcludeForm_Load)
            panel1.ResumeLayout(False)
            ResumeLayout(False)
            PerformLayout()

        End Sub

#End Region

        Private lblStatus As System.Windows.Forms.Label
        Private btnBrowse As System.Windows.Forms.Button
        Private txtExcludedPath As System.Windows.Forms.TextBox
        Private btnOK As System.Windows.Forms.Button
        Private btnAdd As System.Windows.Forms.Button
        Private listExclusions As System.Windows.Forms.ListBox
        Private panel1 As System.Windows.Forms.Panel
        Private label1 As System.Windows.Forms.Label
        Private btnRemove As System.Windows.Forms.Button
        Private btnRemoveAll As System.Windows.Forms.Button
    End Class
End Namespace
