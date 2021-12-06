using System;

namespace Iterationc
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Console.Write("Vashe imja: ");
            string name = Console.ReadLine();
            Console.WriteLine("Privet, "+ name + "!" + " Davaj sygraem!");
            Console.WriteLine("Na schetu: 100");
            Console.WriteLine("Na chto stavite ot 1 do 10:6");
            Console.Write("Skoliko stavite: ");
            int stavka = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Vy postavili "+ stavka + " na 6");
            Random random = new Random();
            int value = random.Next(0,10);
            Console.WriteLine("A vypalo: " + value);
            int amount = 100;
            
            if (value == stavka)
            {
                int result = stavka * 6 + amount;
                Console.WriteLine("U vas na scetu: " + result ); 
            }
            else
            {
                Console.WriteLine("U vas na scetu: " + (amount - stavka));
            }
            Console.WriteLine();
        }
    }
}
