using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Runtime.Serialization.Formatters;

namespace _0108_복습게임만들기
{
    internal class Program
    {
        static void DrawBorder(int width, int height)
        {
            // 위쪽
            Console.SetCursorPosition(0, 0);
            Console.Write("┌" + new string('─', width - 2) + "┐");

            // 아래쪽
            Console.SetCursorPosition(0, height - 1);
            Console.Write("└" + new string('─', width - 2) + "┘");

            // 좌우
            for (int y = 1; y < height - 1; y++)
            {
                Console.SetCursorPosition(0, y);
                Console.Write("│");

                Console.SetCursorPosition(width - 1, y);
                Console.Write("│");
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.SetWindowSize(80, 25); 
            Console.SetBufferSize(80, 25); 
            
            Console.CursorVisible = false;
            ConsoleKeyInfo keyinfo;
            Random rand = new Random();      

            int boxX = rand.Next(1, Console.WindowWidth - 2);
            int boxY = rand.Next(2, Console.WindowHeight - 2);
            int stage = 1;
            int x = 1, y = Console.WindowHeight - 2;


            while (true)
            {

                { 
                                 
                    Console.Clear();
                    //테두리 소환 위쪽에 만들어둔 함수가 적용
                    DrawBorder(Console.WindowWidth, Console.WindowHeight);

                    //스테이지 표시
                    Console.SetCursorPosition(2, 1);
                    Console.Write($"=== Stage {stage} ==="); 
                    //나
                    Console.SetCursorPosition(x, y);
                    Console.Write("▣");
                    //박스
                    Console.SetCursorPosition(boxX, boxY);
                    Console.Write("▩");
                    //박스와 충돌
                    if (x == boxX && y == boxY)
                    {   
                        Console.Clear();
                        DrawBorder(Console.WindowWidth, Console.WindowHeight);
                        Thread.Sleep(500);
                        Console.SetCursorPosition(30,12);
                        Console.Write("스테이지 클리어!");
                        Thread.Sleep(500);            
             
                        stage++;



                        if (stage > 5) 
                        {
                            Console.Clear();
                            DrawBorder(Console.WindowWidth, Console.WindowHeight);
                            Console.SetCursorPosition(32, 12);                            
                            Console.WriteLine("게임 클리어!");
                            Thread.Sleep(500);   
                            Environment.Exit(0);
                        }
                        x = 1; y = Console.WindowHeight - 2;
                        boxX = rand.Next(1, Console.WindowWidth - 2);
                        boxY = rand.Next(2, Console.WindowHeight - 2);

                    }

                }
                keyinfo = Console.ReadKey(true);

                //방향키 입력에 따른 좌표 변경
                switch (keyinfo.Key)
                {
                    case ConsoleKey.UpArrow: if (y > 2) y--; break;
                    case ConsoleKey.DownArrow: if (y < Console.WindowHeight - 2) y++; break;
                    case ConsoleKey.RightArrow: if (x < Console.WindowWidth - 2) x++; break;
                    case ConsoleKey.LeftArrow: if (x > 1) x--; break;
                    case ConsoleKey.Spacebar: Console.Write(" "); break;
                    case ConsoleKey.Escape: break; //ESC키로 탈출
                }
                
               


            }














        }
    }
}
