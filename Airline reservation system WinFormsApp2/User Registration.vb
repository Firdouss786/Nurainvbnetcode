Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.VisualBasic.ApplicationServices


Public Class User_Registration


    ' Define your SQL connection string
    Dim connectionString As String = "Data Source=localhost\SQLEXPRESS;Initial Catalog=AirlineReservationSystem;Integrated Security=True;Encrypt=False"

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim username As String = TextBox1.Text.ToString()
        Dim pass As String = TextBox2.Text.ToString()
        Dim FirstN As String = TextBox3.Text.ToString()
        Dim LastN As String = TextBox4.Text.ToString()
        Dim email As String = TextBox5.Text.ToString()
        Dim role As String = TextBox6.Text.ToString()


        ' Define the SQL INSERT statement
        Dim insertStatement As String = "INSERT INTO Userlogin (Username, Password, FirstName, LastName, Email, Role) VALUES (@TextBox1, @TextBox2, @TextBox3, @TextBox4, @TextBox5, @TextBox6)"

        Try
            ' Establish a connection to the SQL Server
            Using connection As New SqlConnection(connectionString)
                ' Open the connection
                connection.Open()

                ' Prepare the SQL command
                Using command As New SqlCommand(insertStatement, connection)
                    ' Add parameters to the command
                    command.Parameters.AddWithValue("@TextBox1", username)
                    command.Parameters.AddWithValue("@TextBox2", pass)
                    command.Parameters.AddWithValue("@TextBox3", FirstN)
                    command.Parameters.AddWithValue("@TextBox4", LastN)
                    command.Parameters.AddWithValue("@TextBox5", email)
                    command.Parameters.AddWithValue("@TextBox6", role)

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




    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Dim box = New Form1()
        box.Show()
    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged_1(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged

    End Sub
End Class