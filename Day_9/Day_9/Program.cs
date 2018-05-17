using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_9
{
    class Program
    {
        static void Main(string[] args)
        {
            SimboluApstrade summa = new SimboluApstrade();
            Console.WriteLine("Ievadiet  3 vardus: ");
            string teikums = summa.Vardi("as", "bs", "cs");
            Console.WriteLine(teikums);


           /*Tests TestaObjekts = new Tests();
            int rezultats = TestaObjekts.Saskaitisana(3, 7);

            Tests TestaObjekts2 = new Tests();

            TestaObjekts.skaitlis = 3;
            TestaObjekts2.skaitlis = 6;

            TestaObjekts.Set(11);
            rezultats = TestaObjekts.Get();

            Console.WriteLine("Izvade no TestaObjekts: " + TestaObjekts.skaitlis);
            Console.WriteLine("Izvade no TestaObjekts2: " + TestaObjekts2.skaitlis);

            Console.WriteLine("Izvade no klases: " + rezultats);*/
            Console.ReadLine();
        }
    }
}
