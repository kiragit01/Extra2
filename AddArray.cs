using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extra2
{
    internal class AddArray
    {
        public int[] Add(int[] nums) 
        { 
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }
            return nums;
        }
    }
}
