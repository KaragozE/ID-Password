using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int flag = 0;
            while (flag == 0)
            {
                Console.Write("Kullanıcı adı giriniz:");
                string kAdi = Console.ReadLine();
                Console.Write("Şifre Giriniz:");
                string pwd = Console.ReadLine();

                if (kAdi == "admin" && pwd == "123")
                {
                    Console.WriteLine("Hoşgeldiniz");
                    flag = 1;
                }
                else
                {
                    Console.WriteLine("Yanlış kullanıcı adı ya da şifre");
                }
            }
            Console.WriteLine("Portal Eray");
            Console.ReadKey();
        }
    }
}
