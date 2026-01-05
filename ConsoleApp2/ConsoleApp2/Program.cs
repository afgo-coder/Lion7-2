using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //리터럴 : 코드에서 고정된 값
            //int number = 10; //정수 리터럴
            //double pi = 3.14; //실수 리터럴
            //char letter = 'A'; //문자 리터럴
            //string name = "Alice"; //문자열 리터럴

            //Console.WriteLine(number); //WriteLine은 한줄씩 사용
            //Console.WriteLine(pi);    //Write는 한줄에 모두 포함
            //Console.WriteLine(letter);
            //Console.WriteLine(name);

            int score = 100;
            double pi = 3.14;
            char grade = 'A';
            string name = "홍길동";
            Console.WriteLine( "플레이스코어: " + score);
            Console.WriteLine( "파이: " + pi);
            Console.WriteLine( "등급: " + grade);
            Console.WriteLine( "플레이어이름: " + name);
            
        }
    }
}
