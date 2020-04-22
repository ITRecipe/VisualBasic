Module Module1
    'Boolean 변수의 선언과 출력
    Sub Main()
        Dim aBool As Boolean
        Dim aInteger As Integer

        Console.WriteLine("aBool = {0}", aBool) 'aBool 변수를 선언만하고 출력을하면 기본값은 1
        aInteger = aBool
        Console.WriteLine("Boolean의 상수값 = {0}", aInteger)

        aBool = Not aBool
        Console.WriteLine("aBool = {0}", aBool)

        aInteger = aBool
        Console.WriteLine("Boolean의 상수값 = {0}", aInteger)
        Console.ReadLine() '화면 멈춤


    End Sub

End Module
