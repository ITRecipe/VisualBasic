Module Module1
    '다른 모듈에서 이름이 같은 변수 선언과 출력
    Dim aPublic As Integer
    Sub Main()  '메인 모듈 선언
        Dim aInt As Integer
        aPublic = 30
        aInt = 50
        Console.WriteLine("aPublic = {0}, aInt = {1}", aPublic, aInt)
        subModule() '서브 모듈 호출

    End Sub

    Sub subModule() '서브 모듈 선언
        Dim aInt As Integer

        aInt = 80 'Main 모둘과 변수명이 같다.
        Console.WriteLine("aPublic = {0}, aInt = {1}", aPublic, aInt)

    End Sub

End Module
