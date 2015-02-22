Public Class Form1

    Dim calculator As Calculator

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        calculator = New Calculator()
        calculator.SetDisplay(Textbox_Disp)
    End Sub

    Private Sub Btn_0_Click(sender As Object, e As EventArgs) Handles Btn_0.Click
        calculator.InputButton(Btn_0.Text)
    End Sub

    Private Sub Btn_1_Click(sender As Object, e As EventArgs) Handles Btn_1.Click
        calculator.InputButton(Btn_1.Text)
    End Sub

    Private Sub Btn_2_Click(sender As Object, e As EventArgs) Handles Btn_2.Click
        calculator.InputButton(Btn_2.Text)
    End Sub

    Private Sub Btn_3_Click(sender As Object, e As EventArgs) Handles Btn_3.Click
        calculator.InputButton(Btn_3.Text)
    End Sub

    Private Sub Btn_4_Click(sender As Object, e As EventArgs) Handles Btn_4.Click
        calculator.InputButton(Btn_4.Text)
    End Sub

    Private Sub Btn_5_Click(sender As Object, e As EventArgs) Handles Btn_5.Click
        calculator.InputButton(Btn_5.Text)
    End Sub

    Private Sub Btn_6_Click(sender As Object, e As EventArgs) Handles Btn_6.Click
        calculator.InputButton(Btn_6.Text)
    End Sub

    Private Sub Btn_7_Click(sender As Object, e As EventArgs) Handles Btn_7.Click
        calculator.InputButton(Btn_7.Text)
    End Sub

    Private Sub Btn_8_Click(sender As Object, e As EventArgs) Handles Btn_8.Click
        calculator.InputButton(Btn_8.Text)
    End Sub

    Private Sub Btn_9_Click(sender As Object, e As EventArgs) Handles Btn_9.Click
        calculator.InputButton(Btn_9.Text)
    End Sub

    Private Sub Btn_Point_Click(sender As Object, e As EventArgs) Handles Btn_Point.Click
        calculator.InputButton(Btn_Point.Text)
    End Sub

    Private Sub Btn_Backspace_Click(sender As Object, e As EventArgs) Handles Btn_Backspace.Click
        calculator.BackSpace()
    End Sub

    Private Sub Btn_Plus_Click(sender As Object, e As EventArgs) Handles Btn_Plus.Click
        DoOperation(Kalkalator.Calculator.Operation.Addition)
    End Sub

    Private Sub Btn_Minus_Click(sender As Object, e As EventArgs) Handles Btn_Minus.Click
        DoOperation(Kalkalator.Calculator.Operation.Subtraction)
    End Sub

    Private Sub Btn_Multiply_Click(sender As Object, e As EventArgs) Handles Btn_Multiply.Click
        DoOperation(Kalkalator.Calculator.Operation.Multiplication)
    End Sub

    Private Sub Btn_Divide_Click(sender As Object, e As EventArgs) Handles Btn_Divide.Click
        DoOperation(Kalkalator.Calculator.Operation.Division)
    End Sub

    Private Sub Btn_Equals_Click(sender As Object, e As EventArgs) Handles Btn_Equals.Click
        calculator.SetInputFromDisplay()
        calculator.Solve()
        calculator.GetAnswer()
        calculator.ClearInput()
    End Sub

    ''' <summary>
    ''' Helper function for doing arithmetic operations
    ''' </summary>
    ''' <param name="op"></param>
    ''' <remarks></remarks>
    Private Sub DoOperation(op As Calculator.Operation)
        ' Solve first the previously set operation
        calculator.SetInputFromDisplay()
        calculator.Solve()
        calculator.GetAnswer()
        calculator.SetOperator(op)
        calculator.ClearInput()
    End Sub
End Class
