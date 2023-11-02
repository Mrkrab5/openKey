using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace openKey
{
    internal class elGamal
    {

        public elGamal() 
        { 
        
        }

        static public string Decoding(string massenge)
        {
            string tmpString = massenge.ToUpper(), bigReg = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ ", result = "";

            Random rnd = new Random();

            int p = rnd.Next(2, 32), g = 2, x = rnd.Next(0, p), y;

            bool good = false;

            while (!good)
            {
                int count = 0;

                if (Math.Pow(g, p) % p == 1)
                {
                    for (int i = 1; i < p; i++)
                    {
                        if (Math.Pow(g, i) != 1)
                            count++;
                    }

                    if (count == p - 1)
                        good = true;
                }

                if (!good)
                    g++;
            }

            y = (int)(Math.Pow(g, x) % p);

            for (int i = 0; i < massenge.Length; i++)
                result += $"{(int)(Math.Pow(y, x) * bigReg.IndexOf(tmpString[i]) % p)} ";

            return result;
        }
    }
}
