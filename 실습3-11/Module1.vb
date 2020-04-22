'전역 또는 지역상수의 선언과 출력
Module Module1
    Const _x As Integer = 1000 '전역상수
    Sub Main()
        '상수는 Function 또는 Sub 프로시저에서 사용
        Const name As String = "홍길동"  '지역 상수

        Console.WriteLine(" 이름 = {0} ", name)
        Console.WriteLine(" _x = {0} ", _x)

        Console.ReadLine()
    End Sub

End Module
