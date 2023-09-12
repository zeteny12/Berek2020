using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Bérek2020
{
    internal class Program
    {

        static List<Berek> lista = new List<Berek>();

        static void Main(string[] args)
        {
            Beolvasas();
            Feladat3();
            Feladat4();
            Feladat5();
            Feladat7();

            Console.ReadKey();
        }

        private static void Feladat7()
        {
            Console.WriteLine("7. feladat: Statisztika");
            foreach (var item in lista.GroupBy(a => a.Reszleg1).Select(b => new {reszleg = b.Key, darab=b.Count()}))
            {
                Console.WriteLine("\t" + item.reszleg + " - " + item.darab + " fő");
            }
        }

        private static void Feladat5()
        {
            Console.Write("5. feladat: Kérem egy részleg nevét: ");
            string ReszlegNeve = Console.ReadLine();
            Console.Write("6. feladat: ");
        }

        private static void Feladat4()
        {
            int ossz = 0;
            for (int i = 0; i < lista.Count; i++)
            {
                ossz = ossz + lista[i].Ber1;
            }
            double atl = ossz / lista.Count;
            Console.WriteLine("4. feladat: Bérek átlaga: " + atl + " eFt");
        }

        private static void Feladat3()
        {
            Console.WriteLine("3. feladat: Dolgozók száma: " + lista.Count + " fő");
        }

        private static void Beolvasas()
        {
            try
            {
                using (StreamReader sr = new StreamReader("berek2020.txt"))
                {
                    sr.ReadLine();
                    while (!sr.EndOfStream)
                    {
                        lista.Add(new Berek(sr.ReadLine()));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
