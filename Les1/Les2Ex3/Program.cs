using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les2Ex3
{
    class Program
    {
        //Ронжин Л.
        //3. **Исполнитель «Калькулятор» преобразует целое число, записанное на экране. У
        //исполнителя две команды, каждой присвоен номер:
        //1. Прибавь 1.
        //2. Умножь на 2.
        //Первая команда увеличивает число на экране на 1, вторая увеличивает его в 2 раза.Сколько
        //существует программ, которые число 3 преобразуют в число 20:
        //а. С использованием массива.
        //b. * С использованием рекурсии.
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число которое необходимо получить: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            Covert(a, b, a.ToString(), ref count);
            Console.WriteLine($"Кол-во вариантов: {count}");

            #region Дополнено с урока
            int[] arr = new int[b + 1];
            arr[a] = 1;
            for (int i = a + 1; i <= b; i++)
            {
                arr[i] = i % 2 == 0 ? arr[i - 1] + arr[i / 2] : arr[i - 1];
                Console.Write($"{arr[i]} ");
            } 
            #endregion

            Console.ReadKey();
        }

        private static void Covert(int a, int b, string str, ref int count)
        {
            for (int i = 0; i < 2; i++)
            {
                string s = str;
                int temp = a;
                if (i == 0)
                {
                    temp++;
                    s += "+1";
                }
                else
                {
                    temp *= 2;
                    s += "*2";
                }
                if (temp < b) Covert(temp, b, s, ref count);
                else if (temp == b) Console.WriteLine($"{++count}) {s} = {b}");
            }
        }
    }
}
