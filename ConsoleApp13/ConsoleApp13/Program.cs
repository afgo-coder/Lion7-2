using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //연산자
            //int a = 5, b = 3;
            //int sum = a + b; //산술연산자 사용 +
            //bool isEqual = (a == b); //비교연산자 사용 ==

            //Console.WriteLine($"합: {sum}");
            //Console.WriteLine($"a와 b가 같은가?: {isEqual}");

            //단항 연산자
            //int number = 5;
            //Console.WriteLine(+number); //양수 부호 연산자
            //Console.WriteLine(-number); //음수 부호 연산자

            //bool flag = true;
            //Console.WriteLine(!flag); //논리 부정 연산자

            //산술 연산자

            //int a = 10, b = 3;

            //Console.WriteLine(a + b); // 덧셈
            //Console.WriteLine(a - b); // 뺄셈
            //Console.WriteLine(a * b); // 곱셈
            //Console.WriteLine(a / b); // 나눗셈
            //Console.WriteLine(a % b); // 나머지

            //문자열 연결 연산자
            
            //string firstName = "Alice";
            //string lastName = "Smith";
            //Console.WriteLine(firstName+ " " +lastName);

            //할당 연산자

            int a = 5;
            int b = 4;
            
            //a = a + b;
            //Console.WriteLine($"합: " + a);
            //a = 5;
            //a = a - b;
            //Console.WriteLine($"합: " + a);
            //a = 5;
            //a = a * b;
            //Console.WriteLine($"합: " + a);
            //a = 5;
            //a = a / b;
            //Console.WriteLine($"합: " + a);
            
            a += b;
            Console.WriteLine($"합: " + a);
            a = 5;
            a -= b;
            Console.WriteLine($"합: " + a);
            a = 5;
            a *= b;
            Console.WriteLine($"합: " + a);
            a = 5;
            a /= b;
            Console.WriteLine($"합: " + a);
            a = 5;
            a %= b;
            Console.WriteLine($"합: " + a);

            string name = "Alice";
            string last = "Smith";

            name += " " + last;
            Console.WriteLine($"이름:" + name);





        }
    }
}
