using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace 슈팅게임만들기
{
    //미사일 클래스
    public class Bullet
    {
        public int x;
        public int y;
        public bool fire;
    }

    //플레이어 클래스
    public class Player
    {
        [DllImport("msvcrt.dll")]
        static extern int _getch(); //c언어 함수 가져옴

        public int playerX;
        public int playerY;

        public Bullet[] playerBullet = new Bullet[20]; //20개를 먼저 생성후 준비된 미사일 사용
        public Bullet[] playerBullet2 = new Bullet[20];
        public Bullet[] playerBullet3 = new Bullet[20];
        public int Score = 100;
        //아이템
        public Item item = new Item();
        public int itemCount = 0;


        public Player() //생성자
        {
            //플레이어 좌표위치 초기화
            playerX = 0;
            playerY = 12;

            for (int i = 0; i < 20; i++) //총알 20개 초기화
            {
                playerBullet[i] = new Bullet();
                playerBullet[i].x = 0; 
                playerBullet[i].y = 0;
                playerBullet[i].fire = false;

                playerBullet2[i] = new Bullet();
                playerBullet2[i].x = 0;
                playerBullet2[i].y = 0;
                playerBullet2[i].fire = false;

                playerBullet3[i] = new Bullet();
                playerBullet3[i].x = 0;
                playerBullet3[i].y = 0;
                playerBullet3[i].fire = false;
            }

        }
        public void GameMain()
        {
            //키를 입력하는 부분
            KeyControl();
            //플레이어를 그려준다.
            PlayerDraw();
            //UI점수
            UIscore();

            if (item.ItemLife)
            {              
                item.ItemDraw();
                //아이템 충돌
                CrashItem();
            }
        }

        //아이템 충돌이 일어나면 양쪽미사일 발사
        public void CrashItem()
        {
            if (playerY + 1 == item.itemY)
            {
                if (playerX >= item.itemX - 2
                    && playerX <= item.itemX + 2)
                {
                    item.ItemLife = false;

                    if (itemCount < 3)
                        itemCount++;

                    for (int i = 0; i < 20; i++) //총알 20개 초기화
                    {
                        playerBullet[i] = new Bullet();
                        playerBullet[i].x = 0;
                        playerBullet[i].y = 0;
                        playerBullet[i].fire = false;

                        playerBullet2[i] = new Bullet();
                        playerBullet2[i].x = 0;
                        playerBullet2[i].y = 0;
                        playerBullet2[i].fire = false;

                        playerBullet3[i] = new Bullet();
                        playerBullet3[i].x = 0;
                        playerBullet3[i].y = 0;
                        playerBullet3[i].fire = false;
                    }
                }
            }
        }

        public void KeyControl()
        {
            int pressKey; //정수형 변수선언 키값 받을거임

            if (Console.KeyAvailable) //키가 눌렸을때
            {
                pressKey = _getch(); //아스키값 왼쪽 오른쪽등
                if (pressKey == 224) pressKey = _getch();

                switch (pressKey)
                {
                    case 72: //위쪽방향 아스키코드
                        playerY--;
                        if (playerY < 1)
                            playerY = 1;
                        break;
                    case 75:
                        //왼쪽 화살표키
                        playerX--;
                        if (playerX < 0)
                            playerX = 0;
                        break;
                    case 77:
                        //오른쪽
                        playerX++;
                        if (playerX > 75)
                            playerX = 75;
                        break;
                    case 80: //아래
                        playerY++;
                        if (playerY > 21)
                            playerY = 21;
                        break;
                    case 32: //스페이스바
                             //총알 발사
                        for (int i = 0; i < 20; i++)
                        {
                            //미사일이 false 발사가능
                            if (playerBullet[i].fire == false)
                            {
                                playerBullet[i].fire = true;
                                //플레이어 앞에서 미사일 쏘기 +5
                                playerBullet[i].x = playerX + 5;
                                playerBullet[i].y = playerY + 1;
                                //한발씩 쏘겠다.
                                break;
                            }
                        }
                        //총알2 발사
                        for (int i = 0; i < 20; i++)
                        {
                            //미사일이 false 발사가능
                            if (playerBullet2[i].fire == false)
                            {
                                playerBullet2[i].fire = true;
                                //플레이어 앞에서 미사일 쏘기 + 5
                                playerBullet2[i].x = playerX + 5;
                                playerBullet2[i].y = playerY;
                                //한발씩 쏘겠다.
                                break;
                            }
                        }

                        //총알3 발사
                        for (int i = 0; i < 20; i++)
                        {
                            //미사일이 false 발사가능
                            if (playerBullet3[i].fire == false)
                            {
                                playerBullet3[i].fire = true;
                                //플레이어 앞에서 미사일 쏘기 + 5
                                playerBullet3[i].x = playerX + 5;
                                playerBullet3[i].y = playerY + 2;
                                //한발씩 쏘겠다.
                                break;
                            }
                        }

                        break;                       
                }
            }
        }
        public void BulletDraw()
        {
            string bullet = "->";

            for (int i = 0; i < 20; i++)
            {
                if (playerBullet[i].fire == true)
                {
                    Console.SetCursorPosition(playerBullet[i].x - 1, playerBullet[i].y);
                    Console.Write(bullet);

                    playerBullet[i].x++;

                    if (playerBullet[i].x > 78)
                    {
                        playerBullet[i].fire = false;   
                    }

                }
            }
        } 
        //미사일 그리기2 
        public void BulletDraw2()
        {
            string bullet = "->"; //미사일모습

            //20개
            for (int i = 0; i < 20; i++)
            {
                //미사일이 살아있는 상태
                if (playerBullet2[i].fire == true)
                {
                    //좌표설정 -> 중간위치를 위해 보정을 위해 x-1
                    Console.SetCursorPosition(playerBullet2[i].x - 1, playerBullet2[i].y);
                    //총알 출력
                    Console.Write(bullet);

                    playerBullet2[i].x++; //미사일 오른쪽으로 날라가기

                    if (playerBullet2[i].x > 78)
                    {
                        playerBullet2[i].fire = false;  //미사일 false 다시 준비상태
                    }
                }
            }
        }

        public void BulletDraw3()
        {
            string bullet = "->"; //미사일모습

            //20개
            for (int i = 0; i < 20; i++)
            {
                //미사일이 살아있는 상태
                if (playerBullet3[i].fire == true)
                {
                    //좌표설정 -> 중간위치를 위해 보정을 위해 x-1
                    Console.SetCursorPosition(playerBullet3[i].x - 1, playerBullet3[i].y);
                    //총알 출력
                    Console.Write(bullet);

                    playerBullet3[i].x++; //미사일 오른쪽으로 날라가기

                    if (playerBullet3[i].x > 78)
                    {
                        playerBullet3[i].fire = false;  //미사일 false 다시 준비상태
                    }
                }
            }
        }

        public void PlayerDraw()
        {
            string[] player = new string[]
            {
                "->",
                ">>>",
                "->"
            }; //배열 문자열로 그리기

            for (int i = 0; i < player.Length; i++)
            {
                //콘솔좌표 설정
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

        //충돌처리 적 구현하고나서 함수구현
        public void ClashEnemyAndBullet(Enemy enemy)
        {
            for (int i = 0; i < 20; i++)
            {
                //살아있는 미사일
                if (playerBullet[i].fire == true)
                {   //미사일과 적의 y값이 같을때
                    if (playerBullet[i].y == enemy.enemyY)
                    {   //미사일이 적의 x값 범위내에 들어갔을때
                        if (playerBullet[i].x >= (enemy.enemyX - 1)
                            && playerBullet[i].x <= (enemy.enemyX + 1))
                        {
                            //아이템
                            item.ItemLife = true;
                            item.itemX = enemy.enemyX;
                            item.itemY = enemy.enemyY;


                            //충돌
                            Random rand = new Random();
                            enemy.enemyX = 75;
                            enemy.enemyY = rand.Next(2, 22);

                            //스코어
                            Score += 100;
                        }
                    }
                }
                if (playerBullet2[i].fire == true)
                {   //미사일과 적의 y값이 같을때
                    if (playerBullet2[i].y == enemy.enemyY)
                    {   //미사일이 적의 x값 범위내에 들어갔을때
                        if (playerBullet2[i].x >= (enemy.enemyX - 1)
                            && playerBullet2[i].x <= (enemy.enemyX + 1))
                        {
                            //아이템
                            item.ItemLife = true;
                            item.itemX = enemy.enemyX;
                            item.itemY = enemy.enemyY;


                            //충돌
                            Random rand = new Random();
                            enemy.enemyX = 75;
                            enemy.enemyY = rand.Next(2, 22);

                            //스코어
                            Score += 100;
                        }
                    }
                }
                if (playerBullet3[i].fire == true)
                {   //미사일과 적의 y값이 같을때
                    if (playerBullet3[i].y == enemy.enemyY)
                    {   //미사일이 적의 x값 범위내에 들어갔을때
                        if (playerBullet3[i].x >= (enemy.enemyX - 1)
                            && playerBullet3[i].x <= (enemy.enemyX + 1))
                        {
                            //아이템
                            item.ItemLife = true;
                            item.itemX = enemy.enemyX;
                            item.itemY = enemy.enemyY;


                            //충돌
                            Random rand = new Random();
                            enemy.enemyX = 75;
                            enemy.enemyY = rand.Next(2, 22);

                            //스코어
                            Score += 100;
                        }
                    }
                }
            }
        }

    }

    //적 클래스
    public class Enemy
    {
        public int enemyX;
        public int enemyY;

        public Enemy()
        {
            enemyX = 77;
            enemyY = 12;
        }

        public void EnemyDraw()
        {
            string enemy = "<-0->";
            Console.SetCursorPosition(enemyX, enemyY);
            Console.Write(enemy);
        }

        public void EnemyMove()
        {
            Random rand = new Random();
            enemyX--; //왼쪽으로 움직임

            if (enemyX < 2) //화면 왼쪽 넘어가면 새로 좌표잡기
            {
                enemyX = 75;
                enemyY = rand.Next(2, 22);
            }

        }
    }
    //아이템 클래스
    public class Item
    {
        public string ItemName;
        public string ItemSprite;
        public int itemX = 0;
        public int itemY = 0;
        public bool ItemLife = false;

        public void ItemDraw()
        {
            Console.SetCursorPosition(itemX, itemY);
            ItemSprite = "Item★";
            Console.Write(ItemSprite);
        }
    }

    internal class Program
    {

        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);

            //플레이어생성
            Player player = new Player();
            Enemy enemy = new Enemy();

            //콘솔 속도 만들기 frame

            int dwTime = Environment.TickCount;

            while (true) //무한반복
            {
                if (dwTime + 50 < Environment.TickCount)
                {
                    //현재시간 세팅
                    dwTime = Environment.TickCount;
                    Console.Clear();

                    player.GameMain();
                   
                    //총알
                    if (player.itemCount == 0)
                    {
                        player.BulletDraw();
                    }
                    else if (player.itemCount == 1)
                    {
                        player.BulletDraw();
                        player.BulletDraw2();
                    }
                    else
                    {
                        player.BulletDraw();
                        player.BulletDraw2();
                        player.BulletDraw3();
                    }

                    //적이동
                    enemy.EnemyMove();
                    enemy.EnemyDraw();

                    //충돌처리 
                    player.ClashEnemyAndBullet(enemy);

                }
            }

        }
    }
}
