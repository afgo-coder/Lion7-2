using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _0113_프로퍼티_예제문제
{
    internal class Program
    {
        class Student
        {
            // TODO: 필드 선언
            private string Name;
            private int Score;
         
                

            // TODO: Name 프로퍼티 (읽기 전용)
            public string name
            {
                get { return Name; }
            }
            // TODO: Score 프로퍼티 (0~100 검증)
            public int score
            {
                get { return Score; }
                set
                {
                    if (value < 0)
                    {
                        Console.WriteLine($"점수는 0~100사이여야 합니다.(입력값 : {value})");
                        Score = 0;
                    }
                    else if (value > 100)
                    {
                        Console.WriteLine($"점수는 0~100사이어야 합니다. (입력값: {value})");
                        Score = 100;
                    }
                    else
                    {
                        Score = value;
                    }
                }
            }
            // TODO: Grade 프로퍼티 (자동 계산, 읽기 전용)
            public string Grade
            {
                get
                {
                    if (score >= 90) return "A";
                    else if (score >= 80) return "B";
                    else if (score >= 70) return "C";
                    else if (score >= 60) return "D";
                    else return "F";
                }                
            }
            // 생성자
            public Student(string studentName)
            {
                // TODO: 구현
                Name = studentName;
                Score = 0;

            }

            // 정보 출력
            public void ShowInfo()
            {
                Console.WriteLine($"━━━━━━━━━━━━━━━━");
                Console.WriteLine($"이름: {Name}");
                Console.WriteLine($"점수: {Score}점");
                Console.WriteLine($"등급: {Grade}");
                Console.WriteLine($"━━━━━━━━━━━━━━━━");
            }
        }
        static void Main(string[] args)
        {
            Student student = new Student("홍길동");

            student.score = 95;
            student.ShowInfo();

            Console.WriteLine();

            student.score = 75;
            student.ShowInfo();

            Console.WriteLine();

            // 잘못된 값 입력 시도
            student.score = 150;  // 100으로 제한되어야 함
            student.score = -10;  // 0으로 제한되어야 함
            student.ShowInfo();
        }
    }
}
