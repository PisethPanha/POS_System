<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sell_point
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
        components = New ComponentModel.Container()
        DataGridView1 = New DataGridView()
        img = New DataGridViewImageColumn()
        bsProduct = New BindingSource(components)
        Label1 = New Label()
        TableLayoutPanel1 = New TableLayoutPanel()
        PrintDialog1 = New PrintDialog()
        Label4 = New Label()
        Panel3 = New Panel()
        Label6 = New Label()
        lbDateInvoice = New Label()
        Label9 = New Label()
        lbTotal = New Label()
        lbTotalQuantity = New Label()
        lbFee = New Label()
        TableLayoutPanel2 = New TableLayoutPanel()
        Panel1 = New Panel()
        lbBrand = New Label()
        lbStorage = New Label()
        lbRam = New Label()
        txtQuantity = New TextBox()
        lbID = New Label()
        btnAddCart = New Button()
        lbPrice = New Label()
        lbName = New Label()
        PictureBox1 = New PictureBox()
        Panel5 = New Panel()
        btnAccept = New Button()
        Panel6 = New Panel()
        btnReset = New Button()
        btnBack = New Button()
        Label8 = New Label()
        TextBox1 = New TextBox()
        Panel4 = New Panel()
        Label2 = New Label()
        Label10 = New Label()
        txtDisPercence = New TextBox()
        Panel2 = New Panel()
        lbKHR = New Label()
        Label7 = New Label()
        txtExchangeRate = New TextBox()
        Label5 = New Label()
        lbUSD = New Label()
        Label3 = New Label()
        cbDisType = New ComboBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(bsProduct, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel5.SuspendLayout()
        Panel6.SuspendLayout()
        Panel4.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = SystemColors.Control
        DataGridView1.BorderStyle = BorderStyle.None
        DataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {img})
        DataGridView1.Location = New Point(0, 58)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(695, 858)
        DataGridView1.TabIndex = 0
        ' 
        ' img
        ' 
        img.HeaderText = "img"
        img.ImageLayout = DataGridViewImageCellLayout.Stretch
        img.Name = "img"
        img.Resizable = DataGridViewTriState.True
        img.SortMode = DataGridViewColumnSortMode.Automatic
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(192))
        Label1.Font = New Font("Khmer OS Battambang", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.Control
        Label1.Location = New Point(0, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(2028, 51)
        Label1.TabIndex = 1
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.AutoScroll = True
        TableLayoutPanel1.ColumnCount = 1
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.Location = New Point(11, 580)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle())
        TableLayoutPanel1.Size = New Size(724, 421)
        TableLayoutPanel1.TabIndex = 3
        ' 
        ' PrintDialog1
        ' 
        PrintDialog1.UseEXDialog = True
        ' 
        ' Label4
        ' 
        Label4.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Label4.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.ButtonHighlight
        Label4.Location = New Point(1471, 55)
        Label4.Name = "Label4"
        Label4.Size = New Size(432, 48)
        Label4.TabIndex = 11
        Label4.Text = "Invoice"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = SystemColors.ControlLightLight
        Panel3.BorderStyle = BorderStyle.FixedSingle
        Panel3.Controls.Add(Label6)
        Panel3.Controls.Add(lbDateInvoice)
        Panel3.Controls.Add(Label9)
        Panel3.Controls.Add(lbTotal)
        Panel3.Controls.Add(lbTotalQuantity)
        Panel3.Controls.Add(lbFee)
        Panel3.Controls.Add(TableLayoutPanel2)
        Panel3.Location = New Point(0, 46)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(431, 549)
        Panel3.TabIndex = 12
        ' 
        ' Label6
        ' 
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = SystemColors.ActiveCaptionText
        Label6.Location = New Point(3, 105)
        Label6.Name = "Label6"
        Label6.Size = New Size(424, 48)
        Label6.TabIndex = 18
        Label6.Text = "Invoice"
        Label6.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lbDateInvoice
        ' 
        lbDateInvoice.BackColor = Color.Transparent
        lbDateInvoice.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbDateInvoice.Location = New Point(238, 13)
        lbDateInvoice.Name = "lbDateInvoice"
        lbDateInvoice.Size = New Size(187, 41)
        lbDateInvoice.TabIndex = 19
        lbDateInvoice.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label9
        ' 
        Label9.Location = New Point(3, 13)
        Label9.Name = "Label9"
        Label9.Size = New Size(198, 92)
        Label9.TabIndex = 18
        Label9.Text = "Shop Name: Panha Tech" & vbCrLf & "Address: lorry, rokakhnong, donkeo, takeo, combodia" & vbCrLf & "email: panha-tech-168@gmail.com" & vbCrLf & "tel: 0967599904"
        ' 
        ' lbTotal
        ' 
        lbTotal.BackColor = SystemColors.ActiveCaption
        lbTotal.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbTotal.Location = New Point(-1, 507)
        lbTotal.Name = "lbTotal"
        lbTotal.Size = New Size(430, 41)
        lbTotal.TabIndex = 0
        lbTotal.Text = "Total Amount: 0"
        lbTotal.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lbTotalQuantity
        ' 
        lbTotalQuantity.BackColor = SystemColors.ActiveCaption
        lbTotalQuantity.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbTotalQuantity.Location = New Point(-2, 425)
        lbTotalQuantity.Name = "lbTotalQuantity"
        lbTotalQuantity.Size = New Size(432, 41)
        lbTotalQuantity.TabIndex = 4
        lbTotalQuantity.Text = "Total quantity:"
        lbTotalQuantity.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lbFee
        ' 
        lbFee.BackColor = SystemColors.ActiveCaption
        lbFee.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbFee.Location = New Point(-2, 466)
        lbFee.Name = "lbFee"
        lbFee.Size = New Size(433, 41)
        lbFee.TabIndex = 3
        lbFee.Text = "Fee: 0"
        lbFee.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.AutoSize = True
        TableLayoutPanel2.ColumnCount = 1
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel2.Location = New Point(2, 163)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 2
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 42F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 8F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel2.Size = New Size(423, 50)
        TableLayoutPanel2.TabIndex = 1
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(192))
        Panel1.Controls.Add(lbBrand)
        Panel1.Controls.Add(lbStorage)
        Panel1.Controls.Add(lbRam)
        Panel1.Controls.Add(txtQuantity)
        Panel1.Controls.Add(lbID)
        Panel1.Controls.Add(btnAddCart)
        Panel1.Controls.Add(lbPrice)
        Panel1.Controls.Add(lbName)
        Panel1.Controls.Add(PictureBox1)
        Panel1.ForeColor = SystemColors.Control
        Panel1.Location = New Point(76, 56)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(200, 499)
        Panel1.TabIndex = 2
        ' 
        ' lbBrand
        ' 
        lbBrand.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        lbBrand.Location = New Point(0, 286)
        lbBrand.Name = "lbBrand"
        lbBrand.Size = New Size(200, 30)
        lbBrand.TabIndex = 8
        lbBrand.Text = "Brand:  "
        lbBrand.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lbStorage
        ' 
        lbStorage.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        lbStorage.Location = New Point(1, 348)
        lbStorage.Name = "lbStorage"
        lbStorage.Size = New Size(200, 30)
        lbStorage.TabIndex = 7
        lbStorage.Text = "Storage: "
        lbStorage.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lbRam
        ' 
        lbRam.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        lbRam.Location = New Point(1, 318)
        lbRam.Name = "lbRam"
        lbRam.Size = New Size(200, 30)
        lbRam.TabIndex = 6
        lbRam.Text = "RAM:  "
        lbRam.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtQuantity
        ' 
        txtQuantity.BackColor = SystemColors.ControlLightLight
        txtQuantity.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtQuantity.Location = New Point(64, 415)
        txtQuantity.Name = "txtQuantity"
        txtQuantity.Size = New Size(63, 23)
        txtQuantity.TabIndex = 5
        txtQuantity.TextAlign = HorizontalAlignment.Center
        ' 
        ' lbID
        ' 
        lbID.AutoSize = True
        lbID.Location = New Point(86, 62)
        lbID.Name = "lbID"
        lbID.Size = New Size(0, 15)
        lbID.TabIndex = 4
        ' 
        ' btnAddCart
        ' 
        btnAddCart.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        btnAddCart.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAddCart.Location = New Point(40, 453)
        btnAddCart.Name = "btnAddCart"
        btnAddCart.Size = New Size(113, 34)
        btnAddCart.TabIndex = 3
        btnAddCart.Text = "Add To Cart"
        btnAddCart.UseVisualStyleBackColor = False
        ' 
        ' lbPrice
        ' 
        lbPrice.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbPrice.Location = New Point(1, 378)
        lbPrice.Name = "lbPrice"
        lbPrice.Size = New Size(200, 25)
        lbPrice.TabIndex = 2
        lbPrice.Text = "0"
        lbPrice.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lbName
        ' 
        lbName.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbName.Location = New Point(0, 215)
        lbName.Name = "lbName"
        lbName.Size = New Size(200, 30)
        lbName.TabIndex = 1
        lbName.Text = "Product Name"
        lbName.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resource1.tmpIMG
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(200, 200)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(255))
        Panel5.BorderStyle = BorderStyle.FixedSingle
        Panel5.Controls.Add(TableLayoutPanel1)
        Panel5.Controls.Add(btnAccept)
        Panel5.Controls.Add(Panel6)
        Panel5.Controls.Add(Panel1)
        Panel5.Dock = DockStyle.Right
        Panel5.Location = New Point(700, 0)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(1224, 1061)
        Panel5.TabIndex = 14
        ' 
        ' btnAccept
        ' 
        btnAccept.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(192))
        btnAccept.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAccept.ForeColor = SystemColors.ButtonHighlight
        btnAccept.Location = New Point(768, 670)
        btnAccept.Name = "btnAccept"
        btnAccept.Size = New Size(431, 45)
        btnAccept.TabIndex = 1
        btnAccept.Text = "Accept Payment"
        btnAccept.UseVisualStyleBackColor = False
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = SystemColors.ButtonFace
        Panel6.Controls.Add(Panel3)
        Panel6.Location = New Point(771, 55)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(431, 594)
        Panel6.TabIndex = 0
        ' 
        ' btnReset
        ' 
        btnReset.Location = New Point(1756, 12)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(88, 29)
        btnReset.TabIndex = 0
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = True
        ' 
        ' btnBack
        ' 
        btnBack.Location = New Point(254, 6)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(88, 29)
        btnBack.TabIndex = 15
        btnBack.Text = "Home"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(73, 14)
        Label8.Name = "Label8"
        Label8.Size = New Size(68, 25)
        Label8.TabIndex = 16
        Label8.Text = "search"
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(147, 12)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(316, 29)
        TextBox1.TabIndex = 17
        TextBox1.TextAlign = HorizontalAlignment.Center
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(192))
        Panel4.Controls.Add(btnBack)
        Panel4.Location = New Point(700, 4)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(558, 41)
        Panel4.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Label2.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ButtonHighlight
        Label2.Location = New Point(0, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(426, 45)
        Label2.TabIndex = 4
        Label2.Text = "Total Amout"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(61, 111)
        Label10.Name = "Label10"
        Label10.Size = New Size(83, 25)
        Label10.TabIndex = 11
        Label10.Text = "Dicount"
        ' 
        ' txtDisPercence
        ' 
        txtDisPercence.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtDisPercence.Location = New Point(150, 111)
        txtDisPercence.Multiline = True
        txtDisPercence.Name = "txtDisPercence"
        txtDisPercence.Size = New Size(135, 25)
        txtDisPercence.TabIndex = 12
        txtDisPercence.TextAlign = HorizontalAlignment.Center
        ' 
        ' Panel2
        ' 
        Panel2.BorderStyle = BorderStyle.Fixed3D
        Panel2.Controls.Add(lbKHR)
        Panel2.Controls.Add(Label7)
        Panel2.Controls.Add(txtExchangeRate)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(lbUSD)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(cbDisType)
        Panel2.Controls.Add(txtDisPercence)
        Panel2.Controls.Add(Label10)
        Panel2.Controls.Add(Label2)
        Panel2.Location = New Point(1008, 56)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(428, 500)
        Panel2.TabIndex = 5
        ' 
        ' lbKHR
        ' 
        lbKHR.BorderStyle = BorderStyle.Fixed3D
        lbKHR.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbKHR.Location = New Point(0, 417)
        lbKHR.Name = "lbKHR"
        lbKHR.Size = New Size(426, 47)
        lbKHR.TabIndex = 19
        lbKHR.Text = "0"
        lbKHR.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label7
        ' 
        Label7.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(0, 364)
        Label7.Name = "Label7"
        Label7.Size = New Size(426, 40)
        Label7.TabIndex = 18
        Label7.Text = "KHR"
        Label7.TextAlign = ContentAlignment.TopCenter
        ' 
        ' txtExchangeRate
        ' 
        txtExchangeRate.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtExchangeRate.Location = New Point(150, 321)
        txtExchangeRate.Multiline = True
        txtExchangeRate.Name = "txtExchangeRate"
        txtExchangeRate.Size = New Size(190, 31)
        txtExchangeRate.TabIndex = 17
        txtExchangeRate.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(3, 321)
        Label5.Name = "Label5"
        Label5.Size = New Size(141, 25)
        Label5.TabIndex = 16
        Label5.Text = "Exchange Rate"
        ' 
        ' lbUSD
        ' 
        lbUSD.BorderStyle = BorderStyle.Fixed3D
        lbUSD.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbUSD.Location = New Point(0, 257)
        lbUSD.Name = "lbUSD"
        lbUSD.Size = New Size(426, 47)
        lbUSD.TabIndex = 15
        lbUSD.Text = "0"
        lbUSD.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(0, 204)
        Label3.Name = "Label3"
        Label3.Size = New Size(426, 40)
        Label3.TabIndex = 14
        Label3.Text = "USD"
        Label3.TextAlign = ContentAlignment.TopCenter
        ' 
        ' cbDisType
        ' 
        cbDisType.DropDownStyle = ComboBoxStyle.DropDownList
        cbDisType.FormattingEnabled = True
        cbDisType.Items.AddRange(New Object() {"%", "$", "៛"})
        cbDisType.Location = New Point(291, 111)
        cbDisType.Name = "cbDisType"
        cbDisType.Size = New Size(40, 23)
        cbDisType.TabIndex = 13
        ' 
        ' sell_point
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        ClientSize = New Size(1924, 1061)
        Controls.Add(Panel4)
        Controls.Add(TextBox1)
        Controls.Add(Label8)
        Controls.Add(Label4)
        Controls.Add(btnReset)
        Controls.Add(Label1)
        Controls.Add(Panel2)
        Controls.Add(DataGridView1)
        Controls.Add(Panel5)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        MinimizeBox = False
        Name = "sell_point"
        StartPosition = FormStartPosition.CenterScreen
        Text = "sell_point"
        WindowState = FormWindowState.Maximized
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(bsProduct, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel5.ResumeLayout(False)
        Panel6.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents bsProduct As BindingSource
    Friend WithEvents Label1 As Label
    Friend WithEvents img As DataGridViewImageColumn
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents lbTotal As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents lbID As Label
    Friend WithEvents btnAddCart As Button
    Friend WithEvents lbPrice As Label
    Friend WithEvents lbName As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btnReset As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents btnAccept As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lbTotalQuantity As Label
    Friend WithEvents lbFee As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lbDateInvoice As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lbBrand As Label
    Friend WithEvents lbStorage As Label
    Friend WithEvents lbRam As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtDisPercence As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents cbDisType As ComboBox
    Friend WithEvents lbKHR As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtExchangeRate As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lbUSD As Label
    Friend WithEvents Label3 As Label
End Class
