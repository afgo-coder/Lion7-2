using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int a = 78;
            //if (a >= 90)
            //{
            //    Console.WriteLine("A등급");
            //}
            //else if (a > 80 && a <= 89)
            //{
            //    Console.WriteLine("B등급");
            //}
            //else if (a > 70 && a <= 79)
            //{
            //    Console.WriteLine("C등급");
            //}
            //else
            //{
            //    Console.WriteLine("D등급");
            //}

            //Console.WriteLine("if else 끝나고나서 실행");

            //int a = 100;
            //if (a >= 90)
            //{
            //    Console.WriteLine("1통과");
            //}

            //if (a >= 80)
            //{
            //    Console.WriteLine("2통과");
            //}

            //현재 체력: 30 / 100
            // 체력이 30보다 낮은경우
            //⚠️ 경고: 체력이 위험합니다!
            //회복 아이템을 사용하세요!
            //💊 체력이 50 % 이하입니다.
            //체력이 0이면 <-죽음


            //⚔️ 적이 사거리 안에 있습니다!
            //공격 가능!

            //int health = 30;
            //int maxHealth = 100;
            //int diethHealth = 0;
            //int DistanceToEnemy = 5;
            //int AttackRange = 10;


            //Console.WriteLine($"현재체력:{health}/{maxHealth}");
            //if (health <= maxHealth * 0.3)
            //{
            //    Console.WriteLine("경고: 체력이 위험합니다!");
            //    Console.WriteLine("회복 아이템을 사용하세요!");
            //}
            //if (health <= maxHealth * 0.5)
            //{
            //    Console.WriteLine("체력이 50 % 이하입니다.");
            //}
            //if (health == diethHealth)
            //{
            //    Console.WriteLine("게임 오버!");
            //    Console.WriteLine("부활 지점에서 다시 시작합니다.");
            //}
            //if (DistanceToEnemy <= AttackRange)
            //{
            //    Console.WriteLine("적이 사거리 안에 있습니다!");
            //    Console.WriteLine("공격 가능!");
            //}
            //else if (DistanceToEnemy > AttackRange)
            //{
            //    Console.WriteLine("적이 사거리 밖에 있습니다!");
            //    Console.WriteLine("공격 불가능!");

            //}

            //아이템 구매 시스템
            //int playerGold = 500;
            //int itemPrice = 250;
            //string itemName = "강철 검";

            //Console.WriteLine("=== 상점 ===");
            //Console.WriteLine($"아이템:{itemName}");
            //Console.WriteLine($"가격:{itemPrice}골드");
            //Console.WriteLine($"소지금: {playerGold}");

            //if (playerGold >= itemPrice)
            //{
            //    playerGold -= itemPrice;    
            //    Console.WriteLine("구매성공!");
            //    Console.WriteLine($"{itemName}을 획득했습니다");
            //    Console.WriteLine($"남은 골드: {playerGold}골드");
            //}
            //else
            //{
            //    int needGold = itemPrice - playerGold;
            //    Console.WriteLine("골드가 부족합니다.");
            //    Console.WriteLine($"필요한골드:{needGold}");
            //}

            //Console.WriteLine("=== 던전 입장 ===");
            //Console.Write($"레벨을 입력해주세요: ");

            //string Levelinput =
            //    Console.ReadLine();
            //int playerLevel = int.Parse(Levelinput);
            //int requiredLevel = 50;



            //if (playerLevel >= requiredLevel)
            //{
            //    Console.WriteLine("던전에 입장합니다.");
            //    Console.WriteLine("전투 준비!");
            //}
            //else
            //{
            //    int needLevel = requiredLevel - playerLevel;
            //    Console.WriteLine("레벨이 부족합니다.");
            //    Console.WriteLine($"필요한 레벨: {needLevel}레벨");

            //}

            //점수에 따른 등급 판정
            //int score = 8500;
            //string rank;

            //Console.WriteLine("=== 게임 랭크 시스템 ===");
            //Console.Write($"스코어를 입력하세요: ");
            //score = int.Parse(Console.ReadLine());
            //Console.WriteLine($"점수:{score}");

            //if (score >= 10000)
            //{
            //    rank = "SSS";
            //    Console.WriteLine($"등급:{rank}(레전드)");
            //    Console.WriteLine("보상: 전설 아이템 + 골드 10000");
            //}
            //else if (score >= 8000)
            //{
            //    rank = "SS";
            //    Console.WriteLine($"등급:{rank}(마스터)");
            //    Console.WriteLine("보상: 영웅 아이템 + 골드 5000");
            //}
            //else if (score >= 6000)
            //{
            //    rank = "S";
            //    Console.WriteLine($"등급:{rank}(다이아)");
            //    Console.WriteLine("보상: 희귀 아이템 + 골드 3000");
            //}
            //else if (score >= 4000)
            //{
            //    rank = "A";
            //    Console.WriteLine($"등급:{rank}(플래티넘)");
            //    Console.WriteLine("보상: 고급 아이템 + 골드 1500");
            //}
            //else
            //{
            //    rank = "B";
            //    Console.WriteLine($"등급:{rank}(골드)");
            //    Console.WriteLine("보상: 일반 아이템 + 골드 750");
            //}

            //캐릭터 상태 판정
            //Console.WriteLine("=== 캐릭터 상태 ===");
            //Console.Write("체력을 입력하세요 (0-100): ");
            //int health = 
            //health = int.Parse(Console.ReadLine());

            //if (health >= 80)
            //{
            //    Console.WriteLine("상태: 매우좋음");
            //}
            //else if (health >= 60)
            //{
            //    Console.WriteLine("상태: 좋음");
            //}
            //else if (health >= 40)
            //{
            //    Console.WriteLine("상태: 보통");
            //}
            //else if (health >= 20)
            //{
            //    Console.WriteLine("상태: 위험");
            //}
            //else
            //{
            //    Console.WriteLine("상태: 매우 위험!");
            //}




        }
    }
}
