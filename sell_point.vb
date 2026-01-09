Imports System.Collections.Immutable
Imports System.Data.OleDb
Imports System.Diagnostics.Eventing
Imports System.IO
Imports System.IO.Pipelines
Imports System.Text
Imports POS_System.My.Resources
Imports System.Drawing
Imports System.Drawing.Printing
Imports System.ComponentModel

Public Class sell_point


    Public proList As New List(Of cardList)()
    Private total_amount As Decimal = 0
    Private RowIndexTB As Integer = 0
    Private pro_id As Integer
    Private bmp As Bitmap
    Private disprice As Decimal
    Private dispricePercence As Decimal

    Private conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & IO.Directory.GetParent(Application.StartupPath).Parent.FullName.Substring(0, IO.Directory.GetParent(Application.StartupPath).Parent.FullName.Length - 9) & "\" & "admin.accdb;")

    Public Class cardList
        Public Property id As Integer
        Public Property price As Decimal = -1
        Public Property quantity As Decimal
        Public Property name As String
        Public Property index As Integer

        Public Sub New(id As Integer, price As Decimal, quantity As Decimal, name As String, index As Integer)
            Me.id = id
            Me.price = price
            Me.quantity = quantity
            Me.name = name
            Me.index = index

        End Sub
    End Class
    Public Class items
        Public product_name As String
        Public price As Decimal
        Public quantity As Decimal
        Public id As Integer
        Public index As Integer
        Public Sub New(price As Decimal, quantity As Integer, Name As String, index As Integer, id As Integer)
            Me.product_name = Name
            Me.price = price
            Me.id = id
            Me.quantity = quantity
            Me.index = index

        End Sub
    End Class

    Public Function loadData()
        Dim query As String = "select * from product_query"

        Dim adapter As New OleDbDataAdapter(query, conn)
        Dim data As New DataTable()
        adapter.Fill(data)

        DataGridView1.RowTemplate.Height = 100
        DataGridView1.DataSource = data
        DataGridView1.Columns("product_img").Visible = False
        DataGridView1.AllowUserToAddRows = False


        For Each row As DataGridViewRow In DataGridView1.Rows

            row.Cells("img").Value = ByteArrayToImage(row.Cells("product_img").Value)

        Next
    End Function

    Private Sub CapturePanel()
        bmp = New Bitmap(Panel3.Width, Panel3.Height)
        Panel3.DrawToBitmap(bmp, New Rectangle(0, 0, Panel3.Width, Panel3.Height))
    End Sub


    Private Sub PrintPanel()
        CapturePanel()
        Dim pdoc As New PrintDocument()
        AddHandler pdoc.PrintPage, AddressOf Me.PrintPageHandler
        pdoc.Print()
    End Sub



    Private Sub PrintPageHandler(sender As Object, e As PrintPageEventArgs)

        e.Graphics.DrawImage(bmp, 0, 0)
    End Sub


    Private Sub sell_point_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtExchangeRate.Text = 4000
        cbDisType.Text = "%"

        Dim query As String = "select * from product_query"

        Dim adapter As New OleDbDataAdapter(query, conn)
        Dim data As New DataTable()
        adapter.Fill(data)

        DataGridView1.RowTemplate.Height = 100
        DataGridView1.DataSource = data
        DataGridView1.Columns("product_img").Visible = False
        DataGridView1.AllowUserToAddRows = False


        For Each row As DataGridViewRow In DataGridView1.Rows

            If Not TypeOf row.Cells("product_img").Value Is Bitmap Then

                row.Cells("img").Value = ByteArrayToImage(row.Cells("product_img").Value)



            End If

        Next
        TableLayoutPanel1.RowCount = 0
        TableLayoutPanel1.RowStyles.Clear()


    End Sub
    Private Sub AddProductCard(productName As String, price As Decimal, quantity As Integer, index As Integer, Optional productImage As Image = Nothing)


        Dim card As New Panel()
        card.BorderStyle = BorderStyle.FixedSingle
        card.Width = 500
        card.Height = 120
        card.Margin = New Padding(10)
        card.BackColor = Color.White


        Dim pbImage As New PictureBox()
        pbImage.Size = New Size(100, 100)
        pbImage.Location = New Point(10, 10)
        pbImage.SizeMode = PictureBoxSizeMode.Zoom
        pbImage.BorderStyle = BorderStyle.FixedSingle
        If productImage IsNot Nothing Then
            pbImage.Image = productImage
        End If


        Dim lblName As New Label()
        lblName.Text = productName
        lblName.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        lblName.AutoSize = True
        lblName.Location = New Point(120, 15)


        Dim lblPrice As New Label()
        lblPrice.Text = price.ToString("C")
        lblPrice.Font = New Font("Segoe UI", 12, FontStyle.Regular)
        lblPrice.ForeColor = Color.Green
        lblPrice.AutoSize = True
        lblPrice.Location = New Point(120, 45)


        Dim lblQty As New Label()
        lblQty.Text = "Qty: " & quantity.ToString()
        lblQty.Font = New Font("Segoe UI", 9)
        lblQty.AutoSize = True
        lblQty.Location = New Point(120, 75)


        Dim btnDelete As New Button()
        btnDelete.Text = "Delete"
        btnDelete.Size = New Size(80, 30)
        btnDelete.Location = New Point(card.Width - 100, 45)
        btnDelete.BackColor = Color.IndianRed
        btnDelete.ForeColor = Color.White
        btnDelete.FlatStyle = FlatStyle.Flat
        btnDelete.Cursor = Cursors.Hand

        AddHandler btnDelete.Click, Sub(sender, e)
                                        TableLayoutPanel1.Controls.Remove(card)
                                        merge.RemoveAll(Function(x) x.index = index)
                                        proList.RemoveAll(Function(x) x.index = index)
                                        total_amount = proList.Sum(Function(x) x.price)
                                        lbUSD.Text = total_amount
                                        lbKHR.Text = total_amount * Val(txtExchangeRate.Text)
                                        card.Dispose()

                                        regenerateIvoice()
                                    End Sub


        card.Controls.Add(pbImage)
        card.Controls.Add(lblName)
        card.Controls.Add(lblPrice)
        card.Controls.Add(lblQty)
        card.Controls.Add(btnDelete)

        TableLayoutPanel1.RowCount += 1
        TableLayoutPanel1.Controls.Add(card)

    End Sub

    Private Function ByteArrayToImage(bytes As Byte()) As Image
        Dim ms As New MemoryStream(bytes)
        Return Image.FromStream(ms)

    End Function

    Private pro_img As Image
    Private pro_price As Decimal
    Private pro_name As String
    Private proID As Integer
    Private pro_quantity As Integer

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex >= 0 Then
            Dim img As Image = DataGridView1.Rows(e.RowIndex).Cells("img").Value
            PictureBox1.Image = img
            lbBrand.Text = "Brand: " & DataGridView1.Rows(e.RowIndex).Cells("brand_name").Value
            lbRam.Text = "RAM: " & DataGridView1.Rows(e.RowIndex).Cells("Ram_size").Value
            lbStorage.Text = "Storage: " & DataGridView1.Rows(e.RowIndex).Cells("storage_size").Value
            lbPrice.Text = DataGridView1.Rows(e.RowIndex).Cells("price").Value & "$"
            lbName.Text = DataGridView1.Rows(e.RowIndex).Cells("model_name").Value
            pro_id = e.RowIndex
            txtQuantity.Text = 1
            proID = DataGridView1.Rows(e.RowIndex).Cells("ID").Value


        End If
    End Sub



    Private Sub DataGridView1_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles DataGridView1.CellPainting

    End Sub


    Private Sub btnAddCart_Click(sender As Object, e As EventArgs) Handles btnAddCart.Click


        If lbPrice.Text <> "0" Then
            Try
                Dim name As String = DataGridView1.Rows(pro_id).Cells("model_name").Value
                Dim brand As String = DataGridView1.Rows(pro_id).Cells("brand_name").Value
                Dim storage As String = DataGridView1.Rows(pro_id).Cells("storage_size").Value
                Dim ram As String = DataGridView1.Rows(pro_id).Cells("ram_size").Value
                Dim r As String = DataGridView1.Rows(pro_id).Cells("ram_size").Value
                Dim price As String = DataGridView1.Rows(pro_id).Cells("price").Value * txtQuantity.Text
                Dim img As Image = DataGridView1.Rows(pro_id).Cells("img").Value
                Dim quantity As Integer = Val(txtQuantity.Text)
                RowIndexTB += 1
                Dim index As Integer = RowIndexTB
                proList.Add(New cardList(proID, price, quantity, name, RowIndexTB))

                If quantity > 0 Then
                    AddProductCard(name, price, quantity, RowIndexTB, img)
                Else
                    MessageBox.Show("please input quatity value")
                End If

                If txtDisPercence.Text <> "" Then
                    If cbDisType.Text = "%" Then
                        disprice = proList.Sum(Function(x) x.price) * (txtDisPercence.Text / 100)
                        dispricePercence = txtDisPercence.Text
                    ElseIf cbDisType.Text = "$" Then
                        disprice = txtDisPercence.Text
                        dispricePercence = (txtDisPercence.Text / proList.Sum(Function(x) x.price)) * 100
                    ElseIf cbDisType.Text = "៛" Then
                        disprice = txtDisPercence.Text / txtExchangeRate.Text
                        dispricePercence = ((txtDisPercence.Text / txtExchangeRate.Text) / proList.Sum(Function(x) x.price)) * 100
                    End If
                Else

                    disprice = 0
                End If


                If proList.Count <> 0 Then
                    total_amount = proList.Sum(Function(x) x.price) - disprice

                    lbUSD.Text = total_amount.ToString("C")
                    lbKHR.Text = "៛" & (total_amount * Val(txtExchangeRate.Text)).ToString("N0")
                Else
                    lbUSD.Text = 0
                    lbKHR.Text = 0
                End If
            Catch ex As Exception
                MessageBox.Show("please select product ")
            End Try


        Else
            MessageBox.Show("please select product")
        End If


        regenerateIvoice()


    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub

    Private Sub txtExchangeRate_TextChanged(sender As Object, e As EventArgs)
        If txtExchangeRate.Text = "" Then
            Return
        End If
        Try
            regenerateIvoice()
            Dim exchangerate As Decimal = txtExchangeRate.Text
            lbKHR.Text = total_amount * exchangerate
        Catch ex As Exception
            MessageBox.Show("exchange rate must be value of number")
            txtExchangeRate.Text = txtExchangeRate.Text.Remove(txtExchangeRate.Text.Length - 1)
        End Try

    End Sub
    Private merge As New List(Of items)
    Private Sub btnG_invoice_Click(sender As Object, e As EventArgs)

        regenerateIvoice()
        'Dim sb As New StringBuilder()
        'For i As Integer = 0 To merge.Count - 1
        '    Dim ite As items = merge(i)
        '    sb.AppendLine($"#{i + 1}")
        '    sb.AppendLine($"Name    : {ite.product_name}")
        '    sb.AppendLine($"Price   : {ite.price.ToString("C")}")   ' Formats as currency, e.g., $29.99
        '    sb.AppendLine($"Quantity: {ite.quantity}")
        '    sb.AppendLine("-------------------")
        'Next
        'MessageBox.Show(sb.ToString(), "Current Products", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub TableLayoutPanel2_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel2.Paint

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        reset()
    End Sub

    Public Function reset()
        PictureBox1.Image = Resource1.tmpIMG

        lbPrice.Text = "0"
        lbName.Text = "Product Name"
        lbBrand.Text = "Brand: "
        lbRam.Text = "RAM: "
        lbStorage.Text = "Storage: "
        merge.Clear()
        proList.Clear()
        pro_id = -1
        For i = TableLayoutPanel1.Controls.Count - 1 To 0 Step -1
            TableLayoutPanel1.Controls(i).Dispose()
        Next
        lbKHR.Text = 0
        lbUSD.Text = 0

        regenerateIvoice()
    End Function

    Private total_quantity As Integer

    Public Sub regenerateIvoice()
        merge.Clear()
        TableLayoutPanel2.SuspendLayout()
        TableLayoutPanel2.Controls.Clear()
        TableLayoutPanel2.RowStyles.Clear()
        TableLayoutPanel2.RowCount = 0
        TableLayoutPanel2.ResumeLayout()

        If proList.Count <> 0 Then
            For Each it In proList
                Dim existedItem = merge.FirstOrDefault(Function(x) x.id = it.id)
                If existedItem IsNot Nothing Then
                    existedItem.quantity += it.quantity
                    existedItem.price += it.price
                Else
                    merge.Add(New items(it.price, it.quantity, it.name, it.index, it.id))
                End If
            Next
            total_quantity = 0
            For Each q In merge
                total_quantity += q.quantity
            Next

            For i As Integer = 0 To merge.Count - 1
                Dim ite As items = merge(i)
                Dim lbItem As New Label()
                Dim name As String = ite.product_name
                Dim quantity2 As Decimal = ite.quantity
                Dim totalPrice As Decimal = ite.price
                Dim pricePerUnit As Decimal = ite.price / ite.quantity
                txtQuantity.Text = 1

                lbItem.Text = name & "     " & pricePerUnit.ToString("N0") & "$" & "         x" & quantity2 & "        = " & totalPrice.ToString("N0") & "$"
                lbItem.AutoSize = False
                lbItem.Font = New Font("Segoe UI", 9, FontStyle.Bold)
                lbItem.Dock = DockStyle.Top
                lbItem.TextAlign = ContentAlignment.MiddleLeft
                lbItem.Height = 50
                TableLayoutPanel2.RowCount += 2
                TableLayoutPanel2.Controls.Add(lbItem)
            Next
        End If

        If proList.Count <> 0 Then
            lbTotalQuantity.Text = "Total quantity: " & total_quantity
            lbFee.Text = "Discount: " & disprice.ToString("N2") & "$"
            lbUSD.Text = (merge.Sum(Function(x) x.price) - disprice).ToString("N2") & "$"
            lbKHR.Text = (lbUSD.Text * txtExchangeRate.Text).ToString("N0") & "៛"
            lbDateInvoice.Text = Date.Now.ToString
            lbTotal.Text = "Total: " & (merge.Sum(Function(x) x.price) - disprice).ToString("N2") & "$ / " & ((merge.Sum(Function(x) x.price) * txtExchangeRate.Text - (disprice * txtExchangeRate.Text))).ToString("N0") & "៛"
        Else
            lbTotalQuantity.Text = "Total quantity: 0"
            lbFee.Text = "Discount: 0$"
            lbUSD.Text = 0
            lbKHR.Text = 0
            lbTotal.Text = "Total: 0$"
        End If

    End Sub

    Private Sub Button1_MouseEnter(sender As Object, e As EventArgs) Handles btnAccept.MouseEnter
        btnAccept.BackColor = Color.Fuchsia
    End Sub
    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles btnAccept.MouseLeave
        btnAccept.BackColor = Color.FromArgb(192, 0, 192)
    End Sub

    Private Sub btnAccept_Click(sender As Object, e As EventArgs) Handles btnAccept.Click
        PrintPanel()


        For Each it In merge
            Dim query1 As String = "insert into sale_tbl (product_id, quantity_out, discount, total_amount, sale_date) values (?,?,?,?,?)"
            Dim cmd1 As New OleDbCommand(query1, conn)
            conn.Open()
            cmd1.Parameters.AddWithValue("?", it.id)
            cmd1.Parameters.AddWithValue("?", it.quantity)
            cmd1.Parameters.AddWithValue("?", dispricePercence)
            cmd1.Parameters.AddWithValue("?", (it.price - (it.price * (dispricePercence / 100))))
            cmd1.Parameters.AddWithValue("?", Date.Today.ToString("MM/dd/yyyy"))
            cmd1.ExecuteNonQuery()

            conn.Close()
        Next
        reset()

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dashboard_frm.Show()
        Me.Hide()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        conn.Open()
        Dim query As String

        If TextBox1.Text = "" Then
            loadData()
            conn.Close()
            Return
        End If
        Try
            Dim id As Integer = TextBox1.Text
            query = "SELECT * FROM product_query WHERE ID = " & TextBox1.Text
        Catch ex As Exception
            query = "SELECT * FROM product_query WHERE" & " product_name LIKE '%" & TextBox1.Text & "%'"
        End Try



        Try
            Dim adapter As New OleDbDataAdapter(query, conn)
            Dim data As New DataTable()
            adapter.Fill(data)

            DataGridView1.RowTemplate.Height = 100
            DataGridView1.DataSource = data
            DataGridView1.Columns("product_img").Visible = False
            DataGridView1.AllowUserToAddRows = False

            For Each row As DataGridViewRow In DataGridView1.Rows

                row.Cells("img").Value = ByteArrayToImage(row.Cells("product_img").Value)
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try



        conn.Close()

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub lbDateInvoice_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles lbFee.Click

    End Sub

    Private Sub sell_point_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Application.Exit()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub lbTotalQuantity_Click(sender As Object, e As EventArgs) Handles lbTotalQuantity.Click

    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint

    End Sub

    Private Sub txtQuantity_TextChanged(sender As Object, e As EventArgs) Handles txtQuantity.TextChanged

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub lbPrice_Click(sender As Object, e As EventArgs) Handles lbPrice.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtDisPercence.TextChanged

        Try
            Dim disVal As Decimal = txtDisPercence.Text
        Catch ex As Exception
            If txtDisPercence.Text <> "" Then
                MessageBox.Show("discount value must be a number")
                txtDisPercence.Text = txtDisPercence.Text.Substring(0, txtDisPercence.Text.Length - 1)
            End If
        End Try


        If txtDisPercence.Text <> "" Then
            If cbDisType.Text = "%" Then
                disprice = proList.Sum(Function(x) x.price) * (txtDisPercence.Text / 100)
                dispricePercence = txtDisPercence.Text
            ElseIf cbDisType.Text = "$" Then
                disprice = txtDisPercence.Text
                dispricePercence = (txtDisPercence.Text / proList.Sum(Function(x) x.price)) * 100
            ElseIf cbDisType.Text = "៛" Then
                disprice = txtDisPercence.Text / txtExchangeRate.Text
                dispricePercence = ((txtDisPercence.Text / txtExchangeRate.Text) / proList.Sum(Function(x) x.price)) * 100
            End If
        Else
            disprice = 0
        End If
        total_amount = proList.Sum(Function(x) x.price) - disprice

        lbUSD.Text = total_amount.ToString("C")
        lbKHR.Text = "៛" & (total_amount * Val(txtExchangeRate.Text)).ToString("N0")
        regenerateIvoice()
    End Sub


    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub cbDisType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbDisType.SelectedIndexChanged

        Try
            If txtDisPercence.Text <> "" Then
                If cbDisType.Text = "%" Then
                    disprice = proList.Sum(Function(x) x.price) * (txtDisPercence.Text / 100)
                    dispricePercence = txtDisPercence.Text
                ElseIf cbDisType.Text = "$" Then
                    disprice = txtDisPercence.Text
                    dispricePercence = (txtDisPercence.Text / proList.Sum(Function(x) x.price)) * 100
                ElseIf cbDisType.Text = "៛" Then
                    disprice = txtDisPercence.Text / txtExchangeRate.Text
                    dispricePercence = ((txtDisPercence.Text / txtExchangeRate.Text) / proList.Sum(Function(x) x.price)) * 100
                End If
            Else
                disprice = 0
            End If
            total_amount = proList.Sum(Function(x) x.price) - disprice

            lbUSD.Text = total_amount.ToString("C")
        Catch ex As Exception

        End Try
        lbKHR.Text = (total_amount * Val(txtExchangeRate.Text)).ToString("N0") & "៛"
        regenerateIvoice()
    End Sub

    Private Sub txtExchangeRate_TextChanged_1(sender As Object, e As EventArgs) Handles txtExchangeRate.TextChanged
        regenerateIvoice()
    End Sub
End Class