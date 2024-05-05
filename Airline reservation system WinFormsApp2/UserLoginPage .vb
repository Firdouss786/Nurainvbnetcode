Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.VisualBasic.ApplicationServices
Public Class Form1

    Dim objcon As SqlConnection = New SqlConnection("Data Source=localhost\SQLEXPRESS;Initial Catalog=AirlineReservationSystem;Integrated Security=True;Encrypt=False")
    Dim objcmd As SqlCommand = Nothing
    Dim ds As DataSet = New DataSet
    Public usernm As String
    Public userid As String

    Public Function Check_login(ByVal user As String, ByVal pass As String)
        Try
            Dim objcon As SqlConnection = New SqlConnection("Data Source=localhost\SQLEXPRESS;Initial Catalog=AirlineReservationSystem;Integrated Security=True;Encrypt=False")
            Dim sqlcm As SqlCommand = New SqlCommand("Select * FROM Userlogin Where Username='" + TextBox1.Text.ToString() + "' and Password='" + TextBox2.Text.ToString() + "'", objcon)
            Dim add As SqlDataAdapter = New SqlDataAdapter(sqlcm)
            objcon.Open()
            add.Fill(ds)
            If ds.Tables(0).Rows.Count > 0 Then
                Return ds
            Else
                Return ds
            End If
        Catch ex As Exception
            MsgBox("DS empty")
        Finally
        End Try
    End Function

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            ds = Check_login(TextBox1.Text, TextBox2.Text)
            If Not ds Is Nothing Then
                If ds.Tables(0).Rows.Count > 0 Then
                    usernm = ds.Tables(0).Rows(0)("Username").ToString
                    userid = ds.Tables(0).Rows(0)("UserId").ToString
                    If ds.Tables(0).Rows(0)("Role").ToString = "admin" Then

                        Dim Login = New Form1()
                        Me.Hide()
                        Dim box = New Admin_menu()
                        box.Show()
                    Else
                        Dim Login = New Form1()
                        Me.Hide()
                        Dim box = New User_Homepage()
                        box.Show()
                    End If
                End If
            Else
                MsgBox("invalid user name and password")
                TextBox1.Focus()
                TextBox1.Text = ""
                TextBox2.Text = ""
            End If
        Catch ex As Exception
            MsgBox("error")
        Finally
        End Try
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Me.Hide()
        Dim box = New User_Registration()
        box.Show()

    End Sub
End Class





