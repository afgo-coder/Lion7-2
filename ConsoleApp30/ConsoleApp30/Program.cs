using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);

            string[] player = new string[]
                {
                    "->",
                    ">>>",
                    "->"
                }; //배열 문자열로 그리기
            string missile = "->";
            int playerX = 0;
            int playerY = 12;
            int missileX = -1;
            int missileY = -1;
            List<(int x, int y)> missiles = new List<(int, int)>();
            ConsoleKeyInfo keyinfo; //키정보
            Console.CursorVisible = false; //콘솔창 커서 안보이게하기

            //Sleep(1000) 1초동안 프로그램을 잠시멈춤
            //지연방법 시간을 계산해서 1초 루프
            int dwTime = Environment.TickCount; // 1/1000 초가 흐릅니다





            while (true)
            {
                //1초 루프
                if (dwTime + 100 < Environment.TickCount)
                {
                    //현재 시간 세팅
                    dwTime = Environment.TickCount;

                    Console.Clear();
                    //키역영                   

                    if (Console.KeyAvailable)
                    {
                        keyinfo = Console.ReadKey(true); //키 입력 받기 

                        

                        switch (keyinfo.Key)
                        {
                            case ConsoleKey.UpArrow: if (playerY > 0) playerY--; break;
                            case ConsoleKey.DownArrow: if (playerY < Console.WindowHeight - 3) playerY++; break;
                            case ConsoleKey.LeftArrow: if (playerX > 0) playerX--; break;
                            case ConsoleKey.RightArrow: if (playerX < Console.WindowWidth - 3) playerX++; break;
                            case ConsoleKey.Spacebar:
                                if (missiles.Count < 6)
                                    missiles.Add((playerX + 3, playerY + 1)); break;
                            case ConsoleKey.Escape: return; //ESC키로 종료
                        } //switch
                      
                    }//if 2
                     // 모든 미사일 이동 및 그리기
                    for (int i = missiles.Count - 1; i >= 0; i--)
                    {
                        var missile_pos = missiles[i];
                        missile_pos.x += 2;  // 오른쪽으로 이동

                        if (missile_pos.x > Console.WindowWidth)
                        {
                            missiles.RemoveAt(i);  // 화면 벗어난 미사일 제거
                        }
                        else
                        {
                            Console.SetCursorPosition(missile_pos.x, missile_pos.y);
                            Console.Write(missile);
                            missiles[i] = missile_pos;  // 변경된 위치 저장
                        }
                    }

                    for (int i = 0; i < player.Length; i++)
                    {                        
                        Console.SetCursorPosition(playerX, playerY + i);
                        Console.WriteLine(player[i]);                      
                    }//for

                }//if 1
              

            }//while


            












































































        }
    }
}
