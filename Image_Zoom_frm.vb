Public Class Image_Zoom_frm
    Private Sub Image_Zoom_frm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Back_img As Image = CType(stock_control.GetImage.Clone, Image)
        Me.BackgroundImage = Back_img
        Me.BackgroundImageLayout = ImageLayout.Stretch

    End Sub
End Class