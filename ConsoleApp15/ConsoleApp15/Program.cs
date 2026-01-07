using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //증감 연산자 ++--

            //int b = 4;
            //b++; //뒤에 붙어서 후위 증가
            //Console.WriteLine(b);
            //--b; //앞에 붙어서 전위 감소
            //Console.WriteLine(b);

            //전위 후위 증가,감소
            //int count = 5;

            //++count; 바로 증가 //count++; 컴파일 시점에서 바로 적용X 다음 라인에서 연산
            //감소도 마찬가지로 적용
            //Console.WriteLine(++count); //즉시 증가 6
            //Console.WriteLine(count++); Console.Write(count); //다음 라인에서증가 5 > 6

            //=== 몬스터 처치 ===
            //고블린 처치!(킬 카운트: 1)
            //오크 처치!(킬 카운트: 2)
            //드래곤 처치!(킬 카운트: 3)
            //총 처치 수: 3

            //=== 사격 ===
            //남은 탄약: 30
            //발사! 남은탄약: 29
            //발사! 남은탄약: 28
            //발사! 남은탄약: 27

            //=== 카운트다운 ===
            //3
            //2
            //1
            //발사!
            //int killCount = 0;  
            //int ammo = 30;
            //int countdown = 3;
            //Console.WriteLine("=== 몬스터 처치 ===");
            //Console.WriteLine($"고블린 처치!(킬 카운트: {++killCount})");
            //Console.WriteLine($"오크 처치!(킬 카운트: {++killCount})");
            //Console.WriteLine($"드래곤 처치!(킬 카운트: {++killCount})");
            //Console.WriteLine($"총 처치 수: {killCount}마리");

            //Console.WriteLine("=== 사격 ===");
            //Console.WriteLine($"남은 탄약: {ammo}");
            //Console.WriteLine($"발사! 남은탄약: {--ammo}");
            //Console.WriteLine($"발사! 남은탄약: {--ammo}");
            //Console.WriteLine($"발사! 남은탄약: {--ammo}");

            //Console.WriteLine("=== 카운트다운 ===");
            //Console.WriteLine(countdown--);
            //Console.WriteLine(countdown--);
            //Console.WriteLine(countdown--);
            //Console.WriteLine("발사!");

            //관계형 연산자와 논리 연산자

            //int x = 5;
            //int y = 10;

            //Console.WriteLine(x < y); //관계형 True
            //Console.WriteLine(x > y); //관계형 False
            //Console.WriteLine(x <= y); //크거나 같냐? True
            //Console.WriteLine(x >= y); //작거나 같냐? False 
            //Console.WriteLine(x == y); //논리형 같냐? False
            //Console.WriteLine(x != y); //논리형 같지않지않냐? True 

            //논리 연산자 AND, OR, NOT
            //AND(그리고) : && OR(또는) : || NOT(부정) : !
            //bool a = true, b= true;
            ////쉬운 예로는 True = 1 False = 0 %%은 곱셈 ||은 나눗셈 !은 반대의 개념
            //Console.WriteLine(a && b); //둘다 참이어야 참 True
            //Console.WriteLine(a || b); //하나만 참이어도 참 True 기호 | = shift + \
            //Console.WriteLine(!a); //반대 개념 True > False 

            //비트 연산자 &(AND), |(OR), ^(XOR), ~(NOT)
            //int x = 5; // 0101
            //int y = 3; // 0011

            //string binary = Convert.ToString(x & y, 2);

            //Console.WriteLine($"8비트: {binary.PadLeft(8,'0')}"); // 0101 * 0011 = 0001 = 1

            //binary = Convert.ToString(x | y, 2);

            //Console.WriteLine($"8비트: {binary.PadLeft(8,'0')}"); // 0101 + 0011 = 0111 = 7

            //binary = Convert.ToString(x ^ y, 2);

            //Console.WriteLine($"8비트: {binary.PadLeft(8,'0')}"); // 0101 ^ 0011 = 0110 = 6

            //binary = Convert.ToString(~x, 2);

            //Console.WriteLine($"8비트: {binary.PadLeft(8,'0')}"); // ~0101 = 1010 = -6

            //시프트 연산자 <<(왼쪽 시프트), >>(오른쪽 시프트)

            //int value = 4; // 0100

            //string binary = Convert.ToString(value << 1, 2);

            //Console.WriteLine($"8비트: {binary.PadLeft(8, '0')}");

            //binary = Convert.ToString(value >> 1, 2);

            //Console.WriteLine($"8비트: {binary.PadLeft(8,'0')}");

            //비트 연산자와 시프트 연산자를 활용한 인벤토리 시스템

            //int inventory = 0; //0000 0000

            //Console.WriteLine($"초기 인벤토리: {Convert.ToString(inventory, 2).PadLeft(8, '0')}");

            ////슬롯 번호
            //int slot1 = 1;
            //int slot2 = 2;

            ////슬롯 1에 활을 추가
            //inventory = inventory | (1 << slot1);
            //Console.WriteLine($"슬롯 {slot1}에 활 추가");
            //Console.WriteLine($"초기 인벤토리: {Convert.ToString(inventory, 2).PadLeft(8, '0')}");

            ////슬롯 2에 검을 추가
            //inventory = inventory | (1 << slot2);
            //Console.WriteLine($"슬롯 {slot2}에 검 추가");
            //Console.WriteLine($"초기 인벤토리: {Convert.ToString(inventory, 2).PadLeft(8, '0')}");

            //플레이어의 현재 체력이 80이고, 최대 체력이 100입니다.
            //몬스터에게 25의 데미지를 받았습니다
            //회복 포션으로 30을 회복했습니다
            //독 데미지로 5를 받았습니다
            //최종 체력을 계산하여 출력하세요.

            int maxHealth = 100;
            int Health = 80;
            int DamgefromMonster = 25;
            int HealfromPotion = 30;
            int DamgefromPoison = 5;
            Console.WriteLine($"=== 문제1 ===");
            Console.WriteLine($"현재체력: {Health}/{maxHealth}");
            Console.WriteLine($"몬스터에게 25 데미지를 받았습니다");
            Health -= DamgefromMonster;
            Console.WriteLine($"현재체력: {Health}/{maxHealth}");
            Console.WriteLine($"회복 포션으로 체력 30을 회복했습니다");
            Health += HealfromPotion;
            Console.WriteLine($"현재체력: {Health}/{maxHealth}");
            Console.WriteLine($"독 데미지를 5 받았습니다");
            Health -= DamgefromPoison;
            Console.WriteLine($"현재체력: {Health}/{maxHealth}");
            Console.WriteLine($"최종체력은 {Health}입니다.");

            //플레이어가 몬스터 3마리를 처치했습니다.
            //몬스터 1마리당 경험치: 150
            //레벨업에 필요한 경험치: 500

            //총 획득 경험치와 레벨업까지 남은 경험치를 계산하세요.

            int monstersKilled = 3;
            int expPerMonster = 150;
            int expToLevelUp = 500;

            int totalExpGained = monstersKilled * expPerMonster;
            int expRemaining = expToLevelUp - totalExpGained;
            Console.WriteLine($"=== 문제2 ===");
            Console.WriteLine($"처치한 몬스터: {monstersKilled}마리");
            Console.WriteLine($"총 획득 경험치: {totalExpGained}");
            Console.WriteLine($"레벨업까지 남은 경험치: {expRemaining}");

            //파티에서 골드 1234를 획득했습니다. 파티원은 5명입니다.
            //1인당 받을 골드는 얼마인가요?
            //분배 후 남는 골드는 얼마인가요 ?

            int totalGold = 1234;
            int palyer = 5;
            int goldPerPlayer = totalGold / palyer;
            int remainingGold = totalGold % palyer;
            Console.WriteLine($"=== 문제3 ===");
            Console.WriteLine($"총 골드: {totalGold}골드");
            Console.WriteLine($"파티원 수: {palyer}명");
            Console.WriteLine($"1인당 받을 골드: {goldPerPlayer}G");
            Console.WriteLine($"분배 후 남는 골드: {remainingGold}G");

            //다음 조건을 모두 만족해야 던전에 입장할 수 있습니다:
            //플레이어 레벨이 30 이상
            //던전 열쇠를 보유하고 있음
            //체력이 50 % 이상
            //각 조건의 참 / 거짓을 확인하고, 최종 입장 가능 여부를 출력하세요.

            int playerLevel = 30;
            int requiredLevel = 30;
            bool hasKey = true;
            int playerHealth = 60;
            int requiredHealth = 50;
            bool canEnterDungeon = (playerLevel >= requiredLevel) && hasKey && (playerHealth >= requiredHealth);
            Console.WriteLine($"=== 문제4 ===");
            Console.WriteLine($"레벨조건({requiredLevel}이상): {playerLevel >= requiredLevel}");
            Console.WriteLine($"던전열쇠 보유: {hasKey}");
            Console.WriteLine($"체력조건(50%이상): {playerHealth >= requiredHealth}");
            Console.WriteLine($"던전 입장 가능 여부: {canEnterDungeon}");

            //아이템의 원가가 5000골드입니다.
            //VIP 회원이면 20 % 할인
            //쿠폰을 사용하면 추가로 500골드 할인

            //VIP 회원이고 쿠폰이 있을 때의 최종 가격을 계산하세요.

            int itemPrice = 5000;
            bool isVIP = true;
            bool useCoupon = true;
            float vipDiscount = 0.2f;
            int couponDiscount = 500;
            

            Console.WriteLine($"=== 문제5 ===");
            Console.WriteLine($"아이템가격: {itemPrice}골드");
            Console.WriteLine($"VIP회원 여부: {isVIP}");
            Console.WriteLine($"VIP회원 할인 가격:{itemPrice - (itemPrice * vipDiscount)}골드");
            float VipPrice = itemPrice - (int)itemPrice * vipDiscount;
            Console.WriteLine($"쿠폰 사용 여부: {useCoupon}");
            Console.WriteLine($"쿠폰 할인 가격: { VipPrice - couponDiscount}골드");
            float finalPrice = VipPrice - couponDiscount;
            Console.WriteLine($"최종 가격: {finalPrice}골드");








        }
    }
}
