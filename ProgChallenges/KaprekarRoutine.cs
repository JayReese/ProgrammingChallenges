using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgChallenges
{
    class KaprekarRoutine
    {

        List<string> hello = new List<string>();
        byte[] NumberArray;

        public KaprekarRoutine(int number)
        {
            Show(number);
        }

        private void Show(int num)
        {
            Console.WriteLine(ReturnLargestNumber(num));
        }

        private int ReturnLargestNumber(int num)
        {
            NumberArray = ReturnNumberArray(num);

            for (byte i = 0; i < NumberArray.Length; i++)
            {
                switch (NumberIsLargest(NumberArray[i], NumberArray))
                {
                    case -1:
                       break;
                    default:
                        return i;
                }
            }

            return -1;
        }

        private int NumberIsLargest(int numberToCompare, byte[] arrayForComparison)
        {
            for(byte i = 0; i < arrayForComparison.Length; i++)
            {
                if((numberToCompare != arrayForComparison[i]) && numberToCompare >)

            }

            return -1;
        }

        private byte[] ReturnNumberArray(int numberToSplit)
        {
            char[] numberChars = numberToSplit.ToString().ToCharArray();
            byte[] numberArray = new byte[numberChars.Length];

            for (byte i = 0; i < numberChars.Length; i++)
                numberArray[i] = Convert.ToByte(numberChars[i]);

            return numberArray;
        }
    }
}
