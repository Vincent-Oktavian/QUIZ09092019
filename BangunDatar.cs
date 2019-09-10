using System;

namespace QUIZ09092019
{
    class BangunDatar
    {
        public void luas_persegi()
        {
            int sisipersegi, luas;
            Console.WriteLine("#--------------#");
            Console.WriteLine("| BANGUN DATAR |");
            Console.WriteLine("#--------------#");

            Console.WriteLine("Luas Persegi");
            Console.WriteLine("------------");

            Console.Write("jika sisi persegi adalah ");
            sisipersegi = Convert.ToInt32(Console.ReadLine());

            luas = sisipersegi * sisipersegi;

            Console.WriteLine("maka luas persegi adalah "+luas+"\n");
        }
        public void luas_segitiga()
        {
            int alassegitiga, tinggisegitiga, luassegitiga;

            Console.WriteLine("Luas Segitiga");
            Console.WriteLine("-------------");

            Console.Write("Diketahui alas segitiga adalah ");
            alassegitiga = Convert.ToInt32(Console.ReadLine());

            Console.Write("Diketahui tinggi segitiga adalah ");
            tinggisegitiga = Convert.ToInt32(Console.ReadLine());

            luassegitiga = alassegitiga * tinggisegitiga * 1/2;

            Console.WriteLine("maka Luas segitiga adalah "+luassegitiga+"\n");
        }
        public void luas_lingkaran()
        {
            int jari, luaslingkaran;

            Console.WriteLine("Luas Lingkaran");
            Console.WriteLine("--------------");

            Console.Write("Jika jari-jari lingkaran adalah ");
            jari = Convert.ToInt32(Console.ReadLine());

            luaslingkaran = jari * jari * 314/100;

            Console.WriteLine("maka Luas Lingkaran adalah "+luaslingkaran+"\n \n");
        }

    }
}