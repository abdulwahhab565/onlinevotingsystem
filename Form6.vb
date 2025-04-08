Imports Microsoft.Data.SqlClient
Imports BCrypt.Net

Public Class Form6
    ' Connection string
    Private ReadOnly connectionString As String = "Server=GREATNESS;Database=OVS_DB;Integrated Security=True;Trust Server Certificate=True;"

    ' Event handler for admin login
    Private Sub btnAdminLogin_Click(sender As Object, e As EventArgs) Handles btnAdminLogin.Click
        Dim username As String = txtAdminID.Text.Trim()
        Dim password As String = txtAdminPassword.Text.Trim()

        ' Ensure fields are not empty
        If String.IsNullOrWhiteSpace(username) OrElse String.IsNullOrWhiteSpace(password) Then
            MessageBox.Show("Please enter both username and password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            ' Authenticate user
            If AuthenticateAdmin(username, password) Then
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Form4.Show()
                Me.Hide()
            Else
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Function to authenticate admin login
    Private Function AuthenticateAdmin(username As String, password As String) As Boolean
        Dim query As String = "SELECT Password FROM Admins WHERE AdminUsername = @username"
        Dim hashedPassword As String = ""

        Using con As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@username", username.Trim())
                con.Open()
                Dim result = cmd.ExecuteScalar()
                con.Close()

                If result IsNot Nothing Then
                    hashedPassword = result.ToString()
                Else
                    Return False ' User not found
                End If
            End Using
        End Using

        ' Verify the password with BCrypt
        Return BCrypt.Net.BCrypt.Verify(password, hashedPassword)
    End Function

    ' Close button event
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    ' Open Password Update Form (Form7)


    'Private Sub btnOpenPasswordUpdate_Click(sender As Object, e As EventArgs) Handles btnOpenPasswordUpdate.Click
    ' Check if user is authorized
    'If txtAdminID.Text <> "AdminSCH_EC" Then ' Ensure the username is correct
    '  MessageBox.Show("Unauthorized access!", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '  Return
    ' End If

    ' Check if Form7 is already open

    ' Dim existingForm As Form7 = Application.OpenForms().OfType(Of Form7)().FirstOrDefault()
    '  If existingForm IsNot Nothing Then
    '      existingForm.BringToFront()
    'Else
    ' Dim passwordUpdateForm As New Form7()
    'passwordUpdateForm.Show()
    ' End If
    ' End Sub
End Class
