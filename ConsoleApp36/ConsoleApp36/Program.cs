using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp36
{
    internal class Program
    {
        ////매개변수 int a 대신받아준다.
        //static void Attack(ref int a)
        //{
        //    Console.WriteLine("공격력: " + a);
        //    a++;

        //}
        static void Attack(ref int c,out int attack, out int defense)
        {
            attack = 10; 
            defense = 20;
            
            Console.WriteLine(c);
             c++;  
            attack++; 
            defense++ ;
        }

        static void Main(string[] args)
        {
            ////ref 키워드
            ////C# 내부적으로 포인터 개발자들이 신경덜쓰게 잘만들어놓음

            //int a = 10;

            //Attack(ref a);

            //Console.WriteLine("a값: " + a);
            int attack;
            int defense;
            int c = 10;

            Attack(ref c,out attack,out defense);
            Console.WriteLine($"공격력: {attack}");
            Console.WriteLine($"방어력: {defense}");
            Console.WriteLine($"{c},{attack},{defense}");

















        }
    }
}
