Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Book_Flight
    ' Define your SQL connection string
    Dim connectionString As String = "Data Source=localhost\SQLEXPRESS;Initial Catalog=AirlineReservationSystem;Integrated Security=True;Encrypt=False"


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim userid As Integer = TextBox7.Text.ToString()
        Dim FlightId As String = TextBox1.Text.ToString()
        Dim FlightName As String = TextBox2.Text.ToString()
        Dim LeavingFrom As String = TextBox3.Text.ToString()
        Dim GoingTo As String = TextBox4.Text.ToString()
        Dim DepartureDate As String = DateTimePicker1.Value.ToString("yyyy-MM-dd")
        Dim DepartureTime As String = DateTimePicker2.Value.ToString("yyyy-MM-dd")
        Dim Price As String = TextBox6.Text.ToString()



        ' Define the SQL INSERT statement
        Dim insertStatement As String = "INSERT INTO FlightDetails (UserId, FlightId, FlightName, LeavingFrom, GoingTo, DepartureDate, DepartureTime, Price) VALUES (@TextBox7, @TextBox1, @TextBox2, @TextBox3, @TextBox4, @DateTimePicker1,  @DateTimePicker2, @TextBox6)"
        Dim inserttosearch As String = "INSERT INTO SearchBookFlight (UserId, FlightId, FlightName, LeavingFrom, GoingTo, DepartureDate, DepartureTime, Price) VALUES (@TextBox7, @TextBox1, @TextBox2, @TextBox3, @TextBox4, @DateTimePicker1,  @DateTimePicker2, @TextBox6)"

        Try
            ' Establish a connection to the SQL Server
            Using connection As New SqlConnection(connectionString)
                ' Open the connection
                connection.Open()

                ' Prepare the SQL command
                Using command As New SqlCommand(insertStatement, connection)
                    ' Add parameters to the command
                    command.Parameters.AddWithValue("@TextBox7", userid)
                    command.Parameters.AddWithValue("@TextBox1", FlightId)
                    command.Parameters.AddWithValue("@TextBox2", FlightName)
                    command.Parameters.AddWithValue("@TextBox3", LeavingFrom)
                    command.Parameters.AddWithValue("@TextBox4", GoingTo)
                    command.Parameters.AddWithValue("@DateTimePicker1", DepartureDate)
                    command.Parameters.AddWithValue("@DateTimePicker2", DepartureTime)
                    command.Parameters.AddWithValue("@TextBox6", Price)



                    ' Execute the command
                    command.ExecuteNonQuery()

                    ' Display a success message
                    MessageBox.Show("Data saved successfully.")
                End Using

                ' Prepare the SQL command
                Using command As New SqlCommand(inserttosearch, connection)
                    ' Add parameters to the command
                    command.Parameters.AddWithValue("@TextBox7", userid)
                    command.Parameters.AddWithValue("@TextBox1", FlightId)
                    command.Parameters.AddWithValue("@TextBox2", FlightName)
                    command.Parameters.AddWithValue("@TextBox3", LeavingFrom)
                    command.Parameters.AddWithValue("@TextBox4", GoingTo)
                    command.Parameters.AddWithValue("@DateTimePicker1", DepartureDate)
                    command.Parameters.AddWithValue("@DateTimePicker2", DepartureTime)
                    command.Parameters.AddWithValue("@TextBox6", Price)



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
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Dim box = New Form1
        box.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Dim box = New User_Homepage()
        box.Show()
    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Book_Flight_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub
End Class