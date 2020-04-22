Module Module1
    '모듈 밖에서 같은 이름변수의 선언과 출력
    Dim aPublic As Integer '모듈 변수 선언
    Public aInt As Integer = 10 '전역 변수 선언

    Sub Main()
        Dim aInt As Integer 'aInt 지역 변수 선언 -> 우선
        '모듈밖에서 선언한 aInt 변수보다 모듈 안쪽 프로시저 영역에 선언한 aInt 지역변수가 더 우선순위가 높
        aPublic = 30
        aInt = 50
        Console.WriteLine("aPublic = {0}, aInt = {1}", aPublic, aInt)
        Console.ReadLine() '화면 멈춤
    End Sub

End Module
