Imports System.Data.OleDb
Imports System.IO

Public Class Product_Control
    Private conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ICT\source\repos\POS_System\admin.accdb;")
    Private Function ImageToByteArray(img As Image) As Byte()
        Using ms As New MemoryStream()
            Using bmp As New Bitmap(img)
                bmp.Save(ms, Imaging.ImageFormat.Jpeg)
            End Using
            Return ms.ToArray()
        End Using
    End Function

    Private Function ByteArrayToImage(bytes As Byte()) As Image
        Using ms As New MemoryStream(bytes)
            Return Image.FromStream(ms)
        End Using
    End Function
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
    Dim selectedFile As String = "" ' store the file path
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Using ofd As New OpenFileDialog
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
            If ofd.ShowDialog = DialogResult.OK Then
                selectedFile = ofd.FileName
                PictureBox1.Image = Image.FromFile(selectedFile)
            End If
        End Using
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim cmd As New OleDbCommand("INSERT INTO product (product_name, quantity, price, create_date, product_img) VALUES (?,?,?,?,?)", conn)
            cmd.Parameters.AddWithValue("?", txtName.Text)
            cmd.Parameters.AddWithValue("?", txtQuantity.Text)
            cmd.Parameters.AddWithValue("?", txtPrice.Text)
            cmd.Parameters.AddWithValue("?", dtpCreate.Value)
            cmd.Parameters.AddWithValue("?", ImageToByteArray(PictureBox1.Image))
            conn.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("Inserted!")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class