using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0112_예제문제_풀어보기
{

    internal class Program
    {


        //문제 1: 평균 계산 함수
        //정수 배열을 받아 평균을 반환하는 함수를 만드세요.
        //static double average(int[] number)
        //{
        //    if (number.Length <= 0)
        //    {
        //        return 0;  
        //    }
        //    return (double)number.Sum() / number.Length;
        //}
        //문제 2: 등급 판별 함수
        //점수를 받아 A, B, C, D, F 등급을 반환하는 함수를 만드세요.
        //static string GetGrade(int score)
        //{
        //    if (score < 0 || score > 100)
        //    {
        //        return "유효하지않은 점수";

        //    }
        //    if (score >= 90) return "A";
        //    if (score >= 80) return "B";
        //    if (score >= 70) return "C";
        //    if (score >= 60) return "D";
        //    return "F";
        //}
        //문제 3: 소수 판별 함수

        //숫자를 받아 소수인지 판별하는 함수를 만드세요.
        //static bool Juged(int n)
        //{
        //    for (int i = 2; i * i <= n; i++)
        //        if (n % i == 0)
        //            return false;

        //    return true;
        //}
        //문제 4: 경험치 시스템
        //현재 경험치와 획득 경험치를 받아
        //레벨업 여부와 새 경험치를 반환하는 함수를 만드세요. (out 사용)

        //static void aboutExp(int currentExp, int gainedExp, out bool levelUp, out int newExp)
        //{
        //    const int ExpMAX = 100;  
        //    int totalExp = currentExp + gainedExp;

        //    if (totalExp >= ExpMAX)
        //    {
        //        levelUp = true;
        //        newExp = totalExp % ExpMAX;
        //    }
        //    else
        //    {
        //        levelUp = false;
        //        newExp = totalExp;
        //    }
        //}

        //문제 5: 아이템 강화 시스템
        //강화 레벨에 따라 성공 확률이 달라지는
        //아이템 강화 시스템을 함수로 구현하세요.
        static Random random = new Random();

        static bool TryEnhance(int level)
        {
            // 성공 확률 계산 (레벨이 높을수록 낮아짐)
            double successRate = Math.Max(0.5, 1.0 - (level * 0.05));  // 최소 50%

            double roll = random.NextDouble();
            return roll < successRate;
        }


        static void Main(string[] args)
        {

            Console.WriteLine("=== 강화게임 예제 ===");
            Console.WriteLine("아이템 강화 게임 시작! 엔터키를 눌러 강화를 시행하세요.");
            int maxLevel = 100;
            while (true)
            {
                int level = 1;
                Console.WriteLine($"현재 레벨: {level}");

                while (level < maxLevel)
                {
                    Console.ReadLine();  // 엔터키 대기
                    bool success = TryEnhance(level);

                    if (success)
                    {
                        level++;
                        Console.WriteLine($"강화 성공! 현재 레벨: {level}");
                    }
                    else
                    {
                        Console.WriteLine("강화 실패! 1레벨부터 재시작합니다.");
                        break;  // 내부 루프 탈출, 외부 루프로 돌아감
                    }
                }

                if (level >= maxLevel)
                {
                    Console.WriteLine("최대 레벨에 도달했습니다! 게임 종료.");
                    break;  // 게임 종료
                }

                //int expMax = 100;
                //int expNow = 80;
                //int expGain = 30;
                //aboutExp(expNow, expGain, out bool levelUp, out int newExp);           
                //Console.WriteLine("=== 레벨업 예제 ===");
                //Console.WriteLine($"현재레벨: 17");
                //Console.WriteLine($"경험치: {expNow}/{expMax}");
                //Console.WriteLine($"획득 경험치: {expGain}");
                //Console.WriteLine($"레벨업 여부: {levelUp}");
                //Console.WriteLine($"레벨업!");
                //Console.WriteLine("현재레벨: 18");
                //Console.WriteLine($"경험치: {newExp}/{expMax}");
                //    Console.WriteLine("=== 소수 예제 ===");

                //    Console.Write("숫자를 입력하세요: ");
                //    string input = Console.ReadLine();
                //    if (int.TryParse(input, out int num))
                //    {
                //        bool torf = Juged(num);
                //        if (torf is true)
                //        {
                //            Console.WriteLine($"입력한 숫자: {input}은 소수가 맞습니다");
                //        }
                //        else
                //        {
                //            Console.WriteLine($"입력한 숫자: {input}은 소수가 아닙니다");
                //        }
                //    }

                //Console.WriteLine("=== 등급 예제 ===");
                //Console.Write("점수를 입력하세요: ");
                //string input = Console.ReadLine();
                //if (int.TryParse(input, out int score))
                //{
                //    string grade = GetGrade(score);
                //    Console.WriteLine($"점수:{score}점");
                //    Console.WriteLine($"등급:{grade}");
                //}
                //else
                //{
                //    Console.WriteLine("유효한 숫자를 입력하세요.");
                //}

                //    int[] numbers = {1,2,3,4,5,6,7,8,9,10};
                //    double aver = average(numbers);
                //    Console.WriteLine("===평균 계산===");
                //    Console.WriteLine("1+2+3....8+9+10의 평균을 구하시오");
                //    Console.WriteLine("평균: " + aver);
            }
        }
    }
}
