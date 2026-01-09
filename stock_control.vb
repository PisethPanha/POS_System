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
        Property model_name As String
        Property brand_name As String
        Property storage_name As String
        Property ram_name As String
        Property suplier_name As String
        Property quantity As Integer
        Property price As Decimal
        Property img As Byte()
        Public Sub New(name As String, brand_name As String, storage_name As String, ram_name As String, suplier_name As String, quantity As Integer, price As Decimal, img As Byte())
            Me.model_name = name
            Me.brand_name = brand_name
            Me.storage_name = storage_name
            Me.ram_name = ram_name
            Me.suplier_name = suplier_name
            Me.quantity = quantity
            Me.price = price
            Me.img = img
        End Sub
    End Class

    Public Sub reset()
        txtModel.Text = ""
        cbBrand.Text = "Iphone"
        cbRam.Text = "4G"
        cbStorage.Text = "64G"
        cbSuplier.Text = "suplier a"
        txtPrice.Text = ""
        txtQuantity.Text = ""
        lbDate.Text = ""
        lbID.Text = ""
        pbImg.Image = Resource1.tmpIMG
        currentChange = Nothing
    End Sub

    Public Sub loadData()
        conn.Open()
        Dim query As String = "select * from product_query"
        Dim adapter As New OleDbDataAdapter(query, conn)
        Dim data As New DataTable()
        adapter.Fill(data)
        DataGridView1.RowTemplate.Height = 100
        DataGridView1.DataSource = data
        DataGridView1.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.RowsDefaultCellStyle.Font = New Font("Khmer OS Battambang", 12, FontStyle.Bold)
        DataGridView1.Columns("model_name").AutoSizeMode = DataGridViewAutoSizeColumnsMode.AllCells
        DataGridView1.Columns("total_amount").AutoSizeMode = DataGridViewAutoSizeColumnsMode.AllCells
        For Each row As DataGridViewRow In DataGridView1.Rows()

            row.Cells("product_image").Value = row.Cells("product_img").Value
            Dim create_date As Date = row.Cells("create_date").Value

            row.Cells("create_date").Value = create_date.ToString("MM/dd/yyyy")
        Next

        Dim query_brand As String = "select * from brand"
        Dim ad1 As New OleDbDataAdapter(query_brand, conn)
        Dim dt1 As New DataTable
        ad1.Fill(dt1)
        cbBrand.DataSource = dt1
        cbBrand.DisplayMember = "brand_name"
        cbBrand.ValueMember = "brand_id"

        Dim query_storage As String = "select * from storage_size_tbl"
        Dim ad2 As New OleDbDataAdapter(query_storage, conn)
        Dim dt2 As New DataTable
        ad2.Fill(dt2)
        cbStorage.DataSource = dt2
        cbStorage.DisplayMember = "storage_size"
        cbStorage.ValueMember = "storage_id"

        Dim query_ram As String = "select * from ram_size_tbl"
        Dim ad3 As New OleDbDataAdapter(query_ram, conn)
        Dim dt3 As New DataTable
        ad3.Fill(dt3)
        cbRam.DataSource = dt3
        cbRam.DisplayMember = "ram_size"
        cbRam.ValueMember = "ram_size_id"

        Dim query_suplier As String = "select * from suplier_tbl"
        Dim ad4 As New OleDbDataAdapter(query_suplier, conn)
        Dim dt4 As New DataTable
        ad4.Fill(dt4)
        cbSuplier.DataSource = dt4
        cbSuplier.DisplayMember = "sup_name"
        cbSuplier.ValueMember = "sup_id"

        TableLayoutPanel1.CellBorderStyle = BorderStyle.FixedSingle
        DataGridView1.RowTemplate.Height = 100
        DataGridView1.Columns("product_img").Visible = False
        DataGridView1.AllowUserToAddRows = False

        conn.Close()
    End Sub
    Private Sub stock_control_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadData()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
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

        reset()

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

        If e.RowIndex >= 0 Then
            RowIndex = e.RowIndex
            Dim ms As New MemoryStream(CType(DataGridView1.Rows(e.RowIndex).Cells("product_image").Value, Byte()))
            pan.Text = DataGridView1.Rows(e.RowIndex).Cells("sup_name").Value
            txtModel.Text = DataGridView1.Rows(e.RowIndex).Cells("model_name").Value
            cbBrand.Text = DataGridView1.Rows(e.RowIndex).Cells("brand_name").Value
            cbRam.Text = DataGridView1.Rows(e.RowIndex).Cells("ram_size").Value
            cbStorage.Text = DataGridView1.Rows(e.RowIndex).Cells("storage_size").Value
            cbSuplier.Text = DataGridView1.Rows(e.RowIndex).Cells("sup_name").Value
            txtPrice.Text = DataGridView1.Rows(e.RowIndex).Cells("price").Value
            txtQuantity.Text = DataGridView1.Rows(e.RowIndex).Cells("quantity").Value
            lbDate.Text = CDate(DataGridView1.Rows(e.RowIndex).Cells("create_date").Value)
            lbID.Text = DataGridView1.Rows(e.RowIndex).Cells("ID").Value
            pbImg.Image = Image.FromStream(ms)
            currentChange = New IsChange(txtModel.Text, cbBrand.Text, cbStorage.Text, cbRam.Text, cbSuplier.Text, CInt(txtQuantity.Text), CDec(txtPrice.Text), CType(DataGridView1.Rows(e.RowIndex).Cells("product_img").Value, Byte()))
            Dim tp = txtPrice.Text
            'MessageBox.Show(currentChange.create_date & "  " & currentChange.create_date.GetType.ToString & "  " & currentChange.create_date & "  " & currentChange.create_date.GetType.ToString)

        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub



    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim query1 As String = "insert into product (model_name, brand_id, storage_size_id, ram_size_id, suplier_id, quantity, price, create_date, product_img) values (?,?,?,?,?,?,?,?,?)"
        'Dim query2 As String = "insert into new_product (product_name, catagory, quantity, price, create_date) values (?,?,?,?,?)"
        Dim ms As New MemoryStream()
        Dim dl As New quantity_dialog()



        If lbID.Text <> "" Then
            MessageBox.Show("please clear all field before save")
            Return
        End If

        conn.Open()

        pbImg.Image.Save(ms, Imaging.ImageFormat.Jpeg)
        Dim imgByte As Byte() = ms.ToArray()
        Dim quantity As Integer
        Try
            Dim cmd1 As New OleDbCommand(query1, conn)
            'Dim cmd2 As New OleDbCommand(query2, conn)
            cmd1.Parameters.AddWithValue("?", txtModel.Text)
            cmd1.Parameters.AddWithValue("?", cbBrand.SelectedValue)
            cmd1.Parameters.AddWithValue("?", cbStorage.SelectedValue)
            cmd1.Parameters.AddWithValue("?", cbRam.SelectedValue)
            cmd1.Parameters.AddWithValue("?", cbSuplier.SelectedValue)
            'cmd1.Parameters.AddWithValue("?", )

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

            Reset()
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

        If txtModel.Text = "" And txtPrice.Text = "" And txtPrice.Text = "" And txtQuantity.Text = "" Then
            MessageBox.Show("All field cannot empty")
            Return
        End If

        If lbID.Text = "" Then
            MessageBox.Show("please select product to update")
            Return
        End If
        conn.Open()
        Dim query As String = "update product set model_name = ?, brand_id = ?, price = ?, product_img = ?, storage_size_id = ?, ram_size_id = ?, suplier_id = ?  where ID = ? "
        Dim ms As New MemoryStream()
        pbImg.Image.Save(ms, Imaging.ImageFormat.Jpeg)
        Dim imgByte As Byte() = ms.ToArray()
        Dim changed As Boolean =
        txtModel.Text <> currentChange.model_name OrElse
        txtPrice.Text <> currentChange.price OrElse
        cbBrand.Text <> currentChange.brand_name OrElse
        cbRam.Text <> currentChange.ram_name OrElse
        cbStorage.Text <> currentChange.storage_name OrElse
        cbSuplier.Text <> currentChange.suplier_name OrElse
        Not imgByte.SequenceEqual(currentChange.img)

        If changed Then
            Try
                Dim cmd As New OleDbCommand(query, conn)
                cmd.Parameters.AddWithValue("?", txtModel.Text)
                cmd.Parameters.AddWithValue("?", cbBrand.SelectedValue)
                cmd.Parameters.AddWithValue("?", txtPrice.Text)
                cmd.Parameters.AddWithValue("?", imgByte)
                cmd.Parameters.AddWithValue("?", cbStorage.SelectedValue)
                cmd.Parameters.AddWithValue("?", cbRam.SelectedValue)
                cmd.Parameters.AddWithValue("?", cbSuplier.SelectedValue)
                cmd.Parameters.AddWithValue("?", lbID.Text)
                cmd.ExecuteNonQuery()
                MessageBox.Show("update successful")
                currentChange = Nothing
                conn.Close()
                Reset()
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
            query = "SELECT 
                     product_query.ID,
                     product_query.product_img,
                     product_query.model_name,
                     brand.brand_name,
                     ram_size_tbl.ram_size,
                     storage_size_tbl.storage_size,
                     product_query.quantity,
                     product_query.price,
                     product_query.total_amount,
                     suplier_tbl.sup_name,
                     product_query.create_date
                     FROM (((product_query INNER JOIN brand ON product_query.brand_id = brand.brand_ID)
                     INNER JOIN ram_size_tbl ON product_query.ram_size_id = ram_size_tbl.ram_size_id)
                     INNER JOIN storage_size_tbl ON product_query.storage_size_id = storage_size_tbl.storage_id)
                     INNER JOIN suplier_tbl ON product_query.suplier_id = suplier_tbl.sup_id
                     WHERE ID LIKE '%" & txtSearch.Text & "%'"

        Catch ex As Exception
            query = "SELECT * FROM product_query WHERE model_name LIKE " & "'%" & txtSearch.Text & "%'"
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

    Private Sub txtModel_SelectedIndexChanged(sender As Object, e As EventArgs)
        Try
            Dim query = "select * from model"
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cbBrand_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbBrand.SelectedIndexChanged
        'MessageBox.Show(cbBrand.SelectedValue.ToString)
    End Sub

    Private Sub cbStorage_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbStorage.SelectedIndexChanged

    End Sub
End Class