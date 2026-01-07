using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int a = 10, b = 20;
            //int max = (a > b) ? a : b; //삼항 연산자 (조건) ? t : f a가 b보다 크면 a, 아니면 b
            //Console.WriteLine(max);

            //기본 사용법
            //int score = 85;
            //string result = (score >= 60) ? "합격" : "불합격";

            //Console.WriteLine("=== 시험 결과 ===");
            //Console.WriteLine($"점수:{score}");
            //Console.WriteLine($"결과:{result}");

            //예제 1: 레벨에 따른 등급
            //레벨 45
            //50보다 크면 고급 50~30 사이이면 중급 그렇지 않으면 초급

            //출력예시
            //플레이어등급
            //레벨:
            //등급:
            //int level = 45;
            //string grade = (level > 50) ? "고급" : (level >= 30) ? "중급" : "초급";
            //Console.WriteLine("=== 플레이어 등급 ===");
            //Console.WriteLine($"레벨:{level}");
            //Console.WriteLine($"등급:{grade}");

            //int health = 30;
            //int maxHealth = 100;
            //string status = (health >= 70) ? "안전" : (health >= 30) ? "주의" : "위험";
            //Console.WriteLine("=== 플레이어 상태 ===");
            //Console.WriteLine($"체력:{health}/{maxHealth}");
            //Console.WriteLine($"상태:{status}");

            //연산자 우선순위
            //int result = 10 + 2 * 5;//곱셈이 덧셈보다 우선순위
            //Console.WriteLine(result);

            //int adjustedResult = (10 + 2) * 5; //괄호로 우선순위 변경
            //Console.WriteLine(adjustedResult);

            //예제 2: 데미지 계산
            //int baseDamage= 50;
            //int bonusDamage = 20;
            //double criticalMultiplier = 1.5;

            //// 잘못된 계산
            //double damage1= baseDamage + bonusDamage * criticalMultiplier;
            //// 올바른 계산
            //double damage2 = (baseDamage + bonusDamage) * criticalMultiplier;

            //Console.WriteLine("\n=== 크리티컬 데미지 계산 ===");
            //Console.WriteLine($"기본 데미지: {baseDamage}");
            //Console.WriteLine($"보너스 데미지: {bonusDamage}");
            //Console.WriteLine($"크리티컬 배율: {criticalMultiplier}");
            //Console.WriteLine($"잘못된 계산: {damage1}");  // 80.0
            //Console.WriteLine($"올바른 계산: {damage2}");  // 105.0

            //int score = 85;
            //if (score >= 90)
            //{ Console.WriteLine("A학점"); }
            //else
            //{
            //    Console.WriteLine("90점 미만");
            //}

            //int number = 10;
            //if (number > 15)
            //{
            //    Console.WriteLine("15보다 큽니다");
            //}
            //else
            //{
            //    Console.WriteLine("15보다 작거나 같습니다");
            //}

            int score = 75;
            if (score >= 90)
            {
                Console.WriteLine("A학점");
            }
            else if (score >= 80)
            {
                Console.WriteLine("B학점");
            }
            else if (score >= 70)
            {
                Console.WriteLine("C학점");
            }
            else
            {
                Console.WriteLine("F학점");
            }





            }
    }
}
