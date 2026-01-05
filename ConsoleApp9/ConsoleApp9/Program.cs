using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string 형식: 여러 문자를 지정
            //string greeting = "Hello, World!"; //문자열 저장
            //string name = "Alice"; //이름 저장

            //Console.WriteLine(greeting);
            //Console.WriteLine(name);

            // 문자 (char) - 단 하나의 문자만
            //char grade = 'A';
            //char symbol = '★';
            //char number = '9'; // 문자 '9'이지 숫자 9가 아님!

            //// 문자열 (string) - 여러 문자의 조합
            //string playerName = "홍길동";
            //string welcomeMessage = "게임에 오신 것을 환영합니다!";
            //string emptyString = ""; // 빈 문자열도 가능 

            ////실행 결과:
            ////=== RPG 게임 ===
            ////플레이어: 홍길동
            ////등급: A등급 ★
            ////게임에 오신 것을 환영합니다!`

            //Console.WriteLine("=== RPG 게임 ===");
            //Console.WriteLine("플레이어: " + playerName);
            //Console.WriteLine("등급: " + grade + "등급 " + symbol);
            //Console.WriteLine(welcomeMessage);

            //bool 형식 : 참(true) 또는 거짓(false)
            //bool isRunning = true; // 게임이 실행 중인지 여부
            //bool isFinished = false; // 게임이 종료되었는지 여부

            //Console.WriteLine(isRunning);
            //Console.WriteLine(isFinished);

            //실전예제

            //=== 게임 상태 ===
            //게임 실행 중: True
            //일시정지: False
            //열쇠 소지: False
            //문 열림: False
            //플레이어 생존: True

            //=== 캐릭터 상태 ===
            //체력: 80
            //건강 상태: True
            //위험 상태: False

            //bool isGameRunning = true;
            //bool isGamePaused = false;
            //bool hasKey = false;
            //bool isDoorOpen = false;
            //bool isPlayerAlive = true;
            //Console.WriteLine("=== 게임 상태 ===");
            //Console.WriteLine("게임 실행 중: " + isGameRunning);
            //Console.WriteLine("일시정지: " + isGamePaused);
            //Console.WriteLine("열쇠 소지: " + hasKey);
            //Console.WriteLine("문 열림: " + isDoorOpen);
            //Console.WriteLine("플레이어 생존: " + isPlayerAlive);

            //int Health = 80;
            //bool isSafe = true;
            //bool isDanger = false;
            //Console.WriteLine("=== 캐릭터 상태 ===");
            //Console.WriteLine("체력: " + Health);
            //Console.WriteLine("건강 상태: " + isSafe);
            //Console.WriteLine("위험 상태: " + isDanger);

            //System.int32 number = 1234; //int의 닷넷 형식
            //System.String text = "Hello"; //string의 닷넷 형식
            //System.Boolean flag = true; //bool의 닷넷 형식

            int number = 123;
            string numberAsString = number.ToString(); //정수를 문자열로 변환

            bool flag = true;
            string flagAsString = flag.ToString(); //논리값을 문자열로 변환

            Console.WriteLine(numberAsString); //"123"
            Console.WriteLine(flagAsString); //"ture"

           
        }
    }
}
