Module Module1
    'Object 변수의 선언과 출력 , Object 변수는 포괄적인 개념
    Sub Main()
        Dim onObject, offObject As Object

        onObject = 1234
        Console.WriteLine("Object(integer) = {0}", onObject)

        onObject = 1234.5678
        Console.WriteLine("Object(single) = {0}", onObject)

        onObject = "가나다라"
        Console.WriteLine("Object(string) = {0}", onObject)

        offObject = Today()
        Console.WriteLine("Object(date) = {0}", offObject)
        Console.ReadLine() '화면을 멈춤

    End Sub

End Module
