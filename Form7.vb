Imports Microsoft.Data.SqlClient
Imports BCrypt.Net

Public Class Form7
    ' ✅ Your database connection string
    Private ReadOnly connectionString As String = "Server=GREATNESS;Database=OVS_DB;Integrated Security=True;Trust Server Certificate=True;"

    ' 🔹 Button to hash and update passwords
    Private Sub btnUpdatePasswords_Click(sender As Object, e As EventArgs) Handles btnUpdatePasswords.Click
        Try
            Using con As New SqlConnection(connectionString)
                con.Open()

                ' Select all admins and their plain-text passwords (ensure we don't rehash already hashed passwords)
                Dim selectQuery As String = "SELECT AdminUsername, Password FROM Admins WHERE LEN(Password) < 60"
                Dim updateQuery As String = "UPDATE Admins SET Password = @hashedPassword WHERE AdminUsername = @username"

                Using selectCmd As New SqlCommand(selectQuery, con)
                    Using reader As SqlDataReader = selectCmd.ExecuteReader()
                        Dim updates As New List(Of Tuple(Of String, String))()

                        ' Read existing passwords and hash them
                        While reader.Read()
                            Dim username As String = reader("AdminUsername").ToString()
                            Dim plainPassword As String = reader("Password").ToString()

                            ' Ensure password isn't already hashed
                            If Not plainPassword.StartsWith("$2a$") Then
                                ' ✅ Hash the password
                                Dim hashedPassword As String = BCrypt.Net.BCrypt.HashPassword(plainPassword, 12)

                                ' Store updates in a list (to avoid modifying the table while reading)
                                updates.Add(Tuple.Create(username, hashedPassword))
                            End If
                        End While
                        reader.Close()

                        ' Apply the updates after reading is complete
                        For Each updateItem In updates
                            Using updateCmd As New SqlCommand(updateQuery, con)
                                updateCmd.Parameters.AddWithValue("@hashedPassword", updateItem.Item2)
                                updateCmd.Parameters.AddWithValue("@username", updateItem.Item1)
                                updateCmd.ExecuteNonQuery()
                            End Using
                        Next
                    End Using
                End Using

                MessageBox.Show("Passwords updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using
        Catch ex As Exception
            MessageBox.Show("Error updating passwords: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' 🔹 Button to close the form
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
