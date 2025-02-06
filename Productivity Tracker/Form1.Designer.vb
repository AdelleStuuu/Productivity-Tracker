<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        CheckList = New CheckedListBox()
        DifficultySelect = New Button()
        DifficultyCheck = New Label()
        DifficultySelector = New TextBox()
        DayCounter = New NumericUpDown()
        HourCounter = New NumericUpDown()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Button1 = New Button()
        TaskBox = New TextBox()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        Label4 = New Label()
        CalculateTotalScores = New Button()
        PointBox = New TextBox()
        Label5 = New Label()
        Label6 = New Label()
        CType(DayCounter, ComponentModel.ISupportInitialize).BeginInit()
        CType(HourCounter, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' CheckList
        ' 
        CheckList.Font = New Font("High Tower Text", 9F)
        CheckList.FormattingEnabled = True
        CheckList.Location = New Point(106, 304)
        CheckList.Name = "CheckList"
        CheckList.Size = New Size(317, 184)
        CheckList.TabIndex = 0
        ' 
        ' DifficultySelect
        ' 
        DifficultySelect.Font = New Font("High Tower Text", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DifficultySelect.Location = New Point(293, 175)
        DifficultySelect.Name = "DifficultySelect"
        DifficultySelect.Size = New Size(107, 31)
        DifficultySelect.TabIndex = 1
        DifficultySelect.Text = "Select Difficulty "
        DifficultySelect.UseVisualStyleBackColor = True
        ' 
        ' DifficultyCheck
        ' 
        DifficultyCheck.AutoSize = True
        DifficultyCheck.Font = New Font("High Tower Text", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DifficultyCheck.Location = New Point(117, 149)
        DifficultyCheck.Name = "DifficultyCheck"
        DifficultyCheck.Size = New Size(95, 20)
        DifficultyCheck.TabIndex = 3
        DifficultyCheck.Text = "Difficulty:"
        ' 
        ' DifficultySelector
        ' 
        DifficultySelector.BackColor = SystemColors.ControlLightLight
        DifficultySelector.Font = New Font("High Tower Text", 9F)
        DifficultySelector.Location = New Point(218, 144)
        DifficultySelector.Name = "DifficultySelector"
        DifficultySelector.ReadOnly = True
        DifficultySelector.Size = New Size(286, 25)
        DifficultySelector.TabIndex = 4
        ' 
        ' DayCounter
        ' 
        DayCounter.Location = New Point(267, 221)
        DayCounter.Maximum = New Decimal(New Integer() {365, 0, 0, 0})
        DayCounter.Name = "DayCounter"
        DayCounter.Size = New Size(72, 27)
        DayCounter.TabIndex = 5
        ' 
        ' HourCounter
        ' 
        HourCounter.Location = New Point(420, 221)
        HourCounter.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        HourCounter.Name = "HourCounter"
        HourCounter.Size = New Size(64, 27)
        HourCounter.TabIndex = 6
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("High Tower Text", 10.2F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(218, 223)
        Label1.Name = "Label1"
        Label1.Size = New Size(48, 20)
        Label1.TabIndex = 7
        Label1.Text = "Days:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("High Tower Text", 10.2F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(363, 225)
        Label2.Name = "Label2"
        Label2.Size = New Size(54, 20)
        Label2.TabIndex = 8
        Label2.Text = "Hours:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("High Tower Text", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(80, 223)
        Label3.Name = "Label3"
        Label3.Size = New Size(121, 20)
        Label3.TabIndex = 9
        Label3.Text = "Time Alloted:"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(106, 268)
        Button1.Name = "Button1"
        Button1.Size = New Size(317, 30)
        Button1.TabIndex = 10
        Button1.Text = "Add to list "
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TaskBox
        ' 
        TaskBox.Font = New Font("High Tower Text", 9F)
        TaskBox.Location = New Point(218, 106)
        TaskBox.Name = "TaskBox"
        TaskBox.Size = New Size(286, 25)
        TaskBox.TabIndex = 11
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Location = New Point(678, 228)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(250, 125)
        FlowLayoutPanel1.TabIndex = 12
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("High Tower Text", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(34, 107)
        Label4.Name = "Label4"
        Label4.Size = New Size(178, 20)
        Label4.TabIndex = 13
        Label4.Text = "Insert Name of Task:"
        ' 
        ' CalculateTotalScores
        ' 
        CalculateTotalScores.Font = New Font("High Tower Text", 10.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        CalculateTotalScores.Location = New Point(207, 506)
        CalculateTotalScores.Name = "CalculateTotalScores"
        CalculateTotalScores.Size = New Size(121, 30)
        CalculateTotalScores.TabIndex = 14
        CalculateTotalScores.Text = "Calculate Scores"
        CalculateTotalScores.UseVisualStyleBackColor = True
        ' 
        ' PointBox
        ' 
        PointBox.BackColor = Color.Thistle
        PointBox.Font = New Font("High Tower Text", 9F)
        PointBox.Location = New Point(179, 558)
        PointBox.Name = "PointBox"
        PointBox.ReadOnly = True
        PointBox.Size = New Size(275, 25)
        PointBox.TabIndex = 15
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("High Tower Text", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(59, 559)
        Label5.Name = "Label5"
        Label5.Size = New Size(114, 20)
        Label5.TabIndex = 16
        Label5.Text = "Total Points:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Freestyle Script", 30F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = SystemColors.ActiveCaptionText
        Label6.Location = New Point(106, 34)
        Label6.Name = "Label6"
        Label6.Size = New Size(321, 59)
        Label6.TabIndex = 17
        Label6.Text = "Productivity Tracker"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightPink
        ClientSize = New Size(534, 629)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(PointBox)
        Controls.Add(CalculateTotalScores)
        Controls.Add(Label4)
        Controls.Add(FlowLayoutPanel1)
        Controls.Add(TaskBox)
        Controls.Add(Button1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(HourCounter)
        Controls.Add(DayCounter)
        Controls.Add(DifficultySelector)
        Controls.Add(DifficultyCheck)
        Controls.Add(DifficultySelect)
        Controls.Add(CheckList)
        Name = "Form1"
        Text = "Productivity Tracker"
        CType(DayCounter, ComponentModel.ISupportInitialize).EndInit()
        CType(HourCounter, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents CheckList As CheckedListBox
    Friend WithEvents DifficultySelect As Button
    Friend WithEvents DifficultyCheck As Label
    Friend WithEvents DifficultySelector As TextBox
    Friend WithEvents DayCounter As NumericUpDown
    Friend WithEvents HourCounter As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TaskBox As TextBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Label4 As Label
    Friend WithEvents CalculateTotalScores As Button
    Friend WithEvents PointBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label

End Class
