using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuzzyLogic
{ 
    public static class SimpleCompare
    {

        //returns the number of characters that are different in both strings.
        //If one string is less than the other, the string with less characters is padded left with zeros.
        public static int Compare(this string input, string comparedTo)
        {
            int countOfMisMatches = 0;

            int lenInput = input.Length;
            int lenCompareTo = comparedTo.Length;

            try
            {
                //if both string have not length return zero since they are equal in a sense
                //and no reason to compare characters that are not there.
                if (lenInput == 0 && lenCompareTo == 0) return 0;

                if (lenInput != lenCompareTo)
                {
                    if (lenInput < lenCompareTo)
                    {
                        //The input string is shorter than the comparedTo length.
                        //Pad the input string with zeros
                        input = input.PadLeft(lenCompareTo, '0');
                    }
                    else //lenCompareTo is less then lenInput. Pad the comparedTo string with zeros
                    {
                        comparedTo = comparedTo.PadLeft(lenInput, '0');
                    }
                }

                char[] arrInput = input.ToCharArray();
                char[] arrComparedTo = comparedTo.ToCharArray();

                for (int i = 0; i < arrInput.Length; i++)
                {
                    if (arrInput[i] != arrComparedTo[i])
                    {
                        ++countOfMisMatches;
                    }
                }                

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            return countOfMisMatches;
        }
    }
}
