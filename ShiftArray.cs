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
            f1 = arr[n];
            for (int i = n; i >= 0; i--)
            {
                if(i == 0) arr[n] = arr[i];
                f1 = f2;
                f2 = arr[i];
                arr[i] = f1;
            }
        }
    }
}
