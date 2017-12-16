using System;

public class If
{
    // if문은 ~하면 ~한다라는 조건이 맞으면 해당하는 코드를 실행시키는 조건문이다.
    public void Main()
    {
        int n = 10;

        // if문의 구조는 if(boolean) {실행 내용} 이다.
        // boolean이 true라면 if 문 안의 내용이 실행된다.
        if (n < 5)
        {
            Console.WriteLine("n은 5보다 작다.");
        }
        if (5 < n && n < 15)
        {
            Console.WriteLine("n은 5보다 크고 15보다 작다.");
        }

        // 실행할 코드가 한줄이라면 중괄호를 사용하지 않고 if 문 뒤에 붙여 한줄로 쓸 수 있다.
        if (n < 5) Console.WriteLine("n은 5보다 작다.\n");
        if (5 < n && n < 15) Console.WriteLine("n은 5보다 크고 15보다 작다.\n");

        // else if를 이용해 여러 조건마다 실행되는 내용이 다르게 할 수 있다.
        // else if문은 앞에 있는 if문의 조건에 true가 아니고 else if 문의 조건에 true 일 때 실행된다.
        // else if 문은 여러개를 붙여 사용할 수 있다.
        if (n < 5) Console.WriteLine("n은 5보다 작다.");
        else if (n < 10) Console.WriteLine("n은 5와 같거나 크고 10보다 작다.");
        else if (n < 15) Console.WriteLine("n은 10과 같거나 크고 15보다 작다.");

        // else문은 if문과 else if문의 조건에 모두 맞지 않을 때 실행된다.
        n = 100;
        if (n < 5) Console.WriteLine("n은 5보다 작다.");
        else if (n < 10) Console.WriteLine("n은 5와 같거나 크고 10보다 작다.");
        else if (n < 15) Console.WriteLine("n은 10과 같거나 크고 15보다 작다.");
        else Console.WriteLine("n은 15와 같거나 크다.");
    }
}
