using System;
class Programm
{
    static void Main()
    {
        char[,] symbs = { { 'A', 'B', 'C' }, { 'D', 'E', 'F' } };
        Console.WriteLine("Исходный массив:");
        for (int i = 0; i < symbs.GetLength(0); i++)
        {
            for (int j = 0; j < symbs.GetLength(1); j++)
            {
                Console.Write(symbs[i, j] + " ");
            }
            Console.WriteLine();
        }
        Random rnd = new Random();
        int row = rnd.Next(symbs.GetLength(0) + 1);
        int col = rnd.Next(symbs.GetLength(1) + 1);
        Console.WriteLine("Добовляется {0}-я строка и {1}-й столбец", row, col);
        char[,] tmp = new char[symbs.GetLength(0) + 1, symbs.GetLength(1) + 1];
        int a, b;
        char s = 'a';
        for (int i = 0; i < symbs.GetLength(0); i++)
        {
            if (i < row)
                a = i;
            else
                a = i + 1;
            for (int j = 0; j < symbs.GetLength(1); j++)
            {
                if (j < col)
                    b = j;
                else
                    b = j + 1;
                tmp[a, b] = symbs[i, j];
            }
        }
        for (int i = 0; i < tmp.GetLength(1); i++)
        {
            tmp[row, i] = s;
            s++;
        }
        for (int i = 0; i < tmp.GetLength(0); i++)
        {
            if (i != row)
            {
                tmp[i, col] = s;
                s++;
            }
        }
        symbs = tmp;
        Console.WriteLine("Новый массив:");
        for (int i = 0; i < symbs.GetLength(0); i++)
        {
            for (int j = 0; j < symbs.GetLength(1); j++)
            {
                Console.Write(symbs[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
/*
        int rows = 3, cols = 5;
        int[,] nums = new int[rows, cols];
        int value = 1;
        for (int i = 0; i < nums.GetLength(0); i++)
        {
            for (int j = 0; j < nums.GetLength(1); j++)
            {
                nums[i, j] = value;
                value++;
                Console.Write(nums[i, j] + "\t");
            }
            Console.WriteLine();
        }
*/
