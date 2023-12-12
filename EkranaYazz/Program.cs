using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkranaYazz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EkranIslem ei = new EkranIslem();
            ei.EkranaYazz(10,0,5);
            Console.WriteLine("======================");
            ei.EkranaYazz();
        }
    }
    class EkranIslem
    {
        public void EkranaYazz(params int[] sayilar)
        {
            if(sayilar.Length == 0)
            {
                Console.WriteLine("Parametre olmadığı için metottan çıkılıyor.");
                return;
            }
            Console.WriteLine("Parametreden gelen değerler:");
            foreach (var s in sayilar)
            {
                if (s == 0) return;
                Console.WriteLine(s);
            }
        }
    }
}