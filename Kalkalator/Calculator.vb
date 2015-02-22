' Does all the calculations and
' other calculator functions such as displaying text.

Public Class Calculator
    Public Enum Operation As Byte
        Addition
        Subtraction
        Multiplication
        Division
    End Enum
    Dim history As String
    Dim answer As Double
    Dim input As Double
    Dim strInput As String
    Dim display As TextBox
    Dim clearDisplay As Boolean
    Dim arOperation As Operation

    ' Set default values
    Sub New()
        history = Nothing
        answer = 0
        input = Nothing
        strInput = "0"
        display = Nothing
        clearDisplay = True ' Clear the display when DisplayText() is first called
        arOperation = Operation.Addition
    End Sub

    Public Sub SetDisplay(display As TextBox)
        Me.display = display
    End Sub

    Public Function GetDisplayInput() As String
        GetDisplayInput = display.Text
    End Function

    Public Sub SetInput(input As Double)
        Me.input = input
    End Sub

    ''' <summary>
    ''' Display the string input the Textbox set with SetDisplay().
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub DisplayToTextBox()
        If Not IsNothing(display) Then
            display.Text = strInput
        End If

    End Sub

    ''' <summary>
    ''' Add a numerical string to the string input and displays it.
    ''' If no TextBox is set via SetDisplay(), nothing will be displayed.
    ''' </summary>
    ''' <param name="btn">The value of the button pressed</param>
    ''' <remarks></remarks>
    Public Sub InputButton(btn As String)
        If Not IsNumeric(btn) Then
            ' Logic for non-numerical input
            If btn.Equals(".") Then
                If Not strInput.Contains(".") Then
                    strInput &= btn
                End If

            End If

        Else
            ' btn is numeric
            If strInput.Equals("0") Then
                btn = btn.TrimStart("0")
                If Not btn.Equals("") Then
                    strInput = ""   ' clear "0" first before concatenating to it
                End If
            End If
            strInput &= btn
        End If
        DisplayToTextBox()
    End Sub

    ''' <summary>
    ''' Remove the last character of the string input.
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub BackSpace()
        If strInput.Length.Equals(1) Then
            strInput = "0"
        Else
            strInput = strInput.Remove(strInput.Length - 1, 1)
        End If
        DisplayToTextBox()
    End Sub

    Public Sub SetOperator(op As Operation)
        arOperation = op
    End Sub
End Class
