using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algoritm2
{
    class Program
    {
        //Sart elementlari soni bo'yicha faktorial hisoblash uchun funksiya yaratamiz
        static int fact(string a){
            int fact=1;
            for (int i = 1; i <= a.Length; i++)
            {
                fact *= i;
            }
            return fact;
        }
        //Satrni harflari o'rnini almashtirib massiv qaytaradigan funksiya yaratamiz
        static string[] harf(string b)
        {
            //Massiv e'lon qilamiz
            string[] mas;
            mas = new string[fact(b)];
            //Agar satr elementlari 2 ta bo'lsa
            if (b.Length == 2)
            {
                mas[0] = b;
                mas[1] = Convert.ToString(b[1]) + Convert.ToString(b[0]);
            }
            //Agar satr elementlari 2 tadan ko'p bo'lsa
            else
            {
                for (int i = 0; i < b.Length; i++)
                {
                    for (int j = 0; j < fact(b) / b.Length; j++)
                    {
                        //Satrni 1-elementini saqlab qolgan holda, qolgan elementlarini o'rnini almashtirib massivga yuklaymiz
                        mas[fact(b) / b.Length * i + j] = b[0] + get(harf(b.Remove(0, 1)), j);
                    }
                    //Satrni 1-elementini oxiriga o'tkazamiz 
                    b = b.Remove(0, 1) + b[0];
                }
            }
            //Funksiya massivni qaytaradi
            return mas;
        }
        //Funksiya qaytargan massiv elementlarini alohida olish uchun funksiya yaratamiz
        static string get(string[] x, int k)
        {
            return x[k];
        }
        static void Main(string[] args)
        {
            // Satrni kiritib olamiz
            string a;
            Console.Write("Belgilar ketma-ketligini kiriting:");
            a = Console.ReadLine();
            Console.WriteLine();
            //Funksiyaga murojaat qilgan holda chiqaramiz
            for (int i = 0; i < fact(a); i++)
            {
                Console.WriteLine(Convert.ToString(i+1) +".\t"+ get(harf(a), i));
            }
                Console.ReadKey();
        }
    }
}
