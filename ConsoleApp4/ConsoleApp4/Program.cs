using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            string job = "The Ironclad";
            int healty = 80;
            int money = 99;
            int heal = 6;
            int unlock = 5;
            string menu1 = "Back";
            string menu2 = "Embark";


            Console.WriteLine("┏━━━━━━━━━━━━━━━━━━━━━━━━┓");
            Console.WriteLine($"┃     {job}       ┃" );
            Console.WriteLine($"┃        {healty}/{healty}           ┃" );
            Console.WriteLine($"┃      Gold:{money}           ┃" );
            Console.WriteLine($"┃   Ability:heal{heal}HP      ┃" );
            Console.WriteLine($"┃                        ┃" );
            Console.WriteLine($"┃                        ┃" );
            Console.WriteLine($"┃                        ┃" );
            Console.WriteLine($"┃ ┏━━━┓ ┏━━━┓ ┏━━━┓ ┏━━━┓┃" );
            Console.WriteLine($"┃ ┃   ┃ ┃   ┃ ┃   ┃ ┃   ┃┃" );
            Console.WriteLine($"┃ ┗━━━┛ ┗━━━┛ ┗━━━┛ ┗━━━┛┃" );
            Console.WriteLine($"┃                        ┃" );
            Console.WriteLine($"┃                        ┃" );
            Console.WriteLine($"┃ {unlock} Unlocks Remaining    ┃" );
            Console.WriteLine($"┃                        ┃" );
            Console.WriteLine($"┃                        ┃" );
            Console.WriteLine($"┃ {menu1}             {menu2}┃" );
            Console.WriteLine($"┃                        ┃" );
            Console.WriteLine("┗━━━━━━━━━━━━━━━━━━━━━━━━┛");

        }
    }
}
