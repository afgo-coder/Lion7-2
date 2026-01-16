using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp47
{
    // 부모 클래스 (기반 클래스, Base Class)
    class Character
    {
        //public , private, protected //상속이 되어있는 자식이 사용가능하게 열어주는 접근제어자
        protected string name;
        protected int level;
        protected int hp;
        protected int Maxhp;
        protected int attack;
        protected int defense;

        public Character(string charname)
        {
            name = charname;
            level = 1;
            Maxhp = 100;
            hp = Maxhp;
            attack = 30;
            defense = 20;
            
            Console.WriteLine($"캐릭터 {name} 생성!");
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"이름: {name}");
            Console.WriteLine($"레벨: {level}");
            Console.WriteLine($"HP: {hp}/{Maxhp}");
            Console.WriteLine($"공격력: {attack}");
            Console.WriteLine($"방어력: {defense}");
        }


    }

    // 자식 클래스 (파생 클래스, Derived Class)
    class Warrior : Character  // : Character로 상속
    {
        // 상속받은 멤버 + 추가 멤버
        private int rage; //전사만의 고유 속성

        public Warrior(string name):base(name)
        {
            name = "전사"; //base.name 과 같다.
            attack = 60;
            defense = 40;
            Maxhp = 150;
            hp = Maxhp;
            rage = 0;

            Console.WriteLine("직업: 전사");
        }
        public override void ShowInfo()
        {
            base.ShowInfo(); //부모의 ShowInfo 호출
            Console.WriteLine($"분노: {rage}");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== 캐릭터 생성 ===");
            Character character = new Character("석대");
            character.ShowInfo();

            Console.WriteLine("=== 캐릭터 생성 ===");
            Character character1 = new Warrior("석대");
            character1.ShowInfo();

            Console.WriteLine("=== 캐릭터 생성 ===");
            Warrior warrior = new Warrior("홍길동");
            warrior.ShowInfo();

            //상속관계
            //자식 호출 -> 부 > 생성자
            //            자 > 생성자
            //            자 > 소멸자
            //            부 > 소멸자

        }
    }
}
