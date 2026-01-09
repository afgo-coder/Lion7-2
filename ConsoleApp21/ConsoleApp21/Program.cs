using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //int i = 0;

            //while (i < 5) //조건이 ture일 경우 반복문
            //{

            //    Console.WriteLine(i);
            //    i++; //내가 설정해두는 위치에 따라 값이 다름 출력문 앞에 두면 1~5 뒤에 두면 0~4 

            //}

            //Console.WriteLine("=== 카운트다운 ===");
            //int i = 10;

            //while (i > 0)
            //{
            //    Console.WriteLine(i);
            //    i--;
            //}

            // 합계 구하기 (1+2+3+4+5)
            //int sum = 0;
            //int i = 1;

            //while (i <= 5)
            //{
            //    sum = sum + i;
            //    Console.WriteLine($"합계:{sum}");
            //    i++;
            //}

            // 특정 값까지 반복
            //Console.WriteLine("=== 목표 달성하기 ===");
            //int coins = 0;
            //int target = 50;
            //int day = 0;

            //while (coins < target)
            //{
            //    coins += 10; day++;
            //    Console.WriteLine($"{day}일차: 코인 {coins}개");

            //}
            //Console.WriteLine($"목표달성! {day}일 걸렸습니다.");

            //do-while

            //int x = 5; 

            //do //1회 실행후 밑 while 반복문을 통해 반복여부를 확인(다른 반복문 내부에서 조건을 무시하고 사용가능) 
            //{
            //    Console.WriteLine("최소 한번 실행됩니다.");
            //    x--;

            //} while (x > 0);

            //string choice;
            //int totalPrice = 0;

            //do
            //{
            //    //메뉴출력
            //    Console.WriteLine("메뉴판");
            //    Console.WriteLine("1. 짜장면 - 5,000원");
            //    Console.WriteLine("2. 짬뽕 - 6,000원");
            //    Console.WriteLine("3. 탕수육 - 15,000원");
            //    Console.WriteLine("4. 볶음밥 - 7,000원");
            //    Console.WriteLine("0. 주문완료");
            //    Console.WriteLine("===============================");
            //    Console.WriteLine("메뉴 번호를 선택하세요: ");
            //    choice = Console.ReadLine();

            //    메뉴 선택 처리
            //    switch (choice)
            //    {
            //        case "1":
            //            Console.WriteLine("짜장면 추가! (+5,000원)");
            //            totalPrice += 5000;
            //            break;
            //        case "2":
            //            Console.WriteLine("짬뽕 추가! (+6,000원)");
            //            totalPrice += 6000;
            //            break;
            //        case "3":
            //            Console.WriteLine("탕수육 추가! (+15,000원)");
            //            totalPrice += 15000;
            //            break;
            //        case "4":
            //            Console.WriteLine("볶음밥 추가! (+7,000원)");
            //            totalPrice += 7000;
            //            break;
            //        case "0":
            //            Console.WriteLine("주문을 완료합니다.");
            //            break;
            //        default:
            //            Console.WriteLine("잘못된 선택입니다");
            //            break;


            //    }
            //    0번 선택 전까지
            //    if (choice != "0")
            //    {
            //        Console.WriteLine($"현재 총액: {totalPrice:N0}원");
            //    }




            //} while (choice != "0"); //0을 입력할때까지 반복

            //for (int i = 0; i <= 10; i++)
            //{ 
            //if(i == 5)
            //        break;//조건이 맞는다면 반복X
            //    Console.WriteLine(i);
            //}

            //for (int i = 0; i <= 10; i++)
            //{
            //    if (i == 5)
            //        continue;//조건에 맞는것을 건너뛰기

            //    Console.WriteLine(i);
            //}
            //for (int j = 1; j <= 10; j++)
            //{
            //    if (j % 2 == 0) continue; // 홀수만 표기
            //    //j를 2로 나누어서 나머지가 0이라면 건너뛰기
            //    Console.WriteLine(j);
            //}

            //goto는 레이블로 이동. 신중하게 사용해야함

            //int n = 1;

            //천마귀환:

            //if (n <= 5)
            //{
            //    Console.WriteLine(n);
            //    n++;
            //    goto 천마귀환; //레이블로 이동
            //}

            //천마강림:
            //Console.WriteLine("천마강림하셨습니다.");









        }
    }
}
