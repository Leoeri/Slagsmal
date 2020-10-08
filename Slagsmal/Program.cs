using System;

namespace Slagsmal
{
    class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            int damageA = generator.Next(1, 21);
            int damageB = generator.Next(1,21);
            int HPa = 100;
            int HPb = 100;
            int round = 0;
            Console.WriteLine("Skriv in ett namn för spelare 1");
            string namn1 = Console.ReadLine();
            Console.WriteLine("Skriv in ett namn för spelare 2");
            string namn2 = Console.ReadLine();
            Console.Clear();
            while (HPa >= 0 && HPb >= 0)
            {
                round++;
                damageA = generator.Next(1,21);
                damageB = generator.Next(1,21);
                HPa = HPa - damageB;
                HPb = HPb - damageA;
                Console.WriteLine("Runda " + round);
                if(HPa >= 1 && HPb >= 1){
                Console.WriteLine(namn1 + " tog " + damageB + " skada och har " + HPa + " HP kvar");
                Console.WriteLine(namn2 + " tog " + damageA + " skada och har " + HPb + " HP kvar");
                }
                else if(HPa <= 0 && HPb <= 0){
                    Console.WriteLine(namn1 + " tog "+ damageB + " skada och " + namn2 + " tog " + damageA + " skada som gjorde att båda föll medvetslösa och det blir lika!");
                }
                else if(HPa <= 0){
                Console.WriteLine(namn1 + " tog " + damageB + " skada och föll medvetslös");
                Console.WriteLine(namn2 + " vann!");
                }
                else if(HPb <= 0){
                Console.WriteLine(namn2 + " tog " + damageB + " skada och föll medvetslös");
                Console.WriteLine(namn1 + " vann!");

                }

                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
