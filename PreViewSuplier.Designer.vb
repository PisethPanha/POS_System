<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PreViewSuplier
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        OK_Button = New Button()
        Panel2 = New Panel()
        Label2 = New Label()
        pnForPrint = New Panel()
        lbSupName = New Label()
        Panel1 = New Panel()
        DataGridView1 = New DataGridView()
        product_image = New DataGridViewImageColumn()
        Panel2.SuspendLayout()
        pnForPrint.SuspendLayout()
        Panel1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' OK_Button
        ' 
        OK_Button.Anchor = AnchorStyles.None
        OK_Button.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        OK_Button.Location = New Point(1054, 22)
        OK_Button.Margin = New Padding(4, 3, 4, 3)
        OK_Button.Name = "OK_Button"
        OK_Button.Size = New Size(88, 30)
        OK_Button.TabIndex = 0
        OK_Button.Text = "Print"
        OK_Button.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Purple
        Panel2.Controls.Add(OK_Button)
        Panel2.Controls.Add(Label2)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1339, 72)
        Panel2.TabIndex = 39
        ' 
        ' Label2
        ' 
        Label2.Dock = DockStyle.Fill
        Label2.Font = New Font("Khmer OS Battambang", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ButtonHighlight
        Label2.Location = New Point(0, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(1339, 72)
        Label2.TabIndex = 0
        Label2.Text = "បង្កើតរបាយការណ៍ផលិតផលអ្នកផ្គត់ផ្គង់"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' pnForPrint
        ' 
        pnForPrint.BackColor = Color.White
        pnForPrint.Controls.Add(lbSupName)
        pnForPrint.Controls.Add(Panel1)
        pnForPrint.Dock = DockStyle.Bottom
        pnForPrint.Location = New Point(0, 102)
        pnForPrint.Name = "pnForPrint"
        pnForPrint.Size = New Size(1339, 589)
        pnForPrint.TabIndex = 40
        ' 
        ' lbSupName
        ' 
        lbSupName.Dock = DockStyle.Top
        lbSupName.Font = New Font("Khmer OS Battambang", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbSupName.Location = New Point(0, 0)
        lbSupName.Name = "lbSupName"
        lbSupName.Size = New Size(1339, 65)
        lbSupName.TabIndex = 40
        lbSupName.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(DataGridView1)
        Panel1.Dock = DockStyle.Bottom
        Panel1.Location = New Point(0, 121)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1339, 468)
        Panel1.TabIndex = 41
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.BackgroundColor = Color.White
        DataGridView1.BorderStyle = BorderStyle.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(255), CByte(224), CByte(192))
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {product_image})
        DataGridView1.EnableHeadersVisualStyles = False
        DataGridView1.Location = New Point(12, 0)
        DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(255), CByte(224), CByte(192))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle3
        DataGridView1.ScrollBars = ScrollBars.None
        DataGridView1.Size = New Size(1304, 468)
        DataGridView1.TabIndex = 42
        ' 
        ' product_image
        ' 
        product_image.HeaderText = "Product Image"
        product_image.ImageLayout = DataGridViewImageCellLayout.Stretch
        product_image.Name = "product_image"
        product_image.Resizable = DataGridViewTriState.False
        product_image.Width = 91
        ' 
        ' PreViewSuplier
        ' 
        AcceptButton = OK_Button
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        ClientSize = New Size(1339, 691)
        Controls.Add(pnForPrint)
        Controls.Add(Panel2)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Margin = New Padding(4, 3, 4, 3)
        MaximizeBox = False
        MinimizeBox = False
        Name = "PreViewSuplier"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterParent
        Text = "PreViewSuplier"
        Panel2.ResumeLayout(False)
        pnForPrint.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)

    End Sub
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents pnForPrint As Panel
    Friend WithEvents lbSupName As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents product_image As DataGridViewImageColumn

End Class
