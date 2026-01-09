Imports System.Drawing.Printing
Imports System.Windows.Forms

Public Class PreViewSuplier
    Dim WithEvents PD As New Printing.PrintDocument
    Private bmp As Bitmap
    Private bmpPb As Bitmap

    Private Sub CapturePanel()
        bmp = New Bitmap(pnForPrint.Width, pnForPrint.Height)
        pnForPrint.DrawToBitmap(bmp, New Rectangle(0, 0, pnForPrint.Width, pnForPrint.Height))
    End Sub



    Private Sub PrintPanel()
        CapturePanel()

        Dim pd As New PrintDocument()
        pd.DefaultPageSettings.PaperSize = New Printing.PaperSize("A4", 900, 1169)
        pd.DefaultPageSettings.Margins = New Printing.Margins(40, 40, 40, 40)
        pd.DefaultPageSettings.Landscape = True
        AddHandler pd.PrintPage, AddressOf PrintPageHandler
        pd.Print()
    End Sub

    Private Sub PrintPageHandler(sender As Object, e As PrintPageEventArgs)

        e.Graphics.DrawImage(bmp, 0, 0)
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        PrintPanel()
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As Object, ByVal e As EventArgs)
        DialogResult = DialogResult.Cancel
        Close()
    End Sub

    Private Sub PreViewSuplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.RowTemplate.Height = 100
        DataGridView1.DataSource = suplier.dtFordl
        DataGridView1.Columns("sup_id").Visible = False
        DataGridView1.Columns("storage_id").Visible = False
        DataGridView1.Columns("ram_size_id").Visible = False
        DataGridView1.Columns("brand_ID").Visible = False
        DataGridView1.ClearSelection()
        DataGridView1.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Orange
        DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        DataGridView1.Columns("product_img").Visible = False
        DataGridView1.Columns("sup_id").Visible = False
        DataGridView1.Height = (DataGridView1.RowCount * 100) + 100
        DataGridView1.RowHeadersVisible = False
        DataGridView1.AllowUserToAddRows = False
        pnForPrint.Width = DataGridView1.Width
        Dim w As Decimal = 0
        For col As Integer = 0 To DataGridView1.ColumnCount - 6

            w += DataGridView1.Columns(col).Width

        Next
        DataGridView1.Width = w + 2
        lbSupName.Text = suplier.supName
        lbSupName.Width = DataGridView1.Width
        Me.Width = DataGridView1.Width + 50

        For Each row As DataGridViewRow In DataGridView1.Rows
            row.Cells("product_image").Value = row.Cells("product_img").Value
        Next

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs)

    End Sub
End Class
