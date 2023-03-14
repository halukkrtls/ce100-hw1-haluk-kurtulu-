using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ce100_hw1_algo_lib_cs;
using ce100_hw1_algo_test_cs_;
using System.Linq;
using static ce100_hw1_algo_lib_cs.Class1;

namespace ce100_hw1_algo_test_cs_
{
    [TestClass]
    public class UnitTest1
    {
        Class1 unitTest = new Class1();



        [TestMethod]
        public void SelSort_TestWorstCase()
        {
            Random rnd = new Random();
            int[] Arr1 = new int[10000];
            for (int i = 0; i < Arr1.Length; i++)
            {
                Arr1[i] = 9999 - i;
            }

            unitTest.SortArray(Arr1, Arr1.Length);

            int[] exp = (int[])Arr1.ToArray();

            CollectionAssert.AreEqual(exp, Arr1);
        }
        [TestMethod]
        public void SelSort_TestBestCase()
        {
            Random rnd = new Random();
            int[] Arr1 = new int[10000];
            for (int i = 0; i < Arr1.Length; i++)
            {
                Arr1[i] = i;
            }

            unitTest.SortArray(Arr1, Arr1.Length);

            int[] exp = (int[])Arr1.ToArray();

            CollectionAssert.AreEqual(exp, Arr1);
        }
        [TestMethod]
        public void SelSort_TestAverageCase()
        {
            Random rnd = new Random();
            int[] Arr1 = new int[10000];
            for (int i = 0; i < Arr1.Length; i++)
            {
                Arr1[i] = rnd.Next(1, 10000);
            }
            unitTest.SortArray(Arr1, Arr1.Length);
            int[] exp = (int[])Arr1.ToArray();


            CollectionAssert.AreEqual(exp, Arr1);
        }

        //RECURSİVE-POWER


        [TestMethod]
        public void RecPow_test()
        {

            double key = unitTest.CalcuOfPower(2, 3);
            Assert.AreEqual(key, 8);

        }

        [TestMethod]

        public void RecPow_testMinus()
        {

            double result = unitTest.CalcuOfPower(-2, 3);
            Assert.AreEqual(result, -8);

        }

        [TestMethod]

        public void RecPow_test0()
        {

            int result = unitTest.CalcuOfPower(2, 0);
            Assert.AreEqual(result, 1);

        }




        //Binary Search Recursive


        [TestMethod]

        public void TestRecBinarySearch_BestCase()
        {
            int[] nums = new int[10000];
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = i;
            }

            int target = nums[5000]; // middle element
            int expectedIndex = 5000;

            int actualIndex = Class1.BinarySearchRecursive(nums, 0, nums.Length - 1, target);

            Assert.AreEqual(expectedIndex, actualIndex);
        }


        [TestMethod]
        public void TestRecBinarySearch_WorstCase()
        {
            int[] nums = new int[10000];
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = i;
            }

            int target = nums[0]; // middle element
            int expectedIndex = 0;

            int actualIndex = Class1.BinarySearchRecursive(nums, 0, nums.Length - 1, target);

            Assert.AreEqual(expectedIndex, actualIndex);
        }

        [TestMethod]
        public void TestRecBinarySearch_AverageCase()
        {
            int[] nums = new int[10000];
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = i;
            }

            int target = nums[2999]; // middle element
            int expectedIndex = 2999;

            int actualIndex = Class1.BinarySearchRecursive(nums, 0, nums.Length - 1, target);

            Assert.AreEqual(expectedIndex, actualIndex);
        }

        //Binary Search Iterative

        [TestMethod]

        public void BinarySearchIterative_test1()
        {
            int[] nums = new int[10000];
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = i;
            }
            int key = nums[5000];

            double bas = Class1.BinarySearchIterative(nums, key);
            Assert.AreEqual(bas, nums[5000]);
        }


        [TestMethod]
        public void BinarySearchIterative_test2()
        {
            int[] nums = new int[10000];
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = i;
            }
            int key = nums[9999];

            double bas = Class1.BinarySearchIterative(nums, key);
            Assert.AreEqual(bas, nums[9999]);
        }


        [TestMethod]
        public void BinarySearchIterative_test3()
        {
            int[] nums = new int[10000];
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = i;
            }
            int key = nums[1];

            double bas = Class1.BinarySearchIterative(nums, key);
            Assert.AreEqual(bas, nums[1]);
        }






        [TestMethod]
        public void MergeSort_TestSimple_1()
        {

            int[] Arr1 = new int[6] { 3, 1, 5, 2, 4, 6 };

            int[] Exp = new int[6] { 1, 2, 3, 4, 5, 6 };
            CollectionAssert.AreEqual(Class1.mergeSort(Arr1), Exp);
        }

        [TestMethod]
        public void MergeSort_TestSimple_2()
        {

            int[] Arr1 = new int[6] { 2, 4, 1, 3, 5, 6, };

            int[] Exp = new int[6] { 1, 2, 3, 4, 5, 6, };
            CollectionAssert.AreEqual(Class1.mergeSort(Arr1), Exp);
        }

        [TestMethod]
        public void MergeSort_TestSimple_3()
        {

            int[] Arr1 = new int[6] { 5, 3, 1, 6, 2, 4 };

            int[] Exp = new int[6] { 1, 2, 3, 4, 5, 6 };
            CollectionAssert.AreEqual(Class1.mergeSort(Arr1), Exp);
        }

        //MatrixMulRecTest
        [TestMethod]
        public void MatrixMulRecTest1()
        {
            int row1 = 2, col1 = 2,
            row2 = 2, col2 = 2;
            int[,] A = {{4, 5},
                       {7, 9} };
            Class1.i = 0; Class1.j = 0; Class1.k = 0;

            int[,] B = {{8, 0},
                       {2, 3} };

            int[,] C = new int[row1, col2];

            int[,] expected = { { 42, 15 },
                              { 74, 27 } };

            Class1.multiplyMatrixRec(row1, col1, A, row2, col2, B, C);
            CollectionAssert.AreEqual(expected, C);
        }


        [TestMethod]
        public void MatrixMulRecTest2()
        {
            int row1 = 2, col1 = 2,
            row2 = 2, col2 = 2;
            int[,] A = {{6, 1},
                       {9, 4} };
            Class1.i = 0; Class1.j = 0; Class1.k = 0;

            int[,] B = {{0, 4},
                       {9, 6} };

            int[,] C = new int[row1, col2];

            int[,] expected = { { 9, 30 },
                              { 36, 60 } };

            Class1.multiplyMatrixRec(row1, col1, A, row2, col2, B, C);
            CollectionAssert.AreEqual(expected, C);
        }

        [TestMethod]
        public void MatrixMulRecTest3()
        {
            int row1 = 2, col1 = 2,
            row2 = 2, col2 = 2;
            int[,] A = {{8, 6},
                       {3, 1} };
            Class1.i = 0; Class1.j = 0; Class1.k = 0;

            int[,] B = {{7 ,5},
                        {1, 8} };

            int[,] C = new int[row1, col2];

            int[,] expected = { { 62, 88 },
                              { 22, 23 } };

            Class1.multiplyMatrixRec(row1, col1, A, row2, col2, B, C);
            CollectionAssert.AreEqual(expected, C);
        }

        //MatrixMulStrTest
      
      
        
            [TestMethod]
            public void MatrixStrassenBest()
            {
                // Best case: Two identical matrices
                int[,] A1 = new int[10, 10] {
        { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
        { 0, 1, 0, 0, 0, 0, 0, 0, 0, 0 },
        { 0, 0, 1, 0, 0, 0, 0, 0, 0, 0 },
        { 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 },
        { 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
        { 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
        { 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
        { 0, 0, 0, 0, 0, 0, 0, 1, 0, 0 },
        { 0, 0, 0, 0, 0, 0, 0, 0, 1, 0 },
        { 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 }
    };
                int[,] B1 = (int[,])A1.Clone();
                int[,] expected1 = new int[10, 10] {
        { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
        { 0, 1, 0, 0, 0, 0, 0, 0, 0, 0 },
        { 0, 0, 1, 0, 0, 0, 0, 0, 0, 0 },
        { 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 },
        { 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
        { 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
        { 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
        { 0, 0, 0, 0, 0, 0, 0, 1, 0, 0 },
        { 0, 0, 0, 0, 0, 0, 0, 0, 1, 0 },
        { 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 }
    };
                int[,] result1 = MatrixMultiplication.Strassen(A1, B1);
                CollectionAssert.AreEqual(expected1, result1);
            }

            [TestMethod]
            public void MatrixStrassenAvarage()
            {

                Random random = new Random();
                int[,] A2 = new int[10, 10];
                int[,] B2 = new int[10, 10];
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        A2[i, j] = random.Next(-100, 100);
                        B2[i, j] = random.Next(-100, 100);
                    }
                }
                int[,] expected2 = new int[10, 10];
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        int sum = 0;
                        for (int k = 0; k < 10; k++)
                        {
                            sum += A2[i, k] * B2[k, j];
                        }
                        expected2[i, j] = sum;
                    }
                }
                int[,] result2 = MatrixMultiplication.Strassen(A2, B2);
                CollectionAssert.AreEqual(expected2, result2);

            }
            [TestMethod]
            public void MatrixStrassenWorst()
            {

                int[,] A3 = new int[10, 10];
                int[,] B3 = new int[10, 10];
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        A3[i, j] = 1;
                        B3[i, j] = 1;
                    }
                }
                int[,] expected3 = new int[10, 10];
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        expected3[i, j] = 10;
                    }
                }
                int[,] result3 = MatrixMultiplication.Strassen(A3, B3);
                CollectionAssert.AreEqual(expected3, result3);
            }

            //MatrixMulItrTest
            [TestMethod]

            public void TestMatrixMultiplication_Iterative_AverageCase()
            {
                // Arrange
                int[,] a = new int[10, 10];
                int[,] b = new int[10, 10];
                int[,] result = new int[10, 10];
                Random rand = new Random();

                // Fill matrices A and B with random values
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        a[i, j] = rand.Next(1, 10);
                        b[i, j] = rand.Next(1, 10);
                    }
                }

                // Calculate expected result using naive matrix multiplication
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        for (int k = 0; k < 10; k++)
                        {
                            result[i, j] += a[i, k] * b[k, j];
                        }
                    }
                }

                int[,] exp = Class1.multiply(a, b, result);
                CollectionAssert.AreEqual(exp, result);
            }

            [TestMethod]
            public void TestMatrixMultiplication_Iterative_BestCase()
            {
                // Arrange
                int[,] a = new int[10, 10];
                int[,] b = new int[10, 10];
                int[,] result = new int[10, 10];
                Random rand = new Random();

                // Fill matrices A and B with random values
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        a[i, j] = 0;
                        b[i, j] = 0;
                    }
                }

                // Calculate expected result using naive matrix multiplication
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        for (int k = 0; k < 10; k++)
                        {
                            result[i, j] += a[i, k] * b[k, j];
                        }
                    }
                }

                int[,] exp = Class1.multiply(a, b, result);
                CollectionAssert.AreEqual(exp, result);
            }



            [TestMethod]
            public void TestMatrixMultiplication_Iterative_WorstCase()
            {
                // Arrange
                int[,] a = new int[10, 10];
                int[,] b = new int[10, 10];
                int[,] result = new int[10, 10];
                Random rand = new Random();

                // Fill matrices A and B with random values
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        a[i, j] = rand.Next(1, 10);
                        b[i, j] = rand.Next(1, 10);
                    }
                }

                // Calculate expected result using naive matrix multiplication
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        for (int k = 0; k < 10; k++)
                        {
                            result[i, j] += a[i, k] * b[k, j];
                        }
                    }
                }

                int[,] exp = Class1.multiply(a, b, result);
                CollectionAssert.AreEqual(exp, result);
            }



            //RandomizedQuickSoLoTest
            [TestMethod]
            public void RandomizedQuickSoLoTest1()
            {
                int[] array = { 7, 3, 1, 5, 8, 0, 4 };
                int n = array.Length - 1;
                int[] expected = { 0, 1, 3, 4, 5, 7, 8 };

                Class1.QuickSoLo(array, 0, n);
                CollectionAssert.AreEqual(array, expected);
            }

            [TestMethod]
            public void RandomizedQuickSoLoTest2()
            {
                int[] array = { 54, 32, 87, 21, 44, 94, 18 };
                int n = array.Length - 1;
                int[] expected = { 18, 21, 32, 44, 54, 87, 94 };

                Class1.QuickSoLo(array, 0, n);
                CollectionAssert.AreEqual(array, expected);
            }

            [TestMethod]
            public void RandomizedQuickSoLoTest3()
            {
                int[] array = { 482, 135, 742, 354, 920, 640, 201 };
                int n = array.Length - 1;
                int[] expected = { 135, 201, 354, 482, 640, 742, 920 };

                Class1.QuickSoLo(array, 0, n);
                CollectionAssert.AreEqual(array, expected);
            }

            //RandomizedQuickSoHoTest
            [TestMethod]
            public void RandomizedQuickSoHoTest1()
            {
                int[] array = { 5, 1, 7, 0, 8, 9, 2, 4 };
                int n = array.Length;
                int[] expected = { 0, 1, 2, 4, 5, 7, 8, 9 };

                Class1.randomQuicksortHoare(array, 0, n - 1);
                CollectionAssert.AreEqual(array, expected);
            }

            [TestMethod]
            public void RandomizedQuickSoHoTest2()
            {
                int[] array = { 48, 75, 14, 91, 58, 61, 25 };
                int n = array.Length;
                int[] expected = { 14, 25, 48, 58, 61, 75, 91 };

                Class1.randomQuicksortHoare(array, 0, n - 1);
                CollectionAssert.AreEqual(array, expected);
            }

            [TestMethod]
            public void RandomizedQuickSoHoTest3()
            {
                int[] array = { 315, 618, 431, 148, 952, 547, 796, 231 };
                int n = array.Length;
                int[] expected = { 148, 231, 315, 431, 547, 618, 796, 952 };

                Class1.randomQuicksortHoare(array, 0, n - 1);
                CollectionAssert.AreEqual(array, expected);
            }



        }
    }
