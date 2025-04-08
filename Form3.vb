Imports Microsoft.Data.SqlClient

Public Class Form3

    ' Declare loggedInUserID as a private variable
    Private loggedInUserID As Integer
    ' Method to set the logged-in user ID
    Public Sub SetUserID(userID As Integer)
        loggedInUserID = userID
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form5.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conn As New SqlConnection("Server=GREATNESS;Database=OVS_DB;Integrated Security=True;Trust Server Certificate=True;")

        Try
            ' Load Presidential Candidates
            Dim cmd As New SqlCommand("SELECT Name FROM Candidates WHERE Position='President'", conn)
            conn.Open()
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            While reader.Read()
                cboPresident.Items.Add(reader("Name").ToString())
            End While
            reader.Close()
            conn.Close()

            ' Load Financial Secretary Candidates
            cmd = New SqlCommand("SELECT Name FROM Candidates WHERE Position='Financial Secretary'", conn)
            conn.Open()
            reader = cmd.ExecuteReader()
            While reader.Read()
                cboFinancialSecretary.Items.Add(reader("Name").ToString())
            End While
            reader.Close()
            conn.Close()

        Catch ex As Exception
            MessageBox.Show("Error loading candidates: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub


    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim conn As New SqlConnection("Server=GREATNESS;Database=OVS_DB;Integrated Security=True;Trust Server Certificate=True;")

        Try
            ' Ensure user has selected candidates
            If cboPresident.SelectedItem Is Nothing Or cboFinancialSecretary.SelectedItem Is Nothing Then
                MessageBox.Show("Please select a candidate for both positions.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            ' Retrieve Candidate IDs
            Dim presidentID As Integer = GetCandidateID(cboPresident.SelectedItem.ToString(), "President", conn)
            Dim financialSecID As Integer = GetCandidateID(cboFinancialSecretary.SelectedItem.ToString(), "Financial Secretary", conn)

            ' Ensure valid candidate IDs
            If presidentID = 0 Or financialSecID = 0 Then
                MessageBox.Show("Invalid candidate selection. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            ' Insert vote into the database
            Dim cmd As New SqlCommand("INSERT INTO Votes (UserID, PresidentID, FinancialSecID) VALUES (@UserID, @PresidentID, @FinancialSecID)", conn)
            cmd.Parameters.AddWithValue("@UserID", loggedInUserID) ' No more error, loggedInUserID is now set
            cmd.Parameters.AddWithValue("@PresidentID", presidentID)
            cmd.Parameters.AddWithValue("@FinancialSecID", financialSecID)

            conn.Open()
            cmd.ExecuteNonQuery()
            conn.Close()

            MessageBox.Show("Vote Submitted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error submitting vote: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub


    ' Function to get CandidateID based on Name and Position
    Private Function GetCandidateID(candidateName As String, position As String, conn As SqlConnection) As Integer
        Dim candidateID As Integer = 0
        Try
            Dim cmd As New SqlCommand("SELECT CandidateID FROM Candidates WHERE Name = @Name AND Position = @Position", conn)
            cmd.Parameters.AddWithValue("@Name", candidateName)
            cmd.Parameters.AddWithValue("@Position", position)

            If conn.State <> ConnectionState.Open Then conn.Open()
            Dim result = cmd.ExecuteScalar()
            If result IsNot Nothing Then candidateID = Convert.ToInt32(result)
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Error retrieving candidate ID: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return candidateID
    End Function

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class