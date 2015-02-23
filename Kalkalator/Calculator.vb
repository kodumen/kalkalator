﻿' Does all the calculations.
Public Class Calculator
    Public Enum Operation As Byte
        None
        Addition
        Subtraction
        Multiplication
        Division
    End Enum
    Dim input0 As Double    ' Input buffer. All input goes here first.
    Dim input1 As Double    ' Input gets "pushed" here.
    Dim inputStr As String
    Dim pushInput As Boolean
    Dim op As Operation

    Public Sub New()
        input0 = 0
        input1 = 0
        pushInput = False
        inputStr = ""
        op = Operation.Addition
    End Sub

    Public Sub SetInput(input As Double)
        input0 = input
        pushInput = True
    End Sub

    Public Sub SetOperation(op As Operation)
        If pushInput Then
            ' Solve input
            ' "Push" answer to input1
            Solve()
            pushInput = False
        End If
        Me.op = op
    End Sub

    Public Function Solve() As Double
        Dim answer As Double
        If op.Equals(Calculator.Operation.Addition) Then
            answer = input1 + input0
        ElseIf op.Equals(Calculator.Operation.Subtraction) Then
            answer = input1 - input0
        ElseIf op.Equals(Calculator.Operation.Multiplication) Then
            answer = input1 * input0
        ElseIf op.Equals(Calculator.Operation.Division) Then
            answer = input1 / input0
        End If
        input1 = answer
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
            inputStr &= str
        End If
        SetInput(inputStr)
    End Sub

    Public Sub ClearInputString()
        inputStr = ""
    End Sub

    Public Function GetInputString() As String
        GetInputString = inputStr
    End Function
End Class
