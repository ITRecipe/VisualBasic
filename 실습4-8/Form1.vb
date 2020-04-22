Public Class Form1
    '버튼으로 MsgBox 함수의 선언과 출력
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("안녕?", vbExclamation + vbOKOnly, "메시지 박스")
    End Sub
End Class
