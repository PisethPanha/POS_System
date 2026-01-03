<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class LoginForm
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
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents txtPass As System.Windows.Forms.TextBox
    Friend WithEvents OK As System.Windows.Forms.Button
    Friend WithEvents Cancel As System.Windows.Forms.Button

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        UsernameLabel = New Label()
        txtUsername = New TextBox()
        txtPass = New TextBox()
        OK = New Button()
        Cancel = New Button()
        LogoPictureBox = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        CType(LogoPictureBox, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' UsernameLabel
        ' 
        UsernameLabel.Font = New Font("Khmer OS Battambang", 14.25F, FontStyle.Bold)
        UsernameLabel.Location = New Point(400, 264)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New Size(250, 47)
        UsernameLabel.TabIndex = 0
        UsernameLabel.Text = "ឈ្មោះអ្នកប្រើប្រាស់"
        UsernameLabel.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtUsername
        ' 
        txtUsername.Font = New Font("Khmer OS Muol", 18F, FontStyle.Bold)
        txtUsername.Location = New Point(402, 304)
        txtUsername.Margin = New Padding(3, 4, 3, 4)
        txtUsername.Multiline = True
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(287, 57)
        txtUsername.TabIndex = 1
        txtUsername.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtPass
        ' 
        txtPass.Font = New Font("Khmer OS Muol", 18F, FontStyle.Bold)
        txtPass.Location = New Point(402, 401)
        txtPass.Margin = New Padding(3, 4, 3, 4)
        txtPass.Multiline = True
        txtPass.Name = "txtPass"
        txtPass.PasswordChar = "*"c
        txtPass.Size = New Size(287, 53)
        txtPass.TabIndex = 3
        txtPass.TextAlign = HorizontalAlignment.Center
        ' 
        ' OK
        ' 
        OK.Location = New Point(425, 475)
        OK.Margin = New Padding(3, 4, 3, 4)
        OK.Name = "OK"
        OK.Size = New Size(94, 34)
        OK.TabIndex = 4
        OK.Text = "ចូល"
        ' 
        ' Cancel
        ' 
        Cancel.DialogResult = DialogResult.Cancel
        Cancel.Location = New Point(528, 475)
        Cancel.Margin = New Padding(3, 4, 3, 4)
        Cancel.Name = "Cancel"
        Cancel.Size = New Size(94, 34)
        Cancel.TabIndex = 5
        Cancel.Text = "ចេញ"
        ' 
        ' LogoPictureBox
        ' 
        LogoPictureBox.Image = CType(resources.GetObject("LogoPictureBox.Image"), Image)
        LogoPictureBox.Location = New Point(-20, -29)
        LogoPictureBox.Margin = New Padding(3, 4, 3, 4)
        LogoPictureBox.Name = "LogoPictureBox"
        LogoPictureBox.Size = New Size(368, 736)
        LogoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage
        LogoPictureBox.TabIndex = 0
        LogoPictureBox.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Khmer OS Battambang", 14.25F, FontStyle.Bold)
        Label1.Location = New Point(400, 365)
        Label1.Name = "Label1"
        Label1.Size = New Size(250, 32)
        Label1.TabIndex = 6
        Label1.Text = "លេខសម្ងាត់"
        Label1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label2
        ' 
        Label2.BackColor = Color.Purple
        Label2.Font = New Font("Khmer OS Battambang", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ButtonFace
        Label2.Location = New Point(390, 82)
        Label2.Name = "Label2"
        Label2.Size = New Size(313, 77)
        Label2.TabIndex = 7
        Label2.Text = "PANHA TECH"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LoginForm
        ' 
        AcceptButton = OK
        AutoScaleDimensions = New SizeF(7F, 22F)
        AutoScaleMode = AutoScaleMode.Font
        CancelButton = Cancel
        ClientSize = New Size(750, 713)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Cancel)
        Controls.Add(OK)
        Controls.Add(txtPass)
        Controls.Add(txtUsername)
        Controls.Add(UsernameLabel)
        Controls.Add(LogoPictureBox)
        Font = New Font("Khmer OS Muol Light", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.FixedDialog
        Margin = New Padding(3, 4, 3, 4)
        MaximizeBox = False
        MinimizeBox = False
        Name = "LoginForm"
        SizeGripStyle = SizeGripStyle.Hide
        StartPosition = FormStartPosition.CenterScreen
        Text = "LoginForm1"
        CType(LogoPictureBox, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents LogoPictureBox As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label

End Class
