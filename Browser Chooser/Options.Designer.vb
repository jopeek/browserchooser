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
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Browser2Image = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.btnBrowser2 = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.Browser2Name = New System.Windows.Forms.TextBox
        Me.Browser2Target = New System.Windows.Forms.TextBox
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Browser3Image = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.btnBrowser3 = New System.Windows.Forms.Button
        Me.Label9 = New System.Windows.Forms.Label
        Me.Browser3Name = New System.Windows.Forms.TextBox
        Me.Browser3Target = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Browser4Image = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.btnBrowser4 = New System.Windows.Forms.Button
        Me.Label12 = New System.Windows.Forms.Label
        Me.Browser4Name = New System.Windows.Forms.TextBox
        Me.Browser4Target = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.TabPage5 = New System.Windows.Forms.TabPage
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.Browser5Image = New System.Windows.Forms.ComboBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.btnBrowser5 = New System.Windows.Forms.Button
        Me.Label21 = New System.Windows.Forms.Label
        Me.Browser5Name = New System.Windows.Forms.TextBox
        Me.Browser5Target = New System.Windows.Forms.TextBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.TabPage6 = New System.Windows.Forms.TabPage
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.btnSetDefault = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.btnCancel = New System.Windows.Forms.Button
        Me.Browser2FileDialog = New System.Windows.Forms.OpenFileDialog
        Me.Browser3FileDialog = New System.Windows.Forms.OpenFileDialog
        Me.Browser4FileDialog = New System.Windows.Forms.OpenFileDialog
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.CheckBox2 = New System.Windows.Forms.CheckBox
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.Browser5FileDialog = New System.Windows.Forms.OpenFileDialog
        Me.cbURL = New System.Windows.Forms.CheckBox
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.Panel6.SuspendLayout()
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
        Me.Label2.Location = New System.Drawing.Point(3, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Display Name:"
        '
        'Browser1Target
        '
        Me.Browser1Target.Location = New System.Drawing.Point(50, 38)
        Me.Browser1Target.Name = "Browser1Target"
        Me.Browser1Target.Size = New System.Drawing.Size(180, 20)
        Me.Browser1Target.TabIndex = 3
        '
        'btnBrowser1
        '
        Me.btnBrowser1.Location = New System.Drawing.Point(236, 35)
        Me.btnBrowser1.Name = "btnBrowser1"
        Me.btnBrowser1.Size = New System.Drawing.Size(27, 23)
        Me.btnBrowser1.TabIndex = 4
        Me.btnBrowser1.Text = "..."
        Me.btnBrowser1.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSave.Location = New System.Drawing.Point(443, 149)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 21
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Browser1Name
        '
        Me.Browser1Name.Location = New System.Drawing.Point(81, 12)
        Me.Browser1Name.Name = "Browser1Name"
        Me.Browser1Name.Size = New System.Drawing.Size(182, 20)
        Me.Browser1Name.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Target:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(269, 15)
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
        Me.Browser1Image.Location = New System.Drawing.Point(272, 37)
        Me.Browser1Image.Name = "Browser1Image"
        Me.Browser1Image.Size = New System.Drawing.Size(134, 21)
        Me.Browser1Image.TabIndex = 2
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Location = New System.Drawing.Point(173, 42)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(430, 102)
        Me.TabControl1.TabIndex = 8
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(422, 76)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Browser 1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Browser1Image)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.btnBrowser1)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Browser1Name)
        Me.Panel1.Controls.Add(Me.Browser1Target)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(416, 70)
        Me.Panel1.TabIndex = 23
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Panel2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(422, 76)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Browser 2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Browser2Image)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.btnBrowser2)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Browser2Name)
        Me.Panel2.Controls.Add(Me.Browser2Target)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Enabled = False
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(416, 70)
        Me.Panel2.TabIndex = 16
        '
        'Browser2Image
        '
        Me.Browser2Image.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Browser2Image.FormattingEnabled = True
        Me.Browser2Image.Items.AddRange(New Object() {"Firefox", "Internet Explorer", "Opera", "Safari", "Google Chrome"})
        Me.Browser2Image.Location = New System.Drawing.Point(272, 37)
        Me.Browser2Image.Name = "Browser2Image"
        Me.Browser2Image.Size = New System.Drawing.Size(134, 21)
        Me.Browser2Image.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 41)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Target:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Display Name:"
        '
        'btnBrowser2
        '
        Me.btnBrowser2.Location = New System.Drawing.Point(236, 35)
        Me.btnBrowser2.Name = "btnBrowser2"
        Me.btnBrowser2.Size = New System.Drawing.Size(27, 23)
        Me.btnBrowser2.TabIndex = 8
        Me.btnBrowser2.Text = "..."
        Me.btnBrowser2.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(269, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Image:"
        '
        'Browser2Name
        '
        Me.Browser2Name.Location = New System.Drawing.Point(81, 12)
        Me.Browser2Name.Name = "Browser2Name"
        Me.Browser2Name.Size = New System.Drawing.Size(182, 20)
        Me.Browser2Name.TabIndex = 5
        '
        'Browser2Target
        '
        Me.Browser2Target.Location = New System.Drawing.Point(50, 38)
        Me.Browser2Target.Name = "Browser2Target"
        Me.Browser2Target.Size = New System.Drawing.Size(180, 20)
        Me.Browser2Target.TabIndex = 7
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Panel3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(422, 76)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Browser 3"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Browser3Image)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.btnBrowser3)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.Browser3Name)
        Me.Panel3.Controls.Add(Me.Browser3Target)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Enabled = False
        Me.Panel3.Location = New System.Drawing.Point(3, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(416, 70)
        Me.Panel3.TabIndex = 23
        '
        'Browser3Image
        '
        Me.Browser3Image.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Browser3Image.FormattingEnabled = True
        Me.Browser3Image.Items.AddRange(New Object() {"Firefox", "Internet Explorer", "Opera", "Safari", "Google Chrome"})
        Me.Browser3Image.Location = New System.Drawing.Point(272, 37)
        Me.Browser3Image.Name = "Browser3Image"
        Me.Browser3Image.Size = New System.Drawing.Size(134, 21)
        Me.Browser3Image.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 15)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Display Name:"
        '
        'btnBrowser3
        '
        Me.btnBrowser3.Location = New System.Drawing.Point(236, 35)
        Me.btnBrowser3.Name = "btnBrowser3"
        Me.btnBrowser3.Size = New System.Drawing.Size(27, 23)
        Me.btnBrowser3.TabIndex = 12
        Me.btnBrowser3.Text = "..."
        Me.btnBrowser3.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(269, 15)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 13)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Image:"
        '
        'Browser3Name
        '
        Me.Browser3Name.Location = New System.Drawing.Point(81, 12)
        Me.Browser3Name.Name = "Browser3Name"
        Me.Browser3Name.Size = New System.Drawing.Size(182, 20)
        Me.Browser3Name.TabIndex = 9
        '
        'Browser3Target
        '
        Me.Browser3Target.Location = New System.Drawing.Point(50, 38)
        Me.Browser3Target.Name = "Browser3Target"
        Me.Browser3Target.Size = New System.Drawing.Size(180, 20)
        Me.Browser3Target.TabIndex = 11
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(3, 41)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(41, 13)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Target:"
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.Panel4)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(422, 76)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Browser 4"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Browser4Image)
        Me.Panel4.Controls.Add(Me.Label11)
        Me.Panel4.Controls.Add(Me.btnBrowser4)
        Me.Panel4.Controls.Add(Me.Label12)
        Me.Panel4.Controls.Add(Me.Browser4Name)
        Me.Panel4.Controls.Add(Me.Browser4Target)
        Me.Panel4.Controls.Add(Me.Label13)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Enabled = False
        Me.Panel4.Location = New System.Drawing.Point(3, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(416, 70)
        Me.Panel4.TabIndex = 23
        '
        'Browser4Image
        '
        Me.Browser4Image.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Browser4Image.FormattingEnabled = True
        Me.Browser4Image.Items.AddRange(New Object() {"Firefox", "Internet Explorer", "Opera", "Safari", "Google Chrome"})
        Me.Browser4Image.Location = New System.Drawing.Point(272, 37)
        Me.Browser4Image.Name = "Browser4Image"
        Me.Browser4Image.Size = New System.Drawing.Size(134, 21)
        Me.Browser4Image.TabIndex = 14
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(3, 15)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(75, 13)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "Display Name:"
        '
        'btnBrowser4
        '
        Me.btnBrowser4.Location = New System.Drawing.Point(236, 35)
        Me.btnBrowser4.Name = "btnBrowser4"
        Me.btnBrowser4.Size = New System.Drawing.Size(27, 23)
        Me.btnBrowser4.TabIndex = 16
        Me.btnBrowser4.Text = "..."
        Me.btnBrowser4.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(269, 15)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(39, 13)
        Me.Label12.TabIndex = 31
        Me.Label12.Text = "Image:"
        '
        'Browser4Name
        '
        Me.Browser4Name.Location = New System.Drawing.Point(81, 12)
        Me.Browser4Name.Name = "Browser4Name"
        Me.Browser4Name.Size = New System.Drawing.Size(182, 20)
        Me.Browser4Name.TabIndex = 13
        '
        'Browser4Target
        '
        Me.Browser4Target.Location = New System.Drawing.Point(50, 38)
        Me.Browser4Target.Name = "Browser4Target"
        Me.Browser4Target.Size = New System.Drawing.Size(180, 20)
        Me.Browser4Target.TabIndex = 15
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(3, 41)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(41, 13)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "Target:"
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.Panel5)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(422, 76)
        Me.TabPage5.TabIndex = 6
        Me.TabPage5.Text = "Browser 5"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Browser5Image)
        Me.Panel5.Controls.Add(Me.Label20)
        Me.Panel5.Controls.Add(Me.btnBrowser5)
        Me.Panel5.Controls.Add(Me.Label21)
        Me.Panel5.Controls.Add(Me.Browser5Name)
        Me.Panel5.Controls.Add(Me.Browser5Target)
        Me.Panel5.Controls.Add(Me.Label22)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Enabled = False
        Me.Panel5.Location = New System.Drawing.Point(3, 3)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(416, 70)
        Me.Panel5.TabIndex = 23
        '
        'Browser5Image
        '
        Me.Browser5Image.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Browser5Image.FormattingEnabled = True
        Me.Browser5Image.Items.AddRange(New Object() {"Firefox", "Internet Explorer", "Opera", "Safari", "Google Chrome"})
        Me.Browser5Image.Location = New System.Drawing.Point(272, 37)
        Me.Browser5Image.Name = "Browser5Image"
        Me.Browser5Image.Size = New System.Drawing.Size(134, 21)
        Me.Browser5Image.TabIndex = 18
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(3, 15)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(75, 13)
        Me.Label20.TabIndex = 26
        Me.Label20.Text = "Display Name:"
        '
        'btnBrowser5
        '
        Me.btnBrowser5.Location = New System.Drawing.Point(236, 35)
        Me.btnBrowser5.Name = "btnBrowser5"
        Me.btnBrowser5.Size = New System.Drawing.Size(27, 23)
        Me.btnBrowser5.TabIndex = 20
        Me.btnBrowser5.Text = "..."
        Me.btnBrowser5.UseVisualStyleBackColor = True
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(269, 15)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(39, 13)
        Me.Label21.TabIndex = 31
        Me.Label21.Text = "Image:"
        '
        'Browser5Name
        '
        Me.Browser5Name.Location = New System.Drawing.Point(81, 12)
        Me.Browser5Name.Name = "Browser5Name"
        Me.Browser5Name.Size = New System.Drawing.Size(182, 20)
        Me.Browser5Name.TabIndex = 17
        '
        'Browser5Target
        '
        Me.Browser5Target.Location = New System.Drawing.Point(50, 38)
        Me.Browser5Target.Name = "Browser5Target"
        Me.Browser5Target.Size = New System.Drawing.Size(180, 20)
        Me.Browser5Target.TabIndex = 19
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(3, 41)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(41, 13)
        Me.Label22.TabIndex = 30
        Me.Label22.Text = "Target:"
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.Panel6)
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(422, 76)
        Me.TabPage6.TabIndex = 4
        Me.TabPage6.Text = "Miscellaneous"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.cbURL)
        Me.Panel6.Controls.Add(Me.btnSetDefault)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(3, 3)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(416, 70)
        Me.Panel6.TabIndex = 23
        '
        'btnSetDefault
        '
        Me.btnSetDefault.AutoSize = True
        Me.btnSetDefault.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnSetDefault.Location = New System.Drawing.Point(3, 3)
        Me.btnSetDefault.Name = "btnSetDefault"
        Me.btnSetDefault.Size = New System.Drawing.Size(250, 23)
        Me.btnSetDefault.TabIndex = 10
        Me.btnSetDefault.Text = "Activate Browser Choose (Make Default Browser)"
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
        Me.btnCancel.TabIndex = 22
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(328, 6)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(67, 17)
        Me.CheckBox1.TabIndex = 32
        Me.CheckBox1.Text = "Disabled"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Firefox", "Internet Explorer", "Opera", "Safari", "Google Chrome"})
        Me.ComboBox1.Location = New System.Drawing.Point(275, 38)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(134, 21)
        Me.ComboBox1.TabIndex = 33
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 16)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(75, 13)
        Me.Label14.TabIndex = 26
        Me.Label14.Text = "Display Name:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(272, 16)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(39, 13)
        Me.Label15.TabIndex = 31
        Me.Label15.Text = "Image:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(53, 39)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(180, 20)
        Me.TextBox1.TabIndex = 27
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(6, 42)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(41, 13)
        Me.Label16.TabIndex = 30
        Me.Label16.Text = "Target:"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(84, 13)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(182, 20)
        Me.TextBox2.TabIndex = 29
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(239, 36)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(27, 23)
        Me.Button1.TabIndex = 28
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(328, 6)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(67, 17)
        Me.CheckBox2.TabIndex = 32
        Me.CheckBox2.Text = "Disabled"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Firefox", "Internet Explorer", "Opera", "Safari", "Google Chrome"})
        Me.ComboBox2.Location = New System.Drawing.Point(275, 38)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(134, 21)
        Me.ComboBox2.TabIndex = 33
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(6, 16)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(75, 13)
        Me.Label17.TabIndex = 26
        Me.Label17.Text = "Display Name:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(272, 16)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(39, 13)
        Me.Label18.TabIndex = 31
        Me.Label18.Text = "Image:"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(53, 39)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(180, 20)
        Me.TextBox3.TabIndex = 27
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(6, 42)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(41, 13)
        Me.Label19.TabIndex = 30
        Me.Label19.Text = "Target:"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(84, 13)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(182, 20)
        Me.TextBox4.TabIndex = 29
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(239, 36)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(27, 23)
        Me.Button2.TabIndex = 28
        Me.Button2.Text = "..."
        Me.Button2.UseVisualStyleBackColor = True
        '
        'cbURL
        '
        Me.cbURL.AutoSize = True
        Me.cbURL.Location = New System.Drawing.Point(329, 7)
        Me.cbURL.Name = "cbURL"
        Me.cbURL.Size = New System.Drawing.Size(84, 17)
        Me.cbURL.TabIndex = 11
        Me.cbURL.Text = "Show URL?"
        Me.cbURL.UseVisualStyleBackColor = True
        '
        'Options
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(615, 178)
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
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.TabPage6.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
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
    Friend WithEvents Browser2Image As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Browser2Target As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Browser2Name As System.Windows.Forms.TextBox
    Friend WithEvents btnBrowser2 As System.Windows.Forms.Button
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents Browser3Image As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Browser3Target As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Browser3Name As System.Windows.Forms.TextBox
    Friend WithEvents btnBrowser3 As System.Windows.Forms.Button
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
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents Browser5Image As System.Windows.Forms.ComboBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Browser5Target As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Browser5Name As System.Windows.Forms.TextBox
    Friend WithEvents btnBrowser5 As System.Windows.Forms.Button
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Browser5FileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents cbURL As System.Windows.Forms.CheckBox
End Class
