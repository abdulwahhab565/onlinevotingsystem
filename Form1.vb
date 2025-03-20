Imports System.Data.SqlClient

Public Class Form1
    Private conn As New SqlConnection("your_connection_string_here")

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadResults()
    End Sub

    Private Sub LoadResults()
        Try
            conn.Open()

            ' Query to get the results
            Dim query As String = "SELECT position, candidate_name, COUNT(*) AS total_votes 
                                   FROM votes 
                                   GROUP BY position, candidate_name 
                                   ORDER BY position, total_votes DESC"

            Dim cmd As New SqlCommand(query, conn)
            Dim reader As SqlDataReader = cmd.ExecuteReader()

            ' Variables to store candidate names and votes
            Dim president1 As String = "", president2 As String = ""
            Dim sec1 As String = "", sec2 As String = ""
            Dim presVotes1 As Integer = 0, presVotes2 As Integer = 0
            Dim secVotes1 As Integer = 0, secVotes2 As Integer = 0

            While reader.Read()
                Dim pos As String = reader("position").ToString()
                Dim name As String = reader("candidate_name").ToString()
                Dim votes As Integer = Convert.ToInt32(reader("total_votes"))

                If pos = "Presidential" Then
                    If president1 = "" Then
                        president1 = name
                        presVotes1 = votes
                    Else
                        president2 = name
                        presVotes2 = votes
                    End If
                ElseIf pos = "Secretary" Then
                    If sec1 = "" Then
                        sec1 = name
                        secVotes1 = votes
                    Else
                        sec2 = name
                        secVotes2 = votes
                    End If
                End If
            End While

            reader.Close()
            conn.Close()

            ' Display results on the form
            can1.Text = president1 & " - " & presVotes1 & " Votes"
            can2.Text = president2 & " - " & presVotes2 & " Votes"
            can1s.Text = sec1 & " - " & secVotes1 & " Votes"
            can2s.Text = sec2 & " - " & secVotes2 & " Votes"

            ' Total votes display
            tvote.Text = "Total Votes: " & (presVotes1 + presVotes2)
            tvotes.Text = "Total Votes: " & (secVotes1 + secVotes2)

            ' Determine and display winners
            If presVotes1 > presVotes2 Then
                winner.Text = "Winner: " & president1
            ElseIf presVotes2 > presVotes1 Then
                winner.Text = "Winner: " & president2
            Else
                winner.Text = "Tie Between " & president1 & " and " & president2
            End If

            If secVotes1 > secVotes2 Then
                winners.Text = "Winner: " & sec1
            ElseIf secVotes2 > secVotes1 Then
                winners.Text = "Winner: " & sec2
            Else
                winners.Text = "Tie Between " & sec1 & " and " & sec2
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
End Class
