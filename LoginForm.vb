Imports System.Data.OleDb
Public Class LoginForm
    Public role As String
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & IO.Directory.GetParent(Application.StartupPath).Parent.FullName & "\" & "admin.accdb;")
        Dim query As String = "SELECT password, role FROM admin WHERE [username] = ?"


        Try
            conn.Open()
            Dim cmd As New OleDbCommand(query, conn)
            cmd.Parameters.AddWithValue("?", txtUsername.Text)
            Dim read As OleDbDataReader = cmd.ExecuteReader()

            If read.Read() Then
                If read("password") = txtPass.Text Then
                    MessageBox.Show("Logged in! Your role is " & read("role"))
                    role = read("role")
                    MessageBox.Show(role)
                    Dashboard_frm.Show()
                    Me.Hide()
                Else
                MessageBox.Show("Wrong password")
            End If
            Else
                MessageBox.Show("Wrong Username")
            End If
        Catch err As Exception
            MessageBox.Show(err.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
