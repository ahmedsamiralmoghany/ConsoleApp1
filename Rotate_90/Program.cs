using System;
using System.Collections.Generic;

namespace Rotate_90
{
    class Program
    {
        static void RotateMatrix(int[,] mat)
        {
            var lenrgth = mat.GetLength(0);

            for (int x = 0; x < lenrgth / 2; x++)
            {

                for (int y = x; y < lenrgth - x - 1; y++)
                {
                    int temp = mat[x, y];
                    mat[x, y] = mat[y, lenrgth - 1 - x];
                    mat[y, lenrgth - 1 - x] = mat[lenrgth - 1 - x, lenrgth - 1 - y];
                    mat[lenrgth - 1 - x, lenrgth - 1 - y] = mat[lenrgth - 1 - y, x];
                    mat[lenrgth - 1 - y, x] = temp;
                }
            }
        }

        static void DisplayMatrix(int[,] mat)
        {
            var lenrgth = mat.GetLength(0);
            for (int i = 0; i < lenrgth; i++)
            {
                for (int j = 0; j < lenrgth; j++)
                    Console.Write(" " + mat[i, j]);
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static public void Main()
        {
            var list = new List<int[,]>();
            var testNums = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < testNums; i++)
            {
                var size = Convert.ToInt32(Console.ReadLine());
                int[,] array = new int[size, size];
                for (int c = 0; c < size; c++)
                {
                    for (int r = 0; r < size; r++)
                    {
                        array[c, r] = Convert.ToInt32(Console.ReadLine());

                    }

                }

                RotateMatrix(array);
                list.Add(array);
            }


            foreach (var item in list)
            {
                DisplayMatrix(item);
            }

            Console.ReadLine();

        }



    }
}




