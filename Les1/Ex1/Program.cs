using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ронжин Л.
            //1.Ввести вес и рост человека. Рассчитать и вывести индекс массы тела(ИМТ) по формуле
            //I = m / (h * h); где m — масса тела в килограммах, h — рост в метрах.
            Console.Write("Укажите Ваш вес в килограммах: ");
            double weight = Convert.ToDouble(Console.ReadLine());
            Console.Write("Укажите Ваш рост в метрах: ");
            double growth = Convert.ToDouble(Console.ReadLine()); 
            double indexBodyMass = weight / (Math.Pow(growth, 2));
            Console.WriteLine($"Ваш индекс массы тела (ИМТ), при росте {growth} и весе {weight}, составляет: {indexBodyMass}.");
            Console.ReadKey();
        }
    }
}
