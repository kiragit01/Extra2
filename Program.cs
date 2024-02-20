using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extra2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Составьте программу вычисления суммы элементов от второго отрицательного и до конца массива

            Extra1();

            //Ввести два целочисленных массива − по 10 элементов в каждом. Сформировать новый массив,
            //на четных местах которого будут элементы снечетными индексами из первого массива,
            //а на нечетных – с четными индексами из второго.

            Extra2();

            //Перемещение элементов массива: первый элемент массива записать на место последнего,
            //при этом сдвинув второй, третий, …, последний элементы на одну позицию влево

            Extra3();

            Console.ReadKey();
        }


        static void Extra1()
        {
            int[] nums = { -8, -7, -9, 3, -1 };
            SumArray sumArray = new SumArray(nums);
            Console.WriteLine(sumArray.sum);
            Console.WriteLine();
        }

        static void Extra2()
        {
            AddArray addArray = new AddArray();
            FormArray formArray = new FormArray();
            int[] nums1 = new int[10]; //{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] nums2 = new int[10]; //{ 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            addArray.Add(nums1);
            addArray.Add(nums2);
            int[] nums = formArray.LinkArr(nums1 , nums2);
            new WriteArray(nums);
            Console.WriteLine();
        }

        static void Extra3()
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            new ShiftArray(nums);
            new WriteArray(nums);
            Console.WriteLine();
        }


    }
}
