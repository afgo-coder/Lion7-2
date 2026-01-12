using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp34
{
    internal class Program
    {
        static void Attack()
        {
            Console.WriteLine("기본공격");
            Console.WriteLine("데미지 : 50");
        }
        //매개변수 1개
        static void Attack(string target)
        {
            Console.WriteLine($"{target} 기본공격");
            Console.WriteLine("데미지 : 50");
        }
        //매개변수 2개
        static void Attack(string target,int damage)
        {
            Console.WriteLine($"{target} 기본공격");
            Console.WriteLine($"데미지 : {damage}");
        }
        //스킬 공격 (매개변수 3개)
        static void Attack(string target, string skill, int damage) 
        {
            Console.WriteLine($"스킬 발동: {skill}");
            Console.WriteLine($"{target}에게 {damage} 데미지!");
        }
        static void Main(string[] args)
        {
            Attack();
            Console.WriteLine();
            //매서드오버로딩
            Attack("몬스터");
            Console.WriteLine();
            Attack("몬스터",100);
            Console.WriteLine();
            Attack("몬스터", "타격", 100);
































        }
    }
}
