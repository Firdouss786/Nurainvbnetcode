Imports System.Data.SqlClient

Public Class Delete_Flight

    Dim connectionString As String = "Data Source=localhost\SQLEXPRESS;Initial Catalog=AirlineReservationSystem;Integrated Security=True;Encrypt=False"

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim FlightId As String = TextBox1.Text.ToString()

        ' Define the SQL INSERT statement
        Dim query As String = "DELETE FROM FlightDetails WHERE FlightId = @FlightId"

        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Using command As New SqlCommand(query, connection)
                    ' Add parameter for the flight ID
                    command.Parameters.AddWithValue("@FlightId", FlightId)

                    ' Execute the command
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("Flight details deleted successfully.")
                    Else
                        MessageBox.Show("No flight details deleted.")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Dim box = New Form1
        box.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Dim box = New Admin_menu()
        box.Show()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub



    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs)

    End Sub
End Class