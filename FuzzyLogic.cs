using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DuoVia.FuzzyStrings;

namespace FuzzyLogic
{
    public enum FuzzyLogicType
    {
        DiceCoefficient = 0,
        LevenshteinDistance = 1,
        LongestCommonSubsequence = 2,
        SimpleCompare = 3
    }

    public static class FuzzyLogic
    {

        public static double Compare(this string input, string comparedTo, FuzzyLogicType fuzzyLogicType)
        {
            double logicResult = 0;

            try
            {
                
                switch (fuzzyLogicType)
                {
                    case FuzzyLogicType.DiceCoefficient:

                        logicResult = DiceCoefficientExtensions.DiceCoefficient(input, comparedTo);
                        break;

                    case FuzzyLogicType.LevenshteinDistance:

                        logicResult = LevenshteinDistanceExtensions.LevenshteinDistance(input, comparedTo, true);
                        break;

                    case FuzzyLogicType.LongestCommonSubsequence:

                        var lcResult =  LongestCommonSubsequenceExtensions.LongestCommonSubsequence(input, comparedTo, true);

                        logicResult = lcResult.Item2;

                        break;

                    case FuzzyLogicType.SimpleCompare:

                        logicResult = SimpleCompare.Compare(input, comparedTo);
                        break;

                    default:
                        break;
                }

            }
            catch (Exception e)
            {

                return logicResult;
            }

            return logicResult;

        }

    }
}
