Imports System.Data.SqlClient
Imports System.Net
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.VisualBasic.ApplicationServices

Public Class Passenger_Details
    ' Define your SQL connection string
    Dim connectionString As String = "Data Source=localhost\SQLEXPRESS;Initial Catalog=AirlineReservationSystem;Integrated Security=True;Encrypt=False"


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim userid As Integer = TextBox8.Text.ToString()
        Dim FirstN As String = TextBox1.Text.ToString()
        Dim LastN As String = TextBox2.Text.ToString()
        Dim DOB As String = DateTimePicker1.Value.ToString("yyyy-MM-dd")
        Dim address As String = TextBox3.Text.ToString()
        Dim pincode As Integer = TextBox4.Text.ToString()
        Dim phno As String = TextBox5.Text.ToString()
        Dim email As String = TextBox6.Text.ToString()
        Dim passportno As String = TextBox7.Text.ToString()



        ' Define the SQL INSERT statement
        Dim insertStatement As String = "INSERT INTO PassengerDetails (UserId, Firstname, LastName, DateOfBirth, Address, PinCode, PhoneNo, Email, PassportNo) VALUES (@TextBox8, @TextBox1, @TextBox2, @DateTimePicker1, @TextBox3, @TextBox4, @TextBox5, @TextBox6, @TextBox7)"

        Try
            ' Establish a connection to the SQL Server
            Using connection As New SqlConnection(connectionString)
                ' Open the connection
                connection.Open()

                ' Prepare the SQL command
                Using command As New SqlCommand(insertStatement, connection)
                    ' Add parameters to the command
                    command.Parameters.AddWithValue("@TextBox8", userid)
                    command.Parameters.AddWithValue("@TextBox1", FirstN)
                    command.Parameters.AddWithValue("@TextBox2", LastN)
                    command.Parameters.AddWithValue("@DateTimePicker1", DOB)
                    command.Parameters.AddWithValue("@TextBox3", address)
                    command.Parameters.AddWithValue("@TextBox4", pincode)
                    command.Parameters.AddWithValue("@TextBox5", phno)
                    command.Parameters.AddWithValue("@TextBox6", email)
                    command.Parameters.AddWithValue("@TextBox7", passportno)


                    ' Execute the command
                    command.ExecuteNonQuery()

                    ' Display a success message
                    MessageBox.Show("Data saved successfully.")
                End Using
            End Using
        Catch ex As Exception
            ' Display an error message if something went wrong
            MessageBox.Show("Error " & ex.Message)
        End Try

    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Dim box = New Form1
        box.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Dim box = New User_Homepage()
        box.Show()
    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged

    End Sub



    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub Passenger_Details_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged

    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged

    End Sub
End Class