Public Class frmMain
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        MessageBox.Show("안녕하세요! " & txtName.Text & " 님 " & "오늘도 내일도 많이많이 사랑한답니다♥", "뽀뽀나 좀 해봐라")

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
