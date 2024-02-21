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
        public SumArray(int[] nums)
        {
            bool f = false;
            bool r = false;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < 0 && f) r = true;
                if (r) sum += nums[i];
                if (nums[i] < 0 && !f) f = true;
            }
        }
    }
}
