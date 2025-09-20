using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zodiak
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.SetWindowSize(Console.WindowWidth/2,Console.WindowHeight/2);

            
            Console.WriteLine("tgl. lahir (hh/bb/tttt)");
            string sTgl = Console.ReadLine();

            string[] sArrTgl = sTgl.Split('/');

            string hh = sArrTgl[0];
            string bb = sArrTgl[1];
            string tttt = sArrTgl[2];

            // string dateString = "2025-09-20 14:00:00";
            string dateString = tttt + "-" + bb + "-" + hh ;
            DateTime dateTime = DateTime.Parse(dateString);

            string hari = Hari((int)dateTime.DayOfWeek);
            string zodiak = Zodiak(int.Parse(hh), int.Parse(bb));

            Console.WriteLine("");
            Console.WriteLine("-------");
            Console.WriteLine("ZODIAK");
            Console.WriteLine("-------");
            Console.WriteLine("Hari lahir: " + hari);
            Console.WriteLine("Zodiak: " + zodiak);

            Console.ReadKey();
        }

        private static string Hari(int hari)
        {
            switch (hari)
            {
                case 0:
                    return "Minggu";
                case 1:
                    return "Senin";
                case 2:
                    return "Selasa";
                case 3:
                    return "Rabu";
                case 4:
                    return "Kamis";
                case 5:
                    return "Jumat";
                default:
                    return "Sabtu";
            }
        }


        private static int Bulan(string bulan)
        {
            int hasil = 0;

            if (bulan.Equals("januari", StringComparison.InvariantCultureIgnoreCase)) hasil = 01;
            else if (bulan.Equals("februari", StringComparison.InvariantCultureIgnoreCase)) hasil = 02;
            else if (bulan.Equals("maret", StringComparison.InvariantCultureIgnoreCase)) hasil = 03;
            else if (bulan.Equals("april", StringComparison.InvariantCultureIgnoreCase)) hasil = 04;
            else if (bulan.Equals("mei", StringComparison.InvariantCultureIgnoreCase)) hasil = 05;
            else if (bulan.Equals("juni", StringComparison.InvariantCultureIgnoreCase)) hasil = 06;
            else if (bulan.Equals("juli", StringComparison.InvariantCultureIgnoreCase)) hasil = 07;
            else if (bulan.Equals("agustus", StringComparison.InvariantCultureIgnoreCase)) hasil = 08;
            else if (bulan.Equals("september", StringComparison.InvariantCultureIgnoreCase)) hasil = 09;
            else if (bulan.Equals("oktober", StringComparison.InvariantCultureIgnoreCase)) hasil = 10;
            else if (bulan.Equals("november", StringComparison.InvariantCultureIgnoreCase)) hasil = 11;
            else if (bulan.Equals("desember", StringComparison.InvariantCultureIgnoreCase)) hasil = 12;

            return hasil;
        }


        private static int[] getTahun(int tahun)
        {
            int[] tanggal = new int[7];
            tanggal[0] = tahun;

            for (int i = 1; i < tanggal.Length; i++)
            {
                tahun = tahun + 12;
                tanggal[i] = tahun;
            }

            return tanggal;
        }


        private static string Zodiak(int tanggal, int bulan)
        {
            string hasil = "";

            if ((tanggal >= 21 && bulan == 3) || (tanggal <= 19 && bulan == 4))
                hasil = "Aries";
            else if ((tanggal >= 20 && bulan == 4) || (tanggal <= 20 && bulan == 5))
                hasil = "Taurus";
            else if ((tanggal >= 21 && bulan == 5) || (tanggal <= 20 && bulan == 6))
                hasil = "Gemini";
            else if ((tanggal >= 21 && bulan == 6) || (tanggal <= 22 && bulan == 7))
                hasil = "Cancer";
            else if ((tanggal >= 23 && bulan == 7) || (tanggal <= 22 && bulan == 8))
                hasil = "Leo";
            else if ((tanggal >= 23 && bulan == 8) || (tanggal <= 22 && bulan == 9))
                hasil = "Virgo";
            else if ((tanggal >= 23 && bulan == 9) || (tanggal <= 22 && bulan == 10))
                hasil = "Libra";
            else if ((tanggal >= 23 && bulan == 10) || (tanggal <= 21 && bulan == 11))
                hasil = "Scorpio";
            else if ((tanggal >= 22 && bulan == 11) || (tanggal <= 21 && bulan == 12))
                hasil = "Saggitarius";
            else if ((tanggal >= 22 && bulan == 12) || (tanggal <= 19 && bulan == 1))
                hasil = "Capricorn";
            else if ((tanggal >= 20 && bulan == 1) || (tanggal <= 18 && bulan == 2))
                hasil = "Aquarius";
            else if ((tanggal >= 19 && bulan == 2) || (tanggal <= 20 && bulan == 3))
                hasil = "Pisces";

            return hasil;
        }




    }
}
