using System;

class DataType
{
    static void Main()
    {
        // 정수형 기본 타입
        void IntegerType()
        {
            // sbyte(signed byte)에는 부호 있는 8비트 정수(-128 ~ 127)가 들어간다.
            sbyte sByteVar = -128;
            sByteVar = 127;

            // byte에는 부호 없는 8비트 정수(0 ~ 255)가 들어간다.
            byte byteVar = 0;
            byteVar = 255;

            // short에는 부호 있는 16비트 정수(-32,768 ~ 32,767)가 들어간다.
            short shortVar = -32768;
            shortVar = 32767;

            // ushort(unsigned short)에는 부호 없는 16비트 정수(0 ~ 65535)가 들어간다.
            ushort uShortVar = 0;
            uShortVar = 65535;

            // int(integer)에는 부호 있는 32비트 정수(-2,147,483,648 ~ 2,147,483,647)가 들어간다.
            int intVar = -2147483648;
            intVar = 2147483647;

            // uint(unsigned integer)에는 부호 없는 32비트 정수(0 ~ 4,294,967,295)가 들어간다.
            uint uintVar = 0;
            uintVar = 4294967295;

            // long에는 부호 있는 64비트 정수(-9,223,372,036,854,775,808 ~9,223,372,036,854,775,807)
            long longVar = -9223372036854775808;
            longVar = 9223372036854775807;

            // ulong(unsigned long)에는 부호 없는 64비트 정수(0 ~18,446,744,073,709,551,615)가 들어간다.
            ulong ulongVar = 0;
            ulongVar = 18446744073709551615;
        }

        // 실수형 기본 타입
        void RealNumberType()
        {
            // float에는 -3.4 × 10^38 ~ 3.4 × 10^38 범위, 소수점 아래 7번째 자리까지 표현된다. (16비트)
            // float에서는 값 옆에 f를 붙여주어야 한다.
            float floatVar = 12345.6789f;

            // doible에는 ±5.0 × 10^−324 ~ ±1.7 × 10^308 범위, 소수점 아래 16번째 자리까지 표현된다. (64비트)
            double doubleVar = 12345.6789123456789;

            // decimal에는 (-7.9 x 10^28 ~ 7.9 x 10^28) / (100 ~ 10^28) 범위, 소수점 아래 28번째 자리까지 표현된다. (128비트)
            // decimal에서는 값 옆에 m을 붙여주어야 한다.
            decimal decimalVar = 12345.6789123456789123456789m;
        }

        // 문자형 기본 타입
        void CharacterType()
        {
            // char(character)에는 유니코드 16비트 문자 1개가 들어간다.
            char charVar = 'a';
            charVar = '헿';

            // string에는 유니코드 문자열이 들어간다.
            string stringVar = "Hello World";
            stringVar = "안녕 세상!";
        }

        // 불린형 기본 타입
        void booleanType()
        {
            // bool(boolean)에는 true와 false 이 두 값만 담을 수 있다. (1비트)
            bool boolVar = true;
            boolVar = false;
        }

    }

}