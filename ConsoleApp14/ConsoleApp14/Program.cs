using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //캐릭터 스탯 계산
            int baseAttack = 50;
            int weaponDamage = 30;
            int totalAttack = baseAttack + weaponDamage;

            Console.WriteLine("=== 공격력 계산 ===");
            Console.WriteLine($"기본 공격력: {baseAttack}");
            Console.WriteLine($"무기 데미지: {weaponDamage}");
            Console.WriteLine($"총 공격력: {totalAttack}");

            //데미지 계산
            int playerHealth = 100;
            int DamageTaken = 25;
            playerHealth = playerHealth - DamageTaken;

            Console.WriteLine("=== 데미지 계산 ===");
            Console.WriteLine($"받은 데미지: {DamageTaken}");
            Console.WriteLine($"남은 체력: {playerHealth}");

            //경험치 계산
            int monsterSkilled = 5;
            int expPerMonster = 100;
            int totalExp = monsterSkilled * expPerMonster;

            Console.WriteLine("=== 경험치 획득 ===");
            Console.WriteLine($"처치한 몬스터 수: {monsterSkilled}");
            Console.WriteLine($"몬스터 당 경험치: {expPerMonster}");
            Console.WriteLine($"총 경험치: {totalExp}");

            //아이템 분배
            int totalGold = 1000;
            int playerCount = 4;
            int goldPerPlayer = totalGold / playerCount;
            int remainingGold = totalGold % playerCount;

            Console.WriteLine("=== 아이템 분배 ===");
            Console.WriteLine($"총 골드: {totalGold}");
            Console.WriteLine($"플레이어 수: {playerCount}");
            Console.WriteLine($"1인당 골드: {goldPerPlayer}");
            Console.WriteLine($"남은 골드: {remainingGold}");



        }
    }
}
