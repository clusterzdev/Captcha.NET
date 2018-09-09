Imports  Captcha.NET
Public Class Form1
        Dim cap as New CaptchaNET
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If textbox1.Text = cap.secret Then
            MsgBox("Correct")
            Else 
                Msgbox("Wrong captcha")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If RadioButton1.Checked = True Then
            cap.GenerateCaptcha(CaptchaNET.difficulty.easy , PictureBox1)
        ElseIf RadioButton2.Checked = True Then
            cap.GenerateCaptcha(CaptchaNET.difficulty.medium , PictureBox1)
        ElseIf RadioButton3.Checked = True Then
            cap.GenerateCaptcha(CaptchaNET.difficulty.hard , PictureBox1)
        End If
    End Sub
End Class
