Imports System.ComponentModel

Public Class Dashboard_frm
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles lbStockForm.Click
        If LoginForm.role <> "stock_manager" And LoginForm.role <> "administrator" Then
            MessageBox.Show("Your role cannot access this page")
            Return
        End If
        stock_control.Show()
        Me.Hide()
    End Sub

    Private Sub Panel1_Click(sender As Object, e As EventArgs) Handles Panel1.Click
        If LoginForm.role <> "cashier" And LoginForm.role <> "administrator" Then
            MessageBox.Show("Your role cannot access this page")
            Return
        End If
        sell_point.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If LoginForm.role <> "cashier" And LoginForm.role <> "administrator" Then
            MessageBox.Show("Your role cannot access this page")
            Return
        End If
        sell_point.Show()
        Me.Hide()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        If LoginForm.role <> "cashier" And LoginForm.role <> "administrator" Then
            MessageBox.Show("Your role cannot access this page")
            Return
        End If
        sell_point.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If LoginForm.role <> "stock_manager" And LoginForm.role <> "administrator" Then
            MessageBox.Show("Your role cannot access this page")
            Return
        End If
        stock_control.Show()
        Me.Hide()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Dashboard_frm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Application.Exit()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        If LoginForm.role <> "stock_manager" And LoginForm.role <> "administrator" Then
            MessageBox.Show("Your role cannot access this page")
            Return
        End If
        Add_Stock_frm.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Print_Report_frm.Show()
        Me.Hide()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Print_Report_frm.Show()
        Me.Hide()
    End Sub

    Private Sub Panel3_Click(sender As Object, e As PaintEventArgs) Handles Panel3.Click
        Print_Report_frm.Show()
        Me.Hide()
    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint

    End Sub

    Private Sub Dashboard_frm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class