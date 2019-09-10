using System;

namespace QUIZ09092019
{
    class BangunRuang
    {
        public void volume_balok()
        {
            int pb, lb, tb, volumebalok;
            Console.WriteLine("#--------------#");
            Console.WriteLine("| BANGUN RUANG |");
            Console.WriteLine("#--------------# \n");
            Console.WriteLine("Volume Balok");
            Console.WriteLine("------------");

            Console.Write("diketahui p = ");
            pb = Convert.ToInt32(Console.ReadLine());
            Console.Write("l = ");
            lb = Convert.ToInt32(Console.ReadLine());
            Console.Write("t = ");
            tb = Convert.ToInt32(Console.ReadLine());

            volumebalok = pb * lb * tb;

            Console.WriteLine("Maka Volume Balok adalah "+volumebalok+"\n");
        }
        public void volume_kubus()
        {
            int sk, volumekubus;
            Console.WriteLine("Volume Kubus");
            Console.WriteLine("------------");

            Console.Write("Jika sisi suatu kubus adalah ");
            sk = Convert.ToInt32(Console.ReadLine());

            volumekubus = sk * sk * sk;

            Console.WriteLine("maka Volume Kubus adalah "+volumekubus);
            Console.WriteLine("^v^ selesai ^v^");
        }

    }
}