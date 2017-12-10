using System;

public class Array
{
    // 배열(Array)은 비슷한 역할을 하는 변수끼리 묶어 사용하기 편하게 하는 것이다.
    // 003_Variable에서 말했듯이 배열은 값을 힙 영역에 저장하고 그 주소를 스택 영역에 저장을 하는 참조 형식이다.
    static void Main()
    {
        // 배열을 선언할 때에는 (자료형)[] (배열이름) = new (자료형)[(배열의 크기)] {배열의 요소} 와 같이 선언한다. (배열의 요소는 생략해도 된다.)
        // new 키워드는 그에 필요한 메모리를 힙 영역에 할당하는 역할을 한다.
        // 자료형 뒤에 있는 대괄호는 그 변수가 배열이라는 것을 의미한다.
        int[] intArray = new int[5] {1, 2, 3, 4, 5};

        // 배열 안에 있는 원소에 접근하기 위해서 배열 이름 뒤 대괄호에 숫자(index)를 넣어 접근한다.
        // 주의해야 할 점은 배열의 인덱스는 0부터 시작한다.
        Console.WriteLine("intArray[0]: " + intArray[0]);
        Console.WriteLine("intArray[4]: " + intArray[4]);

        // 배열의 길이는 Length 메소드를 사용하여 알 수 있다.
        Console.WriteLine("intArray.Length: " + intArray.Length());

        // 한번 정해지 배열의 크기는 고정이 된다. 하지만 가리키는 대상은 바뀔 수 있다.
        intArray = new int[10];

        // 배열을 선언할 때 값을 지정해 주면 배열의 크기를 지정해주지 않아도 자동으로 크기가 정해진다.
        intArray = new int[] {6, 7, 8, 9, 10};

        // string 형은 char형 문자가 모여있는 배열이다.
        string text = "Hello World!";

        // string 형도 배열이므로 인덱스로 접근이 가능하다.
        Console.WriteLine(text[0]);
        Console.WriteLine(text[4]);

        // 2차원 배열은 대괄호에 ,를 넣어 선언한다.
        int[,] int2dArray = new int[3, 5]
        {
            {1, 2, 3, 4, 5},
            {11, 12, 13, 14, 15},
            {21, 22, 23, 24, 25}
        };

        // 2차원 배열도 인덱스로 접근이 가능하다.
        Console.WriteLine(int2dArray[0, 2]);
    }
}