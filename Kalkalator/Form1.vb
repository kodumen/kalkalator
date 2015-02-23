Public Class Form1

    Dim calculator As Calculator

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        calculator = New Calculator()
    End Sub

    Private Sub Btn_0_Click(sender As Object, e As EventArgs) Handles Btn_0.Click
        calculator.PressNumButton(Btn_0.Text)
        Textbox_Disp.Text = calculator.GetInputString()
    End Sub

    Private Sub Btn_1_Click(sender As Object, e As EventArgs) Handles Btn_1.Click
        calculator.PressNumButton(Btn_1.Text)
        Textbox_Disp.Text = calculator.GetInputString()
    End Sub

    Private Sub Btn_2_Click(sender As Object, e As EventArgs) Handles Btn_2.Click
        calculator.PressNumButton(Btn_2.Text)
        Textbox_Disp.Text = calculator.GetInputString()
    End Sub

    Private Sub Btn_3_Click(sender As Object, e As EventArgs) Handles Btn_3.Click
        calculator.PressNumButton(Btn_3.Text)
        Textbox_Disp.Text = calculator.GetInputString()
    End Sub

    Private Sub Btn_4_Click(sender As Object, e As EventArgs) Handles Btn_4.Click
        calculator.PressNumButton(Btn_4.Text)
        Textbox_Disp.Text = calculator.GetInputString()
    End Sub

    Private Sub Btn_5_Click(sender As Object, e As EventArgs) Handles Btn_5.Click
        calculator.PressNumButton(Btn_5.Text)
        Textbox_Disp.Text = calculator.GetInputString()
    End Sub

    Private Sub Btn_6_Click(sender As Object, e As EventArgs) Handles Btn_6.Click
        calculator.PressNumButton(Btn_6.Text)
        Textbox_Disp.Text = calculator.GetInputString()
    End Sub

    Private Sub Btn_7_Click(sender As Object, e As EventArgs) Handles Btn_7.Click
        calculator.PressNumButton(Btn_7.Text)
        Textbox_Disp.Text = calculator.GetInputString()
    End Sub

    Private Sub Btn_8_Click(sender As Object, e As EventArgs) Handles Btn_8.Click
        calculator.PressNumButton(Btn_8.Text)
        Textbox_Disp.Text = calculator.GetInputString()
    End Sub

    Private Sub Btn_9_Click(sender As Object, e As EventArgs) Handles Btn_9.Click
        calculator.PressNumButton(Btn_9.Text)
        Textbox_Disp.Text = calculator.GetInputString()
    End Sub

    Private Sub DoOperation(op As Calculator.Operation)
        calculator.SetOperation(op)
        calculator.ClearInputString()
        Textbox_Disp.Text = calculator.GetAnswer()
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
        Textbox_Disp.Text = calculator.Solve()
        calculator.ClearInputString()
    End Sub
End Class
