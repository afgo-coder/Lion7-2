using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp51;

namespace ConsoleApp51
{
    //인터페이스
    interface IAttackable
    {
        void Attack(string target);
        int GetAttackPower();

    }

    //인터페이스 Defendable 방어기능 구현
    interface IDefendable
    {
        void Defend();
        int GetDefensePower();
    }

    class Knight : IAttackable ,IDefendable//알트 + 엔터
    {
        public string name;
        public int attackpower;
        public int defensepower;

        public Knight()
        {
            name = "검사";
            attackpower = 18;
        }
        public void Defend()
        {
            Console.WriteLine("기사가 방어모드중입니다");
        }

        public void Attack(string target)
        {
            Console.WriteLine($"검으로 {target}을(를) 공격");
        }

        public int GetAttackPower()
        {
            return attackpower;
        }

        public int GetDefensePower()
        {
            return defensepower;
        }

    }

    //마법사 클래스를 만들고 어택 인터페이스를 구현하시오

    class Mage : IAttackable
    {
        public string name;
        public int attackpower;

        public Mage()
            {
            name = "마법사";
            attackpower = 20;
            }

    
        public void Attack(string target)
        {
            Console.WriteLine($"마법으로 {target}을(를) 공격");
        }

        public int GetAttackPower()
        {
            return attackpower;
        }
    }
}

internal class Program
{
    static void Main(string[] args)
    {
        //Knight knight = new Knight();
        //knight.Attack("오크");
        //Mage mage = new Mage();
        //mage.Attack("고블린");

        //인터페이스 타입으로 배열 생성

        IAttackable[] attacker = new IAttackable[2]; //배열만 준비
        attacker[0] = new Mage();
        attacker[1] = new Knight();

        IDefendable defender = new Knight();
        defender.Defend();

        foreach (IAttackable att in attacker)
        {
            att.Attack("고블린");

        }
        








    }

}
