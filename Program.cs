using System;

namespace QUIZ09092019
{
    class Program
    {
        static void Main(string[] args)
        {
            BangunDatar hasil = new BangunDatar();
            hasil.luas_persegi();
            hasil.luas_segitiga();
            hasil.luas_lingkaran();

            BangunRuang jawaban = new BangunRuang();
            jawaban.volume_balok();
            jawaban.volume_kubus();
        }
    }
}
