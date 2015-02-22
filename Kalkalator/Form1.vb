Public Class Form1

    Dim calculator As Calculator

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        calculator = New Calculator()
        calculator.SetDisplay(Textbox_Disp)
    End Sub

    Private Sub Btn_0_Click(sender As Object, e As EventArgs) Handles Btn_0.Click
<<<<<<< HEAD
        calculator.InputNumber(Btn_0.Text)
    End Sub

    Private Sub Btn_1_Click(sender As Object, e As EventArgs) Handles Btn_1.Click
        calculator.InputNumber(Btn_1.Text)
    End Sub

    Private Sub Btn_2_Click(sender As Object, e As EventArgs) Handles Btn_2.Click
        calculator.InputNumber(Btn_2.Text)
    End Sub

    Private Sub Btn_3_Click(sender As Object, e As EventArgs) Handles Btn_3.Click
        calculator.InputNumber(Btn_3.Text)
    End Sub

    Private Sub Btn_4_Click(sender As Object, e As EventArgs) Handles Btn_4.Click
        calculator.InputNumber(Btn_4.Text)
    End Sub

    Private Sub Btn_5_Click(sender As Object, e As EventArgs) Handles Btn_5.Click
        calculator.InputNumber(Btn_5.Text)
    End Sub

    Private Sub Btn_6_Click(sender As Object, e As EventArgs) Handles Btn_6.Click
        calculator.InputNumber(Btn_6.Text)
    End Sub

    Private Sub Btn_7_Click(sender As Object, e As EventArgs) Handles Btn_7.Click
        calculator.InputNumber(Btn_7.Text)
    End Sub

    Private Sub Btn_8_Click(sender As Object, e As EventArgs) Handles Btn_8.Click
        calculator.InputNumber(Btn_8.Text)
    End Sub

    Private Sub Btn_9_Click(sender As Object, e As EventArgs) Handles Btn_9.Click
        calculator.InputNumber(Btn_9.Text)
    End Sub

    Private Sub Btn_Point_Click(sender As Object, e As EventArgs) Handles Btn_Point.Click
        calculator.InputNumber(Btn_Point.Text)
=======
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
>>>>>>> reCalc
    End Sub
End Class
