using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackchallenge01.Methods
{
    public class LongestIncreasingSubseq
    {
        public static int GetMaxLengthOfSubseq(int[] subseq)
        {
            var n = subseq.Length;
            int result = 0;
            int[] longestsubseq = new int[n];
            
            for (int i = 0; i < n; i++)
            {
                result = Math.Max(result, longestsubseq[i]);
            }

            return result;
        }
    }
}
