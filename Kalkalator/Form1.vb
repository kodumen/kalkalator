﻿Public Class Form1

    Dim calculator As Calculator

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        calculator = New Calculator()
        Textbox_Disp.Text = calculator.GetInput().ToString()
    End Sub

    Private Sub PressButton(str As String)
        calculator.PressNumButton(str)
        Textbox_Disp.Text = calculator.GetInputString()
    End Sub

    Private Sub Btn_0_Click(sender As Object, e As EventArgs) Handles Btn_0.Click
        PressButton(Btn_0.Text)
    End Sub

    Private Sub Btn_1_Click(sender As Object, e As EventArgs) Handles Btn_1.Click
        PressButton(Btn_1.Text)
    End Sub

    Private Sub Btn_2_Click(sender As Object, e As EventArgs) Handles Btn_2.Click
        PressButton(Btn_2.Text)
    End Sub

    Private Sub Btn_3_Click(sender As Object, e As EventArgs) Handles Btn_3.Click
        PressButton(Btn_3.Text)
    End Sub

    Private Sub Btn_4_Click(sender As Object, e As EventArgs) Handles Btn_4.Click
        PressButton(Btn_4.Text)
    End Sub

    Private Sub Btn_5_Click(sender As Object, e As EventArgs) Handles Btn_5.Click
        PressButton(Btn_5.Text)
    End Sub

    Private Sub Btn_6_Click(sender As Object, e As EventArgs) Handles Btn_6.Click
        PressButton(Btn_6.Text)
    End Sub

    Private Sub Btn_7_Click(sender As Object, e As EventArgs) Handles Btn_7.Click
        PressButton(Btn_7.Text)
    End Sub

    Private Sub Btn_8_Click(sender As Object, e As EventArgs) Handles Btn_8.Click
        PressButton(Btn_8.Text)
    End Sub

    Private Sub Btn_9_Click(sender As Object, e As EventArgs) Handles Btn_9.Click
        PressButton(Btn_9.Text)
    End Sub

    Private Sub Btn_Point_Click(sender As Object, e As EventArgs) Handles Btn_Point.Click
        PressButton(Btn_Point.Text)
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

    Private Sub Btn_Backspace_Click(sender As Object, e As EventArgs) Handles Btn_Backspace.Click
        calculator.PressBackspace()
        Textbox_Disp.Text = calculator.GetInput().ToString()
        'Dim inputStr As String
        'inputStr = calculator.GetInputString()
        'If Not inputStr.Equals("") Then
        '    Textbox_Disp.Text = inputStr
        'End If
    End Sub

    Private Sub Btn_CE_Click(sender As Object, e As EventArgs) Handles Btn_CE.Click
        calculator.ClearInputString()
        calculator.SetInput(0)
        Textbox_Disp.Text = "0"
    End Sub

    Private Sub Btn_C_Click(sender As Object, e As EventArgs) Handles Btn_C.Click
        calculator.Reset()
        Textbox_Disp.Text = "0"
    End Sub

    Private Sub Btn_Sign_Click(sender As Object, e As EventArgs) Handles Btn_Sign.Click
        calculator.Negate()
        Textbox_Disp.Text = calculator.GetInput().ToString()
    End Sub

    Private Sub Btn_Sqrt_Click(sender As Object, e As EventArgs) Handles Btn_Sqrt.Click
        calculator.SquareRoot()
        Textbox_Disp.Text = calculator.GetInput()
        calculator.ClearInputString()
    End Sub

    Private Sub Btn_Percent_Click(sender As Object, e As EventArgs) Handles Btn_Percent.Click
        calculator.Percent()
        Textbox_Disp.Text = calculator.GetInput()
        calculator.ClearInputString()
    End Sub

    Private Sub Btn_Reciprocal_Click(sender As Object, e As EventArgs) Handles Btn_Reciprocal.Click
        calculator.Reciprocal()
        Textbox_Disp.Text = calculator.GetInput()
        calculator.ClearInputString()
    End Sub
End Class
