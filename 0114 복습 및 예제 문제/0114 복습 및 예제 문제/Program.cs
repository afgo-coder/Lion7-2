using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _0114_복습_및_예제_문제
{
    //문제 1: 동물원 시스템

    //Animal 부모 클래스와 다양한 동물 자식 클래스를 만들고,
    //다형성으로 관리하세요.
    public class Animal //부모 클래스
    {
        public string name;
        public int count;
        public Animal(string _name, int _count)
        {
            name = _name;
            count = _count;
        }
        public virtual void Info()
        {
            Console.WriteLine($"이름: {name}");
            Console.WriteLine($"개체 수: {count}");
        }
    }
    public class Meat : Animal //자식 클래스 육식 
    {
        public string meal;
        public Meat(string _name, int _count, string _meal) : base(_name, _count)
        {
            meal = _meal;
        }
        public override void Info()
        {
            base.Info();
            Console.WriteLine($"식사 유형: {meal}");
        }
    }
    public class Vege : Animal //자식 클래스 초식
    {
        public string meal;
        public Vege(string _name, int _count, string _meal) : base(_name, _count)
        {
            meal = _meal;
        }
        public override void Info()
        {
            base.Info();
            Console.WriteLine($"식사 유형: {meal}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal Lion = new Meat("사자", 3, "육식");
            Animal Tiger = new Meat("호랑이", 4, "육식");

            Lion.Info();
            Tiger.Info();

            Animal Hippo = new Vege("하마",5,"초식");
            Animal Hores = new Vege("말", 8, "초식");

            Hippo.Info();
            Hores.Info();
        }
    }
}
