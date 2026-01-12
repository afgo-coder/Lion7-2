using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    internal class Program
    {
        //1단계 기본함수
        static void SayHello()
        {
            Console.WriteLine("안녕하세요, 용사님");
            Console.WriteLine("모험을 시작합니다.");
        }
        static void ShowGameStart()
        {
            Console.WriteLine("╔═══════════════════════════════════╗");
            Console.WriteLine("║ ⚔ RPG 게임 시작 ⚔ ║");
            Console.WriteLine("╚═══════════════════════════════════╝");
        }
        static void printseparator()
        {
            Console.WriteLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");
        }    
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //함수 정의 문법
            //반환타입 함수이름(매개변수)
            //{
            // 실행할 코드
            //return 반환값;  // 반환타입이 void가 아닐 때
            //}

            ShowGameStart();
            Console.WriteLine();

            SayHello(); //재사용성 가독성 유지보수
            printseparator();
            Console.WriteLine("게임 메뉴를 불러옵니다 . . . . .");
            printseparator();

            Console.WriteLine("게임 종료");

            printseparator();
           














































































        }
    }
}
