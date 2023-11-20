using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lat2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nama, predikat;
            int nilai_harian, nilai_uts, nilai_uas, nilai_rata;

            Console.WriteLine("=====================================");
            Console.WriteLine(" Program Menghitung Nilai Rata Rata ");
            Console.WriteLine("=====================================");

            while (true)
            {
              
                Console.Write("Masukan nama anda  : ");
                nama = Console.ReadLine();
                Console.Write("Masukan Nilai Harian : ");
                nilai_harian = Convert.ToInt32(Console.ReadLine());
                Console.Write("Masukan  Nilai UTS : ");
                nilai_uts = Convert.ToInt32(Console.ReadLine());                
                Console.Write("Masukan  Nilai UAS : ");
                nilai_uas = Convert.ToInt32(Console.ReadLine());

                nilai_rata = (nilai_harian + nilai_uts + nilai_uas) / 3;              
                Console.WriteLine($"Nilai Rata-rata : {nilai_rata}");
               
                if (nilai_rata >= 80)
                {
                    predikat = "A";
                }
                else if (nilai_rata >= 70 && nilai_rata < 80)
                {
                    predikat = "B";
                }
                else if (nilai_rata >= 60 && nilai_rata < 70)
                {
                    predikat = "C";
                }
                else if (nilai_rata >= 50 && nilai_rata < 60)
                {
                    predikat = "D";
                }
                else
                {
                    predikat = "E";
                }

              
                Console.WriteLine($"Predikat Nilai: {predikat}");               
                Console.Write("Apakah ingin memasukkan data lagi? (ya/tidak): ");
                string jawaban = Console.ReadLine().ToLower();             
                if (jawaban != "ya")
                {
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}
