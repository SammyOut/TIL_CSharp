using System;
public class For
{
    // for문은 코드를 반복 실행하는 반복문이다.
    static void Main()
    {
        // for문의 구조는 for(초기식; 조건식; 증감식) {실행 내용} 이다.
        // for문의 작동 순서는 초기식 -> 조건식이 true라면 -> 실행 내용 -> 증감식 -> 조건식 -> 실행내용...
        // 조건식을 비교하였을 때 false라면 실행 내용을 실행하지 않고 for문을 종료한다.
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine();

        // if문 처럼 실행 내용이 한 줄이라면 for() 실행내용; 으로 간단하게 쓸 수 있다.
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine();

        // for문와 if문을 이용하여 1부터 20까지 수 중에 짝수를 출력하는 코드를 짜보자
        for (int i = 1; i <= 20; i++)
        {
            if (i % 2 == 0) Console.WriteLine(i);
        }

        Console.ReadKey();
    }
}