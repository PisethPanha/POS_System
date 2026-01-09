<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class suplier
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
        Label12 = New Label()
        txtSearch = New TextBox()
        Button1 = New Button()
        btnSave = New Button()
        btnNew = New Button()
        btnUpdate = New Button()
        btnPrint = New Button()
        Label9 = New Label()
        cbVill = New ComboBox()
        txtName = New TextBox()
        Label15 = New Label()
        DataGridView1 = New DataGridView()
        Label13 = New Label()
        lbID = New Label()
        Label10 = New Label()
        Label7 = New Label()
        TableLayoutPanel1 = New TableLayoutPanel()
        Label5 = New Label()
        Panel1 = New Panel()
        TableLayoutPanel2 = New TableLayoutPanel()
        btnDel = New Button()
        txtTelegram = New TextBox()
        Label18 = New Label()
        txtCompany = New TextBox()
        Label3 = New Label()
        txtPhone = New TextBox()
        Label2 = New Label()
        dtpDateSign = New DateTimePicker()
        Panel3 = New Panel()
        Label1 = New Label()
        Label6 = New Label()
        cbProvince = New ComboBox()
        cbDist = New ComboBox()
        cbComm = New ComboBox()
        Label16 = New Label()
        Label17 = New Label()
        Label8 = New Label()
        DataGridView2 = New DataGridView()
        product_image = New DataGridViewImageColumn()
        Label4 = New Label()
        lbSupName = New Label()
        Panel2 = New Panel()
        lbTotal = New Label()
        lbNoData = New Label()
        lbIsSelect = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel1.SuspendLayout()
        Panel1.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        Panel3.SuspendLayout()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label12
        ' 
        Label12.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(192))
        Label12.Font = New Font("Khmer OS Battambang", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.ForeColor = SystemColors.ButtonHighlight
        Label12.Location = New Point(876, 0)
        Label12.Name = "Label12"
        Label12.Size = New Size(282, 43)
        Label12.TabIndex = 33
        Label12.Text = "ព័ត៌មានអ្នកផ្គត់ផ្គង់"
        ' 
        ' txtSearch
        ' 
        txtSearch.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtSearch.Location = New Point(175, 2)
        txtSearch.Multiline = True
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(316, 36)
        txtSearch.TabIndex = 32
        txtSearch.TextAlign = HorizontalAlignment.Center
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Button1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.ButtonHighlight
        Button1.Location = New Point(692, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(78, 34)
        Button1.TabIndex = 30
        Button1.Text = "Home"
        Button1.UseVisualStyleBackColor = False
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
        ' btnPrint
        ' 
        btnPrint.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        btnPrint.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnPrint.ForeColor = SystemColors.ButtonHighlight
        btnPrint.Location = New Point(223, 3)
        btnPrint.Name = "btnPrint"
        btnPrint.Size = New Size(104, 42)
        btnPrint.TabIndex = 16
        btnPrint.Text = "Print"
        btnPrint.UseVisualStyleBackColor = False
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(192))
        Label9.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = SystemColors.ButtonHighlight
        Label9.Location = New Point(82, -4)
        Label9.Name = "Label9"
        Label9.Size = New Size(99, 37)
        Label9.TabIndex = 31
        Label9.Text = "search"
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
        ' txtName
        ' 
        txtName.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        txtName.Location = New Point(187, 62)
        txtName.Multiline = True
        txtName.Name = "txtName"
        txtName.Size = New Size(300, 41)
        txtName.TabIndex = 32
        txtName.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Khmer OS Battambang", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label15.Location = New Point(34, 69)
        Label15.Name = "Label15"
        Label15.Size = New Size(150, 34)
        Label15.TabIndex = 25
        Label15.Text = "ឈ្មោះអ្នកផ្គត់ផ្គង់"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = SystemColors.ButtonFace
        DataGridView1.BorderStyle = BorderStyle.None
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(12, 108)
        DataGridView1.MaximumSize = New Size(640, 643)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersVisible = False
        DataGridView1.Size = New Size(628, 592)
        DataGridView1.TabIndex = 27
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Khmer OS Battambang", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.Location = New Point(76, 222)
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
        lbID.Location = New Point(185, 9)
        lbID.Name = "lbID"
        lbID.Size = New Size(302, 42)
        lbID.TabIndex = 21
        lbID.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Khmer OS Battambang", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(89, 16)
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
        Label7.Location = New Point(49, 453)
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
        TableLayoutPanel1.Controls.Add(btnPrint, 2, 0)
        TableLayoutPanel1.Location = New Point(49, 488)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.Size = New Size(441, 48)
        TableLayoutPanel1.TabIndex = 18
        ' 
        ' Label5
        ' 
        Label5.Font = New Font("Khmer OS Battambang", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(5, 302)
        Label5.Name = "Label5"
        Label5.Size = New Size(203, 48)
        Label5.TabIndex = 9
        Label5.Text = "កាលបរិច្ឆេទចុះឈ្មោះ"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(255))
        Panel1.Controls.Add(TableLayoutPanel2)
        Panel1.Controls.Add(txtTelegram)
        Panel1.Controls.Add(Label18)
        Panel1.Controls.Add(txtCompany)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(txtPhone)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(dtpDateSign)
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(txtName)
        Panel1.Controls.Add(Label15)
        Panel1.Controls.Add(Label13)
        Panel1.Controls.Add(lbID)
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(TableLayoutPanel1)
        Panel1.Controls.Add(Label5)
        Panel1.Location = New Point(668, 44)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(512, 662)
        Panel1.TabIndex = 29
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.BackColor = Color.FromArgb(CByte(64), CByte(0), CByte(64))
        TableLayoutPanel2.ColumnCount = 1
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 20F))
        TableLayoutPanel2.Controls.Add(btnDel, 0, 0)
        TableLayoutPanel2.Location = New Point(158, 532)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 1
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel2.Size = New Size(223, 44)
        TableLayoutPanel2.TabIndex = 53
        ' 
        ' btnDel
        ' 
        btnDel.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        btnDel.Dock = DockStyle.Fill
        btnDel.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDel.ForeColor = SystemColors.ButtonHighlight
        btnDel.Location = New Point(3, 3)
        btnDel.Name = "btnDel"
        btnDel.Size = New Size(217, 38)
        btnDel.TabIndex = 31
        btnDel.Text = "delete"
        btnDel.UseVisualStyleBackColor = False
        ' 
        ' txtTelegram
        ' 
        txtTelegram.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        txtTelegram.Location = New Point(188, 403)
        txtTelegram.Multiline = True
        txtTelegram.Name = "txtTelegram"
        txtTelegram.Size = New Size(300, 41)
        txtTelegram.TabIndex = 52
        txtTelegram.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Khmer OS Battambang", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label18.Location = New Point(78, 410)
        Label18.Name = "Label18"
        Label18.Size = New Size(107, 34)
        Label18.TabIndex = 51
        Label18.Text = "តេលេក្រាម"
        ' 
        ' txtCompany
        ' 
        txtCompany.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        txtCompany.Location = New Point(188, 112)
        txtCompany.Multiline = True
        txtCompany.Name = "txtCompany"
        txtCompany.Size = New Size(300, 41)
        txtCompany.TabIndex = 50
        txtCompany.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Khmer OS Battambang", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(49, 119)
        Label3.Name = "Label3"
        Label3.Size = New Size(136, 34)
        Label3.TabIndex = 49
        Label3.Text = "ឈ្មោះក្រុមហ៊ុន"
        ' 
        ' txtPhone
        ' 
        txtPhone.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        txtPhone.Location = New Point(188, 353)
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
        Label2.Location = New Point(44, 360)
        Label2.Name = "Label2"
        Label2.Size = New Size(147, 34)
        Label2.TabIndex = 47
        Label2.Text = "លេខទំនាក់ទំនង"
        ' 
        ' dtpDateSign
        ' 
        dtpDateSign.CustomFormat = ""
        dtpDateSign.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        dtpDateSign.Location = New Point(190, 302)
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
        Panel3.Location = New Point(188, 172)
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
        ' Label8
        ' 
        Label8.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(192))
        Label8.Font = New Font("Khmer OS Battambang", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = SystemColors.ButtonHighlight
        Label8.Location = New Point(2, -5)
        Label8.Name = "Label8"
        Label8.Size = New Size(1924, 50)
        Label8.TabIndex = 28
        Label8.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' DataGridView2
        ' 
        DataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader
        DataGridView2.BackgroundColor = SystemColors.Control
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Columns.AddRange(New DataGridViewColumn() {product_image})
        DataGridView2.Location = New Point(11, 100)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.Size = New Size(677, 527)
        DataGridView2.TabIndex = 34
        ' 
        ' product_image
        ' 
        product_image.HeaderText = "Product Image"
        product_image.ImageLayout = DataGridViewImageCellLayout.Stretch
        product_image.Name = "product_image"
        product_image.Width = 91
        ' 
        ' Label4
        ' 
        Label4.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(192))
        Label4.Font = New Font("Khmer OS Battambang", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.ButtonHighlight
        Label4.Location = New Point(1338, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(475, 43)
        Label4.TabIndex = 35
        Label4.Text = "ផលិតផលដែលបានទិញពីអ្នកផ្គត់ផ្គង់"
        ' 
        ' lbSupName
        ' 
        lbSupName.Font = New Font("Khmer OS Battambang", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbSupName.Location = New Point(1221, 72)
        lbSupName.Name = "lbSupName"
        lbSupName.Size = New Size(677, 41)
        lbSupName.TabIndex = 36
        lbSupName.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(lbTotal)
        Panel2.Controls.Add(lbNoData)
        Panel2.Controls.Add(lbIsSelect)
        Panel2.Controls.Add(DataGridView2)
        Panel2.Location = New Point(1210, 60)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(702, 640)
        Panel2.TabIndex = 37
        ' 
        ' lbTotal
        ' 
        lbTotal.AutoSize = True
        lbTotal.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbTotal.Location = New Point(11, 57)
        lbTotal.Name = "lbTotal"
        lbTotal.Size = New Size(149, 30)
        lbTotal.TabIndex = 36
        lbTotal.Text = "Total_amount: "
        lbTotal.Visible = False
        ' 
        ' lbNoData
        ' 
        lbNoData.AutoSize = True
        lbNoData.Font = New Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbNoData.Location = New Point(290, 279)
        lbNoData.Name = "lbNoData"
        lbNoData.Size = New Size(128, 36)
        lbNoData.TabIndex = 35
        lbNoData.Text = "No Data"
        ' 
        ' lbIsSelect
        ' 
        lbIsSelect.AutoSize = True
        lbIsSelect.Font = New Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbIsSelect.Location = New Point(37, 279)
        lbIsSelect.Name = "lbIsSelect"
        lbIsSelect.Size = New Size(636, 36)
        lbIsSelect.TabIndex = 0
        lbIsSelect.Text = "Please select suplier to see product from them"
        ' 
        ' suplier
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1924, 700)
        Controls.Add(lbSupName)
        Controls.Add(Label4)
        Controls.Add(Label12)
        Controls.Add(txtSearch)
        Controls.Add(Button1)
        Controls.Add(Label9)
        Controls.Add(DataGridView1)
        Controls.Add(Panel1)
        Controls.Add(Label8)
        Controls.Add(Panel2)
        Name = "suplier"
        Text = "suplier"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel1.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        TableLayoutPanel2.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label12 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnNew As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents pan As Panel
    Friend WithEvents cbSuplier As ComboBox
    Friend WithEvents cbVill As ComboBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label13 As Label
    Friend WithEvents lbNoData As Label
    Friend WithEvents lbID As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents cbProvince As ComboBox
    Friend WithEvents cbDist As ComboBox
    Friend WithEvents cbComm As ComboBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents dtpDateSign As DateTimePicker
    Friend WithEvents txtCompany As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents product_image As DataGridViewImageColumn
    Friend WithEvents lbSupName As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtTelegram As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents lbIsSelect As Label
    Friend WithEvents lbTotal As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents btnDel As Button
End Class
