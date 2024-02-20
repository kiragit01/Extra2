using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extra2
{
    internal class SumArray
    {
        public int sum; 
        public int min1 = 0, min2 = 0;
        public int f1 = 0, f2 = 0;
        public SumArray(int[] nums)
        {
            foreach (int item in nums.Skip(MinInd(nums)))
            {
                sum += item;
            }
        }
        public int MinInd(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < min1)
                {
                    min2 = min1;
                    f2 = f1;
                    min1 = nums[i];
                    f1 = i;
                    
                }
                if (nums[i] > min1 && nums[i] < min2)
                {
                    min2 = nums[i];
                    f2 = i;
                }
            }
            return f2+1;
        }
    }
}
