using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static C_미니프로젝트_상자먹기_게임_.Player;


namespace C_미니프로젝트_상자먹기_게임_
{
    public class Box  // 추가: 상자 클래스
    {
        public int BoxX { get; set; }
        public int BoxY { get; set; }
        public bool IsEaten { get; set; } = false;

        public Box(int x, int y)
        {
            BoxX = x;
            BoxY = y;
        }
        public void Draw()
        {
            if (!IsEaten)
            {
                Console.SetCursorPosition(BoxX, BoxY);
                Console.Write("▦");  // 상자 모양
            }
        }
    }
    public class Player
    {
        [DllImport("msvcrt.dll")]
        static extern int _getch();

        public int playerX;
        public int playerY;
        public static int Score = 0;

        public Player()
        {
            playerX = 1;
            playerY = Console.WindowHeight - 2;
        }

        public void GameMain(int remainingBoxes)
        {
            KeyControl();
            PlayerDraw();
            UIscore();
            UITargetCount(remainingBoxes);
        }

        public void KeyControl()
        {
            int pressKey;
            if (Console.KeyAvailable)
            {
                pressKey = _getch();
                if (pressKey == 224) pressKey = _getch();

                switch (pressKey)
                {
                    case 72:
                        playerY--;
                        if (playerY < 1) playerY = 1;
                        break;
                    case 75:
                        playerX--;
                        if (playerX < 1) playerX = 1;
                        break;
                    case 77:
                        playerX++;
                        if (playerX > 78) playerX = 78;
                        break;
                    case 80:
                        playerY++;
                        if (playerY > 23) playerY = 23;
                        break;
                }
            }
        }
        public class Enemy  // 
        {
            public int EnemyX { get; set; }
            public int EnemyY { get; set; }

            public Enemy(int x, int y)
            {
                EnemyX = x;
                EnemyY = y;
            }

            public void Draw()
            {
                Console.SetCursorPosition(EnemyX, EnemyY);
                Console.Write("X");  // 표시 유지
            }
        }
        public void PlayerDraw()
        {
            string[] player = new string[] { "^□^" };
            for (int i = 0; i < player.Length; i++)
            {
                Console.SetCursorPosition(playerX, playerY + i);
                Console.WriteLine(player[i]);
            }
        }

        public void UIscore()
        {
            Console.SetCursorPosition(63, 0);
            Console.Write("┏━━━━━━━━━━━━━━┓");
            Console.SetCursorPosition(63, 1);
            Console.Write("┃              ┃");
            Console.SetCursorPosition(65, 1);
            Console.Write("Score : " + Score);
            Console.SetCursorPosition(63, 2);
            Console.Write("┗━━━━━━━━━━━━━━┛");
        }
    
    public void UITargetCount(int remainingBoxes)
        {
            Console.SetCursorPosition(63, 3);
            Console.Write("┏━━━━━━━━━━━━━━┓");
            Console.SetCursorPosition(63, 4);
            Console.Write("┃              ┃");
            Console.SetCursorPosition(65, 4);
            Console.Write("남은 박스: " + remainingBoxes);
            Console.SetCursorPosition(63, 5);
            Console.Write("┗━━━━━━━━━━━━━━┛");
        }
    }

    internal class Program
    {
        static void Draw(int width, int height)
        {
            Console.SetCursorPosition(0, 0);
            Console.Write("┌" + new string('─', width - 2) + "┐");
            Console.SetCursorPosition(0, height - 1);
            Console.Write("└" + new string('─', width - 2) + "┘");
            for (int y = 1; y < height - 1; y++)
            {
                Console.SetCursorPosition(0, y);
                Console.Write("│");
                Console.SetCursorPosition(width - 1, y);
                Console.Write("│");
            }
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.SetWindowSize(81, 25);
            Console.SetBufferSize(81, 25);
            

            Console.Clear();
            Draw(80, 25);
            Console.SetCursorPosition(35, 10);  // 화면 중앙 근처
            Console.Write("게임 시작!");
            Console.SetCursorPosition(25, 12);
            Console.Write("아무 키나 눌러 게임을 시작하세요.");
            Console.ReadKey();  // 키 입력 대기

            int stage = 1;  // 현재 스테이지
            const int maxStages = 5;  // 최대 라운드

            while (stage <= maxStages)
            {             
                Console.Clear();
                Draw(80, 25);
                Console.SetCursorPosition(30, 11);
                Console.Write("스테이지 " + stage + " 시작!");
                System.Threading.Thread.Sleep(1000);  // 1초 대기 후 바로 진행

                // 게임 초기화
                Player player = new Player();
                List<Box> boxes = new List<Box>();
                List<Enemy> enemies = new List<Enemy>(); 
                Random rand = new Random();

                int boxCount = 3 + (stage - 1);
                for (int i = 0; i < boxCount; i++)
                {
                    int x, y;
                    do
                    {
                        x = rand.Next(2, 63);  // 점수창 피하기 위해 X 최대 62
                        y = rand.Next(2, 23);
                    } while (boxes.Exists(b => b.BoxX == x && b.BoxY == y));
                    boxes.Add(new Box(x, y));
                }

                int enemyCount = 5 + (stage - 1);  // 변수명
                for (int i = 0; i < enemyCount; i++)
                {
                    int x, y;
                    do
                    {
                        x = rand.Next(2, 63);  //점수창 피하기 위해 X 최대 62
                        y = rand.Next(2, 23);
                    } while (boxes.Exists(b => b.BoxX == x && b.BoxY == y) || enemies.Exists(e => e.EnemyX == x && e.EnemyY == y));
                    enemies.Add(new Enemy(x, y));
                }

                int dwTime = Environment.TickCount;
                bool stageCleared = false;

                while (!stageCleared)
                {
                    if (dwTime + 150 < Environment.TickCount)
                    {
                        Console.Clear();
                        Draw(80, 25);

                        foreach (var box in boxes)
                        {
                            box.Draw();
                        }

                        // 변경: Enemy 그리기
                        foreach (var enemy in enemies)
                        {
                            enemy.Draw();
                        }

                        player.GameMain(boxes.Count);

                        // 상자 충돌 체크
                        for (int i = boxes.Count - 1; i >= 0; i--)
                        {
                            var box = boxes[i];
                            if (!box.IsEaten && player.playerX <= box.BoxX && box.BoxX < player.playerX + 3 &&
                                player.playerY <= box.BoxY && box.BoxY < player.playerY + 1)
                            {
                                box.IsEaten = true;
                                Player.Score += 100;
                                boxes.RemoveAt(i);
                            }
                        }

                        if (boxes.Count == 0)
                        {
                            stageCleared = true;
                            stage++;
                            // 변경: 메시지 제거, 바로 다음 스테이지
                            break;
                        }

                        // 변경: Enemy 충돌 체크
                        foreach (var enemy in enemies)
                        {
                            if (player.playerX <= enemy.EnemyX && enemy.EnemyX < player.playerX + 3 &&
                                player.playerY <= enemy.EnemyY && enemy.EnemyY < player.playerY + 1)
                            {
                                Console.Clear();
                                Console.SetCursorPosition(27, 10);
                                Console.Write("게임 오버! 최종 점수: " + Player.Score);
                                Console.SetCursorPosition(29, 12);
                                Console.Write("게임을 종료합니다");
                                Console.ReadKey();
                                return;
                            }
                        }

                        dwTime = Environment.TickCount;
                    }
                }
            }

            // 최대 라운드 클리어 시 승리
            Console.Clear();
            Console.SetCursorPosition(15, 10);
            Console.Write("축하합니다! 모든 스테이지를 클리어했습니다!");
                                 
        }
    }
}