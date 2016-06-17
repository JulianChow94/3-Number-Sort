using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Number_Sort
{
    class Program
    {
        public static void ThreeSort(int[] A,int size)
        {
            // Low defines the index where the 1s start
            // Mid defines the index which we haven't traversed
            // High defines the index before the 2s start
            int low = 0, mid = 0, temp = 0;
            int high = size - 1;

            // Single Pass
            while (mid <= high)
            {
                switch (A[mid])
                {
                    // Case 1: A[mid] is 0, it has to go before "low"
                    case 0:
                    {
                        temp = A[low];
                        A[low] = A[mid];
                        A[mid] = temp;
                        low++; mid++; break;
                    }
                    // Case 2: A[mid] is 1, this is the correct position, make space for it
                    case 1: { mid++; break; }
                    // Case 3: A[mid] is 2, has to go after high (SWAP WITH THE END)
                    case 2:
                    {
                        temp = A[mid];
                        A[mid] = A[high];
                        A[high] = temp;
                        high--; break;
                    }
                }
            }
        }

        public static void printArray(int[] A, int size)
        {
            int i;
            for (i = 0; i < size; i++)
            {
                Console.Write("{0} ", A[i]);
            }
            Console.WriteLine(" ");
        }

       static void Main(string[] args)
        {
            int[] array = new int[] { 0, 1, 1, 0, 1, 2, 1, 2, 0, 0, 0, 1 };
            int size = array.Length;
            Console.WriteLine("Before Sort");
            printArray(array, size);           
            Console.WriteLine("After Sort");
            ThreeSort(array, size);
            printArray(array, size);
        }
    }
}
