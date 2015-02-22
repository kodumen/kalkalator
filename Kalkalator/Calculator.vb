' Does all the calculations and
' other calculator functions such as displaying text.

Public Class Calculator

    Dim history As String
    Dim answer As Double
    Dim input As Double
    Dim display As TextBox
    Dim clearDisplay As Boolean

    ' Set default values
    Sub New()
        history = Nothing
        answer = Nothing
        input = Nothing
        display = Nothing
        clearDisplay = True ' Clear the display when DisplayText() is first called
    End Sub

    Public Sub SetDisplay(display As TextBox)
        Me.display = display
    End Sub

    Public Function GetDisplayInput() As String
        GetDisplayInput = display.Text
    End Function

    ' Display the string specified on the display
    ' If an operator was previously used, the whole display text is replaced
    ' Otherwise, the input string is concatenated
    Private Sub DisplayInput(stringInput As String)
        ' This prevents having more than one decimal point on the input
        If stringInput.Contains(".") And display.Text.Contains(".") Then
            Return
        End If

        ' Prevent display from concatenating when it's only zero
        ' Appending the literal type character C to a single-character string literal forces it to the Char data type.
        ' Source: https://msdn.microsoft.com/en-us/library/7sx7t66b.aspx?f=255&MSPPError=-2147217396
        If stringInput.First().Equals("0"c) And display.Text.Equals("0") Then
            Return
        End If

        If clearDisplay Then
            If display.Text.Equals("0") And stringInput.First().Equals("."c) Then
                display.Text &= stringInput
            Else
                display.Text = stringInput
            End If
        Else
            display.Text &= stringInput
        End If

        ' Stop display from clearing
        clearDisplay = False
    End Sub

    ' Update the numerical input variable
    ' If a display is set, display the string as well
    Public Sub InputNumber(inputString As String)
        If Not IsNothing(display) Then
            DisplayInput(inputString)
            inputString = display.Text
        End If
        input = Double.Parse(inputString)
    End Sub

End Class
