Module Module1

    Sub Main()
        Console.WriteLine("좋아하는 프로그램을 입력후 엔터를 누를것!")
        Dim language As String
        language = Console.ReadLine() '콘솔에서 입력을 기다림
        language = language.ToUpper '소문자가 입력되면 대문자로 바뀜
        If language = "VISUAL BASIC" Or
            language = "VB" Or
            language = "VB.NET" Then
            Console.WriteLine("아주 좋다!")
        Else
            Console.WriteLine(language & "는 비주얼 베이직이 아님")
        End If
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine("엔터를 누르면 프로그램 종료")
        Console.ReadLine() '화면을 멈춤

    End Sub
End Module
