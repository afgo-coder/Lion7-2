using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp37
{
    internal class Program
    {
        static void Swap1(int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        static void Swap(ref int a, ref int b) //참조문을 활용한 스왑
        {
            int temp = a;
            a = b;
            b = temp;
        }
        static void Main(string[] args)
        {
            int x = 10;
            int y = 20;
            int temp;
            //swap
            //temp = x; //temp에 10을 담음
            //x = y; //10이 없어진 x에 y값 20을 담고
            //y = temp; //20이 없어진 y에 temp에 담아둔 10을 입력
            Swap(ref x, ref y);
            Console.WriteLine("x:" + x + " y:" + y);



        }
    }
}
