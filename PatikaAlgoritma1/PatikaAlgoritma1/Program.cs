using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaAlgoritma1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n).
            //Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.
            //Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.

            int sayiGir = 0;

            Console.WriteLine("Lütfen pozitif bir sayı giriniz: ");

            int input = int.Parse(Console.ReadLine());

            Console.WriteLine($"Lütfen {input} adet sayı giriniz.");
            int[] sayilar = new int[input];
            for (int i = 0; i < input; i++)
            {
                sayiGir = Convert.ToInt32(Console.ReadLine());
                sayilar[i] = sayiGir;

            }
            for (int j = 0; j < input; j++)
            {
                if (sayilar[j] % 2 == 0)
                {
                    Console.Write($"Girilen çift sayı: {sayilar[j]}  ");
                    Console.WriteLine("*************************");
                }
            }

            
            // 2.Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin(n, m).
            //Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.
            //Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.


            Console.WriteLine("Lütfen 2 adet sayı giriniz.");

            int input1 = Convert.ToInt32(Console.ReadLine());
            int input2 = Convert.ToInt32(Console.ReadLine());

            int[] numbers = new int[input1];

            Console.WriteLine($"Lütfen {input1} adet pozitif sayı giriniz.");

            for (int i = 0; i < input1; i++)
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            for (int j = 0; j < input1; j++)
            {
                if (numbers[j] % input2 == 0)
                {
                    Console.WriteLine($"Girilen ikinci sayıya bölünebilen sayılar : {numbers[j]} ");
                }
            }
            Console.WriteLine("*************************");
            //3.Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n).
            //Sonrasında kullanıcıdan n adet kelime girmesi isteyin. 
            //Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.

            Console.WriteLine("Lütfen pozitif bir sayı giriniz.");

            int input3 = Convert.ToInt32(Console.ReadLine());
            string[] words = new string[input3];
            Console.WriteLine($"Lütfen {input3} adet kelime giriniz.");

            for (int i = 0; i < input3; i++)
            {
                string word = Console.ReadLine();
                words[i] = word;
            }
            for (int j = input3 - 1; j >= 0; j--)
            {
                Console.WriteLine(words[j]);
            }

            Console.WriteLine("*************************");
            //4. Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin.
            //Cümledeki toplam kelime ve harf sayısını console'a yazdırın.

            Console.WriteLine("Lütfen bir metin giriniz.");
            int total = 0;
            string input4 = Console.ReadLine();

            string[] wordNumber = input4.Split(' ');

            Console.WriteLine($"girilen metin {wordNumber.Length} kelime ve {input4.Length - (wordNumber.Length - 1)} harften oluşmaktadır.");

            Console.ReadLine();
        }
    }
}
