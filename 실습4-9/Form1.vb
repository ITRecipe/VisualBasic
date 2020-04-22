Public Class Form1
    '메시지 상자 사용하기
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("기본 메시지 상자입니다.", vbOKOnly, "메시지 상자")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("작업을 계속할까요?", vbYesNo + vbQuestion, "메시지 상자")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim returnVal As String

        returnVal = MsgBox("작업을 계속할까요?", vbYesNoCancel, "메시지 상자")

        If returnVal = 6 Then

        ElseIf returnVal = 7 Then
            TextBox1.Text = "<아니요>를 눌렀습니다."

        ElseIf returnVal = 2 Then
            TextBox1.Text = "<취소>를 눌렀습니다."
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim returnVal As String

        returnVal = MsgBox(TextBox1.Text & "이 값이 맞습니까?",
                           vbOKCancel)

        If returnVal = vbOK Then
            TextBox1.Text = TextBox1.Text * TextBox1.Text
        End If
    End Sub
End Class
