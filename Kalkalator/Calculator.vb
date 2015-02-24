' Does all the calculations.
Public Class Calculator
    Public Enum Operation As Byte
        None
        Addition
        Subtraction
        Multiplication
        Division
    End Enum
    Dim input0 As Double ' Answer is stored here as well
    Dim input1 As Double
    Dim inputStr As String
    Dim isOnInput0 As Boolean
    Dim op As Operation

    Public Sub New()
        Reset()
    End Sub

    Public Sub Reset()
        input0 = 0
        input1 = 0
        isOnInput0 = True
        inputStr = ""
        op = Operation.Addition
    End Sub

    Public Sub SetInput(input As Double)
        If isOnInput0 Then
            input0 = input
        Else
            input1 = input
        End If
    End Sub

    Public Sub SetOperation(op As Operation)
        If isOnInput0 Then
            input1 = input0
        Else
            Solve()
        End If
        isOnInput0 = False
        Me.op = op
    End Sub

    Public Function Solve() As Double
        Dim answer As Double
        If op.Equals(Calculator.Operation.Addition) Then
            answer = input0 + input1
        ElseIf op.Equals(Calculator.Operation.Subtraction) Then
            answer = input0 - input1
        ElseIf op.Equals(Calculator.Operation.Multiplication) Then
            answer = input0 * input1
        ElseIf op.Equals(Calculator.Operation.Division) Then
            answer = input0 / input1
        End If
        input0 = answer
        isOnInput0 = True
        Solve = answer
    End Function

    ''' <summary>
    ''' Get the answer without having to calculate again.
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetAnswer() As Double
        GetAnswer = input1
    End Function

    ' Mimics numerical button presses. Concatenates string input. Use ClearInputString() to reset.
    ' Automatically calls SetInput().
    Public Sub PressNumButton(str As String)
        If IsNumeric(str) Then
            If inputStr.Equals("0") Then
                inputStr = str
            Else
                inputStr &= str
            End If
            SetInput(inputStr)
        ElseIf str.Equals(".") And Not inputStr.Contains(".") Then
            If inputStr.Equals("") Then
                inputStr &= "0."
            Else
                inputStr &= str
            End If
            SetInput(inputStr)
        End If
    End Sub

    ' Mimics the function of a pressed backspace button. That is, remove the last character in the input.
    ' Automatically sets the string as input
    Public Sub PressBackspace()
        If inputStr.Length.Equals(1) Then
            inputStr = "0"
            SetInput(inputStr)
        ElseIf inputStr.Length > 0 Then
            inputStr = inputStr.Remove(inputStr.Length - 1, 1)
            SetInput(inputStr)
        End If
    End Sub

    Public Sub ClearInputString()
        inputStr = ""
    End Sub

    Public Function GetInputString() As String
        GetInputString = inputStr
    End Function
End Class
