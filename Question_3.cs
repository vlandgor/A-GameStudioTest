namespace Solution
{
    public class Solution
    {
        public int solution(int[] A)
        {
            if (A.Length == 0 || A[A.Length - 1] < 0 || A[A.Length - 1] > 1)
                return -1;

            int value = 0;

            for (int east = 0; east < A.Length - 1; east++)
            {
                if (A[east] < 0 || A[east] > 1)
                    return -1;

                if (A[east] == 0)
                    for (int west = east + 1; west < A.Length; west++)
                    {
                        if (A[west] == 1)
                            value++;
                    }
            }

            if (value > 1000000)
                return -1;

            return value;
        }
    }
}
