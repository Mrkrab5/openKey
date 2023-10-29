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

        //метод для формирования простых чисел
        static private int Simple()
        {
            int n = 0;

            Random rnd = new Random();

            bool good = false;

            while (!good)
            {
                //Ограничение в целях рациональности
                n = rnd.Next(0, 32);

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

            int n, fynEilera, e = 0;

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
            
            //Число n понадобиться для дальнейшего шифрования
            //fynEilera нужна для поиска взаимно простого числа и формирования закрытого ключа
            n = simple[0] * simple[1];
            fynEilera = (simple[0] - 1) * (simple[1] - 1);

            Random rnd = new Random();

            //Цикл для формирования взаимно простого числа с fynEilera
            while (good)
            {
                //Ограничение в целях рациональности
                e = rnd.Next(0, 10);

                if (fynEilera % e != 0)
                    good = false;
            }

            //d - закрытый ключ, checkSimple - коэффициент при fynEilera
            int d = 0; 

            //Нахождение взаимно простого числа с е по модулю fynEilera
            //ключ d нужен для дешифровки сообщения, его вычисление занимает
            //слишком много времени, без него программа нормально шифрует
            /*
            while (!good)
            {
                d++;

                if (d * e % fynEilera == 1)
                    good = true;

            }
            */

            //Формирование строки результата
            for (int i = 0; i < massenge.Length; i++)
            {
                for (int j = 0; j < bigReg.Length; j++)
                {
                    if (tmpString[i] == bigReg[j])
                        result += $"{Math.Pow(j, e) % n} ";
                }
            }

            return result;
        }
    }
}
