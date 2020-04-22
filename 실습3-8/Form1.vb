Public Class Form1
    'Static 변수의 선언과 결과 값 확인
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form1_Click(sender As Object, e As EventArgs) Handles Me.Click
        Static intValue As Integer
        intValue = intValue + 1 '변수의 연산
        MessageBox.Show("intValue 값은 " & intValue)
    End Sub
End Class
