Imports System.ComponentModel
Imports System.Data.OleDb
Imports System.Drawing.Printing

Public Class Print_Report_frm

    Private conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & IO.Directory.GetParent(Application.StartupPath).Parent.FullName.Substring(0, IO.Directory.GetParent(Application.StartupPath).Parent.FullName.Length - 9) & "\" & "admin.accdb;")
    Dim WithEvents PD As New Printing.PrintDocument
    Dim rowIndex As Integer = 0

    Private bmp As Bitmap

    Private Sub CapturePanel()
        bmp = New Bitmap(Panel1.Width, Panel1.Height)
        Panel1.DrawToBitmap(bmp, New Rectangle(0, 0, Panel1.Width, Panel1.Height))
    End Sub

    Private Sub PrintPanel()
        CapturePanel()

        Dim pd As New PrintDocument()
        AddHandler pd.PrintPage, AddressOf PrintPageHandler
        pd.Print()
    End Sub

    Private Sub PrintPageHandler(sender As Object, e As PrintPageEventArgs)
        e.Graphics.DrawImage(bmp, 0, 0)
    End Sub

    Private Sub Print_Report_frm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dtpDateFrom.Format = DateTimePickerFormat.Custom
        dtpDateFrom.CustomFormat = "MM/dd/yyyy"
        dtpDateTo.Format = DateTimePickerFormat.Custom
        dtpDateTo.CustomFormat = "MM/dd/yyyy"
        cbCatagory.Text = "ទាំងអស់"
        lbdate.Text = "កាលបរិច្ឆេទ: " & dtpDateFrom.Text & " - " & dtpDateTo.Text

        Dim query As String = "select * from product_query"
        Dim adapter As New OleDbDataAdapter(query, conn)
        Dim data As New DataTable()
        adapter.Fill(data)
        DataGridView1.DataSource = data
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.ClearSelection()
        DataGridView1.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Orange
        DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        DataGridView1.Columns("product_img").Visible = False
        DataGridView1.Height = DataGridView1.ColumnHeadersHeight + DataGridView1.Rows.GetRowsHeight(DataGridViewElementStates.Visible)
        DataGridView1.Columns("product_name").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Panel1.Height = DataGridView1.Height + 100

    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        PrintPanel()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles lbReportType.Click

    End Sub

    Public Sub SaleReport()
        'Dim query As String
        'If cbCatagory.Text <> "ទាំងអស់" Then
        '    query = "select * from stock_out where date_out between ? and ?​ and catagory = ?"
        'ElseIf cbCatagory.Text <> "ទាំងអស់" Then
        '    query = "select * from stock_out where date_out between ? and ?​"
        'Else
        '    MessageBox.Show("Please Select Product Catagory")
        '    Return
        'End If
        'Dim adapter As New OleDbDataAdapter(query, conn)
    End Sub
    Private date_from As Date
    Private date_to As Date
    Private Sub cbReportType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbReportType.SelectedIndexChanged


    End Sub




    Private Sub btnFetch_Click(sender As Object, e As EventArgs) Handles btnFetch.Click
        Dim query As String
        date_from = dtpDateFrom.Value
        date_to = dtpDateTo.Value
        lbdate.Text = "កាលបរិច្ឆេទ: " & dtpDateFrom.Text & " - " & dtpDateTo.Text
        lbReportType.Text = cbReportType.Text
        Dim catagory As String = ""

        If cbCatagory.Text <> "ទាំងអស់" Then
            catagory = "and catagory = '" & cbCatagory.Text & "'"
        ElseIf cbCatagory.Text = "ទាំងអស់" Then
            catagory = ""
        End If


        If cbReportType.Text = "របាយការណ៍លក់" Then
            query = "select * from stock_out 
                       where out_type = 'sale' 
                       " & catagory & "
                       and date_out between #" & date_from.ToString("MM/dd/yyyy") & "# 
                       and #" & date_to.ToString("MM/dd/yyyy") & "#"
        ElseIf cbReportType.Text = "របាយការណ៍ចូលស្តុក" Then
            query = "select * from stock_in where date_in between #" & date_from.ToString("MM/dd/yyyy") & "# and #" & date_to.ToString("MM/dd/yyyy") & "# 
                    " & catagory
        ElseIf cbReportType.Text = "របាយការណ៍ផលិតផលក្នុងស្តុក" Then
            query = "select * from product_query where create_date between #" & date_from.ToString("MM/dd/yyyy") & "# and #" & date_to.ToString("MM/dd/yyyy") & "# 
                    " & catagory
        ElseIf cbReportType.Text = "របាយការណ៍ផលិតផលថ្មី" Then
            query = "select * from new_product where create_date between #" & date_from.ToString("MM/dd/yyyy") & "# and #" & date_to.ToString("MM/dd/yyyy") & "# 
                    " & catagory
        Else
            MessageBox.Show("This Report Not Available")
            Return
        End If
        conn.Open()
        Dim adapter As New OleDbDataAdapter(query, conn)
        Dim data As New DataTable()
        adapter.Fill(data)
        DataGridView1.DataSource = data
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.ClearSelection()
        DataGridView1.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Orange
        DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        DataGridView1.Height = DataGridView1.ColumnHeadersHeight + DataGridView1.Rows.GetRowsHeight(DataGridViewElementStates.Visible)
        DataGridView1.Columns("product_name").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        Try
            DataGridView1.Columns("product_img").Visible = False
        Catch ex As Exception

        End Try

        conn.Close()
    End Sub

    Private Sub Print_Report_frm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Application.Exit()
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Dashboard_frm.Show()
        Me.Hide()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class