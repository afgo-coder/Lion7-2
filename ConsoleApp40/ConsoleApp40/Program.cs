using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp40
{
    class Character
    {
        //필드 : 클래스의 데이터
        private string Name;
        private int level;
        private int hp;
        private int maxHP;
        private int mp;
        private int maxMP;

        //public Character(string name, int level, int hp, int maxHP, int mp, int maxMP)
        //{
        //    Name = name;
        //    this.level = level;
        //    this.hp = hp;
        //    this.maxHP = maxHP;
        //    this.mp = mp;
        //    this.maxMP = maxMP;
        //}
        public void SetInfo(string _name, int _level, int _hp, int _maxHP, int _mp, int _maxMP)
        { 
            Name = _name;
            level = _level;
            hp = _hp;
            maxHP = _maxHP;
            mp = _mp;
            maxMP = _maxMP;
        }




        //메서드: 클래스의 기능
        public void ShowInfo()
        {
            Console.WriteLine($"━━━━━━━━━━━━━━━━━━━━━━");
            Console.WriteLine($"이름: {Name}");
            Console.WriteLine($"레벨: {level}");
            Console.WriteLine($"HP: {hp}/{maxHP}");
            Console.WriteLine($"HP: {mp}/{maxMP}");
            Console.WriteLine($"━━━━━━━━━━━━━━━━━━━━━━");
        }
        public void TakeDamage(int damage)
        {
            hp -= damage;
            if (hp < 0) hp= 0;
            Console.WriteLine($"{Name}이(가) {damage} 데미지를 받았습니다!");
            Console.WriteLine($"남은 HP: {hp}/{maxHP}");
        }
        public void Heal(int amount)
        {
            hp += amount;
            if (hp > maxHP) hp = maxHP;
            Console.WriteLine($"{Name}의 HP가 {amount} 회복되었습니다!");
            Console.WriteLine($"현재 HP: {hp}/{maxHP}");
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {

            //객체 생성

            Character player1 = new Character();
            //player1.Name = "홍길동";
            //player1.level = 10;
            //player1.hp = 150;
            //player1.maxHP = 150;
            //player1.mp = 80;
            //player1.maxMP = 80;
            player1.SetInfo("홍길동", 10, 150, 150, 80, 80);
            player1.ShowInfo();
            player1.TakeDamage(50);
            player1.Heal(30);

            Character player2 = new Character();
            //player2.Name = "김민수";
            //player2.level = 20;
            //player2.hp = 300;
            //player2.maxHP = 500;
            //player2.mp = 200;
            //player2.maxMP = 220;
            player2.SetInfo("김민수", 20, 300, 500, 200, 220);
            player2.ShowInfo();
            player2.TakeDamage(100);
            player2.Heal(150);


        }
    }
}
