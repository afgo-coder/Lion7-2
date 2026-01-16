using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp42
{
    class Character
    {
        private int Att;
        //Get / Set 함수
        //public void SetAtt(int _Att)
        //{
        //    Att= _Att;
        //}
        //public int GetAtt()
        //{
        //    return Att;
        //}

        //private int health;
        //public int Health
        //{
        //    get { return health; }
        //    set
        //    {
        //        if (value < 0) health = 0;
        //        else health = value;
        //    }
        //}

        // 자동 프로퍼티
        public int Level { get; set; }

        // 읽기 전용
        public int MaxHP { get; private set; }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Character c = new Character();
            //c.SetAtt(10); //_Att 에 10을 넣었기 때문에 Att는 10으로 변함

            //Console.WriteLine($"공격력: {c.GetAtt()}");





        }
    }
}
