using System;
namespace HelloWorld
{
    class Hello
    {
        static void Main()
        {
            //C#에서 출력은 Console.WriteLine을 사용한다. (JAVA의 System.out.println같은 출력)
            Console.WriteLine("Hello World!");

            //Console.Write로도 출력을 할 수 있다. (JAVA의 System.out.print같은 출력)
            Console.WriteLine("Press any key to exit.");
            //ReadKey는 키를 입력받는 함수이다. 키가 입력되기 전까지 프로그램을 정지시켜 프로그램의 종료를 막는다.
            Console.ReadKey();
        }
    }
}