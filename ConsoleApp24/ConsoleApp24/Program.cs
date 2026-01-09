using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2차원 for문
            //for (int i = 1; i <= 3; i++)
            //{
            //    for (int j = 1; j <= 3; j++)
            //    {
            //        Console.WriteLine($"i:{i} j:{j}");
            //    }
            //    Console.WriteLine();
            //}
            Console.OutputEncoding = Encoding.UTF8;

            //=== 예제 1: 사각형 그리기 ===
            //⬜ ⬜ ⬜
            ////⬜ ⬜ ⬜
            ////⬜ ⬜ ⬜
            //for (int i = 0; i < 3; i++) // 행 3번
            //{
            //    for (int j = 0; j < 3; j++) //열 3번
            //    {
            //        Console.Write("⬜");
            //    }
            //    Console.WriteLine(); //한줄 끝나면 줄바꿈
            //}

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write($"{j+1} ");
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine("\n=== 예제 2: 숫자 표 ===");

            //for (int i = 1; i <= 3; i++)
            //{
            //    for (int j = 1; j <= 3; j++)
            //    {
            //        Console.Write($"{j} ");
            //    }
            //    Console.WriteLine();
            //}

            //=== 예제 3: 좌표 찍기 ===
            //(0, 0)(1, 0)(2, 0)
            //(0, 1)(1, 1)(2, 1)
            //(0, 2)(1, 2)(2, 2)

            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        Console.Write($"({j},{i})");
            //    }
            //    Console.WriteLine();
            //}

            //=== 예제 4: 삼각형 별찍기 ===

            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j <5; j++)
            //    {
            //        if (j <= i)
            //        {
            //            Console.Write("*");
            //        }


            //        else
            //        {
            //            Console.Write(" ");
            //        }
            //    }
            //        Console.WriteLine();
            //}

            //=== 예제 6: 2단 곱셈표 ===
            //1×1 = 1 1×2 = 2 1×3 = 3
            //2×1 = 2 2×2 = 4 2×3 = 6
            //3×1 = 3 3×2 = 6 3×3 = 9

            //for (int i = 1; i < 4; i++)
            //{
            //    for (int j = 1; j < 4; j++)
            //    {
            //        Console.Write($"{i}x{j} = {j * i} ");
            //    }
            //    Console.WriteLine(" ");
            //}

            //=== 예제 9: 미니 게임 맵 ===
            //🏠 🟩 🟩 🟩
            // 🟩 🟩 🟩 🟩
            // 🟩 🟩 🟩 🟩
            // 🟩 🟩 🟩 🎯
            Console.OutputEncoding = Encoding.UTF8;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (i == 0 && j == 0)
                    {
                        Console.Write($"집");
                    }
                    else if (i == 3 && j == 3)
                    {
                        Console.Write($"끝");
                    }
                    else
                    {
                        Console.Write("🟩");
                    }
                }
                Console.WriteLine(" ");
            }



        }
    }
}
