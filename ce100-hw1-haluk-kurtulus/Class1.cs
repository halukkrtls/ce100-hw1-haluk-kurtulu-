using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ce100_hw1_algo_lib_cs
{
    public class Class1
    {
        /**
        * @file ce100_hw1_algo_lib_cs
        * @author Haluk KURTULUS
        * @date 14 March 2023
        *
        * @brief <b> hw-1 Functions </b>
        *
        * hw-1 Sample Lib Functions
        *
        * @see http://bilgisayar.mmf.erdogan.edu.tr/en/
        *
        */




        /**
        *
        *	  @name   Selection Sort
        *
        *	  @brief Selection Sort Function
        *
        *	  In each iteration of the selection sort algorithm, the smallest entry in an unsorted list is found. The lowest element determined at the conclusion of the iteration is replaced with the element at the start of the list.
        *	  @param  [in] numArray, arrayLength [\b int]   Selection Sort in the serie
        *
        *	  @retval [\b int] Selection Sort
        **/


        public int[] SortArray(int[] numArray, int arrayLength)
        {
            
            int tempVar, smallestVal;
            for (int i = 0; i < arrayLength - 1; i++)
            {
                smallestVal = i;
                for (int j = i + 1; j < arrayLength; j++)
                {
                    if (numArray[j] < numArray[smallestVal])
                    {
                        smallestVal = j;
                    }
                }
                tempVar = numArray[smallestVal];
                numArray[smallestVal] = numArray[i];
                numArray[i] = tempVar;
            }
            return numArray;
        }



        /**
        *
        *	  @name   Recursive Power
        *
        *	  @brief Recursive Power Function
        *
        *	  It's a formula for computing the power of a number.
        *
        *	  @param  [in] x, y [\b int]   Recursive Power in the serie
        *
        *	  @retval [\b int] Recursive Power
        **/

        public int CalcuOfPower(int x, int y)
        {
            if (y == 0)
                return 1;
            else
                return x * CalcuOfPower(x, y - 1);
        }




        /**
        *
        *	  @name   Binary Search Recursive
        *
        *	  @brief Binary Search Recursive Function
        *
        *	  It's the function that allows us to put complex numbers in order with the fewest possible moves.
        *
        *	  @param  [in] inputArray, min, max, key [\b int]   Binary Search Recursive in the serie
        *
        *	  @retval [\b int] Binary Search Recursive
        **/

        public static int BinarySearchRecursive(int[] inputArray, int min, int max, int key)
        {


            int mid = min + (max - min) / 2;

            if (key == inputArray[mid])
            {
                return mid;
            }
            else if (key < inputArray[mid])
            {
                return BinarySearchRecursive(inputArray, min, mid - 1, key);
            }
            else
            {
                return BinarySearchRecursive(inputArray, mid + 1, max, key);
            }

        }


        /**
        *
        *	  @name   Binary Search Iterative
        *
        *	  @brief Binary Search Iterative Function
        *
        *	  Determine whether the target exists in the array in logarithmic time given a sorted array of n integers and a target value using the binary search algorithm. If target is found in the array, report its index.
        *
        *	  @param  [in] inputArray, key [\b int]   Binary Search Iterative in the serie
        *
        *	  @retval [\b int] Binary Search Iterative
        **/

        public static int BinarySearchIterative(int[] inputArray, int key)
        {

            int min = 0;
            int max = inputArray.Length - 1;
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (key == inputArray[mid])
                {
                    return mid;
                }
                else if (key < inputArray[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            return -1;
        }

        /**
        *
        *	  @name   Merge Sort
        *
        *	  @brief Merge Sort Function
        *
        *	  The recusrive technique necessitates the creation of a multi-branch recursion until the elements are just one iterm apart. The merging is done using the DoMerge function, which takes three arguments: start, middle, and right.
        *
        *	  @param  [in] array [\b int]   Merge Sort in the serie
        *
        *	  @retval [\b int] Merge Sort
        **/
        public static int[] mergeSort(int[] array)
        {
            
            int[] left;
            int[] right;
            int[] result = new int[array.Length];


            if (array.Length <= 1)
                return array;

            int midPoint = array.Length / 2;

            left = new int[midPoint];



            if (array.Length % 2 == 0)
                right = new int[midPoint];

            else
                right = new int[midPoint + 1];

            for (int i = 0; i < midPoint; i++)
                left[i] = array[i];

            int x = 0;


            for (int i = midPoint; i < array.Length; i++)
            {
                right[x] = array[i];
                x++;
            }

            left = mergeSort(left);

            right = mergeSort(right);

            result = merge(left, right);
            return result;
        }


        public static int[] merge(int[] left, int[] right)
        {
            int resultLength = right.Length + left.Length;
            int[] result = new int[resultLength];

            int indexLeft = 0, indexRight = 0, indexResult = 0;

            while (indexLeft < left.Length || indexRight < right.Length)
            {

                if (indexLeft < left.Length && indexRight < right.Length)
                {

                    if (left[indexLeft] <= right[indexRight])
                    {
                        result[indexResult] = left[indexLeft];
                        indexLeft++;
                        indexResult++;
                    }

                    else
                    {
                        result[indexResult] = right[indexRight];
                        indexRight++;
                        indexResult++;
                    }
                }

                else if (indexLeft < left.Length)
                {
                    result[indexResult] = left[indexLeft];
                    indexLeft++;
                    indexResult++;
                }

                else if (indexRight < right.Length)
                {
                    result[indexResult] = right[indexRight];
                    indexRight++;
                    indexResult++;
                }
            }
            return result;
        }



        //MATRİX MULTIPLICATION STRASSEN:

        /**
        *
        *	  @name   MATRİX MULTIPLICATION STRASSEN
        *
        *	  @brief  MATRİX MULTIPLICATION STRASSEN Function
        *
        *	  Find the multiplication matrix of two square matrices A and B, each of size n x n.
        *
        *	  @param  [in] mass [\n int]   MATRİX MULTIPLICATION STRASSEN in the serie
        *
        *	  @retval [\n int] MATRİX MULTIPLICATION STRASSEN
        **/

        public static class MatrixMultiplication
        {
            public static int[,] Strassen(int[,] A, int[,] B)
            {

                int i, j, k;
                // Get the size of the matrices.
                int N = A.GetLength(1);
                // Create a new matrix to hold the result of the multiplication.
                int[,] C = new int[N, N];
                // If the matrices are 1x1, multiply them and return the result.
                if (N == 1)
                {
                    C[0, 0] = A[0, 0] * B[0, 0];
                    return C;
                }
                else
                {
                    // Otherwise, perform standard matrix multiplication using nested loops.
                    for (i = 0; i < N; i++)
                    {
                        for (j = 0; j < N; j++)
                        {
                            C[i, j] = 0;
                            for (k = 0; k < N; k++)
                            {
                                C[i, j] += A[i, k] * B[k, j];
                            }
                        }
                    }
                    // Return the result of the multiplication.
                    return C;
                }
            }

        }

    
    //MATRİX MULTIPLICATION RECURSIVE:

    /**
    *
    *	  @name   MATRİX MULTIPLICATION RECURSIVE
    *
    *	  @brief  MATRİX MULTIPLICATION RECURSIVE Function
    *
    *	  Matrix Multiplication is a binary operation and it produces a matrix from two or more matrices. But for matrix multiplication, 
    *	  the number columns of the first matrix should be equal to the number of rows of the 2nd matrix.
    *
    *	  @param  [in] mass [\i row1, col1, A, row2, col2, B, C int]   MATRİX MULTIPLICATION RECURSIVE in the serie
    *
    *	  @retval [\row1, col1, A, row2, col2, B, C int] MATRİX MULTIPLICATION RECURSIVE
    **/

    public static int MAX = 100;

        // Note that below variables
        // are static i and j are used
        // to know current cell of result
        // matrix C[][]. k is used to
        // know current column number of
        // A[][] and row number of B[][]
        // to be multiplied
        public static int i = 0, j = 0, k = 0;

        public static void multiplyMatrixRec(int row1, int col1,
                                        int[,] A, int row2,
                                        int col2, int[,] B,
                                        int[,] C)
        {
            // If all rows traversed
            if (i >= row1)
                return;

            // If i < row1
            if (j < col2)
            {
                if (k < col1)
                {
                    C[i, j] += A[i, k] * B[k, j];
                    k++;

                    multiplyMatrixRec(row1, col1, A,
                                        row2, col2, B, C);
                }

                k = 0;
                j++;
                multiplyMatrixRec(row1, col1, A,
                                    row2, col2, B, C);
            }

            j = 0;
            i++;
            multiplyMatrixRec(row1, col1, A,
                                row2, col2, B, C);
        }


        //MATRİX MULTIPLICATION ITERATIVE:

        /**
        *
        *	  @name   MATRİX MULTIPLICATION ITERATIVE
        *
        *	  @brief  MATRİX MULTIPLICATION ITERATIVE Function
        *
        *	  Matrix multiplication is defined as follows: if C = AB for a n m matrix A and a m p matrix B, then C is a n p matrix with entries.
        *
        *	  @param  [in] mass [\mat1, mat2, res int]   MATRİX MULTIPLICATION ITERATIVE in the serie
        *
        *	  @retval [\mat1, mat2, rec int] MATRİX MULTIPLICATION ITERATIVE
        **/

        static int N = 4;

        // This function multiplies mat1[][]
        // and mat2[][], and stores the result
        // in res[][]
        public static int[,] multiply(int[,] mat1,
                             int[,] mat2, int[,] res)
        {
            int i, j, k;
            for (i = 0; i < N; i++)
            {
                for (j = 0; j < N; j++)
                {
                    res[i, j] = 0;
                    for (k = 0; k < N; k++)
                        res[i, j] += mat1[i, k]
                                     * mat2[k, j];
                }
            }
            return res;
        }

    




        //RANDOMIZED QUICKSORT LAMUTO:

        /**
        *
        *   @name   RANDOMIZED QUICKSORT LAMUTO
        *
        *	@brief  RANDOMIZED QUICKSORT LAMUTO Function
        *
        *   We initially partition the array in place in QuickSort so that all elements to the left of the pivot element are smaller, and all elements to the right of the pivot are larger.
        
        *
        *	@param  [in] mass [\arr, low, high int]   RANDOMIZED QUICKSORT LAMUTO in the serie
        *
        *	@retval [\arr, low, high int] RANDOMIZED QUICKSORT LAMUTO
        **/

        /* This function takes last element as pivot,
            places the pivot element at its correct
            position in sorted array, and places all
            smaller (smaller than pivot) to left of
            pivot and all greater elements to right
            of pivot */
        static int partitioon(int[] arr, int low, int high)
        {

            // pivot is chosen randomly
            random(arr, low, high);
            int pivot = arr[high];

            int i = (low - 1); // index of smaller element
            for (int j = low; j < high; j++)
            {

                // If current element is smaller than or
                // equal to pivot
                if (arr[j] < pivot)
                {
                    i++;

                    // swap arr[i] and arr[j]
                    int tempp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = tempp;
                }
            }

            // swap arr[i+1] and arr[high] (or pivot)
            int tempp2 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = tempp2;

            return i + 1;
        }

        // This Function helps in calculating
        // random numbers between low(inclusive)
        // and high(inclusive)
        public static int random(int[] arr, int low, int high)
        {

            Random rand = new Random();
            int pivot = rand.Next(low, high) % (high - low) + low;

            int tempp1 = arr[pivot];
            arr[pivot] = arr[high];
            arr[high] = tempp1;

            return partitioon(arr, low, high);
        }

        /* The main function that implements Quicksort()
            arr[] --> Array to be sorted,
            low --> Starting index,
            high --> Ending index */
        public static void QuickSoLo(int[] arr, int low, int high)
        {
            if (low < high)
            {
                /* pi is partitioning index, arr[pi] is
                        now at right place */
                int pi = partitioon(arr, low, high);

                // Recursively sort elements before
                // partition and after partition
                QuickSoLo(arr, low, pi - 1);
                QuickSoLo(arr, pi + 1, high);
            }
        }




        //RANDOMIZED QUICKSORT HOURE:

        /**
        *
        *   @name   RANDOMIZED QUICKSORT HOURE
        *
        *	@brief  RANDOMIZED QUICKSORT HOURE Function
        *
        *   We split the array in place in QuickSort so that all elements to the left of the pivot element are smaller, and all elements to the right of the pivot are larger.
        
        *
        *	@param  [in] mass [\arr, low, high int]   RANDOMIZED QUICKSORT HOURE in the serie
        *
        *	@retval [\arr, low, high int] RANDOMIZED QUICKSORT HOURE
        **/

        public static int randomhoarepartition(int[] arr, int low, int high)
        {
            int pivot = arr[low];
            int i = low - 1, j = high + 1;

            while (true)
            {

                // Find leftmost element greater than
                // or equal to pivot
                do
                {
                    i++;
                } while (arr[i] < pivot);

                // Find rightmost element smaller than
                // or equal to pivot
                do
                {
                    j--;
                } while (arr[j] > pivot);

                // If two pointers met
                if (i >= j)
                    return j;

                int tempp = arr[i];
                arr[i] = arr[j];
                arr[j] = tempp;
            }
        }
        public static int Random(int[] arr, int low, int high)
        {
            // Generate a random number in between
            // low .. high
            Random rand = new Random();
            int pivot = rand.Next() % (high - low) + low;

            int tempp1 = arr[pivot];
            arr[pivot] = arr[high];
            arr[high] = tempp1;

            return randomhoarepartition(arr, low, high);
        }
        public static void randomQuicksortHoare(int[] array, int lw, int high)
        {
            if (lw < high)
            {
                /* pi is partitioning index, arr[pi] is
                      now at right place */
                int pi = Random(array, lw, high);

                // Recursively sort elements before
                // partition and after partition
                randomQuicksortHoare(array, lw, pi);
                randomQuicksortHoare(array, pi + 1, high);
            }
        }
    }
}



        