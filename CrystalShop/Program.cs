using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            
            int crystal = 0;
            int gold;
            int priseOfCrystal = 10;
            int numberOfCrystals;

            Console.WriteLine("Приветствуем Вас в магазине кристаллов");
            Console.Write("Сколько золота у Вас есть? ");
            gold = Convert.ToInt32(Console.ReadLine());
            Console.Write("Сколько кристаллов хотите приобрести? ");
            numberOfCrystals = Convert.ToInt32(Console.ReadLine());

            gold -= priseOfCrystal * numberOfCrystals;
            crystal += numberOfCrystals;

            Console.WriteLine($"У вас {crystal} кристаллов и {gold} золота");
        }
    }
}
