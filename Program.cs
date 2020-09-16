using System;

namespace XoaPhanTuKhoiMang
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = {4, 6, 7, 8, 1};
            int n;
            Console.Write("Mang ");
            HienMang(array, array.Length);
            Console.WriteLine("Nhap phan tu can xoa trong mang");
            n = Convert.ToInt32(Console.ReadLine());
            Xoa(array, n);
            Console.WriteLine("Mang sau khi xoa la: ");
            HienMang(array, array.Length - 1);
        }

        static bool Xoa(int[] a, int n)
        {
            bool found = false;
            for (int i = 0; i < a.Length; ++i)
            {
                if (found)
                {
                    a[i - 1] = a[i];
                }
                else if (a[i] == n)
                {
                    int x = i;
                    Console.WriteLine($"Vi tri cua phan tu {n} la : {x} ");
                    found = true;
                }
            }
            return found;
        }

        static void HienMang(int[] a, int size)
        {
            for (int i = 0; i < size; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
        }
    }
}