<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Print_Report_frm
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
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        PrintDocument1 = New Printing.PrintDocument()
        btnPrint = New Button()
        Panel1 = New Panel()
        Panel3 = New Panel()
        DataGridView1 = New DataGridView()
        lbdate = New Label()
        Label1 = New Label()
        lbReportType = New Label()
        Panel2 = New Panel()
        btnHome = New Button()
        Label2 = New Label()
        cbReportType = New ComboBox()
        Label3 = New Label()
        dtpDateFrom = New DateTimePicker()
        Label5 = New Label()
        Label6 = New Label()
        dtpDateTo = New DateTimePicker()
        btnFetch = New Button()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnPrint
        ' 
        btnPrint.BackColor = Color.FromArgb(CByte(64), CByte(0), CByte(64))
        btnPrint.ForeColor = SystemColors.ButtonHighlight
        btnPrint.Location = New Point(724, 117)
        btnPrint.Name = "btnPrint"
        btnPrint.Size = New Size(64, 32)
        btnPrint.TabIndex = 1
        btnPrint.Text = "បង្កើត"
        btnPrint.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.AutoSize = True
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(lbdate)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(lbReportType)
        Panel1.Location = New Point(0, 172)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(806, 736)
        Panel1.TabIndex = 2
        ' 
        ' Panel3
        ' 
        Panel3.AutoSize = True
        Panel3.Controls.Add(DataGridView1)
        Panel3.Location = New Point(0, 138)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(803, 304)
        Panel3.TabIndex = 7
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToResizeColumns = False
        DataGridView1.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = Color.White
        DataGridViewCellStyle1.Font = New Font("Khmer OS Battambang", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = Color.Black
        DataGridViewCellStyle1.SelectionBackColor = Color.White
        DataGridViewCellStyle1.SelectionForeColor = Color.Black
        DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DataGridView1.BackgroundColor = Color.White
        DataGridView1.BorderStyle = BorderStyle.None
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = SystemColors.Control
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Enabled = False
        DataGridView1.EnableHeadersVisualStyles = False
        DataGridView1.Location = New Point(0, 0)
        DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = SystemColors.Control
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.NullValue = Nothing
        DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle4
        DataGridView1.ScrollBars = ScrollBars.None
        DataGridView1.Size = New Size(800, 301)
        DataGridView1.TabIndex = 2
        ' 
        ' lbdate
        ' 
        lbdate.AutoSize = True
        lbdate.Font = New Font("Khmer OS Battambang", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbdate.Location = New Point(551, 9)
        lbdate.Name = "lbdate"
        lbdate.Size = New Size(82, 22)
        lbdate.TabIndex = 6
        lbdate.Text = "កាលបរិច្ឆេទ: "
        ' 
        ' Label1
        ' 
        Label1.Location = New Point(12, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(198, 92)
        Label1.TabIndex = 2
        Label1.Text = "Shop Name: Panha Tech" & vbCrLf & "Address: lorry, rokakhnong, donkeo, takeo, combodia" & vbCrLf & "email: panha-tech-168@gmail.com" & vbCrLf & "tel: 0967599904"
        ' 
        ' lbReportType
        ' 
        lbReportType.AutoSize = True
        lbReportType.Font = New Font("Khmer OS Battambang", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbReportType.Location = New Point(296, 97)
        lbReportType.Name = "lbReportType"
        lbReportType.Size = New Size(170, 38)
        lbReportType.TabIndex = 5
        lbReportType.Text = "របាយការណ៍លក់"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Purple
        Panel2.Controls.Add(btnHome)
        Panel2.Controls.Add(Label2)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(800, 72)
        Panel2.TabIndex = 3
        ' 
        ' btnHome
        ' 
        btnHome.BackColor = Color.FromArgb(CByte(64), CByte(0), CByte(64))
        btnHome.ForeColor = SystemColors.ButtonHighlight
        btnHome.Location = New Point(27, 14)
        btnHome.Name = "btnHome"
        btnHome.Size = New Size(64, 32)
        btnHome.TabIndex = 13
        btnHome.Text = "Home"
        btnHome.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Khmer OS Battambang", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ButtonHighlight
        Label2.Location = New Point(277, 14)
        Label2.Name = "Label2"
        Label2.Size = New Size(234, 49)
        Label2.TabIndex = 0
        Label2.Text = "បង្កើតរបាយការណ៍"
        ' 
        ' cbReportType
        ' 
        cbReportType.DisplayMember = "ជ្រើសរើស"
        cbReportType.DropDownStyle = ComboBoxStyle.DropDownList
        cbReportType.Font = New Font("Khmer OS Battambang", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cbReportType.FormattingEnabled = True
        cbReportType.Items.AddRange(New Object() {"របាយការណ៍លក់", "របាយការណ៍ស្តុកចូល", "របាយការណ៍ផលិតផលក្នុងស្តុក", "របាយការណ៍ផលិតផលថ្មី"})
        cbReportType.Location = New Point(158, 119)
        cbReportType.Name = "cbReportType"
        cbReportType.Size = New Size(151, 30)
        cbReportType.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Khmer OS Battambang", 11.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(158, 89)
        Label3.Name = "Label3"
        Label3.Size = New Size(139, 27)
        Label3.TabIndex = 3
        Label3.Text = "ប្រភេទរបាយការណ៍"
        ' 
        ' dtpDateFrom
        ' 
        dtpDateFrom.Location = New Point(388, 117)
        dtpDateFrom.MinimumSize = New Size(0, 30)
        dtpDateFrom.Name = "dtpDateFrom"
        dtpDateFrom.Size = New Size(78, 30)
        dtpDateFrom.TabIndex = 6
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Khmer OS Battambang", 8.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(344, 124)
        Label5.Name = "Label5"
        Label5.Size = New Size(38, 19)
        Label5.TabIndex = 7
        Label5.Text = "ចាប់ពី"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Khmer OS Battambang", 8.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(472, 124)
        Label6.Name = "Label6"
        Label6.Size = New Size(30, 19)
        Label6.TabIndex = 8
        Label6.Text = "ដល់"
        ' 
        ' dtpDateTo
        ' 
        dtpDateTo.Location = New Point(508, 118)
        dtpDateTo.MinimumSize = New Size(0, 30)
        dtpDateTo.Name = "dtpDateTo"
        dtpDateTo.Size = New Size(78, 30)
        dtpDateTo.TabIndex = 9
        ' 
        ' btnFetch
        ' 
        btnFetch.BackColor = Color.FromArgb(CByte(64), CByte(0), CByte(64))
        btnFetch.ForeColor = SystemColors.ButtonHighlight
        btnFetch.Location = New Point(630, 117)
        btnFetch.Name = "btnFetch"
        btnFetch.Size = New Size(88, 32)
        btnFetch.TabIndex = 12
        btnFetch.Text = "ទាញទិន្នន័យ"
        btnFetch.UseVisualStyleBackColor = False
        ' 
        ' Print_Report_frm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(255))
        ClientSize = New Size(800, 906)
        Controls.Add(btnFetch)
        Controls.Add(dtpDateTo)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(dtpDateFrom)
        Controls.Add(Label3)
        Controls.Add(cbReportType)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(btnPrint)
        Name = "Print_Report_frm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Print_Report_frm"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel3.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents btnPrint As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents cbReportType As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lbReportType As Label
    Friend WithEvents dtpDateFrom As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents dtpDateTo As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents lbdate As Label
    Friend WithEvents btnFetch As Button
    Friend WithEvents btnHome As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents DataGridView1 As DataGridView
End Class
