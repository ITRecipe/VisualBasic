Public Class Form1
    'InputBox 명령 혁신의 선언과 출력
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim Message, Title, MyValue

        Message = "임의의 값을 입력 해라"

        Title = "InputBox Demo"

        MyValue = InputBox(Message, Title)

        If MyValue = "" Then
            MsgBox("입력된 값 없음!",
            vbExclamation + vbOKOnly, "오류")
        Else
            MsgBox("입력 값은 " + MyValue + "이다!",
                vbInformation + vbOKOnly, "입력")
        End If

    End Sub
End Class
