using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //숫자 데이터 형식: 정수와 실수를 다룰때 사용하는 다양한 형식
            //int integerNum = 10; //정수형
            //float floatNum = 3.14f; //단정밀도 실수형
            //double doubleNum = 3.14159; //배정밀도 실수형

            //Console.WriteLine(integerNum);
            //Console.WriteLine( floatNum);
            //Console.WriteLine(doubleNum);

            byte Level = 50; //0~255
            short attack = 1500; //공격력
            int gold = 1234567; //소지금
            long exp = 99999999; //경험치

            Console.WriteLine("=== 캐릭터 정보 ===");
            Console.WriteLine($"레벨: {Level}" );
            Console.WriteLine($"공격력: {attack}");
            Console.WriteLine($"소지금: {gold}");
            Console.WriteLine($"경험치: {exp}");

            //타입별 최대값 확인
            Console.WriteLine("=== 타입별 최대값 ===");
            Console.WriteLine($"byte 최대값: {byte.MaxValue}");
            Console.WriteLine($"short 최대값: {short.MaxValue}");
            Console.WriteLine($"int 최대값: {int.MaxValue}");
            Console.WriteLine($"long 최대값: {long.MaxValue}");



        }
    }
}
