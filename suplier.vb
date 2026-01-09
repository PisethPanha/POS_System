Imports System.ComponentModel
Imports System.Data.OleDb
Imports System.Net.Http.Headers

Public Class suplier

    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & IO.Directory.GetParent(Application.StartupPath).Parent.FullName.Substring(0, IO.Directory.GetParent(Application.StartupPath).Parent.FullName.Length - 9) & "\" & "admin.accdb;")
    Private isLoading As Boolean = True
    Private isDisLoading As Boolean = True
    Private isComLoading As Boolean = True
    Public dtFordl As New DataTable
    Public supName As String

    Public Function loadData()
        conn.Open()
        Dim adt As New OleDbDataAdapter("select * from sup_info", conn)
        Dim dt As New DataTable
        adt.Fill(dt)
        DataGridView1.DataSource = dt
        DataGridView1.AllowUserToAddRows = False

        dtpDateSign.Format = DateTimePickerFormat.Custom
        dtpDateSign.CustomFormat = "MM/dd/yyyy"

        DataGridView2.Visible = False
        lbNoData.Visible = False

        Dim queryv As String = "SELECT * FROM village_query"
        Dim adapterv As New OleDbDataAdapter(queryv, conn)
        Dim datav As New DataTable

        Dim queryc As String = "SELECT * FROM commune_tbl"
        Dim adapterc As New OleDbDataAdapter(queryc, conn)
        Dim datac As New DataTable

        Dim queryd As String = "SELECT * FROM district_tbl"
        Dim adapterd As New OleDbDataAdapter(queryd, conn)
        Dim datad As New DataTable

        Dim queryp As String = "SELECT * FROM provice_tbl"
        Dim adapterp As New OleDbDataAdapter(queryp, conn)
        Dim datap As New DataTable

        conn.Close()

        adapterv.Fill(datav)
        adapterp.Fill(datap)
        adapterd.Fill(datad)
        adapterc.Fill(datac)
        cbVill.DataSource = datav
        cbProvince.DataSource = datap
        cbComm.DataSource = datac
        cbDist.DataSource = datad

        cbVill.DisplayMember = "vill_kh"
        cbVill.ValueMember = "vill_id"

        cbProvince.ValueMember = "province_code"
        cbProvince.DisplayMember = "province_kh"

        cbDist.ValueMember = "dis_code"
        cbDist.DisplayMember = "dis_kh"

        cbComm.DisplayMember = "comm_kh"
        cbComm.ValueMember = "comm_code"

    End Function

    Public Function reset()
        lbID.Text = ""
        txtName.Text = ""
        txtCompany.Text = ""
        txtPhone.Text = ""
        txtTelegram.Text = ""
        dtpDateSign.Value = Date.Today.ToString("MM/dd/yyyy")
        DataGridView2.Visible = False
        lbNoData.Visible = False
        lbSupName.Visible = False
    End Function

    Private Sub suplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        loadData()

        isLoading = False
    End Sub

    Private Sub cbProvince_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProvince.SelectedIndexChanged

        If isLoading Then Exit Sub
        Dim queryv As String = "SELECT * FROM village_query WHERE province_code = " & cbProvince.SelectedValue
        Dim adapterv As New OleDbDataAdapter(queryv, conn)
        Dim datav As New DataTable

        Dim queryc As String = "SELECT * FROM commune_tbl WHERE province_code = " & cbProvince.SelectedValue
        Dim adapterc As New OleDbDataAdapter(queryc, conn)
        Dim datac As New DataTable

        Dim queryd As String = "SELECT * FROM district_tbl WHERE pro_code = " & cbProvince.SelectedValue
        Dim adapterd As New OleDbDataAdapter(queryd, conn)
        Dim datad As New DataTable



        adapterv.Fill(datav)
        adapterd.Fill(datad)
        adapterc.Fill(datac)
        cbVill.DataSource = datav
        cbComm.DataSource = datac
        cbDist.DataSource = datad

        cbVill.DisplayMember = "vill_kh"
        cbVill.ValueMember = "vill_id"

        cbDist.ValueMember = "dis_code"
        cbDist.DisplayMember = "dis_kh"

        cbComm.DisplayMember = "comm_kh"
        cbComm.ValueMember = "comm_code"
        isDisLoading = False
        'MessageBox.Show(cbProvince.SelectedValue)
    End Sub

    Private Sub cbDist_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbDist.SelectedIndexChanged
        If isDisLoading Then Exit Sub
        Dim queryv As String = "SELECT * FROM village_query WHERE dis_code = " & cbDist.SelectedValue
        Dim adapterv As New OleDbDataAdapter(queryv, conn)
        Dim datav As New DataTable

        Dim queryc As String = "SELECT * FROM commune_tbl WHERE dis_code = " & cbDist.SelectedValue
        Dim adapterc As New OleDbDataAdapter(queryc, conn)
        Dim datac As New DataTable

        adapterv.Fill(datav)
        adapterc.Fill(datac)
        cbVill.DataSource = datav
        cbComm.DataSource = datac

        cbVill.DisplayMember = "vill_kh"
        cbVill.ValueMember = "vill_id"

        cbComm.DisplayMember = "comm_kh"
        cbComm.ValueMember = "comm_code"
        isComLoading = False
    End Sub

    Private Sub cbComm_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbComm.SelectedIndexChanged
        If isDisLoading Then Exit Sub
        Dim queryv As String = "SELECT * FROM village_query WHERE comm_code = " & cbComm.SelectedValue
        Dim adapterv As New OleDbDataAdapter(queryv, conn)
        Dim datav As New DataTable

        adapterv.Fill(datav)
        cbVill.DataSource = datav

        cbVill.DisplayMember = "vill_kh"
        cbVill.ValueMember = "vill_id"

        cbComm.DisplayMember = "comm_kh"
        cbComm.ValueMember = "comm_code"
        isComLoading = False
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex < 0 Then
            Return
        End If

        lbSupName.Visible = True
        lbID.Text = DataGridView1.Rows(e.RowIndex).Cells("sup_id").Value
        txtName.Text = DataGridView1.Rows(e.RowIndex).Cells("sup_name").Value
        txtCompany.Text = DataGridView1.Rows(e.RowIndex).Cells("company_name").Value
        txtTelegram.Text = DataGridView1.Rows(e.RowIndex).Cells("telegram").Value
        txtPhone.Text = DataGridView1.Rows(e.RowIndex).Cells("phone").Value
        cbProvince.Text = DataGridView1.Rows(e.RowIndex).Cells("province_kh").Value
        cbDist.Text = DataGridView1.Rows(e.RowIndex).Cells("dis_kh").Value
        cbComm.Text = DataGridView1.Rows(e.RowIndex).Cells("comm_kh").Value
        cbVill.Text = DataGridView1.Rows(e.RowIndex).Cells("vill_kh").Value
        dtpDateSign.Value = DataGridView1.Rows(e.RowIndex).Cells("date_sign").Value
        supName = DataGridView1.Rows(e.RowIndex).Cells("sup_name").Value


        Dim query As String = "select * from product_query where sup_id = " & DataGridView1.Rows(e.RowIndex).Cells("sup_id").Value
        Dim ad As New OleDbDataAdapter(query, conn)
        Dim dt As New DataTable
        Dim dt2 As New DataTable
        dtFordl.Clear()
        ad.Fill(dtFordl)
        ad.Fill(dt)


        DataGridView2.RowTemplate.Height = 100
        DataGridView2.DataSource = dt
        DataGridView2.Columns("sup_id").Visible = False
        DataGridView2.Columns("storage_id").Visible = False
        DataGridView2.Columns("ram_size_id").Visible = False
        DataGridView2.Columns("brand_ID").Visible = False



        If DataGridView2.RowCount >= 1 Then
            lbIsSelect.Visible = False
            lbNoData.Visible = False
            lbTotal.Visible = True
            DataGridView2.Visible = True
        Else
            DataGridView2.Visible = False
            lbNoData.Visible = True
            lbTotal.Visible = False
        End If

        DataGridView2.Columns("product_img").Visible = False
        DataGridView2.RowHeadersVisible = False
        DataGridView2.AllowUserToAddRows = False
        lbSupName.Text = DataGridView1.Rows(e.RowIndex).Cells("sup_name").Value

        Dim total As Decimal = 0
        For Each row As DataGridViewRow In DataGridView2.Rows
            row.Cells("product_image").Value = row.Cells("product_img").Value
            total += CType(row.Cells("total_amount").Value, Decimal)
        Next
        lbTotal.Text = "Total_amount: " & total.ToString("C")
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click

        If lbID.Text = "" Then
            MessageBox.Show("please select suplier before print")
            Return
        End If
        If DataGridView2.RowCount < 1 Then
            MessageBox.Show("this suplier hasn't product for print")
            Return
        End If

        PreViewSuplier.Show()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If lbID.Text <> "" Then
            MessageBox.Show("please clear all field before save")
            Return
        End If
        'MessageBox.Show(cbVill.SelectedValue)
        Dim query As String = "insert into suplier_tbl (sup_name, village_id, phone, telegram, company_name, date_sign) values (?,?,?,?,?,?)"
        Dim cmd As New OleDbCommand(query, conn)
        cmd.Parameters.AddWithValue("?", txtName.Text)
        cmd.Parameters.AddWithValue("?", cbVill.SelectedValue)
        cmd.Parameters.AddWithValue("?", txtPhone.Text)
        cmd.Parameters.AddWithValue("?", txtTelegram.Text)
        cmd.Parameters.AddWithValue("?", txtCompany.Text)
        cmd.Parameters.Add("?", OleDbType.Date).Value = dtpDateSign.Value.ToString("MM/dd/yyyy")
        conn.Open()
        cmd.ExecuteNonQuery()
        conn.Close()
        loadData()
        reset()
    End Sub



    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click

        If lbID.Text = "" Then
            MessageBox.Show("please select suplier to delete")
            Return
        End If

        Dim query As String = "delete * from suplier_tbl where sup_id = " & lbID.Text
        Dim cmd As New OleDbCommand(query, conn)
        conn.Open()
        cmd.ExecuteNonQuery()
        conn.Close()
        loadData()
        reset()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dashboard_frm.Show()
        Me.Hide()
    End Sub

    Private Sub suplier_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Application.Exit()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim query As String = "update suplier_tbl set sup_name = ?, village_id = ?, phone = ?, telegram = ?, company_name = ?, date_sign = ? where sup_id = ? "
        Dim cmd As New OleDbCommand(query, conn)
        cmd.Parameters.AddWithValue("?", txtName.Text)
        cmd.Parameters.AddWithValue("?", cbVill.SelectedValue)
        cmd.Parameters.AddWithValue("?", txtPhone.Text)
        cmd.Parameters.AddWithValue("?", txtTelegram.Text)
        cmd.Parameters.AddWithValue("?", txtCompany.Text)
        cmd.Parameters.Add("?", OleDbType.Date).Value = dtpDateSign.Value.ToString("MM/dd/yyyy")
        cmd.Parameters.AddWithValue("?", lbID.Text)
        conn.Open()
        cmd.ExecuteNonQuery()
        conn.Close()
        loadData()
        reset()
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        reset()
        lbTotal.Visible = False
        lbIsSelect.Visible = True
    End Sub
End Class