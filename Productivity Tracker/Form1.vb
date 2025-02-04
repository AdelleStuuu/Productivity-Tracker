Imports System.Net.Security

Public Class Form1
    Dim selectDifficulty As Integer = 1

    Private Sub DifficultySelect_Click(sender As Object, e As EventArgs) Handles DifficultySelect.Click

        Select Case selectDifficulty
            Case 1
                DifficultySelector.Text = "Easy"
                selectDifficulty += 1
            Case 2
                DifficultySelector.Text = "Medium"
                selectDifficulty += 1
            Case 3
                DifficultySelector.Text = "Hard"
                selectDifficulty = 1
        End Select
    End Sub

    Public Sub CalculateScores()
        If DifficultySelector.Text = "" Then
            MsgBox("Error, No difficulty settings")
        ElseIf DayCounter.Value = 0 And HourCounter.Value = 0 Then
            MsgBox("Error, No Deadline")
        ElseIf TaskBox.Text = "" Then
            MsgBox("Error, No Task")
        Else
            Dim Score As Double
            Dim DayScore As Double
            Dim HourScore As Double

            If DifficultySelector.Text = "Easy" Then
                Score = 10
            ElseIf DifficultySelector.Text = "Medium" Then
                Score = 20
            ElseIf DifficultySelector.Text = "Hard" Then
                Score = 30
            End If

            DayScore = DayCounter.Value * 0.1
            HourScore = HourCounter.Value * 0.01
            Score -= DayScore + HourScore

            CheckList.Items.Add(TaskBox.Text & ", " & Math.Round(Score, 2) & " points")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CalculateScores()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles CalculateTotalScores.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
