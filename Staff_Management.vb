Imports System.ComponentModel
Imports System.Data.OleDb
Imports System.IO
Imports POS_System.My.Resources

Public Class Staff_Management

    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & IO.Directory.GetParent(Application.StartupPath).Parent.FullName.Substring(0, IO.Directory.GetParent(Application.StartupPath).Parent.FullName.Length - 9) & "\" & "admin.accdb;")
    Private isLoading As Boolean = True
    Private isDisLoading As Boolean = True
    Private isComLoading As Boolean = True

    Public Function loadData()
        conn.Open()
        Dim adt As New OleDbDataAdapter("select * from staff_query", conn)
        Dim dt As New DataTable
        adt.Fill(dt)
        DataGridView1.DataSource = dt
        DataGridView1.AllowUserToAddRows = False

        dtpDateSign.Format = DateTimePickerFormat.Custom
        dtpDateSign.CustomFormat = "MM/dd/yyyy"

        For Each row As DataGridViewRow In DataGridView1.Rows
            row.Cells("staff_photo").Value = row.Cells("photo").Value
        Next

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
        txtCardID.Text = ""
        dtpDateSign.Text = Date.Today.ToString("MM/dd/yyyy")
        txtTelegram.Text = ""
        txtPhone.Text = ""
        txtPass.Text = ""
        txtUserName.Text = ""
        pbImg.Image = Resource1.tmpIMG
    End Function

    Private Sub Staff_Management_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DataGridView1.RowTemplate.Height = 100
        loadData()
        DataGridView1.Columns("photo").Visible = False
        For Each row As DataGridViewRow In DataGridView1.Rows
            row.Cells("staff_photo").Value = row.Cells("photo").Value
        Next

        Dim queryr As String = "SELECT * FROM role"
        Dim adapterr As New OleDbDataAdapter(queryr, conn)
        Dim datar As New DataTable

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
        adapterr.Fill(datar)
        cbVill.DataSource = datav
        cbProvince.DataSource = datap
        cbComm.DataSource = datac
        cbDist.DataSource = datad
        cbRole.DataSource = datar

        cbRole.DisplayMember = "role_name"
        cbRole.ValueMember = "role_id"

        cbVill.DisplayMember = "vill_kh"
        cbVill.ValueMember = "vill_id"

        cbProvince.ValueMember = "province_code"
        cbProvince.DisplayMember = "province_kh"

        cbDist.ValueMember = "dis_code"
        cbDist.DisplayMember = "dis_kh"

        cbComm.DisplayMember = "comm_kh"
        cbComm.ValueMember = "comm_code"

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

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex < 0 Then
            Return
        End If
        Dim ms As New MemoryStream(CType(DataGridView1.Rows(e.RowIndex).Cells("photo").Value, Byte()))
        lbID.Text = DataGridView1.Rows(e.RowIndex).Cells("staff_id").Value
        txtName.Text = DataGridView1.Rows(e.RowIndex).Cells("staff_name").Value
        txtCardID.Text = DataGridView1.Rows(e.RowIndex).Cells("card_id").Value
        cbProvince.Text = DataGridView1.Rows(e.RowIndex).Cells("province_kh").Value
        cbComm.Text = DataGridView1.Rows(e.RowIndex).Cells("comm_kh").Value
        cbVill.Text = DataGridView1.Rows(e.RowIndex).Cells("vill_kh").Value
        cbDist.Text = DataGridView1.Rows(e.RowIndex).Cells("dis_kh").Value
        txtPhone.Text = DataGridView1.Rows(e.RowIndex).Cells("phone_number").Value
        txtTelegram.Text = DataGridView1.Rows(e.RowIndex).Cells("telegram").Value
        txtUserName.Text = DataGridView1.Rows(e.RowIndex).Cells("user_log").Value
        txtPass.Text = DataGridView1.Rows(e.RowIndex).Cells("pass_log").Value
        pbImg.Image = Image.FromStream(ms)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim ms As New MemoryStream()
        Dim query As String = "insert into staff_tbl (staff_name, card_id, address_id, role_id, phone_number, photo, telegram, date_joint, user_log, pass_log) values (?,?,?,?,?,?,?,?,?,?)"
        Dim cmd As New OleDbCommand(query, conn)
        cmd.Parameters.AddWithValue("?", txtName.Text)
        cmd.Parameters.AddWithValue("?", txtCardID.Text)
        cmd.Parameters.AddWithValue("?", cbVill.SelectedValue)
        cmd.Parameters.AddWithValue("?", cbRole.SelectedValue)
        cmd.Parameters.AddWithValue("?", txtPhone.Text)

        pbImg.Image.Save(ms, Imaging.ImageFormat.Jpeg)
        Dim imgByte() As Byte = ms.ToArray

        cmd.Parameters.AddWithValue("?", imgByte)
        cmd.Parameters.AddWithValue("?", txtTelegram.Text)
        cmd.Parameters.Add("?", OleDbType.Date).Value = dtpDateSign.Value.ToString("MM/dd/yyyy")
        cmd.Parameters.AddWithValue("?", txtUserName.Text)
        cmd.Parameters.AddWithValue("?", txtPass.Text)
        conn.Open()
        cmd.ExecuteNonQuery()
        conn.Close()
        loadData()
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
        Dim ms As New MemoryStream()
        Dim query As String = "update staff_tbl set staff_name = ?, card_id = ?, address_id = ?, role_id = ?, phone_number = ?, photo = ?, telegram = ?, date_joint = ?,  user_log = ?, pass_log = ? where staff_id = ?"
        Dim cmd As New OleDbCommand(query, conn)
        cmd.Parameters.AddWithValue("?", txtName.Text)
        cmd.Parameters.AddWithValue("?", txtCardID.Text)
        cmd.Parameters.AddWithValue("?", cbVill.SelectedValue)
        cmd.Parameters.AddWithValue("?", cbRole.SelectedValue)
        cmd.Parameters.AddWithValue("?", txtPhone.Text)

        pbImg.Image.Save(ms, Imaging.ImageFormat.Jpeg)
        Dim imgByte() As Byte = ms.ToArray

        cmd.Parameters.AddWithValue("?", imgByte)
        cmd.Parameters.AddWithValue("?", txtTelegram.Text)
        cmd.Parameters.Add("?", OleDbType.Date).Value = dtpDateSign.Value.ToString("MM/dd/yyyy")
        cmd.Parameters.AddWithValue("?", txtUserName.Text)
        cmd.Parameters.AddWithValue("?", txtPass.Text)
        cmd.Parameters.AddWithValue("?", lbID.Text)

        conn.Open()
        cmd.ExecuteNonQuery()
        conn.Close()
        loadData()
        reset()
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        Dim query As String = "delete * from staff_tbl where staff_id = " & lbID.Text
        Dim cmd As New OleDbCommand(query, conn)
        conn.Open()
        cmd.ExecuteNonQuery()
        conn.Close()
        loadData()
        reset()
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        reset()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dashboard_frm.Show()
        Me.Hide()
    End Sub

    Private Sub Staff_Management_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Application.Exit()
    End Sub
End Class