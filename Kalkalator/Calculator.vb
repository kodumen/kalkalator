' Does all the calculations.
Public Class Calculator
    Public Enum Operation As Byte
        None
        Addition
        Subtraction
        Multiplication
        Division
    End Enum
    Dim input As Double
    Dim answer As Double

    Public Sub SetInput(input As Double)
        Me.input = input
    End Sub
End Class
