using System;
using System.Text;
using System.Threading;

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

            int stage = 1;

            // 플레이어 시작 위치 (테두리 안쪽)
            int x = 1, y = Console.WindowHeight - 2;

            // 목표물 위치
            int boxX = rand.Next(1, Console.WindowWidth - 2);
            int boxY = rand.Next(2, Console.WindowHeight - 2);

            while (true)
            {
                Console.Clear();

                // 테두리
                DrawBorder(Console.WindowWidth, Console.WindowHeight);

                // 스테이지 표시
                Console.SetCursorPosition(2, 1);
                Console.Write($"=== Stage {stage} ===");

                // 플레이어
                Console.SetCursorPosition(x, y);
                Console.Write("▣");

                // 목표물
                Console.SetCursorPosition(boxX, boxY);
                Console.Write("▦");

                // 충돌 판정
                if (x == boxX && y == boxY)
                {
                    Console.Clear();
                    DrawBorder(Console.WindowWidth, Console.WindowHeight);

                    Console.SetCursorPosition(30, 12);
                    Console.Write("스테이지 클리어!");
                    Thread.Sleep(800);

                    stage++;

                    if (stage >= 5)
                    {
                        Console.Clear();
                        DrawBorder(Console.WindowWidth, Console.WindowHeight);
                        Console.SetCursorPosition(32, 12);
                        Console.Write("게임 클리어!");
                        Thread.Sleep(1500);
                        return;
                    }

                    // 다음 스테이지 준비
                    x = 1;
                    y = Console.WindowHeight - 2;
                    boxX = rand.Next(1, Console.WindowWidth - 2);
                    boxY = rand.Next(2, Console.WindowHeight - 2);
                }


                keyinfo = Console.ReadKey(true);

                // 방향키 입력에 따른 좌표 변경
                switch (keyinfo.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (y > 2) y--;
                        break;

                    case ConsoleKey.DownArrow:
                        if (y < Console.WindowHeight - 2) y++;
                        break;

                    case ConsoleKey.LeftArrow:
                        if (x > 1) x--;
                        break;

                    case ConsoleKey.RightArrow:
                        if (x < Console.WindowWidth - 2) x++;
                        break;

                    case ConsoleKey.Escape:
                        return;
                }
            }
        }
    }
}
