using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolayProjeler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Fibonacci(); //Ortalama Hesaplama
            //Triangle(); //Üçgen Çizme
            //Circle(); //Daire Çizme
            //Algorithm(); //Algoritma
            ReverseWritting(); //Karakter Tersten Yazma

            Console.ReadLine();

        }
        private static void Fibonacci()
        {
            Console.Write("Kaç adet Fibonacci sayısı hesaplamak istersiniz? ");
            int numbers = int.Parse(Console.ReadLine());

            //İlk iki Fibonacci sayısı 0 ve 1'dir
            int a = 0; int b = 1;
            List<int> FibonacciList = new List<int> { a, b };

            //İstenilen kadar Fibonacci sayısı hesaplamak için
            for (int i = 2; i < numbers; i++)
            {
                int fnumbers = a + b;
                FibonacciList.Add(fnumbers);
                a = b;
                b = fnumbers;
            }

            //Ortalama hesaplama
            double avgFibonacci = FibonacciList.Average();

            Console.WriteLine("Hesaplanan Fibonacci sayıları: " + string.Join(", ", FibonacciList));
            Console.Write("Ortalama: " + avgFibonacci);
        }
        private static void Triangle()
        {
            Console.Write("Çizmek istediğiniz üçgenin alanını girin: ");
            int area = int.Parse(Console.ReadLine());

            //üçgeni çizme
            for (int i = 0; i < area; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        private static void Circle()
        {
            Console.WriteLine("Lütfen çizmek istediğiniz dairenin yarıçapını giriniz: ");
            double radius = double.Parse(Console.ReadLine());

            for (int i = -(int)radius; i <= (int)radius; i++)
            {
                for (int j = -(int)radius; j <= (int)radius; j++)
                {
                    if (i * i + j * j <= radius * radius)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
        private static void Algorithm()
        {
            Console.WriteLine("Lütfen bir kelime ve bir sayı girin(Kelime ve sayıyı virgül ile ayırın: ");
            string word = Console.ReadLine();

            //alınan değerleri virgülden sonra ayırma işlemi
            string[] words = word.Split(',');

            //virgülden sonra sayıyı alma
            int number = int.Parse(words[1]);

            //belirtilen sayıdaki karakteri çıkarma işlemi
            string word2 = words[0].Remove(number + 1, 1);

            Console.WriteLine($"{word2}");
        }

        private static void ReverseWritting()
        {
            Console.WriteLine("Lütfen bir şeyler yazın: ");
            string input = Console.ReadLine();
            string[] inputWords = input.Split(' '); //alınan karakterleri boşluk ile ayırıp karakter dizisi haline getirdim

            for (int i = 0; i < inputWords.Length; i++)
            {
                //Alınan ilk karakteri sildim
                string word1 = inputWords[i].Remove(0, 1);

                //Alınan ilk karakteri sonuna yazdım
                Console.Write($"{word1}" + $"{inputWords[i][0]}" + " ");
            }
        }
    }
}
