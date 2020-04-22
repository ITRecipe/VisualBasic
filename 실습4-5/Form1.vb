Public Class Form1
    'MsgBox 함수의 선언과 출력
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim msg, button, title As String

        msg = "MsgBox의 기호 상수를 나타낸다." &
            Chr(10) & "줄이 바뀜"   '& _ Chr(10) :줄바꿈 ASCII 코드

        button = vbYesNoCancel + vbInformation

        title = "MsgBox 함수"

        MsgBox(msg, button, title)

    End Sub
End Class
