Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient

Public Class Form4
    ' Function to establish a database connection
    Private Function GetConnection() As SqlConnection
        Return New SqlConnection("Server=GREATNESS;Database=OVS_DB;Integrated Security=True;Trust Server Certificate=True;")
    End Function

    ' ✅ Form Load - Initialize Candidates and Voters List
    ' ✅ Populate the ComboBox with Positions
    Private Sub PopulatePositions()
        cmbPosition.Items.Clear()
        cmbPosition.Items.Add("PRESIDENT")
        cmbPosition.Items.Add("FINANCIAL SECRETARY")
        cmbPosition.SelectedIndex = 0 ' 👈 Auto-select first item
    End Sub

    ' ✅ Call this function when the form loads
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeListViewColumns()
        PopulatePositions() ' Add this line to populate the combo box
        LoadCandidates()
        LoadVoters()
    End Sub


    ' ✅ Set up ListView Columns Once (Prevent Flickering)
    Private Sub InitializeListViewColumns()
        lvCandidates.View = View.Details
        lvCandidates.Columns.Clear()
        lvCandidates.Columns.Add("Candidate ID", 100, HorizontalAlignment.Left)
        lvCandidates.Columns.Add("Name", 150, HorizontalAlignment.Left)
        lvCandidates.Columns.Add("Position", 120, HorizontalAlignment.Left)

        lvVoter.View = View.Details
        lvVoter.Columns.Clear()
        lvVoter.Columns.Add("User ID", 100, HorizontalAlignment.Left)
        lvVoter.Columns.Add("Username", 150, HorizontalAlignment.Left)
    End Sub

    ' ✅ Load Candidates from Database
    Private Sub LoadCandidates()
        Using conn As SqlConnection = GetConnection()
            Try
                conn.Open()
                Dim query As String = "SELECT CandidateID, Name, Position FROM Candidates"
                Dim cmd As New SqlCommand(query, conn)
                Dim reader As SqlDataReader = cmd.ExecuteReader()

                lvCandidates.Items.Clear()

                While reader.Read()
                    Dim item As New ListViewItem(reader("CandidateID").ToString())
                    item.SubItems.Add(reader("Name").ToString())
                    item.SubItems.Add(reader("Position").ToString())
                    lvCandidates.Items.Add(item)
                End While
                reader.Close()
            Catch ex As Exception
                MessageBox.Show("Error loading candidates: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    ' ✅ Load Voters from Database
    ' ✅ Load Voters from Users Table
    Private Sub LoadVoters()
        Using conn As SqlConnection = GetConnection()
            Try
                conn.Open()
                Dim query As String = "SELECT UserID, Username FROM Users"
                Dim cmd As New SqlCommand(query, conn)
                Dim reader As SqlDataReader = cmd.ExecuteReader()

                lvVoter.Items.Clear()

                While reader.Read()
                    Dim item As New ListViewItem(reader("UserID").ToString())
                    item.SubItems.Add(reader("Username").ToString())
                    lvVoter.Items.Add(item)
                End While
                reader.Close()
            Catch ex As Exception
                MessageBox.Show("Error loading voters: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub


    ' ✅ Add Candidate Button
    Private Sub btnAddCandidate_Click(sender As Object, e As EventArgs) Handles btnAddCandidate.Click
        If String.IsNullOrWhiteSpace(txtName.Text) OrElse cmbPosition.SelectedIndex = -1 Then
            MessageBox.Show("Please enter all candidate details.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If


        Using conn As SqlConnection = GetConnection()
            Try
                conn.Open()

                ' Check if candidate already exists
                Dim checkQuery As String = "SELECT COUNT(*) FROM Candidates WHERE Name = @Name AND Position = @Position"
                Dim checkCmd As New SqlCommand(checkQuery, conn)
                checkCmd.Parameters.AddWithValue("@Name", txtName.Text.Trim())
                checkCmd.Parameters.AddWithValue("@Position", cmbPosition.SelectedItem.ToString())
                Dim count As Integer = CInt(checkCmd.ExecuteScalar())

                If count > 0 Then
                    MessageBox.Show("Candidate already exists!", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If

                ' Insert Candidate
                Dim query As String = "INSERT INTO Candidates (Name, Position) VALUES (@Name, @Position)"
                Dim cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@Name", txtName.Text.Trim())
                cmd.Parameters.AddWithValue("@Position", cmbPosition.SelectedItem.ToString())

                cmd.ExecuteNonQuery()
                MessageBox.Show("Candidate added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadCandidates()
            Catch ex As Exception
                MessageBox.Show("Error adding candidate: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    ' ✅ Edit Candidate Button
    Private Sub btnEditCandidate_Click(sender As Object, e As EventArgs) Handles btnEditCandidate.Click
        If lvCandidates.SelectedItems.Count = 0 Then
            MessageBox.Show("No candidate selected!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim selectedID As String = lvCandidates.SelectedItems(0).Text
        MessageBox.Show("Editing Candidate ID: " & selectedID)

        Using conn As SqlConnection = GetConnection()
            Try
                conn.Open()
                Dim query As String = "UPDATE Candidates SET Name = @Name, Position = @Position WHERE CandidateID = @CandidateID"
                Dim cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@CandidateID", selectedID)
                cmd.Parameters.AddWithValue("@Name", txtName.Text.Trim())
                cmd.Parameters.AddWithValue("@Position", cmbPosition.SelectedItem.ToString())

                cmd.ExecuteNonQuery()
                MessageBox.Show("Candidate updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadCandidates()
            Catch ex As Exception
                MessageBox.Show("Error updating candidate: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    ' ✅ Delete Candidate Button
    Private Sub btnDeleteCandidate_Click(sender As Object, e As EventArgs) Handles btnDeleteCandidate.Click
        If lvCandidates.SelectedItems.Count = 0 Then
            MessageBox.Show("Please select a candidate to delete.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim selectedID As String = lvCandidates.SelectedItems(0).Text
        MessageBox.Show("Deleting Candidate ID: " & selectedID, "Debug Info")

        Dim confirmDelete As DialogResult = MessageBox.Show("Are you sure you want to delete this candidate?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If confirmDelete = DialogResult.Yes Then
            Using conn As SqlConnection = GetConnection()
                Try
                    conn.Open()
                    Dim query As String = "DELETE FROM Candidates WHERE CandidateID = @CandidateID"
                    Dim cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@CandidateID", selectedID)

                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MessageBox.Show("Candidate deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        LoadCandidates()
                    Else
                        MessageBox.Show("Candidate not found in database!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error deleting candidate: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End If
    End Sub
    ' ✅ Logout Button
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim confirmLogout As DialogResult = MessageBox.Show("Are you sure you want to log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If confirmLogout = DialogResult.Yes Then
            Me.Close()
            Form1.Show()
        End If
    End Sub

    ' ✅ Fill TextBox and ComboBox When Selecting a Candidate
    Private Sub lvCandidates_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvCandidates.SelectedIndexChanged
        If lvCandidates.SelectedItems.Count > 0 Then
            Dim selectedItem As ListViewItem = lvCandidates.SelectedItems(0)
            txtName.Text = selectedItem.SubItems(1).Text ' Candidate Name
            cmbPosition.Text = selectedItem.SubItems(2).Text ' Position
        End If
    End Sub

End Class
