using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //오늘의 온도를 입력받아 적절한 옷차림을 추천해주세요.
            //온도가 30도 이상: 매우 더워요 반팔과 반바지를 입으세요.
            //온도가 20도 이상 30도 미만: 적당해요 긴팔 티셔츠를 입으세요.
            //온도가 10도 이상 20도 미만: 쌀쌀해요 가디건이나 코트를 챙기세요.
            //온도가 0도 이상 10도 미만: 추워요 코트를 입으세요.
            //온도가 0도 미만:매우 추워요! 패딩과 목도리가 필요해요.

            //입력예시
            //온도: 25도
            //출력예시
            //현재 온도: 25도
            //적당해요 긴팔 티셔츠를 입으세요.

           

            //Console.WriteLine("오늘의 온도를 입력해주세요:");
            //int temperature = int.Parse(Console.ReadLine());

            //if (temperature >= 30)
            //{
            //    Console.WriteLine($"현재 온도: {temperature}도");
            //    Console.WriteLine("매우 더워요 반팔과 반바지를 입으세요.");
            //}
            //else if(temperature >= 20 && temperature < 30)
            //{
            //    Console.WriteLine($"현재 온도: {temperature}도");
            //    Console.WriteLine("적당해요 긴팔 티셔츠를 입으세요.");
            //}   
            //else if (temperature >= 10 && temperature < 20)
            //{
            //    Console.WriteLine($"현재 온도: {temperature}도");
            //    Console.WriteLine("쌀쌀해요 가디건이나 코트를 챙기세요.");
            //}
            //else if (temperature >= 0 && temperature < 10)
            //{
            //    Console.WriteLine($"현재 온도: {temperature}도");
            //    Console.WriteLine("추워요 코트를 입으세요.");
            //}
            //else if (temperature < 0)
            //{
            //    Console.WriteLine($"현재 온도: {temperature}도");
            //    Console.WriteLine("매우 추워요! 패딩과 목도리가 필요해요");
            //}
            //사용자가 선택한 번호에 따라 게임 캐릭터의 직업 정보를 출력

            //직업 번호에 따른 정보
            //1번 전사-높은 체력과 방어력/ 시작 스탯: HP +50,공격력 +10
            //2번 마법사-강력한 마법공격 / 시작 스탯: 마나 +100, 마법력 +20
            //3번 궁수-원거리 공격 특화 / 시작 스탯:민첩 +15, 크리티컬 +10%
            //4번 도적- 빠른 속도와 회피 / 시작 스탯: 민첩 +20, 회피율 +15%
            //그 외: 잘못된 선택입니다. 1~4 중에서 선택해주세요

            

            Console.WriteLine("=== 캐릭터 선택 ===");
            Console.WriteLine("1.전사 2.마법사 3.궁수 4.도적");
            Console.Write("직업을 선택해주세요: ");
            int select = int.Parse(Console.ReadLine());

            switch (select)
            {
                case 1:
                    Console.WriteLine("당신이 고른 직업은 전사 입니다");
                    Console.WriteLine("전사는 높은 체력과 방어력을 가지고있습니다");
                    Console.WriteLine("시작 스탯: HP +50 공격력 +10");
                 break;
                case 2:
                    Console.WriteLine("당신이 고른 직업은 마법사 입니다");
                    Console.WriteLine("마법사는 강력한 마법공격을 사용합니다");
                    Console.WriteLine("시작 스탯: 마나 +100 마법력 +20");
                    break;
                case 3:
                    Console.WriteLine("당신이 고른 직업은 궁수 입니다");
                    Console.WriteLine("궁수는 원거리 공격에 특화된 직업입니다");
                    Console.WriteLine("시작 스탯: 민첩 +15 크리티컬 +10%");
                    break;
                case 4:
                    Console.WriteLine("당신이 고른 직업은 도적 입니다");
                    Console.WriteLine("도적은 빠른 속도와 회피가 특기입니다");
                    Console.WriteLine("시작 스탯: 민첩 +20 회피율 +15%");
                    break;
                default:
                    Console.WriteLine("잘못된 선택입니다. 1~4 중에서 선택해주세요");
                    break;



            }





























        }
    }
}
