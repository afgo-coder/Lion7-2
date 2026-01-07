using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int day = 3;

            //switch (day)
            //{ 
            //    case 1:
            //    Console.WriteLine("Monday");
            //    break;
            //    case 2:
            //    Console.WriteLine("Tuesday");
            //    break;
            //    case 3:
            //    Console.WriteLine("Wednesday");
            //    break;
            //    default:
            //    Console.WriteLine("유효하지 않은 요일");
            //    break;
            //}

            //캐릭터 선택 화면을 Switch로 만드시오
            //jobChoice 1: 전사, 2: 마법사, 3: 궁수
            //Console.OutputEncoding = Encoding.UTF8;
            //Console.WriteLine("=== 캐릭터생성 ===");
            //Console.WriteLine("1.전사 2.마법사 3.궁수");
            //Console.Write("직업을 선택해주세요: ");
            //int jobChoice =
            //int.Parse(Console.ReadLine());


            //switch (jobChoice)
            //{
            //    case 1:
            //        Console.WriteLine("⚔️전사를 선택하셨습니다");
            //        Console.WriteLine("직업: ⚔️전사");
            //        Console.WriteLine("특성: 높은 체력과 방어력");
            //        Console.WriteLine("주 무기: 검, 도끼");
            //        Console.WriteLine("스탯: HP +50, 공격력 +10");
            //    break;
            //    case 2:
            //        Console.WriteLine("🔮마법사를 선택하셨습니다.");
            //        Console.WriteLine("직업: 🔮마법사");
            //        Console.WriteLine("특성: 강력한 마법 공격");
            //        Console.WriteLine("주 무기: 지팡이, 마법서");
            //        Console.WriteLine("스탯: MP +50, 마법 공격력 +15");
            //        break;
            //    case 3:
            //    Console.WriteLine("🏹궁수를 선택하셨습니다.");
            //        Console.WriteLine("직업: 🏹궁수");
            //        Console.WriteLine("특성: 원거리 공격과 높은 민첩성");
            //        Console.WriteLine("주 무기: 활, 석궁");
            //        Console.WriteLine("스탯: 민첩성 +20, 치명타 확률 +5%");
            //        break;
            //    default:
            //    Console.WriteLine("유효하지 않은 직업입니다.");
            //    break;
            //}

            Console.WriteLine("\n=== 아이템 정보 ===");
            string itemType = "weapon";
            Console.OutputEncoding = Encoding.UTF8;
            switch (itemType)
            {
                case "weapon":
                    Console.WriteLine("🗡️ 무기 - 공격력 증가");
                    break;
                case "armor":
                    Console.WriteLine("🛡️ 방어구 - 방어력 증가");
                    break;
                case "potion":
                    Console.WriteLine("🧪 물약 - 체력/마나 회복");
                    break;
                case "accessory":
                    Console.WriteLine("💍 장신구 - 특수 능력 부여");
                    break;
                default:
                    Console.WriteLine("❓ 알 수 없는 아이템");
                    break;
            }









        }
    }
}
