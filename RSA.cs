using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace openKey
{
    internal class RSA
    {

        public RSA()
        {

        }

        static private int Simple()
        {
            int n = 0;

            Random rnd = new Random();

            bool good = false;

            while (!good)
            {
                n = rnd.Next();

                int count = 0;

                for (int i = 2; i < n / 2; i++)
                {
                    if (n % i == 0)
                        count++;
                }

                if (count == 0)
                    good = true;
            }

            return n;
        }

        static public string Decoding(string massenge)
        {
            string tmpString = massenge.ToUpper(), bigReg = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ ", result = "";

            int[] simple = new int[2];

            int n, fynEilera, e;

            bool good = false;

            //Цикл для формирования 2-х случайных простых чисел результат умножения которых
            //будет больше любого из кодов сообщения
            while (!good)
            {
                simple[0] = Simple();
                simple[1] = Simple();

                if (simple[0] * simple[1] > bigReg.Length)
                    good = true;
            }

            n = simple[0] * simple[1];
            fynEilera = (simple[0] - 1) * (simple[1] - 1);

            Random rnd = new Random();

            //Цикл для формирования взаимно простого числа с n
            while (good)
            {
                e = rnd.Next(0, n);

                if (n % e == 0)
                    good = false;
            }



            return result;
        }
    }
}
