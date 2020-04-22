Module Module1
    'Date 변수의 선언과 출력
    Sub Main()
        'dateA,dateB,dateC,dateD,dateE를 Date형 변수로 선언
        Dim dateA, dateB, dateC, dateD, dateE As Date

        dateA = #4/15/2019#     'dateA에 값 #4/15/2019#을 대입
        dateB = "2019-04-15"    'dateB에 값 "2019-04-15"을 대입
        dateC = "4/15/2019"     'dateC에 값 "4/15/2019"을 대입

        dateD = #4/15/2019 5:23:05 PM#
        dateE = Today() 'Today() : 오늘 날짜를 출력하는 메소드 , 시스템상의 걸쳐 있는 날짜 및 시간대를 자동으로 뿌려줌

        Console.WriteLine("sdateA [{0}]", dateA)
        Console.WriteLine("sdateB [{0}]", dateB)
        Console.WriteLine("sdateC [{0}]", dateC)
        Console.WriteLine("sdateD [{0}]", dateD)
        Console.WriteLine("sdateE [{0}]", dateE)

        Console.ReadLine() '화면 멈춤
    End Sub

End Module