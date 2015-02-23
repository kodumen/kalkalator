' Does all the calculations and
' other calculator functions such as displaying text.

Public Class Calculator
    Dim input0 As Double
    Dim input1 As Double
    Dim answer As Double        ' Store answer here
    Dim isInput0Empty As Boolean

    ''' <summary>
    ''' Store input number in the currently empty input variable.
    ''' Use SetOperator() to lock the input and store in another variable.
    ''' </summary>
    ''' <param name="input"></param>
    ''' <remarks></remarks>
    Public Sub SetInput(input As Double)
        If isInput0Empty Then
            input0 = input
        Else
            input1 = input
        End If
    End Sub
End Class
