<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class stock_control
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
        DataGridView1 = New DataGridView()
        product_image = New DataGridViewImageColumn()
        Label1 = New Label()
        txtName = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        lbTotal = New Label()
        pbImg = New PictureBox()
        Label8 = New Label()
        Panel1 = New Panel()
        txtSuplier = New TextBox()
        Label11 = New Label()
        lbDate = New Label()
        Panel2 = New Panel()
        txtCatagory = New ComboBox()
        txtQuantity = New Label()
        lbID = New Label()
        Label10 = New Label()
        btnBrowse = New Button()
        Label7 = New Label()
        TableLayoutPanel1 = New TableLayoutPanel()
        btnSave = New Button()
        btnNew = New Button()
        btnUpdate = New Button()
        btnDel = New Button()
        txtPrice = New TextBox()
        Button1 = New Button()
        txtSearch = New TextBox()
        Label9 = New Label()
        Label12 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbImg, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = SystemColors.ButtonFace
        DataGridView1.BorderStyle = BorderStyle.None
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {product_image})
        DataGridView1.Location = New Point(2, 68)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(640, 591)
        DataGridView1.TabIndex = 0
        ' 
        ' product_image
        ' 
        product_image.HeaderText = "product image"
        product_image.ImageLayout = DataGridViewImageCellLayout.Stretch
        product_image.Name = "product_image"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Khmer OS Battambang", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(25, 72)
        Label1.Name = "Label1"
        Label1.Size = New Size(148, 34)
        Label1.TabIndex = 1
        Label1.Text = "ឈ្មោះផលិតផល"
        ' 
        ' txtName
        ' 
        txtName.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        txtName.Location = New Point(183, 69)
        txtName.Multiline = True
        txtName.Name = "txtName"
        txtName.Size = New Size(300, 41)
        txtName.TabIndex = 2
        txtName.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Khmer OS Battambang", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(100, 129)
        Label2.Name = "Label2"
        Label2.Size = New Size(73, 34)
        Label2.TabIndex = 3
        Label2.Text = "ប្រភេទ"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Khmer OS Battambang", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(89, 191)
        Label3.Name = "Label3"
        Label3.Size = New Size(84, 34)
        Label3.TabIndex = 5
        Label3.Text = "បរិមាណ"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Khmer OS Battambang", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(122, 257)
        Label4.Name = "Label4"
        Label4.Size = New Size(51, 34)
        Label4.TabIndex = 7
        Label4.Text = "តម្លៃ"
        ' 
        ' Label5
        ' 
        Label5.Font = New Font("Khmer OS Battambang", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(11, 311)
        Label5.Name = "Label5"
        Label5.Size = New Size(169, 34)
        Label5.TabIndex = 9
        Label5.Text = "កាលបរិច្ឆេទបញ្ចូល"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Khmer OS Battambang", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(86, 366)
        Label6.Name = "Label6"
        Label6.Size = New Size(93, 34)
        Label6.TabIndex = 11
        Label6.Text = "តម្លៃសរុប"
        ' 
        ' lbTotal
        ' 
        lbTotal.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        lbTotal.BorderStyle = BorderStyle.Fixed3D
        lbTotal.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbTotal.Location = New Point(182, 359)
        lbTotal.Name = "lbTotal"
        lbTotal.Size = New Size(302, 42)
        lbTotal.TabIndex = 12
        lbTotal.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' pbImg
        ' 
        pbImg.Image = My.Resources.Resource1.tmpIMG
        pbImg.Location = New Point(507, 16)
        pbImg.Name = "pbImg"
        pbImg.Size = New Size(200, 200)
        pbImg.SizeMode = PictureBoxSizeMode.StretchImage
        pbImg.TabIndex = 13
        pbImg.TabStop = False
        ' 
        ' Label8
        ' 
        Label8.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(192))
        Label8.Font = New Font("Khmer OS Battambang", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = SystemColors.ButtonHighlight
        Label8.Location = New Point(2, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(1396, 50)
        Label8.TabIndex = 14
        Label8.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(255))
        Panel1.Controls.Add(txtSuplier)
        Panel1.Controls.Add(Label11)
        Panel1.Controls.Add(lbDate)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(txtQuantity)
        Panel1.Controls.Add(lbID)
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(btnBrowse)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(TableLayoutPanel1)
        Panel1.Controls.Add(pbImg)
        Panel1.Controls.Add(lbTotal)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(txtPrice)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(txtName)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Label5)
        Panel1.Location = New Point(667, 49)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(731, 573)
        Panel1.TabIndex = 15
        ' 
        ' txtSuplier
        ' 
        txtSuplier.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        txtSuplier.Location = New Point(183, 412)
        txtSuplier.Multiline = True
        txtSuplier.Name = "txtSuplier"
        txtSuplier.Size = New Size(300, 41)
        txtSuplier.TabIndex = 27
        txtSuplier.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Khmer OS Battambang", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(81, 419)
        Label11.Name = "Label11"
        Label11.Size = New Size(99, 34)
        Label11.TabIndex = 26
        Label11.Text = "អ្នកផ្គត់ផ្គង់"
        ' 
        ' lbDate
        ' 
        lbDate.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        lbDate.BorderStyle = BorderStyle.Fixed3D
        lbDate.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbDate.Location = New Point(182, 305)
        lbDate.Name = "lbDate"
        lbDate.Size = New Size(302, 42)
        lbDate.TabIndex = 25
        lbDate.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(txtCatagory)
        Panel2.Location = New Point(184, 129)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(300, 41)
        Panel2.TabIndex = 24
        ' 
        ' txtCatagory
        ' 
        txtCatagory.DisplayMember = "ជ្រើសរើស"
        txtCatagory.Dock = DockStyle.Fill
        txtCatagory.Font = New Font("Khmer OS Battambang", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtCatagory.FormattingEnabled = True
        txtCatagory.Items.AddRange(New Object() {"ទាំងអស់", "laptop", "desktop", "camera", "phone", "PC accessory", "PC compnent", "PC all-in-one", "office accessory", "program"})
        txtCatagory.Location = New Point(0, 0)
        txtCatagory.Name = "txtCatagory"
        txtCatagory.Size = New Size(300, 30)
        txtCatagory.TabIndex = 23
        ' 
        ' txtQuantity
        ' 
        txtQuantity.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        txtQuantity.BorderStyle = BorderStyle.Fixed3D
        txtQuantity.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtQuantity.Location = New Point(182, 185)
        txtQuantity.Name = "txtQuantity"
        txtQuantity.Size = New Size(302, 42)
        txtQuantity.TabIndex = 22
        txtQuantity.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lbID
        ' 
        lbID.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        lbID.BorderStyle = BorderStyle.Fixed3D
        lbID.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbID.Location = New Point(182, 9)
        lbID.Name = "lbID"
        lbID.Size = New Size(302, 42)
        lbID.TabIndex = 21
        lbID.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Khmer OS Battambang", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(86, 16)
        Label10.Name = "Label10"
        Label10.Size = New Size(36, 34)
        Label10.TabIndex = 20
        Label10.Text = "ID"
        ' 
        ' btnBrowse
        ' 
        btnBrowse.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        btnBrowse.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBrowse.ForeColor = SystemColors.ButtonHighlight
        btnBrowse.Location = New Point(534, 222)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(158, 37)
        btnBrowse.TabIndex = 18
        btnBrowse.Text = "Change Image"
        btnBrowse.UseVisualStyleBackColor = False
        ' 
        ' Label7
        ' 
        Label7.BackColor = Color.FromArgb(CByte(64), CByte(0), CByte(64))
        Label7.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = SystemColors.ButtonHighlight
        Label7.Location = New Point(86, 463)
        Label7.Name = "Label7"
        Label7.Size = New Size(482, 37)
        Label7.TabIndex = 19
        Label7.Text = "ACTIONS"
        Label7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 4
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.Controls.Add(btnSave, 0, 0)
        TableLayoutPanel1.Controls.Add(btnNew, 3, 0)
        TableLayoutPanel1.Controls.Add(btnUpdate, 1, 0)
        TableLayoutPanel1.Controls.Add(btnDel, 2, 0)
        TableLayoutPanel1.Location = New Point(86, 498)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.Size = New Size(482, 50)
        TableLayoutPanel1.TabIndex = 18
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        btnSave.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSave.ForeColor = SystemColors.ButtonHighlight
        btnSave.Location = New Point(3, 3)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(114, 44)
        btnSave.TabIndex = 14
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' btnNew
        ' 
        btnNew.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        btnNew.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnNew.ForeColor = SystemColors.ButtonHighlight
        btnNew.Location = New Point(363, 3)
        btnNew.Name = "btnNew"
        btnNew.Size = New Size(116, 44)
        btnNew.TabIndex = 17
        btnNew.Text = "New"
        btnNew.UseVisualStyleBackColor = False
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        btnUpdate.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnUpdate.ForeColor = SystemColors.ButtonHighlight
        btnUpdate.Location = New Point(123, 3)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(114, 44)
        btnUpdate.TabIndex = 15
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' btnDel
        ' 
        btnDel.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        btnDel.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDel.ForeColor = SystemColors.ButtonHighlight
        btnDel.Location = New Point(243, 3)
        btnDel.Name = "btnDel"
        btnDel.Size = New Size(114, 44)
        btnDel.TabIndex = 16
        btnDel.Text = "Delete"
        btnDel.UseVisualStyleBackColor = False
        ' 
        ' txtPrice
        ' 
        txtPrice.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        txtPrice.Location = New Point(183, 252)
        txtPrice.Multiline = True
        txtPrice.Name = "txtPrice"
        txtPrice.Size = New Size(300, 41)
        txtPrice.TabIndex = 8
        txtPrice.TextAlign = HorizontalAlignment.Center
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Button1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.ButtonHighlight
        Button1.Location = New Point(692, 9)
        Button1.Name = "Button1"
        Button1.Size = New Size(78, 34)
        Button1.TabIndex = 23
        Button1.Text = "Home"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' txtSearch
        ' 
        txtSearch.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtSearch.Location = New Point(175, 7)
        txtSearch.Multiline = True
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(316, 36)
        txtSearch.TabIndex = 25
        txtSearch.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(192))
        Label9.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = SystemColors.ButtonHighlight
        Label9.Location = New Point(82, 1)
        Label9.Name = "Label9"
        Label9.Size = New Size(99, 37)
        Label9.TabIndex = 24
        Label9.Text = "search"
        ' 
        ' Label12
        ' 
        Label12.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(192))
        Label12.Font = New Font("Khmer OS Battambang", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.ForeColor = SystemColors.ButtonHighlight
        Label12.Location = New Point(876, 1)
        Label12.Name = "Label12"
        Label12.Size = New Size(282, 49)
        Label12.TabIndex = 26
        Label12.Text = "ព័ត៌មានផលិតផល"
        ' 
        ' stock_control
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1399, 621)
        Controls.Add(Label12)
        Controls.Add(txtSearch)
        Controls.Add(Label9)
        Controls.Add(Button1)
        Controls.Add(Panel1)
        Controls.Add(Label8)
        Controls.Add(DataGridView1)
        Name = "stock_control"
        Text = "stock_control"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(pbImg, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        TableLayoutPanel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents product_image As DataGridViewImageColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lbTotal As Label
    Friend WithEvents pbImg As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnNew As Button
    Friend WithEvents btnDel As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label7 As Label
    Friend WithEvents btnBrowse As Button
    Friend WithEvents lbID As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtQuantity As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtCatagory As ComboBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lbDate As Label
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtSuplier As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
End Class
