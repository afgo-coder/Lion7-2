using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////실수 데이터 형식: 소수점을 포함한 숫자를 표현
            //float A = 3.14f; //단정밀도 실수 (4바이트)
            //double B = 3.1415926535; //배정밀도 실수 (8바이트)
            //decimal C = 3.1415926535897932384626433832m; //고정소수점 실수 (16바이트)

            //Console.WriteLine("float A: " + A);
            //Console.WriteLine("double B: " + B);
            //Console.WriteLine("decimal C: " + C);

            //접미사 사용: 숫자의 데이터 형식을 명시
            //int intergerValue = 100; //기본 정수형 (int)
            //long longValue = 100L; //정수형 long 접미사 L
            //float floatValue = 3.14f; //실수형 float 접미사 f
            //double doubleValue = 3.14; //기본 실수형 (double)
            //decimal decimalValue = 3.14m; //고정밀도 실수형 decimal 접미사 m

            //Console.WriteLine(intergerValue);
            //Console.WriteLine(longValue);
            //Console.WriteLine(floatValue);
            //Console.WriteLine(doubleValue);
            //Console.WriteLine(decimalValue);

            //char 형식: 단일 문자를 표현
            //char letter = 'A'; //문자 A
            //char symbol = '#'; //특수 기호 #
            //char number = '9'; //숫자 형태의 문자 지정 '9'

            //Console.WriteLine(letter);
            //Console.WriteLine(symbol);
            //Console.WriteLine(number);

            //출력
            //==== 캐릭터 능력치 ====
            //float 이동속도 5.5
            //double 공격속도 1.25
            //decimal 아이템가격 12.99

            float 이동속도 = 5.5f;
            double 공격속도 = 1.25;
            decimal 아이템가격 = 12.99m;

            Console.WriteLine("==== 캐릭터 능력치 ====");
            Console.WriteLine("이동속도: " + 이동속도);
            Console.WriteLine("공격속도: " + 공격속도);
            Console.WriteLine("아이템가격: " + 아이템가격);

        }
    }
}
