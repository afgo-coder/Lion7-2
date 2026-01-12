using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace _0109_복습
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //배열 선언을 이용해 표 만들기
            //과목별 최고·최저 점수 및 학생명 출력(난이도: 중)
            //각 과목의 최고점과 최저점을 구하고, 그 점수를 얻은 학생 이름을 출력하라(동점 처리 포함).

            //학생 : 김민수 김철수 이지훈 강유진
            //과목 : 국어 과학 수학 사회
            //점수 : (89,90,100,78) (88,85,77,95) (78,100,100,80) (95,98,97,96) 

            string[] name = { "김민수", "김철수", "이지훈", "강유진" };
            string[] subject = { "국어", "과학", "수학", "사회" };
            int[,] score = new int[4, 4]
                {
                    { 89,90,100,78},
                    { 88,85,77,95 },
                    { 78,100,100,80},
                    { 95,98,97,96 }
                };

            Console.WriteLine("=== 성적 발표 ===");
            
            Console.Write("이름\t");
            foreach (string subjects in subject)
            {
                Console.Write($"{subjects}\t");
            }
            Console.WriteLine("평균");
            Console.WriteLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");
            for (int i = 0; i < score.GetLength(0); i++)      
            {
                Console.Write($"{name[i]}\t");
                int sum = 0;
                for (int j = 0; j < score.GetLength(1); j++)
                {
                    Console.Write($"{score[i, j]}\t");
                    sum += score[i, j];
                }
                double average = (double)sum / score.GetLength(1);
                Console.WriteLine($"{average:F1}");
            }
            Console.WriteLine("=== 과목별 평균 ===");
            for (int subjects = 0; subjects < score.GetLength(1); subjects++)            
            {
                int sum = 0;
                for (int student = 0; student < score.GetLength(0); student++)
                {
                    sum += score[student,subjects];
                }
                double avg = (double)sum / score.GetLength(0);
                Console.WriteLine($"{subject[subjects]}: {avg:F1}점");
            }
            Console.WriteLine("\n=== 과목별 최고점과 최저점 ===");
            for (int j = 0; j < score.GetLength(1); j++)
            {
                int maxScore = int.MinValue;
                int minScore = int.MaxValue;
                List<string> maxStudents = new List<string>();
                List<string> minStudents = new List<string>();

                for (int i = 0; i < score.GetLength(0); i++)
                {
                    int currentScore = score[i, j];
                    if (currentScore > maxScore)
                    {
                        maxScore = currentScore;
                        maxStudents.Clear();
                        maxStudents.Add(name[i]);
                    }
                    else if (currentScore == maxScore)
                    {
                        maxStudents.Add(name[i]);
                    }

                    if (currentScore < minScore)
                    {
                        minScore = currentScore;
                        minStudents.Clear();
                        minStudents.Add(name[i]);
                    }
                    else if (currentScore == minScore)
                    {
                        minStudents.Add(name[i]);
                    }
                }

                string maxNames = string.Join(", ", maxStudents);
                string minNames = string.Join(", ", minStudents);
                Console.WriteLine($"{subject[j]}: 최고점 {maxScore} ({maxNames}), 최저점 {minScore} ({minNames})");
            }





        }
    }
}
