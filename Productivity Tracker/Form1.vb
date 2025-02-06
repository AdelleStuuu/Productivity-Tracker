Imports System.Net.Security

Public Class Form1
    'declare all public variables 
    Dim selectDifficulty As Integer = 1
    Dim ArrayCount As Integer = 0
    Dim TotalScore As Double
    Dim filteredArray(100) As Double
    Dim ScoreList(100) As Double
    Private Sub DifficultySelect_Click(sender As Object, e As EventArgs) Handles DifficultySelect.Click
        'select case chooses a string for difficulty based on button tap
        'increment one to move difficulty level 
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
        'check for errors 
        If DifficultySelector.Text = "" Then
            MsgBox("Error, No difficulty settings")
        ElseIf DayCounter.Value = 0 And HourCounter.Value = 0 Then
            MsgBox("Error, No Deadline")
        ElseIf TaskBox.Text = "" Then
            MsgBox("Error, No Task")
        Else
            'variable declaraion
            Dim Score As Double
            Dim DayScore As Double
            Dim HourScore As Double
            'check if difficult is easy, medium or hard, assign base scores depending on difficulty
            Select Case DifficultySelector.Text
                Case "Easy"
                    Score = 10
                Case "Medium"
                    Score = 20
                Case "Hard"
                    Score = 30
            End Select

            'calculate scores by this formula 
            'score =  difficulty - (10% of Days + 1% of hours)
            DayScore = DayCounter.Value * 0.1
            HourScore = HourCounter.Value * 0.01
            Score -= DayScore + HourScore

            Dim day As String
            Dim hour As String

            'check if the value is 1, if it is, word must be singular
            If DayCounter.Value = 1 Then
                day = "Day"
            Else
                day = "Days"
            End If

            If HourCounter.Value = 1 Then
                hour = "Hour"
            Else
                hour = "Hours"
            End If


            'add score value to an array and increment by 1
            ScoreList(ArrayCount) = Score
            ArrayCount += 1
            'add all values in check list 
            CheckList.Items.Add(TaskBox.Text & ", must be done in: " & DayCounter.Value & " " & day & ", " & HourCounter.Value & " " & hour & ", " & Math.Round(Score, 2) & " points")
        End If
    End Sub
    Function RemoveZerosFromArray(array As Double()) As Double()
        'remove zeroes from the old array and add non zeroes to new array
        Return array.Where(Function(ArrayNumber) ArrayNumber <> 0).ToArray()
    End Function

    'call subroutine CalculateScores
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CalculateScores()
    End Sub

    Private Sub CalculateTotalScores_Click(sender As Object, e As EventArgs) Handles CalculateTotalScores.Click
        'for loop that checks all checked boxes and adds their point value to total score
        'checked box is removed soon after 
        'current index of array is set to 0 for future deletion
        For i As Integer = CheckList.Items.Count - 1 To 0 Step -1
            If CheckList.GetItemChecked(i) Then
                TotalScore += ScoreList(i)
                CheckList.Items.RemoveAt(i)
                PointBox.Text = Math.Round(TotalScore, 2)
                ScoreList(i) = 0
            End If
        Next
        'declare function 'RemoveZeroesFromArray'
        filteredArray = RemoveZerosFromArray(ScoreList)
        ScoreList = RemoveZerosFromArray(filteredArray)
        'reset the positions of the array by moving scorelist content to filteredArray, redeclaring and vice versa
        Array.Copy(ScoreList, filteredArray, ScoreList.Length)
        ReDim ScoreList(100)
        Array.Copy(filteredArray, ScoreList, filteredArray.Length)
        ReDim filteredArray(100)
        'set array count to current number of checklist 
        ArrayCount = CheckList.Items.Count
    End Sub

End Class
