Imports Microsoft.Data.SqlClient

Public Class Form5
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conn As New SqlConnection("Server=GREATNESS;Database=OVS_DB;Integrated Security=True;Trust Server Certificate=True;")

        ' Ensure ListView is set to Details view
        lvResults.View = View.Details
        lvResults.Columns.Clear()
        lvResults.Columns.Add("Candidate Name", 200, HorizontalAlignment.Left)
        lvResults.Columns.Add("Vote Count", 100, HorizontalAlignment.Center)

        ' Queries for Presidential and Financial Secretary votes
        Dim cmdPresident As New SqlCommand("SELECT Candidates.Name, COUNT(*) AS VoteCount 
                                         FROM Votes 
                                         JOIN Candidates ON Votes.PresidentID = Candidates.CandidateID 
                                         GROUP BY Candidates.Name 
                                         ORDER BY VoteCount DESC", conn)

        Dim cmdSecretary As New SqlCommand("SELECT Candidates.Name, COUNT(*) AS VoteCount 
                                     FROM Votes 
                                     JOIN Candidates ON Votes.FinancialSecID = Candidates.CandidateID 
                                     GROUP BY Candidates.Name 
                                     ORDER BY VoteCount DESC", conn)


        Try
            conn.Open()
            Dim reader As SqlDataReader

            ' Clear ListView before adding new results
            lvResults.Items.Clear()

            ' Add header for Presidential Candidates
            Dim headerPresident As New ListViewItem("PRESIDENTIAL CANDIDATES")
            headerPresident.Font = New Font(lvResults.Font, FontStyle.Bold)
            lvResults.Items.Add(headerPresident)

            ' Load Presidential Candidates
            reader = cmdPresident.ExecuteReader()
            Dim firstPres As Boolean = True ' Track first candidate (winner)

            While reader.Read()
                Dim item As New ListViewItem(reader("Name").ToString())
                item.SubItems.Add(reader("VoteCount").ToString() & " Votes")
                lvResults.Items.Add(item)

                ' First candidate in sorted order is the winner
                If firstPres Then
                    lblPresWinner.Text = "Presidential Winner: " & reader("Name").ToString()
                    firstPres = False
                End If
            End While
            reader.Close()

            ' Add a blank row for spacing
            lvResults.Items.Add(New ListViewItem(""))

            ' Add header for Financial Secretary Candidates
            Dim headerSecretary As New ListViewItem("FINANCIAL SECRETARY CANDIDATES")
            headerSecretary.Font = New Font(lvResults.Font, FontStyle.Bold)
            lvResults.Items.Add(headerSecretary)

            ' Load Financial Secretary Candidates
            reader = cmdSecretary.ExecuteReader()
            Dim firstSec As Boolean = True ' Track first candidate (winner)

            While reader.Read()
                Dim item As New ListViewItem(reader("Name").ToString())
                item.SubItems.Add(reader("VoteCount").ToString() & " Votes")
                lvResults.Items.Add(item)

                ' First candidate in sorted order is the winner
                If firstSec Then
                    lblSecWinner.Text = "Financial Secretary Winner: " & reader("Name").ToString()
                    firstSec = False
                End If
            End While
            reader.Close()

        Catch ex As Exception
            MessageBox.Show("Error loading election results: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub
End Class