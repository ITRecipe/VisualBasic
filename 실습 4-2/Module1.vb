Module Module1
    '형 변환 메소드의 선언과 출력
    Sub Main()
        Dim decimalVal As Decimal
        Dim doubleVal As Double
        Dim integerVal As Integer
        Dim charVal As Char
        Dim boolVal As Boolean
        Dim StringVal As String = "123.456"
        Dim StringVal2 As String = "123456"

        decimalVal = Convert.ToDecimal(StringVal)
        Console.WriteLine("The string as a decimal is {0}.", decimalVal)

        doubleVal = Convert.ToDouble(StringVal)
        Console.WriteLine _
            ("The string as a double is {0}.", doubleVal)

        integerVal = Convert.ToInt32(StringVal2)
        Console.WriteLine("The string as a integer is {0}.", integerVal)

        StringVal2 = "1"
        charVal = Convert.ToChar(StringVal2)
        Console.WriteLine("The string as a char is {0}.", charVal)

        StringVal2 = "True"
        boolVal = Convert.ToBoolean(StringVal2)
        Console.WriteLine("The string as a bool is {0}.", boolVal)

        StringVal2 = Convert.ToString(StringVal)
        Console.WriteLine("The decimal as a string is {0}.", StringVal2)

        doubleVal = Double.Parse(StringVal2)
        Console.WriteLine("The decimal as a string is {0}.", doubleVal)

        Console.ReadLine()
    End Sub

End Module
