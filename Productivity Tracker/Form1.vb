Imports System.Net.Security

Public Class Form1
    Dim selectDifficulty As Integer = 1
    Dim ArrayCount As Integer = 0
    Dim TotalScore As Double
    Dim filteredArray(100) As Double
    Dim ScoreList(100) As Double
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

            Select Case DifficultySelector.Text
                Case "Easy"
                    Score = 10
                Case "Medium"
                    Score = 20
                Case "Hard"
                    Score = 30
            End Select

            DayScore = DayCounter.Value * 0.1
            HourScore = HourCounter.Value * 0.01
            Score -= DayScore + HourScore

            ScoreList(ArrayCount) = Score
            ArrayCount += 1
            CheckList.Items.Add(TaskBox.Text & ", " & Math.Round(Score, 2) & " points")
        End If
    End Sub
    Function RemoveZerosFromArray(array As Double()) As Double()
        Return array.Where(Function(ArrayNumber) ArrayNumber <> 0).ToArray()
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CalculateScores()
    End Sub

    Private Sub CalculateTotalScores_Click(sender As Object, e As EventArgs) Handles CalculateTotalScores.Click
        For i As Integer = CheckList.Items.Count - 1 To 0 Step -1
            If CheckList.GetItemChecked(i) Then
                TotalScore += ScoreList(i)
                CheckList.Items.RemoveAt(i)
                PointBox.Text = Math.Round(TotalScore, 2)
                ScoreList(i) = 0
            End If
        Next

        filteredArray = RemoveZerosFromArray(ScoreList)
        ScoreList = RemoveZerosFromArray(filteredArray)
        Array.Copy(ScoreList, filteredArray, ScoreList.Length)
        ReDim ScoreList(100)
        Array.Copy(filteredArray, ScoreList, filteredArray.Length)
        ReDim filteredArray(100)
        ArrayCount = CheckList.Items.Count
    End Sub

End Class
