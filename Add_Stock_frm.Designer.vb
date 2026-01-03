<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_Stock_frm
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
        Label9 = New Label()
        Button1 = New Button()
        lbID = New Label()
        Label10 = New Label()
        txtSearch = New TextBox()
        Panel1 = New Panel()
        lbQuantity = New Label()
        Label11 = New Label()
        lbDate = New Label()
        txtQuantity = New TextBox()
        lbCatagory = New Label()
        lbPrice = New Label()
        lbName = New Label()
        btnAdd = New Button()
        pbImg = New PictureBox()
        lbTotal = New Label()
        Label6 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Label5 = New Label()
        Label8 = New Label()
        product_image = New DataGridViewImageColumn()
        DataGridView1 = New DataGridView()
        Panel1.SuspendLayout()
        CType(pbImg, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(112, 8)
        Label9.Name = "Label9"
        Label9.Size = New Size(68, 25)
        Label9.TabIndex = 30
        Label9.Text = "search"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Button1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.ButtonHighlight
        Button1.Location = New Point(691, 8)
        Button1.Name = "Button1"
        Button1.Size = New Size(78, 34)
        Button1.TabIndex = 29
        Button1.Text = "Home"
        Button1.UseVisualStyleBackColor = False
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
        ' txtSearch
        ' 
        txtSearch.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtSearch.Location = New Point(186, 6)
        txtSearch.Multiline = True
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(316, 29)
        txtSearch.TabIndex = 31
        txtSearch.TextAlign = HorizontalAlignment.Center
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(255))
        Panel1.Controls.Add(lbQuantity)
        Panel1.Controls.Add(Label11)
        Panel1.Controls.Add(lbDate)
        Panel1.Controls.Add(txtQuantity)
        Panel1.Controls.Add(lbCatagory)
        Panel1.Controls.Add(lbPrice)
        Panel1.Controls.Add(lbName)
        Panel1.Controls.Add(btnAdd)
        Panel1.Controls.Add(lbID)
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(pbImg)
        Panel1.Controls.Add(lbTotal)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Label5)
        Panel1.Location = New Point(666, 51)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(731, 570)
        Panel1.TabIndex = 28
        ' 
        ' lbQuantity
        ' 
        lbQuantity.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        lbQuantity.BorderStyle = BorderStyle.Fixed3D
        lbQuantity.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbQuantity.Location = New Point(183, 182)
        lbQuantity.Name = "lbQuantity"
        lbQuantity.Size = New Size(302, 42)
        lbQuantity.TabIndex = 30
        lbQuantity.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Khmer OS Battambang", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(32, 182)
        Label11.Name = "Label11"
        Label11.Size = New Size(148, 34)
        Label11.TabIndex = 29
        Label11.Text = "បរិមាណបច្ចុប្បន្ន"
        ' 
        ' lbDate
        ' 
        lbDate.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        lbDate.BorderStyle = BorderStyle.Fixed3D
        lbDate.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbDate.Location = New Point(182, 344)
        lbDate.Name = "lbDate"
        lbDate.Size = New Size(302, 42)
        lbDate.TabIndex = 28
        lbDate.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' txtQuantity
        ' 
        txtQuantity.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        txtQuantity.Location = New Point(184, 235)
        txtQuantity.Multiline = True
        txtQuantity.Name = "txtQuantity"
        txtQuantity.Size = New Size(300, 41)
        txtQuantity.TabIndex = 27
        txtQuantity.TextAlign = HorizontalAlignment.Center
        ' 
        ' lbCatagory
        ' 
        lbCatagory.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        lbCatagory.BorderStyle = BorderStyle.Fixed3D
        lbCatagory.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbCatagory.Location = New Point(183, 129)
        lbCatagory.Name = "lbCatagory"
        lbCatagory.Size = New Size(302, 42)
        lbCatagory.TabIndex = 26
        lbCatagory.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lbPrice
        ' 
        lbPrice.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        lbPrice.BorderStyle = BorderStyle.Fixed3D
        lbPrice.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbPrice.Location = New Point(183, 290)
        lbPrice.Name = "lbPrice"
        lbPrice.Size = New Size(302, 42)
        lbPrice.TabIndex = 25
        lbPrice.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lbName
        ' 
        lbName.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        lbName.BorderStyle = BorderStyle.Fixed3D
        lbName.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbName.Location = New Point(183, 66)
        lbName.Name = "lbName"
        lbName.Size = New Size(302, 42)
        lbName.TabIndex = 24
        lbName.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        btnAdd.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAdd.ForeColor = SystemColors.ButtonHighlight
        btnAdd.Location = New Point(245, 454)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(158, 37)
        btnAdd.TabIndex = 23
        btnAdd.Text = "Add Stock"
        btnAdd.UseVisualStyleBackColor = False
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
        ' lbTotal
        ' 
        lbTotal.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        lbTotal.BorderStyle = BorderStyle.Fixed3D
        lbTotal.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbTotal.Location = New Point(182, 398)
        lbTotal.Name = "lbTotal"
        lbTotal.Size = New Size(302, 42)
        lbTotal.TabIndex = 12
        lbTotal.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Khmer OS Battambang", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(86, 405)
        Label6.Name = "Label6"
        Label6.Size = New Size(93, 34)
        Label6.TabIndex = 11
        Label6.Text = "តម្លៃសរុប"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Khmer OS Battambang", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(122, 296)
        Label4.Name = "Label4"
        Label4.Size = New Size(51, 34)
        Label4.TabIndex = 7
        Label4.Text = "តម្លៃ"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Khmer OS Battambang", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(44, 242)
        Label3.Name = "Label3"
        Label3.Size = New Size(134, 34)
        Label3.TabIndex = 5
        Label3.Text = "បរិមាណបន្ថែម"
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
        ' Label5
        ' 
        Label5.Font = New Font("Khmer OS Battambang", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(11, 350)
        Label5.Name = "Label5"
        Label5.Size = New Size(169, 34)
        Label5.TabIndex = 9
        Label5.Text = "កាលបរិច្ឆេទបញ្ចូល"
        ' 
        ' Label8
        ' 
        Label8.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(192))
        Label8.Font = New Font("Khmer OS Battambang", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = SystemColors.ButtonHighlight
        Label8.Location = New Point(666, -1)
        Label8.Name = "Label8"
        Label8.Size = New Size(731, 56)
        Label8.TabIndex = 27
        Label8.Text = "ព័ត៌មានផលិតផល"
        Label8.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' product_image
        ' 
        product_image.HeaderText = "product image"
        product_image.ImageLayout = DataGridViewImageCellLayout.Stretch
        product_image.Name = "product_image"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = SystemColors.ButtonFace
        DataGridView1.BorderStyle = BorderStyle.None
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {product_image})
        DataGridView1.Location = New Point(1, 67)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(640, 554)
        DataGridView1.TabIndex = 26
        ' 
        ' Add_Stock_frm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1399, 621)
        Controls.Add(Label9)
        Controls.Add(Button1)
        Controls.Add(txtSearch)
        Controls.Add(Panel1)
        Controls.Add(Label8)
        Controls.Add(DataGridView1)
        Name = "Add_Stock_frm"
        Text = "Add_Stock_frm"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(pbImg, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label9 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents lbID As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pbImg As PictureBox
    Friend WithEvents lbTotal As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents product_image As DataGridViewImageColumn
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnAdd As Button
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents lbCatagory As Label
    Friend WithEvents lbPrice As Label
    Friend WithEvents lbName As Label
    Friend WithEvents lbDate As Label
    Friend WithEvents lbQuantity As Label
    Friend WithEvents Label11 As Label
End Class
