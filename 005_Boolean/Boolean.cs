using System;
public class Boolean
{
    // Boolean은 어떤 것이 참(true)인지, 거짓(false)인지 판단하는 것이다.
    // 나중에 if문과 for문을 사용하기 위해 필요하니 알아보자.
    static void Main()
    {
        // 보통 if문과 for문에서 관계 연산자(<, <=, >, >=, ==, !=)를 사용한다.
        // 관계 연산자는 수학의 부등호와 같다. (but ==는 두 값이 같을 때, !=는 두 값이 다를 때 true이다.)
        Console.WriteLine("10 < 20: " + (10 < 20));
        Console.WriteLine("10 <= 20: " + (10 <= 20));
        Console.WriteLine("10 > 20: " + (10 > 20));
        Console.WriteLine("10 >= 20: " + (10 >= 20));
        Console.WriteLine("10 == 20: " + (10 == 20));
        Console.WriteLine("10 != 20: " + (10 != 20));

        // 논리 연산자는 두 boolean 값을 묶어 이 것이 true인지 false인지 구분하는 것이다.
        // 논리 연산자에는 ||, &&, ^, ! 가 있다.

        // ||는 OR 연산이라고 한다. 두 식중 하나라도 true라면 true를 반환한다.
        Console.WriteLine("\ntrue || true: " + (true || true));
        Console.WriteLine("true || false: " + (true || false));
        Console.WriteLine("false || true: " + (false || true));
        Console.WriteLine("false || false: " + (false || false));

        // &&는 AND 연산이라고 한다. 두 식 다 true라면 true를 반환한다.
        Console.WriteLine("\ntrue && true: " + (true && true));
        Console.WriteLine("true && false: " + (true && false));
        Console.WriteLine("false && true: " + (false && true));
        Console.WriteLine("false && false: " + (false && false));

        // ^는 XOR 연산이라고 한다. 두 식 중 한 식만 true라면 true를 반환한다.
        Console.WriteLine("\ntrue ^ true: " + (true ^ true));
        Console.WriteLine("true ^ false: " + (true ^ false));
        Console.WriteLine("false ^ true: " + (false ^ true));
        Console.WriteLine("false ^ false: " + (false ^ false));

        // !는 NOT 연산이라고 한다. true라면 false로, false라면 true로 반전시킨다.
        Console.WriteLine("\n!true: " + !true);
        Console.WriteLine("!false: " + !false);

        // 이 관계 연산자와 논리 연산자를 이용하여 복잡한 boolean이 참인지 거짓인지 알 수 있다.
        // 예를 들어 n이라는 정수가 3과 5의 배수이면서 2의 배수가 아닌지 확인해보자.
        int n = 30;
        Console.WriteLine("\nn(30)은 3과 5의 배수이면서 2의 배수가 아닌가?: " + (n % 3 == 0 && n % 5 == 0 && !(n % 2 == 0)));
        n = 15;
        Console.WriteLine("n(15)은 3과 5의 배수이면서 2의 배수가 아닌가?: " + (n % 3 == 0 && n % 5 == 0 && !(n % 2 == 0)));
        n = 10;
        Console.WriteLine("n은(10) 3과 5의 배수이면서 2의 배수가 아닌가?: " + (n % 3 == 0 && n % 5 == 0 && !(n % 2 == 0)));

        Console.ReadKey();
    }

}