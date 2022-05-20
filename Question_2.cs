using System.Linq;

namespace Solution
{
    public class Solution2
    {
        public int solution(int X, int[] A)
        {
            if (!A.All(x => x > 0) || A.Length < 1 || X < 1)
                return -1;

            int[] array = new int[A.Length > X ? A.Length : X];

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] < X)
                    array[A[i]] = A[i];

                if (A[i] == X && CheckArray(X, array))
                    return i;
            }

            return -1;
        }

        private bool CheckArray(int X, int[] array)
        {
            for (int i = 1; i < X; i++)
            {
                if (array[i] != i)
                    return false;
            }

            return true;
        }
    }
}
