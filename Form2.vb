Imports Microsoft.Data.SqlClient

Public Class Form2
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim conn As New SqlConnection("Server=GREATNESS;Database=OVS_DB;Integrated Security=True;Trust Server Certificate=True;")
        Dim cmd As New SqlCommand("SELECT UserID FROM Users WHERE Username = @Username AND Password = @Password", conn)
        cmd.Parameters.AddWithValue("@Username", txtUsername.Text)
        cmd.Parameters.AddWithValue("@Password", txtPassword.Text) ' Ensure hashing is used for real apps

        Try
            conn.Open()
            Dim result As Object = cmd.ExecuteScalar()
            If result IsNot Nothing Then
                ' Store the UserID in Form3 before opening it
                Dim userID As Integer = Convert.ToInt32(result)
                Dim votingForm As New Form3()
                votingForm.SetUserID(userID) ' Pass the User ID
                votingForm.Show()
                Me.Hide() ' Hide login form
            Else
                MessageBox.Show("Invalid credentials.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click
        Form6.Show()
        Me.Hide()
    End Sub


End Class
