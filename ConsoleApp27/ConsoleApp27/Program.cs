using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //다차원배열
            // 방법 1: 크기만 지정
            //int[,] grid = new int[3, 4];  // 3행 4열

            //// 방법 2: 선언과 동시에 초기화
            //int[,] numbers = new int[2, 3]
            //{
            //     { 1, 2, 3 },
            //     { 4, 5, 6 }
            //};

            //// 방법 3: new 생략 (간단한 초기화)
            //int[,] scores =
            //{
            //       { 90, 85, 88 },
            //       { 92, 78, 95 },
            //       { 87, 91, 84 }
            //};
            ////배열 크기 확인
            //int[,] array = new int[3, 4];

            //// 전체 요소 개수
            //int totalElements = array.Length;  // 12 (3 x 4)

            //// 특정 차원의 길이
            //int rows = array.GetLength(0);     // 3 (행 개수)
            //int cols = array.GetLength(1);     // 4 (열 개수)

            //// Rank: 배열의 차원 수
            //int dimensions = array.Rank;       // 2

            //=== 좌석 배치도 ===

            //[A1][A2][A3]
            //[B1][B2][B3]
            //[C1][C2][C3]



            //string[,] seat = new string[3, 3]
            //    {
            //        {"A1","A2","A3" },
            //        {"B1","B2","B3" },
            //        {"C1","C2","C3"}
            //    };

            //Console.WriteLine("=== 좌석 배치도 ===");

            ////행의반복 (row)
            //for (int row = 0; row < seat.GetLength(0); row++)
            //{
            //    //열의 반복 (column)
            //    for (int col = 0; col < seat.GetLength(1); col++)
            //    {
            //        Console.Write($"[{seat[row, col]}]");
            //    }
            //    Console.WriteLine(); //줄바꿈
            //}

            ////첫 번째 좌석: A1
            ////중앙 좌석: B2
            ////마지막 좌석: C3
            //Console.WriteLine("첫 번째 좌석: " + seat[0,0]);
            //Console.WriteLine("중앙 좌석: " + seat[1, 1]);
            //Console.WriteLine("마지막 좌석: " + seat[2, 2]);

            //2D 게임맵
            Console.OutputEncoding = Encoding.UTF8;
            //int[,] map = new int[5, 5]
            //{
            //    { 0,0,1,0,0},
            //    { 0,2,1,0,3},
            //    { 0,0,1,0,0},
            //    { 1,1,1,0,0},
            //    { 0,0,0,0,9},
            //};
            //Console.WriteLine("== 던전맵 ==");
            //Console.WriteLine("0: 통로 1: 벽 2: 몬스터 3: 보물 9: 출구\n");

            ////맵 출력
            //for (int y = 0; y < map.GetLength(0); y++)
            //{
            //    for (int x = 0; x < map.GetLength(1); x++)
            //    {
            //        switch (map[y,x])
            //        {
            //            case 0:
            //                Console.Write("□ ");
            //                break;
            //            case 1:
            //                Console.Write("■");
            //            break;
            //            case 2:
            //                Console.Write("◆ ");
            //                break;
            //            case 3:
            //                Console.Write("★ ");
            //                break;
            //            case 9:
            //                Console.Write("※ ");
            //                break;
            //        }

            //    }
            //    Console.WriteLine();
            //}
            //=== 성적표 ===

            //이름  국어 영어  수학 과학  평균
            //━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
            //김철수 85  90  88  92  88.8
            //이영희 78  85  90  87  85.0
            //박민수 92  88  95  90  91.3

            //=== 과목별 평균 ===
            //국어: 85.0점
            //영어: 87.7점
            //수학: 91.0점
            //과학: 89.7점

            string[] name = { "김철수", "이영희", "박민수" };
            string[] subjects = { "국어", "영어", "수학", "과학" };

            int[,] score = new int[3, 4]
            {
                { 85,90,88,92},
                { 78,85,90,87},
                { 92,88,95,90}
            };

            //성적표 출력
            Console.WriteLine("=== 성적표 ===\n");
            Console.Write("이름  ");
            foreach (string subject in subjects)
            {
                Console.Write($"{subject}\t");
            }
            Console.WriteLine("평균");
            Console.WriteLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");

            for (int i = 0; i < score.GetLength(0); i++) 
            {
                Console.Write($"{name[i]}:\t");
                int sum = 0;
                for (int j = 0; j < score.GetLength(1); j++)
                {
                    Console.Write($"{score[i, j]}\t");
                    sum += score[i, j];
                }
                double average = (double)sum / score.GetLength(1);
                Console.WriteLine($"{average:F1}");
            }
            Console.WriteLine("\n=== 과목별 평균 ===");
            for (int subject = 0; subject < score.GetLength(1); subject++)
            {
                int sum = 0;
                for (int student = 0; student < score.GetLength(0); student++)
                {
                    sum += score[student, subject];
                }
                double avg = (double)sum / score.GetLength(0);
                Console.WriteLine($"{subjects[subject]}: {avg:F1}점");
            }















            }
    }
}
