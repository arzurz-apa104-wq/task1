using System;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 580, 8, 6, 19, 156 };
            int minelement = GetMin(nums);
            Console.WriteLine(minelement);

            Console.WriteLine("cevrenin sahesi: " + Area(10));
            Console.WriteLine("duzbucaqlının sahesi: " + Area(6, 12));
            Console.WriteLine("paralelepipedin tam sethi: " + Area(9, 13, 17));
            Console.WriteLine("ucbucagin daxiline cekilmish cevrenin sahesi: " + Area(5, 7, 11, 4));
        }

        static int GetMin(int[] arr)
        {
            int min = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }

            return min;
        }

        static int Area(int r)
        {
            return 3 * r * r;
        }

        static int Area(int a, int b)
        {
            return a * b;
        }

        static int Area(int a, int b, int c)
        {
            return 2 * (a * b + a * c + b * c);
        }

        static int Area(int a, int b, int c, int r)
        {
            int perimetr = (a + b + c) / 2;
            return perimetr * r;
        }
    }
}
