Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Search_Flight
    Dim connectionString As String = "Data Source=localhost\SQLEXPRESS;Initial Catalog=AirlineReservationSystem;Integrated Security=True;Encrypt=False"


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim userid As String = TextBox1.Text.ToString()
        Dim LeavingFrom As String = TextBox2.Text.ToString()
        Dim GoingTo As String = TextBox3.Text.ToString()
        Dim DepartureDate As String = DateTimePicker1.Value.ToString("yyyy-MM-dd")



        Dim query As String = "SELECT * FROM FlightDetails WHERE 1=1"

        If Not String.IsNullOrEmpty(userid) Then
            query &= " AND userid = @UserId"
        End If

        If Not String.IsNullOrEmpty(LeavingFrom) Then
            query &= " AND LeavingFrom = @LeavingFrom"
        End If

        If Not String.IsNullOrEmpty(GoingTo) Then
            query &= " AND GoingTo = @GoingTo"
        End If

        If Not String.IsNullOrEmpty(DepartureDate) Then
            query &= " AND DepartureDate = @DepartureDate"
        End If


        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@UserId", userid)
                    command.Parameters.AddWithValue("@LeavingFrom", LeavingFrom)
                    command.Parameters.AddWithValue("@GoingTo", GoingTo)
                    command.Parameters.AddWithValue("@DepartureDate", DepartureDate)


                    Using reader As SqlDataReader = command.ExecuteReader()
                        ' Iterate through the results and do something with them
                        While reader.Read()
                            ' Example: Display the results in a MessageBox
                            MessageBox.Show($"Flight: {reader("FlightName")}, Departure Date: {reader("DepartureDate").ToString()}")
                        End While
                    End Using

                   
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

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

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub
End Class