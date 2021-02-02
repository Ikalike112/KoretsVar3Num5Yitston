using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Yitstona y = new Yitstona("водогрязеторфопарафинолечение","скрытоколокольчик");
            Console.WriteLine("МАМА КРАСИВАЯ");
            Console.WriteLine(y.Zawifr("МАМА КРАСИВАЯ"));
            Console.WriteLine(y.Raswifr(y.Zawifr("МАМА КРАСИВАЯ")));
            Console.ReadKey();
        }
    }
}
