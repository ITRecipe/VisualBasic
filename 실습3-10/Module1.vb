Module Module1
    '2개 프로시저에서 상수의 선언과 출력

    'GWAMOK 이라는 상수를 정수형으로 선언하며 값에 2를 대입
    Private Const GWAMOK As Integer = 2

    Public gi_sum As Integer    'gi_Sum 변수를 정수형으로 선언
    Public gi_avg As Integer    'gi_Avg 변수를 정수형으로 선언

    Sub Main()
        'Eng를 정수형 변수로 선언하면서 초기값을 지정
        Dim Eng As Integer = 80
        Dim Kor As Integer  'Kor_Sum을 정수형 변수로 선언
        Kor = 90    'Kor 변수에 값 90 대입.

        'Sum 변수에 Kor값과 Eng값을 더한 값을 대입.
        gi_sum = Kor + Eng

        Sub_Avg()   '평균값을 구하는 procedure를 호출

        Console.WriteLine("국어:{0}, 영어:{1}, 합계:{2}",
            Kor, Eng, gi_sum)
        Console.ReadLine()
    End Sub

    Sub Sub_Avg()
        Dim Kor As Integer = 70 'Kor 변수에 값 70 대입
        Dim Eng As Integer = 60 'Eng 변수에 값 60 대입

        'gi_Sum 변수에 kor값과 Eng값을 더한 값을 대입
        gi_sum = Kor + Eng

        'gi_Avg에 gI_Sum 값을 GWAMOK을 나눈 몫의 값을 대입
        gi_avg = gi_sum \ GWAMOK
        Console.WriteLine("합계 : {0},평균 : {1}", gi_sum, gi_avg)
    End Sub
End Module
