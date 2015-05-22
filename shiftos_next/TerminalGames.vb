Module TerminalGames

    Public mathquiz As Boolean = False
    Public guessthenumber As Boolean = False

    Public Sub MQInterpret(question As String, answer As Integer)
        Dim random As New Random()
        Dim args() As String = question.Replace("What is ", "").Split(" ")
        Select Case args(1)
            Case "+"
                If answer = args(0) + args(2) Then
                    Dim cptoadd As Integer = random.Next(1, 5)
                    AddLine("Correct! You have earned " & cptoadd & " Codepoints!")
                    AddCP(cptoadd)
                Else
                    AddLine("Incorrect! Better luck next time...")
                End If
            Case "-"
                If answer = args(0) - args(2) Then
                    Dim cptoadd As Integer = random.Next(1, 5)
                    AddLine("Correct! You have earned " & cptoadd & " Codepoints!")
                    AddCP(cptoadd)
                Else
                    AddLine("Incorrect! Better luck next time...")
                End If
            Case "*"
                If answer = args(0) * args(2) Then
                    Dim cptoadd As Integer = random.Next(1, 5)
                    AddLine("Correct! You have earned " & cptoadd & " Codepoints!")
                    AddCP(cptoadd)
                Else
                    AddLine("Incorrect! Better luck next time...")
                End If
            Case "/"
                If answer = args(0) / args(2) Then
                    Dim cptoadd As Integer = random.Next(1, 5)
                    AddLine("Correct! You have earned " & cptoadd & " Codepoints!")
                    AddCP(cptoadd)
                Else
                    AddLine("Incorrect! Better luck next time...")
                End If
        End Select
        MQCreateQuestion()
    End Sub

    Public Sub MQCreateQuestion()
        Dim rand As New Random
        Dim num1 As Integer = rand.Next(1, 10)
        Dim num2 As Integer = rand.Next(1, 10)
        Dim operandchooser As Integer = rand.Next(1, 4)
        Dim operand As String
        Select Case operandchooser
            Case 1
                operand = " + "
            Case 2
                While num2 > num1
                    num2 = rand.Next(1, 10)
                End While
                operand = " - "
            Case 3
                operand = " * "
            Case 4
                operand = " / "
            Case Else
                operand = " + "
        End Select
        AddLine("What is " & num1 & operand & num2 & " ?")
    End Sub

    Public Sub changeinterpreter()
        If mathquiz = True Then
            AddLine(" === MathQuiz ===" & vbNewLine)
            AddLine("MathQuiz is a basic game for ShiftOS that allows you to earn Codepoints for solving math " & vbNewLine & "questions. These questions will always be (num1) (operand) (num2) = (answer)." & vbNewLine)
            AddLine("(num1) and (num2) will always be integers between 1 and 10.")
            AddLine("(operand) Will always be either a +, -, * (times) or / (division) statement that can change the answer.")
            MQCreateQuestion()
        End If
        If guessthenumber = True Then
            AddLine(" -= Guess The Number =-" & vbNewLine)
            AddLine("Guess the Number is a game that allows you to earn Codepoints for")
            AddLine("guessing a number between 1 and 100." & vbNewLine)
            GTNStart()
        End If
    End Sub

    Public GTNCorrect As Integer

    Public Sub GTNStart()
        Dim rand As New Random()
        GTNCorrect = rand.Next(1, 100)
        AddLine("Choose a number between 1 and 100:")
    End Sub

    Public Sub GTNInterpret(num As Integer)
        If num < 100 And num > 0 Then
            If GTNCorrect = num Then
                Dim rand As New Random()
                Dim cptoadd As Integer = rand.Next(1, 10)
                AddLine("Correct! You have earned " & cptoadd & " Codepoints.")
                GTNStart()
            ElseIf num > GTNCorrect Then
                AddLine("Lower!")
            ElseIf num < GTNCorrect Then
                AddLine("Higher!")
            End If
        Else
            AddLine("Number isn't between 1 and 100!")
        End If
    End Sub
End Module
