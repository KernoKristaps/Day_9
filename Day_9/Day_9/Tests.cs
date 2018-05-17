using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_9
{
    class Tests
    {
        //public, private
        //public int skaitlis;

        private int Privatais1;
        private int Privatais2;

        public int Get()
        {
            return Privatais1;
        }

        public void Set(int value)
        {
            if (value != 0)
            {
                Privatais1 = value;
            }
            else
            {
                Privatais1 = 1;
            }

        }

        public int GetPrivatais2()
        {
            return Privatais2;
        }

        public void SetPrivatais2(int value)
        {
            Privatais2 = value;
        }


        public int Saskaitisana(int a, int b)
        {
            Izvade();
            return a + b;
        }

        private void Izvade()
        {
            Console.WriteLine("tests!");
        }
    }
}
