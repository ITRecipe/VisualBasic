Public Class Form1
    'PDF 코드 잘못됨 동영상 코드를 입력해야 실행됨
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Kor, Eng, Mat, Total As Integer

        Kor = TextBox1.Text
        Eng = TextBox2.Text
        Mat = TextBox3.Text
        Total = Kor + Eng + Mat
        Label5.Text = Total
    End Sub
End Class
