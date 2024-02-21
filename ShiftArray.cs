using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extra2
{
    internal class ShiftArray
    {
        public int f1,f2;
        public ShiftArray(int[] arr) 
        { 
            int n = arr.Length - 1;
            for (int i = n; i >= 0; i--)
            {
                f1 = f2;
                f2 = arr[i];
                arr[i] = f1;
            }
            arr[n] = arr[0];
        }
    }
}
