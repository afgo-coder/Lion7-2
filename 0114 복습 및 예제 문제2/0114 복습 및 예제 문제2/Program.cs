using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0114_복습_및_예제_문제2
{
    //문제 2: 상점 시스템

    //다양한 상품 타입을 다형성으로 관리하고,
    //타입별로 다른 할인율을 적용하세요.

    //부모: 제품 자식: 가전 / 가구 손자: 전자레인지,오븐 / 의자,침대
    //AI한테 물어봐서 만든코드 세세한 부만 수정했음

    public abstract class Product // 부모 클래스
    {
        public string name;
        public double price;
        public Product(string _name, double _price)
        {
            name = _name;
            price = _price;
        }
        public abstract double GetDiscountedPrice(); // 할인된 가격 계산 (다형성)
        public virtual void Info()
        {
            Console.WriteLine("현재 고르신 상품입니다");
            Console.WriteLine($"제품: {name}, 원가: {price}원");
        }
    }

    public abstract class Appliance : Product // 자식 클래스: 가전
    {
        public Appliance(string _name, double _price) : base(_name, _price) { }
        public override double GetDiscountedPrice()
        {
            return price * 0.9; // 가전 10% 할인
        }
        public override void Info()
        {
            base.Info();
            Console.WriteLine("카테고리: 가전");
        }
    }

    public abstract class Furniture : Product // 자식 클래스: 가구
    {
        public Furniture(string _name, double _price) : base(_name, _price) { }
        public override double GetDiscountedPrice()
        {
            return price * 0.85; // 가구 15% 할인
        }
        public override void Info()
        {
            base.Info();
            Console.WriteLine("카테고리: 가구");
        }
    }

    // 손자 클래스: 가전
    public class Microwave : Appliance
    {
        public Microwave(string _name, double _price) : base(_name, _price) { }
        public override double GetDiscountedPrice()
        {
            return base.GetDiscountedPrice() * 0.95; // 추가 5% 할인
        }
    }

    public class Oven : Appliance
    {
        public Oven(string _name, double _price) : base(_name, _price) { }
        public override double GetDiscountedPrice()
        {
            return base.GetDiscountedPrice() * 0.95; // 추가 5% 할인
        }
    }

    // 손자 클래스: 가구
    public class Chair : Furniture
    {
        public Chair(string _name, double _price) : base(_name, _price) { }
        public override double GetDiscountedPrice()
        {
            return base.GetDiscountedPrice() * 0.9; // 추가 10% 할인
        }
    }

    public class Bed : Furniture
    {
        public Bed(string _name, double _price) : base(_name, _price) { }
        public override double GetDiscountedPrice()
        {
            return base.GetDiscountedPrice() * 0.9; // 추가 10% 할인
        }
    }

    // Shop 클래스: 다형성으로 상품 관리
    public class ShopSystem
    {
        public static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            products.Add(new Microwave("전자레인지", 100000));
            products.Add(new Oven("오븐", 200000));
            products.Add(new Chair("의자", 50000));
            products.Add(new Bed("침대", 300000));

            // 다형성: Product 타입으로 각 상품의 할인 가격 계산 및 출력
            foreach (Product product in products)
            {
                product.Info();
                Console.WriteLine($"할인 가격: {product.GetDiscountedPrice()}원");
                Console.WriteLine();
            }
        }
    }
}

