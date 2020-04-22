Module Module1
    '서식 메소드의 선언과 출력
    Sub Main()
        Dim decimalVal As Decimal
        Dim doubleVal As Double
        Dim integerVal As Integer
        Dim charVal As Char
        Dim boolVal As Boolean
        Dim StringVal As String = "123.456"
        Dim StringVal2 As String = "123456"

        decimalVal = Convert.ToDecimal(stringVal)
        Console.WriteLine("The string as a decimal is {0}.", decimalVal)

        doubleVal = Convert.ToDouble(stringVal)
        Console.WriteLine _
            ("The string as a double is {0}.", doubleVal)

        integerVal = Convert.ToInt32(stringVal2)
        Console.WriteLine("The string as a integer is {0}.", integerVal)

        StringVal2 = "1"
        CharVal = Convert.ToChar(StringVal2)
        Console.WriteLine("The string as a char is {0}.", charVal)

        stringVal2 = "True"
        boolVal = Convert.ToBoolean(stringVal2)
        Console.WriteLine("The string as a bool is {0}.", boolVal)

        stringVal2 = Convert.ToString(stringVal)
        Console.WriteLine("The string as a string is {0}.", stringVal2)

        doubleVal = Double.Parse(stringVal2)
        Console.WriteLine("The deciimal as a string is {0}.", doubleVal)

        Console.ReadLine()
    End Sub

End Module
