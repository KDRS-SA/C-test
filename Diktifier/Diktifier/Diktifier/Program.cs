using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            bool more = true;
            Console.WriteLine("Oppgi en tekststreng som kan 'dikt-i-fiseres' etter Jan Erik Wold-metoden:"+Environment.NewLine+"(For eksempel 'kulturuke')");
            string streng = Console.ReadLine().ToLower();
            while (more)
            {
                for (int a = 0; a < 10; a++)
                {
                    streng = ByttBokstaver(streng);
                }
                Console.WriteLine(Environment.NewLine + "Flere nyttige ord? (Esc for å bryte..)");
                ConsoleKeyInfo ck = Console.ReadKey();
                switch (ck.Key)
                {
                    case ConsoleKey.Escape: more = false; break;
                }
            }
        }

        public static string ByttBokstaver(string innStreng)
        {
            string utStreng = string.Empty;

            int pos1 = new Random().Next(innStreng.Length);
            int pos2 = 0;
            while (pos2 == 0 || pos2 == pos1)
                pos2 = new Random().Next(innStreng.Length);
            char[] a = innStreng.ToCharArray();
            char temp = a[pos1];
            a[pos1] = a[pos2];
            a[pos2] = temp;
            utStreng = new String(a);
            Console.WriteLine(utStreng);
            return utStreng;
        }
    }
}
