using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// 사용자 입력을 문자열로 받기
            //Console.Write("이름을 입력하세요: ");
            //string userName = Console.ReadLine(); // 사용자가 입력한 값을 읽어서 userName 변수에 저장
            //// Console.ReadLine(); 입력을 받아서 읽을수있다

            //Console.WriteLine($"안녕하세요,{userName}님!");//입력값 출력

            //문자열을 정수로 변환
            //Console.Write("나이를 입력하세요: ");
            //string Input = Console.ReadLine();
            //int age = int.Parse(Input); // 문자열을 정수로 변환

            //Console.WriteLine($"내년에는 {age + 1}살이 되겠군요!.");

            //이진수를 정수로 변환
            //Console.Write("2진수를 입력하세요: ");
            //string binaryInput = Console.ReadLine();
            //int dcimalValue = Convert.ToInt32(binaryInput, 2); // 2진수->10진수 변환
            ////정수를 이진수로 변환
            //string binaryOutput = Convert.ToString(dcimalValue, 2); // 10진수->2진수 변환

            //Console.WriteLine($"입력한 2진수: {binaryInput}"); // ex: 1010
            //Console.WriteLine($"10진수로 변환: {dcimalValue}"); //ex: 10
            //Console.WriteLine($"다시 2진수로 변환: {binaryOutput}"); //ex: 1010

            //=== 캐릭터 생성 ===
            //캐릭터 이름을 입력하세요: 홍길동
            //환영합니다, 홍길동님!
            //시작 레벨을 입력하세요: 5
            //홍길동님의 시작 레벨은 5입니다.

            Console.WriteLine("=== 캐릭터 생성 ===");
            Console.Write("캐릭터 이름을 입력하세요: ");
            string NameInput = Console.ReadLine();
            Console.WriteLine($"환영합니다, {NameInput}님!");
            Console.Write("시작 레벨을 입력하세요: ");
            string levelInput = Console.ReadLine();
            int level = int.Parse(levelInput);
            Console.WriteLine($"{NameInput}님의 시작 레벨은 {level}입니다.");




        }
    }
}
