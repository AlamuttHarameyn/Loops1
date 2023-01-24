using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._17._1_Cevrimler2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir sayi giriniz:");
            int n = Convert.ToInt32(Console.ReadLine());
            int i = 2;
            do 
            //herhangi bir koşula bakmaksızın olduğu gibi çalıştırır.
            //,koşul ifadesi başlamgıç ifadeszi geçerli değil.
            {
                Console.Write("{0,3}",i);
                i += 2;
            } 
            while (i <= n);
            Console.ReadKey();
        }
    }
}
