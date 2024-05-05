Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Add_Flight
    Dim connectionString As String = "Data Source=localhost\SQLEXPRESS;Initial Catalog=AirlineReservationSystem;Integrated Security=True;Encrypt=False"


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim FlightId As String = TextBox1.Text.ToString()
        Dim FlightName As String = TextBox3.Text.ToString()
        Dim LeavingFrom As String = TextBox4.Text.ToString()
        Dim GoingTo As String = TextBox5.Text.ToString()
        Dim DepartureDate As String = TextBox6.Text.ToString()
        Dim DepartureTime As String = TextBox7.Text.ToString()
        Dim Price As String = TextBox8.Text.ToString()





        ' Define the SQL INSERT statement
        Dim insertStatement As String = "INSERT INTO FlightDetails (FlightId, FlightName, LeavingFrom, GoingTo, DepartureDate, DepartureTime, Price) VALUES (@TextBox1, @TextBox3, @TextBox4, @TextBox5, @TextBox6, @TextBox7, @TextBox8)"

        Try
            ' Establish a connection to the SQL Server
            Using connection As New SqlConnection(connectionString)
                ' Open the connection
                connection.Open()

                ' Prepare the SQL command
                Using command As New SqlCommand(insertStatement, connection)
                    ' Add parameters to the command

                    command.Parameters.AddWithValue("@TextBox1", FlightId)
                    command.Parameters.AddWithValue("@TextBox3", FlightName)
                    command.Parameters.AddWithValue("@TextBox4", LeavingFrom)
                    command.Parameters.AddWithValue("@TextBox5", GoingTo)
                    command.Parameters.AddWithValue("@TextBox6", DepartureDate)
                    command.Parameters.AddWithValue("@TextBox7", DepartureTime)
                    command.Parameters.AddWithValue("@TextBox8", Price)



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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Dim box = New Form1()
        box.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Dim box = New Admin_menu()
        box.Show()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged

    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged

    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged

    End Sub
End Class