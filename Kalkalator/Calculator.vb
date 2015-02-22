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



End Class
