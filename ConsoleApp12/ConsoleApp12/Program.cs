using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var를 사용하여 변수 자동추론 및 선언
            //var name = "Alice"; //문자열로 추론
            //var age = 25;       //정수로 추론
            //var isStudent = true; //논리값으로 추론

            //Console.WriteLine($"이름: {name}, 나이: {age}, 학생여부: {isStudent}");

            ////default 키워드를 사용한 기본값 설정
            //int defaultInt = default; //0으로 초기화
            //string defaultString = default; //null로 초기화
            //bool defaultBool = default; //false로 초기화

            //Console.WriteLine($"기본 정수값: {defaultInt}, 기본 문자열값: {defaultString}, 기본 논리값: {defaultBool}");

            //1. 암시적 변환 (작은 타입 -> 큰 타입)
            //int smallNumber = 100;
            //long bigNumber = smallNumber; //int -> long으로 암시적 변환*(자동변환)
            //double doubleNumber = smallNumber; //int -> double로 암시적 변환*(자동변환)

            //Console.WriteLine("=== 암시적 변환 ===");
            //Console.WriteLine($"int: {smallNumber.GetType()}");
            //Console.WriteLine($"long: {bigNumber.GetType()}");
            //Console.WriteLine($"double: {doubleNumber.GetType()}");

            ////2. 명시적 변환 (큰 타입 -> 작은 타입)
            //double pi = 3.14159;
            //int intPi = (int)pi; //소수점 이하 버림 명시적 변환

            //Console.WriteLine("=== 명시적 변환 ===");
            //Console.WriteLine($"double: {pi}");
            //Console.WriteLine($"int로 변환: {intPi}");

            //3. 문자열을 숫자로변환
            string scoreText = "95";
            int score = int.Parse(scoreText); //문자열을 정수로 변환

            string PriceText = "19.99";
            double price = double.Parse(PriceText); //문자열을 실수로 변환

            Console.WriteLine("=== 문자열을 숫자로 변환 ===");
            Console.WriteLine($"점수(문자열):{scoreText} -> 숫자:{score}");
            Console.WriteLine($"가격(문자열):{PriceText} -> 숫자:{price}");

            //4. 숫자를 문자열로 변환
            int platerLevel = 50;
            string levelText = platerLevel.ToString();

            Console.WriteLine("=== 숫자를 문자열로 변환 ===");
            Console.WriteLine($"플레이어 레벨(숫자):{platerLevel} -> 문자열:{levelText}");






        }
    }
}
