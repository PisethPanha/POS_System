<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Staff_Management
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
        txtTelegram = New TextBox()
        txtPhone = New TextBox()
        Label2 = New Label()
        dtpDateSign = New DateTimePicker()
        Panel3 = New Panel()
        Label1 = New Label()
        Label6 = New Label()
        cbProvince = New ComboBox()
        cbDist = New ComboBox()
        cbComm = New ComboBox()
        cbVill = New ComboBox()
        Label16 = New Label()
        Label17 = New Label()
        Label9 = New Label()
        Label12 = New Label()
        txtSearch = New TextBox()
        Button1 = New Button()
        Label18 = New Label()
        product_image = New DataGridViewImageColumn()
        DataGridView1 = New DataGridView()
        staff_photo = New DataGridViewImageColumn()
        Panel1 = New Panel()
        Label3 = New Label()
        cbRole = New ComboBox()
        txtCardID = New TextBox()
        Label4 = New Label()
        btnBrowse = New Button()
        pbImg = New PictureBox()
        txtName = New TextBox()
        lbname = New Label()
        Label13 = New Label()
        lbID = New Label()
        Label10 = New Label()
        Label7 = New Label()
        TableLayoutPanel1 = New TableLayoutPanel()
        btnSave = New Button()
        btnNew = New Button()
        btnUpdate = New Button()
        btnDel = New Button()
        Label5 = New Label()
        Label8 = New Label()
        txtPass = New TextBox()
        Label11 = New Label()
        txtUserName = New TextBox()
        Label14 = New Label()
        Panel3.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(pbImg, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtTelegram
        ' 
        txtTelegram.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        txtTelegram.Location = New Point(183, 517)
        txtTelegram.Multiline = True
        txtTelegram.Name = "txtTelegram"
        txtTelegram.Size = New Size(300, 41)
        txtTelegram.TabIndex = 52
        txtTelegram.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtPhone
        ' 
        txtPhone.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        txtPhone.Location = New Point(183, 467)
        txtPhone.Multiline = True
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(300, 41)
        txtPhone.TabIndex = 48
        txtPhone.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Khmer OS Battambang", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(39, 474)
        Label2.Name = "Label2"
        Label2.Size = New Size(147, 34)
        Label2.TabIndex = 47
        Label2.Text = "លេខទំនាក់ទំនង"
        ' 
        ' dtpDateSign
        ' 
        dtpDateSign.CustomFormat = ""
        dtpDateSign.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        dtpDateSign.Location = New Point(185, 333)
        dtpDateSign.Name = "dtpDateSign"
        dtpDateSign.Size = New Size(299, 29)
        dtpDateSign.TabIndex = 46
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.White
        Panel3.Controls.Add(Label1)
        Panel3.Controls.Add(Label6)
        Panel3.Controls.Add(cbProvince)
        Panel3.Controls.Add(cbDist)
        Panel3.Controls.Add(cbComm)
        Panel3.Controls.Add(cbVill)
        Panel3.Controls.Add(Label16)
        Panel3.Controls.Add(Label17)
        Panel3.Location = New Point(184, 158)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(300, 120)
        Panel3.TabIndex = 45
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Khmer OS Battambang", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(154, 65)
        Label1.Name = "Label1"
        Label1.Size = New Size(26, 19)
        Label1.TabIndex = 45
        Label1.Text = "ភូមិ"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Khmer OS Battambang", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(4, 65)
        Label6.Name = "Label6"
        Label6.Size = New Size(57, 19)
        Label6.TabIndex = 46
        Label6.Text = "ឃុំ/សង្កាត់"
        ' 
        ' cbProvince
        ' 
        cbProvince.DropDownStyle = ComboBoxStyle.DropDownList
        cbProvince.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        cbProvince.FormattingEnabled = True
        cbProvince.Location = New Point(4, 27)
        cbProvince.Name = "cbProvince"
        cbProvince.Size = New Size(133, 29)
        cbProvince.TabIndex = 42
        ' 
        ' cbDist
        ' 
        cbDist.DropDownStyle = ComboBoxStyle.DropDownList
        cbDist.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        cbDist.FormattingEnabled = True
        cbDist.Location = New Point(154, 27)
        cbDist.Name = "cbDist"
        cbDist.Size = New Size(132, 29)
        cbDist.TabIndex = 41
        ' 
        ' cbComm
        ' 
        cbComm.DropDownStyle = ComboBoxStyle.DropDownList
        cbComm.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        cbComm.FormattingEnabled = True
        cbComm.Location = New Point(2, 84)
        cbComm.Name = "cbComm"
        cbComm.Size = New Size(133, 29)
        cbComm.TabIndex = 38
        ' 
        ' cbVill
        ' 
        cbVill.DropDownStyle = ComboBoxStyle.DropDownList
        cbVill.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        cbVill.FormattingEnabled = True
        cbVill.Location = New Point(155, 84)
        cbVill.Name = "cbVill"
        cbVill.Size = New Size(132, 29)
        cbVill.TabIndex = 33
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Khmer OS Battambang", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label16.Location = New Point(4, 5)
        Label16.Name = "Label16"
        Label16.Size = New Size(73, 19)
        Label16.TabIndex = 44
        Label16.Text = "រាជធានី/ខេត្ត"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Khmer OS Battambang", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label17.Location = New Point(151, 5)
        Label17.Name = "Label17"
        Label17.Size = New Size(63, 19)
        Label17.TabIndex = 43
        Label17.Text = "ស្រុក/ខណ្ឌ"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(192))
        Label9.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = SystemColors.ButtonHighlight
        Label9.Location = New Point(79, -1)
        Label9.Name = "Label9"
        Label9.Size = New Size(99, 37)
        Label9.TabIndex = 38
        Label9.Text = "search"
        ' 
        ' Label12
        ' 
        Label12.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(192))
        Label12.Font = New Font("Khmer OS Battambang", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.ForeColor = SystemColors.ButtonHighlight
        Label12.Location = New Point(873, 3)
        Label12.Name = "Label12"
        Label12.Size = New Size(282, 43)
        Label12.TabIndex = 40
        Label12.Text = "ព័ត៌មានបុគ្គលិក"
        ' 
        ' txtSearch
        ' 
        txtSearch.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtSearch.Location = New Point(184, 5)
        txtSearch.Multiline = True
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(316, 36)
        txtSearch.TabIndex = 39
        txtSearch.TextAlign = HorizontalAlignment.Center
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Button1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.ButtonHighlight
        Button1.Location = New Point(693, 5)
        Button1.Name = "Button1"
        Button1.Size = New Size(78, 34)
        Button1.TabIndex = 37
        Button1.Text = "Home"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Khmer OS Battambang", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label18.Location = New Point(73, 524)
        Label18.Name = "Label18"
        Label18.Size = New Size(107, 34)
        Label18.TabIndex = 51
        Label18.Text = "តេលេក្រាម"
        ' 
        ' product_image
        ' 
        product_image.HeaderText = "Product Image"
        product_image.ImageLayout = DataGridViewImageCellLayout.Stretch
        product_image.Name = "product_image"
        product_image.Width = 91
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = SystemColors.ButtonFace
        DataGridView1.BorderStyle = BorderStyle.None
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {staff_photo})
        DataGridView1.Location = New Point(9, 111)
        DataGridView1.MaximumSize = New Size(640, 643)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersVisible = False
        DataGridView1.Size = New Size(628, 592)
        DataGridView1.TabIndex = 34
        ' 
        ' staff_photo
        ' 
        staff_photo.HeaderText = "Staff Photo"
        staff_photo.ImageLayout = DataGridViewImageCellLayout.Stretch
        staff_photo.Name = "staff_photo"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(255))
        Panel1.Controls.Add(txtPass)
        Panel1.Controls.Add(Label11)
        Panel1.Controls.Add(txtUserName)
        Panel1.Controls.Add(Label14)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(cbRole)
        Panel1.Controls.Add(txtCardID)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(btnBrowse)
        Panel1.Controls.Add(pbImg)
        Panel1.Controls.Add(txtTelegram)
        Panel1.Controls.Add(Label18)
        Panel1.Controls.Add(txtPhone)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(dtpDateSign)
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(txtName)
        Panel1.Controls.Add(lbname)
        Panel1.Controls.Add(Label13)
        Panel1.Controls.Add(lbID)
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(TableLayoutPanel1)
        Panel1.Controls.Add(Label5)
        Panel1.Location = New Point(665, 47)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(920, 662)
        Panel1.TabIndex = 36
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Khmer OS Battambang", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(109, 286)
        Label3.Name = "Label3"
        Label3.Size = New Size(71, 34)
        Label3.TabIndex = 57
        Label3.Text = "តួរនាទី"
        ' 
        ' cbRole
        ' 
        cbRole.DropDownStyle = ComboBoxStyle.DropDownList
        cbRole.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        cbRole.FormattingEnabled = True
        cbRole.Location = New Point(186, 289)
        cbRole.Name = "cbRole"
        cbRole.Size = New Size(133, 29)
        cbRole.TabIndex = 47
        ' 
        ' txtCardID
        ' 
        txtCardID.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        txtCardID.Location = New Point(181, 57)
        txtCardID.Multiline = True
        txtCardID.Name = "txtCardID"
        txtCardID.Size = New Size(300, 41)
        txtCardID.TabIndex = 56
        txtCardID.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Khmer OS Battambang", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(77, 64)
        Label4.Name = "Label4"
        Label4.Size = New Size(91, 34)
        Label4.TabIndex = 55
        Label4.Text = "លេខកាត"
        ' 
        ' btnBrowse
        ' 
        btnBrowse.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        btnBrowse.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBrowse.ForeColor = SystemColors.ButtonHighlight
        btnBrowse.Location = New Point(556, 215)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(158, 37)
        btnBrowse.TabIndex = 54
        btnBrowse.Text = "Change Image"
        btnBrowse.UseVisualStyleBackColor = False
        ' 
        ' pbImg
        ' 
        pbImg.Image = My.Resources.Resource1.tmpIMG
        pbImg.Location = New Point(529, 9)
        pbImg.Name = "pbImg"
        pbImg.Size = New Size(200, 200)
        pbImg.SizeMode = PictureBoxSizeMode.StretchImage
        pbImg.TabIndex = 53
        pbImg.TabStop = False
        ' 
        ' txtName
        ' 
        txtName.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        txtName.Location = New Point(183, 103)
        txtName.Multiline = True
        txtName.Name = "txtName"
        txtName.Size = New Size(300, 41)
        txtName.TabIndex = 32
        txtName.TextAlign = HorizontalAlignment.Center
        ' 
        ' lbname
        ' 
        lbname.AutoSize = True
        lbname.Font = New Font("Khmer OS Battambang", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbname.Location = New Point(40, 110)
        lbname.Name = "lbname"
        lbname.Size = New Size(128, 34)
        lbname.TabIndex = 25
        lbname.Text = "ឈ្មោះបុគ្គលិក"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Khmer OS Battambang", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.Location = New Point(72, 208)
        Label13.Name = "Label13"
        Label13.Size = New Size(109, 34)
        Label13.TabIndex = 25
        Label13.Text = "អាស័យដ្ឋាន"
        ' 
        ' lbID
        ' 
        lbID.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        lbID.BorderStyle = BorderStyle.Fixed3D
        lbID.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbID.Location = New Point(181, 9)
        lbID.Name = "lbID"
        lbID.Size = New Size(302, 42)
        lbID.TabIndex = 21
        lbID.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Khmer OS Battambang", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(85, 16)
        Label10.Name = "Label10"
        Label10.Size = New Size(36, 34)
        Label10.TabIndex = 20
        Label10.Text = "ID"
        ' 
        ' Label7
        ' 
        Label7.BackColor = Color.FromArgb(CByte(64), CByte(0), CByte(64))
        Label7.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = SystemColors.ButtonHighlight
        Label7.Location = New Point(45, 567)
        Label7.Name = "Label7"
        Label7.Size = New Size(441, 35)
        Label7.TabIndex = 19
        Label7.Text = "ACTIONS"
        Label7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.BackColor = Color.FromArgb(CByte(64), CByte(0), CByte(64))
        TableLayoutPanel1.ColumnCount = 4
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.Controls.Add(btnSave, 0, 0)
        TableLayoutPanel1.Controls.Add(btnNew, 3, 0)
        TableLayoutPanel1.Controls.Add(btnUpdate, 1, 0)
        TableLayoutPanel1.Controls.Add(btnDel, 2, 0)
        TableLayoutPanel1.Location = New Point(45, 603)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.Size = New Size(441, 48)
        TableLayoutPanel1.TabIndex = 18
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        btnSave.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSave.ForeColor = SystemColors.ButtonHighlight
        btnSave.Location = New Point(3, 3)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(104, 42)
        btnSave.TabIndex = 14
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' btnNew
        ' 
        btnNew.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        btnNew.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnNew.ForeColor = SystemColors.ButtonHighlight
        btnNew.Location = New Point(333, 3)
        btnNew.Name = "btnNew"
        btnNew.Size = New Size(105, 42)
        btnNew.TabIndex = 17
        btnNew.Text = "New"
        btnNew.UseVisualStyleBackColor = False
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        btnUpdate.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnUpdate.ForeColor = SystemColors.ButtonHighlight
        btnUpdate.Location = New Point(113, 3)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(104, 42)
        btnUpdate.TabIndex = 15
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' btnDel
        ' 
        btnDel.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        btnDel.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDel.ForeColor = SystemColors.ButtonHighlight
        btnDel.Location = New Point(223, 3)
        btnDel.Name = "btnDel"
        btnDel.Size = New Size(104, 42)
        btnDel.TabIndex = 16
        btnDel.Text = "Delete"
        btnDel.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.Font = New Font("Khmer OS Battambang", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(0, 333)
        Label5.Name = "Label5"
        Label5.Size = New Size(203, 48)
        Label5.TabIndex = 9
        Label5.Text = "កាលបរិច្ឆេទចុះឈ្មោះ"
        ' 
        ' Label8
        ' 
        Label8.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(192))
        Label8.Font = New Font("Khmer OS Battambang", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = SystemColors.ButtonHighlight
        Label8.Location = New Point(-1, -2)
        Label8.Name = "Label8"
        Label8.Size = New Size(1924, 50)
        Label8.TabIndex = 35
        Label8.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' txtPass
        ' 
        txtPass.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        txtPass.Location = New Point(183, 417)
        txtPass.Multiline = True
        txtPass.Name = "txtPass"
        txtPass.Size = New Size(300, 41)
        txtPass.TabIndex = 61
        txtPass.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Khmer OS Battambang", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(73, 424)
        Label11.Name = "Label11"
        Label11.Size = New Size(111, 34)
        Label11.TabIndex = 60
        Label11.Text = "លេខសម្ងាត់"
        ' 
        ' txtUserName
        ' 
        txtUserName.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        txtUserName.Location = New Point(183, 367)
        txtUserName.Multiline = True
        txtUserName.Name = "txtUserName"
        txtUserName.Size = New Size(300, 41)
        txtUserName.TabIndex = 59
        txtUserName.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Khmer OS Battambang", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label14.Location = New Point(14, 374)
        Label14.Name = "Label14"
        Label14.Size = New Size(172, 34)
        Label14.TabIndex = 58
        Label14.Text = "ឈ្មោះអ្នកប្រើប្រាស់"
        ' 
        ' Staff_Management
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1406, 708)
        Controls.Add(Label9)
        Controls.Add(Label12)
        Controls.Add(txtSearch)
        Controls.Add(Button1)
        Controls.Add(DataGridView1)
        Controls.Add(Panel1)
        Controls.Add(Label8)
        Name = "Staff_Management"
        Text = "Staff_Management"
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(pbImg, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtTelegram As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpDateSign As DateTimePicker
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cbProvince As ComboBox
    Friend WithEvents cbDist As ComboBox
    Friend WithEvents cbComm As ComboBox
    Friend WithEvents cbVill As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label18 As Label
    Friend WithEvents product_image As DataGridViewImageColumn
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtName As TextBox
    Friend WithEvents lbname As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lbID As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnSave As Button
    Friend WithEvents btnNew As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDel As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents staff_photo As DataGridViewImageColumn
    Friend WithEvents btnBrowse As Button
    Friend WithEvents pbImg As PictureBox
    Friend WithEvents txtCardID As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cbRole As ComboBox
    Friend WithEvents txtPass As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtUserName As TextBox
    Friend WithEvents Label14 As Label
End Class
