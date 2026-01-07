using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 콘솔코딩연습
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            

            Console.WriteLine("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
            Console.WriteLine("┃         === 무제 ===         ┃");
            Console.WriteLine("┃                              ┃");
            Console.WriteLine("┃                              ┃");
            Console.WriteLine("┃                              ┃");
            Console.WriteLine("┃                              ┃");
            Console.WriteLine("┃  1.Play                      ┃");
            Console.WriteLine("┃  2.Settings                  ┃");
            Console.WriteLine("┃  3.Exit                      ┃");
            Console.WriteLine("┃                              ┃");
            Console.WriteLine("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");
            Console.Write("Select:");
            int select = int.Parse(Console.ReadLine());
           

                switch (select)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("=== 캐릭터 선택 ===");
                        Console.WriteLine(" ⚔️       🔮       🏹 ");
                        Console.WriteLine("1.전사 2. 마법사 3. 궁수");
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
                        Console.WriteLine("┃  2.Settings                  ┃");
                        Console.WriteLine("┃  2.Settings                  ┃");
                        Console.WriteLine("┃  2.Settings                  ┃");
                        Console.WriteLine("┃  2.Settings                  ┃");
                        Console.WriteLine("┃  2.Settings                  ┃");
                        Console.WriteLine("┃  2.Settings                  ┃");
                        Console.WriteLine("┃  2.Settings                  ┃");
                        Console.WriteLine("┃  2.Settings                  ┃");
                        Console.WriteLine("┃  2.Settings                  ┃");
                        Console.WriteLine("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");
                        break;
                    case 3:
                        Console.Clear();
                        for (int i = 1; i < 10; i++)
                            Console.WriteLine("Bye");
                        break;
                default:
                    Console.WriteLine("Wrong Input Try 1,2 or 3");
                    break;







                }


        }
    }
}
