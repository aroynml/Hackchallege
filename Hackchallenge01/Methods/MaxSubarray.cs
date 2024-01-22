using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackchallenge01.Methods
{
    public class MaxSubarray
    {
        public static int ComputeMaximumSum(IReadOnlyList<int> numbers)
        {
            var maximumSum = int.MinValue;
            for (var i = 0; i < numbers.Count; i++)
            {
                var currentSum = numbers[i];
                for (var j = i + 1; j < numbers.Count; j++)
                {
                    currentSum += numbers[j];
                    if (currentSum > maximumSum)
                        maximumSum = currentSum;
                }
            }

            var maximumElement = numbers.Max();
            return maximumElement > maximumSum ? maximumElement : maximumSum;
        }
    }
}
