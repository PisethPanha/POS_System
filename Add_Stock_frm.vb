Imports System.ComponentModel
Imports System.Data.OleDb
Imports System.IO
Imports System.Text
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports POS_System.My.Resources




Public Class Add_Stock_frm
    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & IO.Directory.GetParent(Application.StartupPath).Parent.FullName.Substring(0, IO.Directory.GetParent(Application.StartupPath).Parent.FullName.Length - 9) & "\" & "admin.accdb;")

    Public Function loadData()
        conn.Open()
        Dim query As String = "SELECT * FROM product_query"
        Dim adapter As New OleDbDataAdapter(query, conn)
        Dim data As New DataTable()
        adapter.Fill(data)
        DataGridView1.RowTemplate.Height = 100
        DataGridView1.DataSource = data
        DataGridView1.Columns("product_img").Visible = False
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        For Each row As DataGridViewRow In DataGridView1.Rows
            row.Cells("product_image").Value = row.Cells("product_img").Value
        Next

        conn.Close()
    End Function

    Public Function reset()
        lbID.Text = ""
        lbName.Text = ""
        lbCatagory.Text = ""
        lbQuantity.Text = ""
        txtQuantity.Text = ""
        lbPrice.Text = ""
        lbDate.Text = ""
        lbTotal.Text = ""
        pbImg.Image = Resource1.tmpIMG
    End Function


    Private Sub Add_Stock_frm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.Open()
        Dim query As String = "SELECT * FROM product_query"
        Dim adapter As New OleDbDataAdapter(query, conn)
        Dim data As New DataTable()
        adapter.Fill(data)
        DataGridView1.RowTemplate.Height = 100
        DataGridView1.DataSource = data
        DataGridView1.Columns("product_img").Visible = False
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        For Each row As DataGridViewRow In DataGridView1.Rows
            row.Cells("product_image").Value = row.Cells("product_img").Value
        Next

        conn.Close()

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex >= 0 Then

            lbID.Text = DataGridView1.Rows(e.RowIndex).Cells("ID").Value
            lbName.Text = DataGridView1.Rows(e.RowIndex).Cells("product_name").Value
            lbCatagory.Text = DataGridView1.Rows(e.RowIndex).Cells("catagory").Value
            lbQuantity.Text = DataGridView1.Rows(e.RowIndex).Cells("quantity").Value
            lbPrice.Text = DataGridView1.Rows(e.RowIndex).Cells("price").Value
            lbDate.Text = CDate(DataGridView1.Rows(e.RowIndex).Cells("create_date").Value).ToString("MM/dd/yyyy")
            lbTotal.Text = DataGridView1.Rows(e.RowIndex).Cells("total").Value
            Dim imgByte As Byte() = CType(DataGridView1.Rows(e.RowIndex).Cells("product_img").Value, Byte())
            Dim ms As New MemoryStream(imgByte)
            Dim img As Image = Image.FromStream(ms)
            pbImg.Image = img
        End If



    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles lbPrice.Click

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        If lbID.Text = "" Then
            MessageBox.Show("Please Select Product To Add stock")
            Return
        End If

        Try
            Dim quantity As Integer = txtQuantity.Text
        Catch ex As Exception
            MessageBox.Show("Quantity Must Be Integer And Cannot Empty")
            txtQuantity.Text = ""
            Return
        End Try
        conn.Open()
        Dim query1 As String = "update product_query set quantity = quantity + ? where ID = ?"
        Dim query2 As String = "insert into stock_in (product_id, product_name, quantity_in, date_in, catagory) values (?,?,?,?,?)"
        Try
            Dim cmd1 As New OleDbCommand(query1, conn)
            cmd1.Parameters.AddWithValue("?", txtQuantity.Text)
            cmd1.Parameters.AddWithValue("?", lbID.Text)
            cmd1.ExecuteNonQuery()

            Dim cmd2 As New OleDbCommand(query2, conn)
            cmd2.Parameters.AddWithValue("?", lbID.Text)
            cmd2.Parameters.AddWithValue("?", lbName.Text)
            cmd2.Parameters.AddWithValue("?", txtQuantity.Text)
            cmd2.Parameters.AddWithValue("?", Date.Today.ToString("MM/dd/yyyy"))
            cmd2.Parameters.AddWithValue("?", lbCatagory.Text)
            cmd2.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            conn.Close()
        End Try

        conn.Close()
        loadData()
        reset()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dashboard_frm.Show()
        Me.Hide()
    End Sub

    Private Sub Add_Stock_frm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Application.Exit()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged

        Dim query As String

        If txtSearch.Text = "" Then
            loadData()

            Return
        End If
        Try
            Dim id As Integer = txtSearch.Text
            query = "SELECT * FROM product_query WHERE ID = " & txtSearch.Text
        Catch ex As Exception
            query = "SELECT * FROM product_query WHERE" & " product_name LIKE '%" & txtSearch.Text & "%'"
        End Try


        conn.Open()

        Try
            Dim adapter As New OleDbDataAdapter(query, conn)
            Dim data As New DataTable()
            adapter.Fill(data)

            DataGridView1.RowTemplate.Height = 100
            DataGridView1.DataSource = data
            DataGridView1.Columns("product_img").Visible = False
            DataGridView1.AllowUserToAddRows = False
            DataGridView1.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            For Each row As DataGridViewRow In DataGridView1.Rows
                row.Cells("product_image").Value = row.Cells("product_img").Value
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try



        conn.Close()
    End Sub
End Class