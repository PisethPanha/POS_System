<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Product_Control
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
        Label1 = New Label()
        txtName = New TextBox()
        txtQuantity = New TextBox()
        Label2 = New Label()
        txtPrice = New TextBox()
        Label3 = New Label()
        dtpCreate = New DateTimePicker()
        Label4 = New Label()
        Button1 = New Button()
        PictureBox1 = New PictureBox()
        Button2 = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(24, 44)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(658, 365)
        DataGridView1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(713, 49)
        Label1.Name = "Label1"
        Label1.Size = New Size(37, 15)
        Label1.TabIndex = 1
        Label1.Text = "name"
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(785, 49)
        txtName.Name = "txtName"
        txtName.Size = New Size(231, 23)
        txtName.TabIndex = 2
        ' 
        ' txtQuantity
        ' 
        txtQuantity.Location = New Point(785, 116)
        txtQuantity.Name = "txtQuantity"
        txtQuantity.Size = New Size(231, 23)
        txtQuantity.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(713, 116)
        Label2.Name = "Label2"
        Label2.Size = New Size(51, 15)
        Label2.TabIndex = 3
        Label2.Text = "quantity"
        ' 
        ' txtPrice
        ' 
        txtPrice.Location = New Point(785, 178)
        txtPrice.Name = "txtPrice"
        txtPrice.Size = New Size(231, 23)
        txtPrice.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(713, 178)
        Label3.Name = "Label3"
        Label3.Size = New Size(33, 15)
        Label3.TabIndex = 5
        Label3.Text = "price"
        ' 
        ' dtpCreate
        ' 
        dtpCreate.Location = New Point(785, 247)
        dtpCreate.Name = "dtpCreate"
        dtpCreate.Size = New Size(200, 23)
        dtpCreate.TabIndex = 7
        dtpCreate.Value = New Date(2025, 12, 28, 0, 0, 0, 0)
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(731, 253)
        Label4.Name = "Label4"
        Label4.Size = New Size(30, 15)
        Label4.TabIndex = 8
        Label4.Text = "date"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(831, 402)
        Button1.Name = "Button1"
        Button1.Size = New Size(91, 36)
        Button1.TabIndex = 9
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(809, 289)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(153, 101)
        PictureBox1.TabIndex = 10
        PictureBox1.TabStop = False
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(984, 402)
        Button2.Name = "Button2"
        Button2.Size = New Size(91, 36)
        Button2.TabIndex = 11
        Button2.Text = "save"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Product_Control
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1148, 450)
        Controls.Add(Button2)
        Controls.Add(PictureBox1)
        Controls.Add(Button1)
        Controls.Add(Label4)
        Controls.Add(dtpCreate)
        Controls.Add(txtPrice)
        Controls.Add(Label3)
        Controls.Add(txtQuantity)
        Controls.Add(Label2)
        Controls.Add(txtName)
        Controls.Add(Label1)
        Controls.Add(DataGridView1)
        Name = "Product_Control"
        Text = "Product_Control"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpCreate As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button2 As Button
End Class
