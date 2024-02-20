using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extra2
{
    internal class WriteArray
    {
        public WriteArray(int[] nums) 
        {
            foreach (int item in nums)
            {
                Console.WriteLine(item);
            }
        }
    }
}
