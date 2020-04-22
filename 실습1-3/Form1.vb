Public Class frmMain
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtOutput.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles cmdInput.Click
        Dim strHello As String '스트링형으로 strHello 라는 변수 선언
        strHello = " 안녕하세요? " + txtInput.Text + " 님 "
        txtOutput.Text = strHello

    End Sub
End Class
