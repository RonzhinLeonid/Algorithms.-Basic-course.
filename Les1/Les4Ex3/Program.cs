using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les4Ex3
{

    //Ронжин Л.
    //3. ***Требуется обойти конём шахматную доску размером NxM, пройдя через все поля доски по
    //одному разу.Здесь алгоритм решения такой же как и в задаче о 8 ферзях.Разница только в проверке
    //положения коня.

    class Program
    {
            //static int[,] Ar = new int[6, 6];
            //static int n;
            static void Main(string[] args)
            {
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        int[,] Ar = new int[5, 5];
                        int n = 0;
                        Move(i, j, Ar, n);
                        Console.WriteLine("-------------------------");
                    }
                
                }

                Console.ReadLine();
            }
            static void Move(int X, int Y, int[,] Ar, int n)
            {
                int iX = 0, iY = 0, nn = ++n;
                bool WasStep = false;
                Ar[X, Y] = 1;
                for (int i = 0; i < 8; i++)
                {
                    switch (i)
                    {
                        case 0: iX = X + 1; iY = Y - 2; break;
                        case 1: iX = X + 2; iY = Y + 1; break;
                        case 2: iX = X - 1; iY = Y + 2; break;
                        case 3: iX = X - 2; iY = Y - 1; break;
                        case 4: iX = X - 1; iY = Y - 2; break;
                        case 5: iX = X + 2; iY = Y - 1; break;
                        case 6: iX = X + 1; iY = Y + 2; break;
                        case 7: iX = X - 2; iY = Y + 1; break;
                    }
                    if (iX > -1 && iX < 5 && iY > -1 && iY < 5 && Ar[iX, iY] == 0)
                    {
                        WasStep = true;
                        Console.WriteLine("{0,4}:  {1}-{2}  ->   {3}-{4}", "(" + nn + ")", X + 1, Y + 1, iX + 1, iY + 1);
                        Move(iX, iY, Ar, n);
                    }
                }
                if (!WasStep) n--;
            }
        
    }
}
