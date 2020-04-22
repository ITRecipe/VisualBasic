Public Class Form1
    'MsgBox 함수의 선언과 출력
    Private Sub Form1_Click(sender As Object, e As EventArgs) Handles Me.Click
        Dim msg As String

        msg = MsgBox("빨강 선택함?", vbYesNo, "질문")

        If msg = vbYes Then
            MsgBox("빨강 선택",, "답변")
        Else
            MsgBox("파랑 선택",, "답변")
        End If

    End Sub
End Class
