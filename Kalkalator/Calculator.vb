' Does all the calculations.
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
    Dim pushInput As Boolean
    Dim op As Operation

    Public Sub SetInput(input As Double)
        input0 = input
        pushInput = True
    End Sub

    Public Sub SetOperation(op As Operation)
        If pushInput Then
            ' Solve input
            ' "Push" answer to input1
            input1 = Solve()
            pushInput = False
        End If
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
        Solve = answer
    End Function


End Class
