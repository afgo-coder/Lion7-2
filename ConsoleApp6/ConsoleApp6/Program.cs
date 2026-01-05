using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //상수: 변경 불가능한 값
            //const double pi = 3.14159; //상수 Pi 선언 및 초기화
            //const int MaxScore = 100; //정수형 상수 선언

            ////출력
            //Console.WriteLine("Pi: " + pi);
            //Console.WriteLine("MaxScore: "+ MaxScore);
            //만약 추가로 변수 pi = 3.14; 지정한다면 오류: 상수는 변경 불가능

            const int player = 4;
            const int gold = 1000;
            const string version = "1.0.0";
            Console.WriteLine("**실행결과: **");
            Console.WriteLine( "```");
            Console.WriteLine("=== 게임 설정 ===" );
            Console.WriteLine( "최대 플레이어: "+ player);
            Console.WriteLine( "시작골드: "+ gold +"G");
            Console.WriteLine( "버전: "+ version);
            Console.WriteLine( "```");

        }
    }
}
