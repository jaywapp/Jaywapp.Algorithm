namespace Jaywapp.Algorithm.String.KMP
{
    public class PrefixAnalysis
    {
        public static int[] Analyze(string pattern)
        {
            var array = new int[pattern.Length];

            array[0] = 0;
            int i = 1;
            int j = 0;

            while (i < pattern.Length)
            {
                if (pattern[i] == pattern[j])
                {
                    array[i] = j + 1;
                    i++;
                    j++;
                }
                else if (j > 0)
                {
                    j = array[j - 1];
                }
                else
                {
                    array[j] = 0;
                    i++;
                }
            }

            return array;
        }
    }
}
