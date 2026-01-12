using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp35
{
    internal class Program
    {
        //static void CastFireBall(string target, int damage = 100, int manacost = 30)
        //{
        //    Console.WriteLine($"파이어볼 시전!");
        //    Console.WriteLine($"대상: {target}");
        //    Console.WriteLine($"데미지: {damage}");
        //    Console.WriteLine($"마나 소모: {manacost}");
        //}
        //=== 아이템 사용 ===

        //💊 회복 포션 사용!
        //회복량: 50 HP

        //💊 고급 회복 포션 사용!
        //회복량: 100 HP

        //=== 소환 마법 ===

        //✨ 슬라임 소환!
        //레벨: 1
        //수량: 1마리

        //✨ 고블린 소환!
        //레벨: 5
        //수량: 1마리

        //✨ 드래곤 소환!
        //레벨: 50
        //수량: 3마리
        //기본매개변수 사용

        static void Usepotion(string name, int heal = 50)
        {
            Console.WriteLine("=== 아이템 사용 ===");
            Console.WriteLine($"💊 {name}사용!");
            Console.WriteLine($"회복량: {heal} HP");
        }
        static void Monsterspwan(string monster = "슬라임", int level = 1, int count = 1)
        {
            Console.WriteLine("=== 소환 마법 ===");
            Console.WriteLine($"✨{monster}소환!");
            Console.WriteLine($"레벨: {level}");
            Console.WriteLine($"수량: {count}마리");
        }


        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            ////모든매개변수 지정
            //CastFireBall("고블린", 150, 40);
            //Console.WriteLine();
            //CastFireBall("오크", manacost: 20);
            //Console.WriteLine();
            //CastFireBall("드래곤");

            Usepotion("회복포션");
            Usepotion("고급 회복포션",100);

            Monsterspwan();
            Monsterspwan("고블린",5);
            Monsterspwan("드래곤",50,3);



        }
    }
}
