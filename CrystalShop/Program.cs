using System;
using System.Text;

namespace CrystalShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            
            int crystals = 0;
            int gold;
            int priseOfCrystal = 10;
            int crystalsInOrder;

            Console.WriteLine("Приветствуем Вас в магазине кристаллов");
            Console.Write("Сколько золота у Вас есть? ");
            gold = Convert.ToInt32(Console.ReadLine());
            Console.Write("Сколько кристаллов хотите приобрести? ");
            crystalsInOrder = Convert.ToInt32(Console.ReadLine());

            gold -= priseOfCrystal * crystalsInOrder;
            crystals += crystalsInOrder;

            Console.WriteLine($"У вас {crystals} кристаллов и {gold} золота");
        }
    }
}
