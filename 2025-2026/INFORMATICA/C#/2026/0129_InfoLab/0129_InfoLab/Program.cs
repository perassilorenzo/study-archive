using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _0129_InfoLab
{
    internal class Program
    {
        static Random rnd = new Random();

        static void Main(string[] args)
        {

        }
        /// <summary>
        /// carica un array di n numeri casuali, fra min e max (entrambi compresi)
        /// </summary>
        /// <param name="n">numero di elementi da generare, > 0</param>
        /// <param name="min">numero minimo</param>
        /// <param name="max">numero massimo, >= del minimo</param>
        /// <returns></returns>
        public int[] RandomLoadArray(int n, int min, int max)
        {
            if (n <= 0)
            {
                return null;
            }

            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                array[i] = rnd.Next(min, max + 1);
            }

            return array;
        }

        public void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }

            Console.WriteLine(array[array.Length - 1]);
        }

        public string ArrayToString(int[] array)
        {
            string str = "";
            for (int i = 0;i < array.Length; i++)
            {
                str += " " + array[i].ToString();
            }

            return $"{str} {array[array.Length - 1]}";
        }

        public int GreaterElementArray(int[] array)
        {
            return GreaterElementOfSubArray(array, 0, array.Length - 1);

            //int max = array[0];

            //for (int i = 1; i < array.Length; i++)
            //{
            //    if (array[i] > max) max = array[i];
            //}

            //return max;
        }

        public int GreaterElementOfSubArray(int[] array, int start, int end)
        {
            CheckSubArrayIndices(array, ref start, ref end);

            int max = array[start];
            for (int i = start+1; i <= end; i++)
            {
                if ( array[i] > max ) max = array[i];
            }

            return max;
        }

        public bool ArrayContainsElement(int[] array, int element)
        {
            return SubArrayContainsElement(array, 0, array.Length-1, element);
        }

        private bool SubArrayContainsElement(int[] array, int min, int max, int element)
        {
            CheckSubArrayIndices(array, ref min, ref max);

            for (int i = min; i <= max; i++)
            {
                if (array[i] == element) return true;
            }
            return false;
        }

        public int[] SortedArray(int[] array)
        {
            return SortedSubArray(array, 0, array.Length - 1);
           
            //int[] sortedArray = new int[array.Length];

            //for (int i = 0; i < array.Length; i++)
            //{
            //    int minIndex = i;
            //    for (int j = 0; j < array.Length; j++)
            //    {
            //        if (array[minIndex] > array[j])
            //        {
            //            int temp = array[i];
            //            array[i] = array[j];
            //            array[j] = temp;
            //        }
            //    }
                
            //    sortedArray[i] = array[minIndex];
            //}

            //return sortedArray;
        }

        public int[] SortedSubArray(int[] array, int max, int min)
        {
            CheckSubArrayIndices(array, ref max, ref min);

            int[] sortedArray = new int[max-min];

            for (int i = min; i <= max; i++)
            {
                int minIndex = i;
                for (int j = min; j < max; j++)
                {
                    if (array[minIndex] > array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }

                sortedArray[i] = array[minIndex];
            }

            return sortedArray;
        }
        public void SortArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int minIndex = i;
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[minIndex] > array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
                if (minIndex != i)
                {
                    int temp = array[i];
                    array[i] = array[minIndex];
                    array[minIndex] = temp;
                }
            }
        }

        public void SortSubArray(int[] array, int start, int end)
        {
            CheckSubArrayIndices(array, ref start, ref end);

            for (int i = start; i <= end; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j <= end; j++)
                {
                    if (array[minIndex] > array[j])
                    {
                        minIndex = j;
                    }
                }

                if (minIndex != i)
                {
                    int temp = array[i];
                    array[i] = array[minIndex];
                    array[minIndex] = temp;
                }
            }
        }

        public void CheckSubArrayIndices(int[] array, ref int min, ref int max)
        {
            if (min < 0) min = 0;
            if (max > array.Length - 1) max = array.Length - 1;
            if (min > max)
            {
                int temp = min;
                min = max;
                max = temp;
            }
        }
    }
}\\