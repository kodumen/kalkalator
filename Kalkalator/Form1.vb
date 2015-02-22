Public Class Form1

    Private Sub AboutCalculatorToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub NumBox_TextChanged(sender As Object, e As EventArgs) Handles Textbox_Disp.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn_Plus.Click

    End Sub

    Private Sub Btn_0_Click(sender As Object, e As EventArgs) Handles Btn_0.Click
        DisplayButtonText(Btn_0.Text)
    End Sub

    Private Sub Btn_1_Click(sender As Object, e As EventArgs) Handles Btn_1.Click
        DisplayButtonText(Btn_1.Text)
    End Sub

    Private Sub Btn_2_Click(sender As Object, e As EventArgs) Handles Btn_2.Click
        DisplayButtonText(Btn_2.Text)
    End Sub

    Private Sub Btn_3_Click(sender As Object, e As EventArgs) Handles Btn_3.Click
        DisplayButtonText(Btn_3.Text)
    End Sub

    Private Sub Btn_4_Click(sender As Object, e As EventArgs) Handles Btn_4.Click
        DisplayButtonText(Btn_4.Text)
    End Sub

    Private Sub Btn_5_Click(sender As Object, e As EventArgs) Handles Btn_5.Click
        DisplayButtonText(Btn_5.Text)
    End Sub

    Private Sub Btn_6_Click(sender As Object, e As EventArgs) Handles Btn_6.Click
        DisplayButtonText(Btn_6.Text)
    End Sub

    Private Sub Btn_7_Click(sender As Object, e As EventArgs) Handles Btn_7.Click
        DisplayButtonText(Btn_7.Text)
    End Sub

    Private Sub Btn_8_Click(sender As Object, e As EventArgs) Handles Btn_8.Click
        DisplayButtonText(Btn_8.Text)
    End Sub

    Private Sub Btn_9_Click(sender As Object, e As EventArgs) Handles Btn_9.Click
        DisplayButtonText(Btn_9.Text)
    End Sub

    Private Sub DisplayButtonText(buttonText As String)
        If Textbox_Disp.Text = "0" Then
            Textbox_Disp.Text = buttonText
        Else
            Textbox_Disp.Text &= buttonText
            'Ampersand for contatination
        End If

    End Sub

    Private Sub Btn_Backspace_Click(sender As Object, e As EventArgs) Handles Btn_Backspace.Click
        Dim strDisplayText = Textbox_Disp.Text

        If strDisplayText.Length = 1 Then
            Textbox_Disp.Text = "0"
        Else
            strDisplayText = strDisplayText.Remove(strDisplayText.Length - 1)
            Textbox_Disp.Text = strDisplayText
        End If

    End Sub

    Private Sub Btn_Point_Click(sender As Object, e As EventArgs) Handles Btn_Point.Click
        If Textbox_Disp.Text = "0" Then
            Textbox_Disp.Text = "0."
        End If
        If Not Textbox_Disp.Text.Contains(".") Then
            DisplayButtonText(Btn_Point.Text)
        End If
    End Sub
End Class
