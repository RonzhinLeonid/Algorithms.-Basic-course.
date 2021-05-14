using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les6Ex2
{
    class Program
    {
        //Ронжин Л.
        //2. Переписать программу, реализующее двоичное дерево поиска.
        //а) Добавить в него обход дерева различными способами;
        //б) Реализовать поиск в двоичном дереве поиска;
        //в) *Добавить в программу обработку командной строки с помощью которой можно указывать
        //из какого файла считывать данные, каким образом обходить дерево
        static void Main(string[] args)
        {
			Random rList = new Random(50);
			int maxVal = 200;
			int n = 30;

			BinaryTree<int> tree = new BinaryTree<int>(maxVal, null);

			for (int i = 0; i < n; i++)
			{
				int val = rList.Next(maxVal);
				tree.add(val);
			}

			Console.WriteLine("Распечатка двоичного дерева в виде скобочной записи");
			tree.printTree();
			Console.WriteLine("КЛП — «корень–левый–правый»");
			tree.preOrderTravers();
			Console.WriteLine("ЛКП — «левый–корень–правый»");
			tree.inOrderTravers();
			Console.WriteLine("ЛПК — «левый–правый–корень»");
			tree.postOrderTravers();
			Console.Write("Введите число для поиска: ");
			int z = int.Parse(Console.ReadLine());
			var sch = tree.search(z);
			if (sch != null)
				sch.printTree();
			else
				Console.WriteLine("Ничего не найдено.");

			Console.ReadKey();
		}
    }
}
