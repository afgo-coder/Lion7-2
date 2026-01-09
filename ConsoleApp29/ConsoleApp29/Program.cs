using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////가변 배열
            //string[][] raid = new string[3][];

            //raid[0] = new string[] { "전사", "힐러", "마법사", "궁수" };
            //raid[1] = new string[] { "도적", "전사", "힐러" };
            //raid[2] = new string[] { "마법사", "궁수", "힐러","전사","탱커" };

            //Console.WriteLine("=== 레이드 파티 구성 ===");
            //for (int i = 0; i < raid.Length; i++)
            //{
            //    Console.WriteLine($"파티{i+1} ({raid[i].Length}명)");
            //    for (int j = 0; j < raid[i].Length; j++)
            //    {
            //        Console.WriteLine($"- {raid[i][j]}");
            //    }
            //}

            //List < T > -동적 배열

            //List<T> 는 크기가 자동으로 조절되는 동적 배열입니다.

            //📚 List vs 배열

            //| 특징 | 배열 | List<T> |
            //| ------| ------| ---------|
            //| 크기 | 고정 | 자동 조절 |
            //| 추가 / 삭제 | 불가 | 가능 |
            //| 성능 | 약간 빠름 | 약간 느림 |
            //| 편의성 | 기본 | 다양한 메서드 제공 |

            //선언 방법
            //List<int> numbers = new List<int>();           // 빈 리스트
            //List<string> names = new List<string>();       // 문자열 리스트
            //List<float> prices = new List<float>();        // 실수 리스트

            //// 초기값과 함께 선언
            //List<int> scores = new List<int> { 85, 90, 78, 95 };
            //List<string> items = new List<string> { "검", "방패", "포션" };

            //// C# 3.0 이후 간단한 초기화
            //var players = new List<string> { "철수", "영희", "민수" };

            //List<string> items = new List<string>();

            //// Add: 끝에 추가
            //items.Add("회복 포션");
            //items.Add("마나 포션");

            //List 생성
            //List<string> inven = new List<string>();

            //Console.WriteLine("=== 도적 인벤토리 시스템 ===");

            ////아이템 추가 (Add)
            //inven.Add("hp potion");
            //inven.Add("mp potion");
            //inven.Add("steel blade");
            //Console.WriteLine("아이템 3개 추가");

            ////현재 인벤토리
            //Console.WriteLine($"인벤토리 ({inven.Count})개");

            //for (int i = 0; i < inven.Count; i++)
            //{
            //    Console.WriteLine($"[{i}]{inven[i]}");
            //}
            //Console.WriteLine();
            //inven[0] = "green potion";

            //for (int i = 0; i < inven.Count; i++)
            //{
            //    Console.WriteLine($"[{i}]{inven[i]}");
            //}
            //Console.WriteLine();
            ////특정 위치에 추가
            //inven.Insert(1, "legend sword");

            //for (int i = 0; i < inven.Count; i++)
            //{
            //    Console.WriteLine($"[{i}]{inven[i]}");
            //}
            //Console.WriteLine();

            ////아이템 제거
            //inven.Remove("mp potion");
            //Console.WriteLine();

            //for (int i = 0; i < inven.Count; i++)
            //{
            //    Console.WriteLine($"[{i}]{inven[i]}");
            //}

            ////인덱스로 제거 (RemoveAt)
            //inven.RemoveAt(0);
            //Console.WriteLine();
            //for (int i = 0; i < inven.Count; i++)
            //{
            //    Console.WriteLine($"[{i}]{inven[i]}");
            //}

            //Dictionary<string, int> stats = new Dictionary<string, int>();

            //데이터추가
            //stats.Add("HP", 150);
            //stats.Add("MP", 80);
            //stats.Add("공격력", 75);
            //stats.Add("방어력", 50);
            //stats.Add("민첩", 60);

            //Console.WriteLine("=== 캐릭터 스탯 ===");
            //foreach (KeyValuePair<string, int> stat in stats)
            //{
            //    Console.WriteLine($"{stat.Key}: {stat.Value}");
            //}

            ////키 존재 확인
            //string searchStat = "방어력";

            //if (stats.ContainsKey(searchStat))
            //{
            //    Console.WriteLine($"검색내용:{stats[searchStat]}");
            //}
            //else
            //{
            //    Console.WriteLine("해당스탯이 없습니다.");
            //}

            //=== 상점 아이템 ===
            //회복 포션: 50골드
            //마나 포션: 40골드
            //강철 검: 500골드
            //가죽 갑옷: 300골드
            //마법 반지: 1000골드

            //✅ '강철 검' 구매 성공!
            //남은 골드: 100
            Console.OutputEncoding = Encoding.UTF8;
            Dictionary<string, int> item = new Dictionary<string, int>();

            item.Add("회복 포션",50);
            item.Add("마나 포션",40);
            item.Add("강철 검", 500);
            item.Add("가죽 갑옷", 300);
            item.Add("마법 반지", 1000);

            Console.WriteLine("=== 상점 아이템 ===");
            foreach (KeyValuePair<string, int> items in item )
            {
                Console.WriteLine($"{items.Key}: {items.Value}골드");
            }
            string searchitem = ("강철 검");
            Console.WriteLine();

            if (item.ContainsKey(searchitem))
            {
                Console.WriteLine($"✅ {searchitem} 구매성공!");
            }
            else
            {
                Console.WriteLine("해당물건이 없습니다.");
            }
            Console.WriteLine("남은 골드: 100");







        }
    }
}
