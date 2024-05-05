Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.VisualBasic.ApplicationServices
Imports System.Windows.Forms


Public Class User_Homepage



    Dim objcon As SqlConnection = New SqlConnection("Data Source=localhost\SQLEXPRESS;Initial Catalog=AirlineReservationSystem;Integrated Security=True;Encrypt=False")
    Dim objcmd As SqlCommand = Nothing
    Dim dt As New DataTable
    Dim usernm As String
    Dim userid = Form1.userid



    Public Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs)
        '
        ' Fill in the data grid with a List
        '
        MsgBox("This is the userID = " & userid)
        Dim sqlcm = New SqlCommand("Select * FROM SearchBookFlight Where UserId='" + userid.ToString + "'", objcon)
        Dim add = New SqlDataAdapter(sqlcm)
        objcon.Open()
        add.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub


    Public Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click


        Me.Hide()
        Dim box = New Book_Flight()
        box.Show()
    End Sub

    Public Sub Button3_Click(ByVal sender As Object, e As EventArgs) Handles Button3.Click

        Me.Hide()
        Dim box = New Search_Flight()
        box.Show()
    End Sub
    Public Sub Button2_Click(ByVal sender As Object, e As EventArgs) Handles Button2.Click

        Me.Hide()
        Dim box = New Passenger_Details()
        box.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        Dim box = New Form1()
        box.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)

    End Sub
End Class


