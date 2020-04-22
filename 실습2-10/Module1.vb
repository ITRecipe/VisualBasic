Option Explicit Off

Module Module1
    'Option Explicit문의 선언과 출력
    Sub Main()
        Dim aInt As Integer
        'Option Explicit Off를 선언하면 따로 선언(정의)되지 않아도 사용가능 , 확실히 제어해주는 명령 중 하나
        'Option Explicit On을 선언하면 ex) aPublic = 30 으로 선언된 문장이 에러 남.

        aPublic = 30
        aInt = 50
        Console.WriteLine("aPublic = {0}, aInt = {1}", aPublic, aInt)
        Console.ReadLine()

    End Sub

End Module
