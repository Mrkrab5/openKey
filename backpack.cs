using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace openKey
{
    internal class backpack
    {

        public backpack() 
        { 
        
        }

        static public string Decoding(string massenge)
        {
            string tmpString = massenge.ToUpper(), result = "";

            Dictionary<char, string> dictBinCode = new Dictionary<char, string>()
            { {'А', "10010000"}, {'Б', "10010001"}, {'В', "10010010"}, {'Г', "10010011"}, {'Д', "10010100"}, 
              {'Е', "10010101"}, {'Ё', "10000001"}, {'Ж', "10010110"}, {'З', "10010111"}, {'И', "10011000"}, 
              {'Й', "10011001"}, {'К', "10011010"}, {'Л', "10011011"}, {'М', "10011100"}, {'Н', "10011101"}, 
              {'О', "10011110"}, {'П', "10011111"}, {'Р', "10100000"}, {'С', "10100001"}, {'Т', "10100010"}, 
              {'У', "10100011"}, {'Ф', "10100100"}, {'Х', "10100101"}, {'Ц', "10100110"}, {'Ч', "10100111"}, 
              {'Ш', "10101000"}, {'Щ', "10101001"}, {'Ъ', "10101010"}, {'Ы', "10101011"}, {'Ь', "10101100"},
              {'Э', "10101101"}, {'Ю', "10101110"}, {'Я', "10101111"}, {' ', "10110000"} };

            int[] backpackValue = new int[] {62, 93, 186, 403, 417, 352, 315, 210};

            int[] encryptSymbol = new int[massenge.Length];

            return result;
        }
    }
}
