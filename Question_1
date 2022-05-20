using System.Linq;

namespace Solution
{
    public class Solution
    {
        public int solution(int[] A)
        {
            if(A.Length <= 0)
                return -1;

            int[] sortedArray = A.RemoveNegative().Distinct().OrderBy(x => x).ToArray();
            int value = sortedArray[0];

            for (int i = 0; i < sortedArray.Length; i++, value++)
            {
                if(sortedArray[i] != value)
                    return value;
            }

            return value;
        }
    }


    public static class Extentions
    {
        public static int[] RemoveNegative(this int[] array)
        {
            int[] updatedArray = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                    updatedArray[i] = array[i];
            }

            return updatedArray;
        }
    }
}
