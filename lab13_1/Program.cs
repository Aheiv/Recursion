using System;

namespace lab13_1
{
    internal class Program
    {
        static int Iter(int[] ar)
        {
            int max = ar[0];
            int k = 0;
            for (int i = 1; i < ar.Length; i++)
            {
                if (ar[i] > max) max = ar[i];
            }
            for (int i = 0; i < ar.Length; i++)
            {
                if (ar[i] == max) k++;
            }
            return k;
        }
        static int Rec(int[] ar, int index, int k)
        {
            int max = ar[0];
            for (int i = 1; i < ar.Length; i++)
            {
                if (ar[i] > max) max = ar[i];
            }
            if (index != ar.Length)
            {
                if (ar[index] == max) return Rec(ar, index + 1, k + 1);
                else return Rec(ar, index + 1, k);
            }
            return k;
        }
        static void Main(string[] args)
        {
            Random r = new Random();
            Console.Write("Какой длины будет массив? ");
            int n = int.Parse(Console.ReadLine());
            while (n < 1 || n > 10)
            {
                Console.Write("\nНеверный ввод, надо положительное и меньше 11! ");
                n = int.Parse(Console.ReadLine());
            }
            int[] a = new int[n];
            Console.Write("\nСгенерированный массив: ");
            for (int i = 0; i < n; i++)
            {
                a[i] = r.Next(-10, 10);
                Console.Write($"{a[i]}   ");
            }
            int maxk = Iter(a);
            Console.WriteLine("\nЧисло максимальных элементов(итерация): " + maxk);
            maxk = Rec(a, 0, 0);
            Console.WriteLine("\nЧисло максимальных элементов(рекурсия): " + maxk);
        }
    }
}
