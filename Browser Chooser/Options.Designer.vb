<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Options
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Options))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Browser1Target = New System.Windows.Forms.TextBox
        Me.btnBrowser1 = New System.Windows.Forms.Button
        Me.Browser1FileDialog = New System.Windows.Forms.OpenFileDialog
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.btnSave = New System.Windows.Forms.Button
        Me.Browser1Name = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Browser1Image = New System.Windows.Forms.ComboBox
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.Browser1Disable = New System.Windows.Forms.CheckBox
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.Browser2Disable = New System.Windows.Forms.CheckBox
        Me.Browser2Image = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Browser2Target = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Browser2Name = New System.Windows.Forms.TextBox
        Me.btnBrowser2 = New System.Windows.Forms.Button
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.Browser3Disable = New System.Windows.Forms.CheckBox
        Me.Browser3Image = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Browser3Target = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Browser3Name = New System.Windows.Forms.TextBox
        Me.btnBrowser3 = New System.Windows.Forms.Button
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.Browser4Disable = New System.Windows.Forms.CheckBox
        Me.Browser4Image = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Browser4Target = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Browser4Name = New System.Windows.Forms.TextBox
        Me.btnBrowser4 = New System.Windows.Forms.Button
        Me.TabPage5 = New System.Windows.Forms.TabPage
        Me.btnSetDefault = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.btnCancel = New System.Windows.Forms.Button
        Me.Browser2FileDialog = New System.Windows.Forms.OpenFileDialog
        Me.Browser3FileDialog = New System.Windows.Forms.OpenFileDialog
        Me.Browser4FileDialog = New System.Windows.Forms.OpenFileDialog
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(170, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(364, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Use the following tabs to set up what browsers to choose from:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Display Name:"
        '
        'Browser1Target
        '
        Me.Browser1Target.Location = New System.Drawing.Point(53, 39)
        Me.Browser1Target.Name = "Browser1Target"
        Me.Browser1Target.Size = New System.Drawing.Size(180, 20)
        Me.Browser1Target.TabIndex = 3
        '
        'btnBrowser1
        '
        Me.btnBrowser1.Location = New System.Drawing.Point(239, 36)
        Me.btnBrowser1.Name = "btnBrowser1"
        Me.btnBrowser1.Size = New System.Drawing.Size(27, 23)
        Me.btnBrowser1.TabIndex = 4
        Me.btnBrowser1.Text = "..."
        Me.btnBrowser1.UseVisualStyleBackColor = True
        '
        'Browser1FileDialog
        '
        Me.Browser1FileDialog.FileName = "OpenFileDialog1"
        '
        'btnSave
        '
        Me.btnSave.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSave.Location = New System.Drawing.Point(443, 149)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Browser1Name
        '
        Me.Browser1Name.Location = New System.Drawing.Point(84, 13)
        Me.Browser1Name.Name = "Browser1Name"
        Me.Browser1Name.Size = New System.Drawing.Size(182, 20)
        Me.Browser1Name.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Target:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(272, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Image:"
        '
        'Browser1Image
        '
        Me.Browser1Image.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Browser1Image.FormattingEnabled = True
        Me.Browser1Image.Items.AddRange(New Object() {"Firefox", "Internet Explorer", "Opera", "Safari", "Google Chrome"})
        Me.Browser1Image.Location = New System.Drawing.Point(275, 38)
        Me.Browser1Image.Name = "Browser1Image"
        Me.Browser1Image.Size = New System.Drawing.Size(134, 21)
        Me.Browser1Image.TabIndex = 9
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Location = New System.Drawing.Point(173, 42)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(430, 102)
        Me.TabControl1.TabIndex = 8
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Browser1Disable)
        Me.TabPage1.Controls.Add(Me.Browser1Image)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Browser1Target)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Browser1Name)
        Me.TabPage1.Controls.Add(Me.btnBrowser1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(422, 76)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Browser 1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Browser1Disable
        '
        Me.Browser1Disable.AutoSize = True
        Me.Browser1Disable.Location = New System.Drawing.Point(328, 6)
        Me.Browser1Disable.Name = "Browser1Disable"
        Me.Browser1Disable.Size = New System.Drawing.Size(67, 17)
        Me.Browser1Disable.TabIndex = 9
        Me.Browser1Disable.Text = "Disabled"
        Me.Browser1Disable.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Browser2Disable)
        Me.TabPage2.Controls.Add(Me.Browser2Image)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.Browser2Target)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.Browser2Name)
        Me.TabPage2.Controls.Add(Me.btnBrowser2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(422, 76)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Browser 2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Browser2Disable
        '
        Me.Browser2Disable.AutoSize = True
        Me.Browser2Disable.Location = New System.Drawing.Point(328, 6)
        Me.Browser2Disable.Name = "Browser2Disable"
        Me.Browser2Disable.Size = New System.Drawing.Size(67, 17)
        Me.Browser2Disable.TabIndex = 16
        Me.Browser2Disable.Text = "Disabled"
        Me.Browser2Disable.UseVisualStyleBackColor = True
        '
        'Browser2Image
        '
        Me.Browser2Image.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Browser2Image.FormattingEnabled = True
        Me.Browser2Image.Items.AddRange(New Object() {"Firefox", "Internet Explorer", "Opera", "Safari", "Google Chrome"})
        Me.Browser2Image.Location = New System.Drawing.Point(275, 38)
        Me.Browser2Image.Name = "Browser2Image"
        Me.Browser2Image.Size = New System.Drawing.Size(134, 21)
        Me.Browser2Image.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Display Name:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(272, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Image:"
        '
        'Browser2Target
        '
        Me.Browser2Target.Location = New System.Drawing.Point(53, 39)
        Me.Browser2Target.Name = "Browser2Target"
        Me.Browser2Target.Size = New System.Drawing.Size(180, 20)
        Me.Browser2Target.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 42)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Target:"
        '
        'Browser2Name
        '
        Me.Browser2Name.Location = New System.Drawing.Point(84, 13)
        Me.Browser2Name.Name = "Browser2Name"
        Me.Browser2Name.Size = New System.Drawing.Size(182, 20)
        Me.Browser2Name.TabIndex = 13
        '
        'btnBrowser2
        '
        Me.btnBrowser2.Location = New System.Drawing.Point(239, 36)
        Me.btnBrowser2.Name = "btnBrowser2"
        Me.btnBrowser2.Size = New System.Drawing.Size(27, 23)
        Me.btnBrowser2.TabIndex = 12
        Me.btnBrowser2.Text = "..."
        Me.btnBrowser2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Browser3Disable)
        Me.TabPage3.Controls.Add(Me.Browser3Image)
        Me.TabPage3.Controls.Add(Me.Label8)
        Me.TabPage3.Controls.Add(Me.Label9)
        Me.TabPage3.Controls.Add(Me.Browser3Target)
        Me.TabPage3.Controls.Add(Me.Label10)
        Me.TabPage3.Controls.Add(Me.Browser3Name)
        Me.TabPage3.Controls.Add(Me.btnBrowser3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(422, 76)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Browser 3"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Browser3Disable
        '
        Me.Browser3Disable.AutoSize = True
        Me.Browser3Disable.Location = New System.Drawing.Point(328, 6)
        Me.Browser3Disable.Name = "Browser3Disable"
        Me.Browser3Disable.Size = New System.Drawing.Size(67, 17)
        Me.Browser3Disable.TabIndex = 24
        Me.Browser3Disable.Text = "Disabled"
        Me.Browser3Disable.UseVisualStyleBackColor = True
        '
        'Browser3Image
        '
        Me.Browser3Image.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Browser3Image.FormattingEnabled = True
        Me.Browser3Image.Items.AddRange(New Object() {"Firefox", "Internet Explorer", "Opera", "Safari", "Google Chrome"})
        Me.Browser3Image.Location = New System.Drawing.Point(275, 38)
        Me.Browser3Image.Name = "Browser3Image"
        Me.Browser3Image.Size = New System.Drawing.Size(134, 21)
        Me.Browser3Image.TabIndex = 25
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Display Name:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(272, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 13)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Image:"
        '
        'Browser3Target
        '
        Me.Browser3Target.Location = New System.Drawing.Point(53, 39)
        Me.Browser3Target.Name = "Browser3Target"
        Me.Browser3Target.Size = New System.Drawing.Size(180, 20)
        Me.Browser3Target.TabIndex = 19
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 42)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(41, 13)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Target:"
        '
        'Browser3Name
        '
        Me.Browser3Name.Location = New System.Drawing.Point(84, 13)
        Me.Browser3Name.Name = "Browser3Name"
        Me.Browser3Name.Size = New System.Drawing.Size(182, 20)
        Me.Browser3Name.TabIndex = 21
        '
        'btnBrowser3
        '
        Me.btnBrowser3.Location = New System.Drawing.Point(239, 36)
        Me.btnBrowser3.Name = "btnBrowser3"
        Me.btnBrowser3.Size = New System.Drawing.Size(27, 23)
        Me.btnBrowser3.TabIndex = 20
        Me.btnBrowser3.Text = "..."
        Me.btnBrowser3.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.Browser4Disable)
        Me.TabPage4.Controls.Add(Me.Browser4Image)
        Me.TabPage4.Controls.Add(Me.Label11)
        Me.TabPage4.Controls.Add(Me.Label12)
        Me.TabPage4.Controls.Add(Me.Browser4Target)
        Me.TabPage4.Controls.Add(Me.Label13)
        Me.TabPage4.Controls.Add(Me.Browser4Name)
        Me.TabPage4.Controls.Add(Me.btnBrowser4)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(422, 76)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Browser 4"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'Browser4Disable
        '
        Me.Browser4Disable.AutoSize = True
        Me.Browser4Disable.Location = New System.Drawing.Point(328, 6)
        Me.Browser4Disable.Name = "Browser4Disable"
        Me.Browser4Disable.Size = New System.Drawing.Size(67, 17)
        Me.Browser4Disable.TabIndex = 32
        Me.Browser4Disable.Text = "Disabled"
        Me.Browser4Disable.UseVisualStyleBackColor = True
        '
        'Browser4Image
        '
        Me.Browser4Image.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Browser4Image.FormattingEnabled = True
        Me.Browser4Image.Items.AddRange(New Object() {"Firefox", "Internet Explorer", "Opera", "Safari", "Google Chrome"})
        Me.Browser4Image.Location = New System.Drawing.Point(275, 38)
        Me.Browser4Image.Name = "Browser4Image"
        Me.Browser4Image.Size = New System.Drawing.Size(134, 21)
        Me.Browser4Image.TabIndex = 33
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(75, 13)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "Display Name:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(272, 16)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(39, 13)
        Me.Label12.TabIndex = 31
        Me.Label12.Text = "Image:"
        '
        'Browser4Target
        '
        Me.Browser4Target.Location = New System.Drawing.Point(53, 39)
        Me.Browser4Target.Name = "Browser4Target"
        Me.Browser4Target.Size = New System.Drawing.Size(180, 20)
        Me.Browser4Target.TabIndex = 27
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 42)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(41, 13)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "Target:"
        '
        'Browser4Name
        '
        Me.Browser4Name.Location = New System.Drawing.Point(84, 13)
        Me.Browser4Name.Name = "Browser4Name"
        Me.Browser4Name.Size = New System.Drawing.Size(182, 20)
        Me.Browser4Name.TabIndex = 29
        '
        'btnBrowser4
        '
        Me.btnBrowser4.Location = New System.Drawing.Point(239, 36)
        Me.btnBrowser4.Name = "btnBrowser4"
        Me.btnBrowser4.Size = New System.Drawing.Size(27, 23)
        Me.btnBrowser4.TabIndex = 28
        Me.btnBrowser4.Text = "..."
        Me.btnBrowser4.UseVisualStyleBackColor = True
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.btnSetDefault)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(422, 76)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Miscellaneous"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'btnSetDefault
        '
        Me.btnSetDefault.AutoSize = True
        Me.btnSetDefault.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnSetDefault.Location = New System.Drawing.Point(6, 6)
        Me.btnSetDefault.Name = "btnSetDefault"
        Me.btnSetDefault.Size = New System.Drawing.Size(122, 23)
        Me.btnSetDefault.TabIndex = 10
        Me.btnSetDefault.Text = "Make Default Browser"
        Me.btnSetDefault.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Browser_Chooser.My.Resources.Resources.BrowserChooser31
        Me.PictureBox1.Location = New System.Drawing.Point(7, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(160, 160)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(524, 149)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 9
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Browser2FileDialog
        '
        Me.Browser2FileDialog.FileName = "OpenFileDialog1"
        '
        'Browser3FileDialog
        '
        Me.Browser3FileDialog.FileName = "OpenFileDialog2"
        '
        'Browser4FileDialog
        '
        Me.Browser4FileDialog.FileName = "OpenFileDialog3"
        '
        'Options
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(615, 185)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Options"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Options"
        Me.TopMost = True
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Browser1Target As System.Windows.Forms.TextBox
    Friend WithEvents btnBrowser1 As System.Windows.Forms.Button
    Friend WithEvents Browser1FileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Browser1Name As System.Windows.Forms.TextBox
    Friend WithEvents Browser1Image As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Browser1Disable As System.Windows.Forms.CheckBox
    Friend WithEvents Browser2Disable As System.Windows.Forms.CheckBox
    Friend WithEvents Browser2Image As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Browser2Target As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Browser2Name As System.Windows.Forms.TextBox
    Friend WithEvents btnBrowser2 As System.Windows.Forms.Button
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents Browser3Disable As System.Windows.Forms.CheckBox
    Friend WithEvents Browser3Image As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Browser3Target As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Browser3Name As System.Windows.Forms.TextBox
    Friend WithEvents btnBrowser3 As System.Windows.Forms.Button
    Friend WithEvents Browser4Disable As System.Windows.Forms.CheckBox
    Friend WithEvents Browser4Image As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Browser4Target As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Browser4Name As System.Windows.Forms.TextBox
    Friend WithEvents btnBrowser4 As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Browser2FileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Browser3FileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Browser4FileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnSetDefault As System.Windows.Forms.Button
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
End Class
