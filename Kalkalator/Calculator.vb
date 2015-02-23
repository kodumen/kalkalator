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

    Public Sub SetOperator(op As Operation)
        If pushInput Then
            ' Solve input
            ' "Push" answer to input1
        End If
        Me.op = op
    End Sub


End Class
