using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                //for (int i = 0; i < 5; i++)
                //{
                //    Console.WriteLine("Hello World!");
                //}

                //Console.OutputEncoding = Encoding.UTF8;

                //Console.WriteLine("=== 몬스터 웨이브 시작 ===");
                //int monster = 5;
                //for (int wave = 1; wave <= monster;)

                //{
                //    Console.WriteLine($"👹고블린 #{wave}생성!");
                //    wave++;
                //}
                //Console.WriteLine($"총 {monster}마리 생성완료!");

                //카운트다운

                //for (int count = 5; count >= 1; count --)
                //{
                //    Console.WriteLine($"{count}..");
                //}
                //Console.WriteLine("🎮 게임 시작!");

                //for (; ; ) //아무것도 적지 않으면 무한반복
                //{
                //    Console.WriteLine( "무한반복");
                //    Thread.Sleep(500);
                //}

                //랜덤함수
                //게임에서 굉장히 중요한 기능.

                // Random 객체 생성
                //Random random = new Random();

                //// 주요 메서드
                //int number1 = random.Next();           // 0 ~ int.MaxValue
                //int number2 = random.Next(10);         // 0 ~ 9
                //int number3 = random.Next(1, 7);       // 1 ~ 6 (주사위)
                //double number4 = random.NextDouble();  // 0.0 ~ 1.0

                //검뽑기 시뮬레이션
                //무한의 대검 10%
                //카타나     20%
                //엑스칼리버 30%
                //정기점검   40%


                string sword = "무한의 대검";

                Console.WriteLine("당신은 20번 뽑기가 가능합니다. 지금 실행합니다");

                Random rand = new Random();

                int random = 0;

                for (int i = 0; i < 20; i++)
                { 
                   random = rand.Next(1, 101);

                    if (random >= 1 && random <= 10)
                    {
                        sword = "무한의 대검";
                    }
                    else if (random >= 11 && random <= 30)
                    {
                        sword = "카타나";
                    }
                    else if (random >= 31 && random <= 60)
                    {
                        sword = "엑스칼리버";
                    }
                    else
                    {
                        sword = "정기점검";
                    }
                    Console.WriteLine($"{i + 1}번째 뽑기 결과 : {sword}");
                    Thread.Sleep(500);




                }


            }
        }
    }
}
