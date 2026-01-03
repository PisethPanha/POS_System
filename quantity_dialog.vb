Imports System.Windows.Forms

Public Class quantity_dialog

    Public Class DiaLogVal
        Public quantity As Integer
        Public create_date As Date
        Public Sub New(quantity As Integer, create_date As Date)
            Me.create_date = create_date
            Me.quantity = quantity
        End Sub
    End Class

    Public dlval As New List(Of DiaLogVal)

    Public Function InputQuantity()
        Return dlval
    End Function




    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        dlval.Add(New DiaLogVal(txtQuantity.Text, dtpPicker.Value))
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Hide()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub quantity_dialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpPicker.Format = DateTimePickerFormat.Custom
        dtpPicker.CustomFormat = "MM/dd/yyyy"
    End Sub

    Private Sub txtQuantity_TextChanged(sender As Object, e As EventArgs) Handles txtQuantity.TextChanged

    End Sub
End Class
