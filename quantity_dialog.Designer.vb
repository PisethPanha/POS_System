<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class quantity_dialog
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
        TableLayoutPanel1 = New TableLayoutPanel()
        OK_Button = New Button()
        Cancel_Button = New Button()
        Label1 = New Label()
        txtQuantity = New TextBox()
        Label2 = New Label()
        dtpPicker = New DateTimePicker()
        Label5 = New Label()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Controls.Add(OK_Button, 0, 0)
        TableLayoutPanel1.Controls.Add(Cancel_Button, 1, 0)
        TableLayoutPanel1.Location = New Point(323, 316)
        TableLayoutPanel1.Margin = New Padding(4, 3, 4, 3)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Size = New Size(170, 33)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' OK_Button
        ' 
        OK_Button.Anchor = AnchorStyles.None
        OK_Button.Location = New Point(4, 3)
        OK_Button.Margin = New Padding(4, 3, 4, 3)
        OK_Button.Name = "OK_Button"
        OK_Button.Size = New Size(77, 27)
        OK_Button.TabIndex = 0
        OK_Button.Text = "OK"
        ' 
        ' Cancel_Button
        ' 
        Cancel_Button.Anchor = AnchorStyles.None
        Cancel_Button.Location = New Point(89, 3)
        Cancel_Button.Margin = New Padding(4, 3, 4, 3)
        Cancel_Button.Name = "Cancel_Button"
        Cancel_Button.Size = New Size(77, 27)
        Cancel_Button.TabIndex = 1
        Cancel_Button.Text = "Cancel"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Khmer OS Battambang", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(117, 148)
        Label1.Name = "Label1"
        Label1.Size = New Size(63, 27)
        Label1.TabIndex = 1
        Label1.Text = "បរិមាណ"
        ' 
        ' txtQuantity
        ' 
        txtQuantity.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtQuantity.Location = New Point(181, 147)
        txtQuantity.Multiline = True
        txtQuantity.Name = "txtQuantity"
        txtQuantity.Size = New Size(197, 25)
        txtQuantity.TabIndex = 2
        txtQuantity.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label2
        ' 
        Label2.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(192))
        Label2.Dock = DockStyle.Top
        Label2.Font = New Font("Khmer OS Battambang", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ButtonHighlight
        Label2.Location = New Point(0, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(507, 57)
        Label2.TabIndex = 3
        Label2.Text = "សូមបញ្ជូលបរិមាណផលិតផល"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' dtpPicker
        ' 
        dtpPicker.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        dtpPicker.Location = New Point(181, 189)
        dtpPicker.Margin = New Padding(5, 5, 3, 3)
        dtpPicker.Name = "dtpPicker"
        dtpPicker.Size = New Size(197, 23)
        dtpPicker.TabIndex = 11
        ' 
        ' Label5
        ' 
        Label5.Font = New Font("Khmer OS Battambang", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(60, 187)
        Label5.Name = "Label5"
        Label5.Size = New Size(122, 34)
        Label5.TabIndex = 12
        Label5.Text = "កាលបរិច្ឆេទបញ្ចូល"
        ' 
        ' quantity_dialog
        ' 
        AcceptButton = OK_Button
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        CancelButton = Cancel_Button
        ClientSize = New Size(507, 363)
        Controls.Add(dtpPicker)
        Controls.Add(Label5)
        Controls.Add(Label2)
        Controls.Add(txtQuantity)
        Controls.Add(Label1)
        Controls.Add(TableLayoutPanel1)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Margin = New Padding(4, 3, 4, 3)
        MaximizeBox = False
        MinimizeBox = False
        Name = "quantity_dialog"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "Input Quantity"
        TableLayoutPanel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpPicker As DateTimePicker
    Friend WithEvents Label5 As Label

End Class
