Imports System.Data.OleDb
Imports System.IO
Imports System.Threading.Channels
Imports POS_System.My.Resources



Public Class stock_control
    Private conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & IO.Directory.GetParent(Application.StartupPath).Parent.FullName.Substring(0, IO.Directory.GetParent(Application.StartupPath).Parent.FullName.Length - 9) & "\" & "admin.accdb;")
    Private currentChange As IsChange
    Private RowIndex As Integer = -1

    Public Function GetImage() As Image
        Dim img As Image = pbImg.Image
        Return img
    End Function

    Public Class IsChange
        Property name As String
        Property catagory As String
        Property quantity As Integer
        Property price As Decimal
        Property img As Byte()
        Public Sub New(name As String, catagory As String, quantity As Integer, price As Decimal, img As Byte())
            Me.name = name
            Me.catagory = catagory
            Me.quantity = quantity
            Me.price = price
            Me.img = img
        End Sub
    End Class

    Public Sub reset()
        txtName.Text = ""
        txtCatagory.Text = ""
        txtPrice.Text = ""
        txtQuantity.Text = ""
        lbTotal.Text = ""
        lbDate.Text = Date.Today
        lbID.Text = ""
        pbImg.Image = Resource1.tmpIMG
        currentChange = New IsChange("", "", 0, 0, Nothing)
    End Sub

    Public Sub loadData()
        conn.Open()
        Dim query As String = "select * from product_query"
        Dim adapter As New OleDbDataAdapter(query, conn)
        Dim data As New DataTable()
        adapter.Fill(data)
        DataGridView1.DataSource = data
        DataGridView1.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.RowsDefaultCellStyle.Font = New Font("Khmer OS Battambang", 12, FontStyle.Bold)
        DataGridView1.Columns("product_name").AutoSizeMode = DataGridViewAutoSizeColumnsMode.AllCells
        DataGridView1.Columns("total").AutoSizeMode = DataGridViewAutoSizeColumnsMode.AllCells
        For Each row As DataGridViewRow In DataGridView1.Rows()

            row.Cells("product_image").Value = row.Cells("product_img").Value
            Dim create_date As Date = row.Cells("create_date").Value

            row.Cells("create_date").Value = create_date.ToString("MM/dd/yyyy")
        Next

        conn.Close()
    End Sub
    Private Sub stock_control_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCatagory.Height = 42


        TableLayoutPanel1.CellBorderStyle = BorderStyle.FixedSingle
        DataGridView1.RowTemplate.Height = 100
        loadData()
        DataGridView1.Columns("product_img").Visible = False
        DataGridView1.AllowUserToAddRows = False


        conn.Close()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        conn.Open()
        If lbID.Text = "" Then
            MessageBox.Show("please select product to delete")
            conn.Close()
            Return
        End If

        Dim query As String = "delete * from product_query where ID = ?"
        Dim cmd As New OleDbCommand(query, conn)
        cmd.Parameters.AddWithValue("?", lbID.Text)
        Try
            cmd.ExecuteNonQuery()
            conn.Close()
            reset()
            loadData()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            conn.Close()
        End Try

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        txtName.Text = ""
        txtCatagory.Text = ""
        txtPrice.Text = ""
        txtQuantity.Text = ""
        lbTotal.Text = ""
        lbDate.Text = Date.Today.ToString("MM/dd/yyyy")
        lbID.Text = ""
        pbImg.Image = Resource1.tmpIMG
        currentChange = New IsChange("", "", 0, 0, Nothing)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

        If e.RowIndex >= 0 Then
            RowIndex = e.RowIndex
            Dim ms As New MemoryStream(CType(DataGridView1.Rows(e.RowIndex).Cells("product_img").Value, Byte()))
            txtName.Text = DataGridView1.Rows(e.RowIndex).Cells("product_name").Value
            txtCatagory.Text = DataGridView1.Rows(e.RowIndex).Cells("catagory").Value
            txtPrice.Text = DataGridView1.Rows(e.RowIndex).Cells("price").Value
            txtQuantity.Text = DataGridView1.Rows(e.RowIndex).Cells("quantity").Value
            lbTotal.Text = DataGridView1.Rows(e.RowIndex).Cells("total").Value
            lbDate.Text = CDate(DataGridView1.Rows(e.RowIndex).Cells("create_date").Value)
            lbID.Text = DataGridView1.Rows(e.RowIndex).Cells("ID").Value

            pbImg.Image = Image.FromStream(ms)
            currentChange = New IsChange(txtName.Text, txtCatagory.Text, CInt(txtQuantity.Text), CDec(txtPrice.Text), CType(DataGridView1.Rows(e.RowIndex).Cells("product_img").Value, Byte()))
            Dim tp = txtPrice.Text
            'MessageBox.Show(currentChange.create_date & "  " & currentChange.create_date.GetType.ToString & "  " & currentChange.create_date & "  " & currentChange.create_date.GetType.ToString)

        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub



    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim query1 As String = "insert into product_query (product_name, catagory, quantity, price, create_date, product_img) values (?,?,?,?,?,?)"
        Dim query2 As String = "insert into new_product (product_name, catagory, quantity, price, create_date) values (?,?,?,?,?)"
        Dim ms As New MemoryStream()
        Dim dl As New quantity_dialog()



        If lbID.Text <> "" Then
            MessageBox.Show("please clear all field before save")
            Return
        End If

        If txtCatagory.Text = "" And txtName.Text = "" And txtPrice.Text = "" And txtQuantity.Text = "" Then
            MessageBox.Show("All field cannot empty")
            Return
        End If

        conn.Open()

        pbImg.Image.Save(ms, Imaging.ImageFormat.Jpeg)
        Dim imgByte As Byte() = ms.ToArray()
        Dim quantity As Integer
        Try
            Dim cmd1 As New OleDbCommand(query1, conn)
            Dim cmd2 As New OleDbCommand(query2, conn)
            cmd1.Parameters.AddWithValue("?", txtName.Text)
            cmd1.Parameters.AddWithValue("?", txtCatagory.Text)

            If dl.ShowDialog = DialogResult.OK Then
                quantity = dl.dlval(0).quantity
                cmd1.Parameters.AddWithValue("?", quantity)
            Else
                conn.Close()
                Return
            End If
            cmd1.Parameters.AddWithValue("?", txtPrice.Text)
            cmd1.Parameters.Add("?", OleDbType.Date).Value = CDate(dl.dlval(0).create_date.ToString("MM/dd/yyyy"))
            cmd1.Parameters.AddWithValue("?", imgByte)
            cmd1.ExecuteNonQuery()

            conn.Close()

            conn.Open()
            cmd2.Parameters.AddWithValue("?", txtName.Text)
            cmd2.Parameters.AddWithValue("?", txtCatagory.Text)
            cmd2.Parameters.AddWithValue("?", quantity)
            cmd2.Parameters.AddWithValue("?", txtPrice.Text)
            cmd2.Parameters.Add("?", OleDbType.Date).Value = CDate(dl.dlval(0).create_date.ToString("MM/dd/yyyy"))
            cmd2.ExecuteNonQuery()
            conn.Close()

            reset()
            loadData()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        reset()

    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim opf As New OpenFileDialog
        opf.Filter = "Image File | *.jpg; *.png; *.gif; *jpeg"

        If opf.ShowDialog = DialogResult.OK Then
            pbImg.Image = Image.FromFile(opf.FileName)

        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        If txtCatagory.Text = "" And txtName.Text = "" And txtPrice.Text = "" And txtQuantity.Text = "" Then
            MessageBox.Show("All field cannot empty")
            Return
        End If

        If RowIndex = -1 Then
            MessageBox.Show("please select product to update")
            Return
        End If
        conn.Open()
        Dim query As String = "update product_query set product_name = ?, catagory = ?, quantity = ?, price = ?, product_img = ? where ID = ? "
        Dim ms As New MemoryStream()
        pbImg.Image.Save(ms, Imaging.ImageFormat.Jpeg)
        Dim imgByte As Byte() = ms.ToArray()
        Dim changed As Boolean =
   txtName.Text <> currentChange.name OrElse
   txtCatagory.Text <> currentChange.catagory OrElse
   CInt(txtQuantity.Text) <> currentChange.quantity OrElse
   CDec(txtPrice.Text) <> currentChange.price OrElse Not imgByte.SequenceEqual(currentChange.img)

        If changed Then
            Try
                Dim cmd As New OleDbCommand(query, conn)
                cmd.Parameters.AddWithValue("?", txtName.Text)
                cmd.Parameters.AddWithValue("?", txtCatagory.Text)
                cmd.Parameters.AddWithValue("?", txtQuantity.Text)
                cmd.Parameters.AddWithValue("?", txtPrice.Text)
                cmd.Parameters.AddWithValue("?", imgByte)
                cmd.Parameters.AddWithValue("?", lbID.Text)
                cmd.ExecuteNonQuery()
                MessageBox.Show("update successful")
                currentChange = New IsChange("", "", 0, CDec(txtPrice.Text), CType(Nothing, Byte()))
                conn.Close()
                reset()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            conn.Close()
            loadData()

        Else
            Dim bool As Boolean = Not imgByte.SequenceEqual(currentChange.img)
            MessageBox.Show("No value has been changed  " & bool)
            conn.Close()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dashboard_frm.Show()
        Me.Hide()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim query As String


        If txtSearch.Text = "" Then

            loadData()
            conn.Close()
            Return
        End If
        conn.Open()
        Try
            Dim keywork As Integer = txtSearch.Text
            query = "SELECT * FROM product_query WHERE ID = " & txtSearch.Text

        Catch ex As Exception
            query = "SELECT * FROM product_query WHERE product_name LIKE " & "'%" & txtSearch.Text & "%'"
        End Try

        Dim adapter As New OleDbDataAdapter(query, conn)
        Dim data As New DataTable()
        adapter.Fill(data)
        DataGridView1.DataSource = data

        For Each row As DataGridViewRow In DataGridView1.Rows()
            row.Cells("product_image").Value = row.Cells("product_img").Value
        Next
        conn.Close()

    End Sub

    Private Sub pbImg_Click(sender As Object, e As EventArgs) Handles pbImg.Click
        Image_Zoom_frm.Show()

    End Sub

    Private Sub stock_controlClosing(sender As Object, e As EventArgs) Handles Me.Closing
        Application.Exit()
    End Sub

    Private Sub txtModel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtModel.SelectedIndexChanged
        Try
            Dim query As String = "select * from model"
        Catch ex As Exception

        End Try
    End Sub
End Class