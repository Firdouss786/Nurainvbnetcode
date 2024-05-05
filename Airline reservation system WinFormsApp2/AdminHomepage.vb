Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.VisualBasic.ApplicationServices
Imports System.Windows.Forms




Public Class Admin_menu


    Dim objcon As SqlConnection = New SqlConnection("Data Source=localhost\SQLEXPRESS;Initial Catalog=AirlineReservationSystem;Integrated Security=True;Encrypt=False")
    Dim objcmd As SqlCommand = Nothing
    Dim dt As New DataTable
    Dim usernm As String
    Dim userid = Form1.userid

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Dim box = New Modify_Flight()
        box.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        '
        ' Fill in the data grid with a List
        '
        MsgBox("This is the userID = " & userid)
        Dim sqlcm = New SqlCommand("Select * FROM PassengerDetails Where UserId='" + userid.ToString + "'", objcon)
        Dim add = New SqlDataAdapter(sqlcm)
        objcon.Open()
        add.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        Dim box = New Form1
        box.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Dim box = New Delete_Flight()
        box.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim box = New Add_Flight()
        box.Show()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub
End Class
