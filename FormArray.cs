using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extra2
{
    internal class FormArray
    {
        public int[] arr = new int[10];
        public int[] LinkArr(int[] arr1, int[] arr2)
        {
            for (int i = 0; i < arr1.Length; i++)
            {
                if(i % 2 == 0) arr[i] = arr2[i];
                else arr[i] = arr1[i];
            }
            return arr;
        }
    }
}
