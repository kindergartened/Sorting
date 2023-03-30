namespace SorterTest
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TestBubbleSort()
        {
            for (int i = 0; i < 100; i++)
            {
                dynamic[] actual = Filling("int", 100);
                dynamic[] expected = actual.Clone() as dynamic[];
                BubbleSort(actual, true, "int");
                Array.Sort(expected);
                CollectionAssert.AreEqual(expected, actual);
            }

            for (int i = 0; i < 100; i++)
            {
                dynamic[] actual = Filling("string", 100);
                dynamic[] expected = actual.Clone() as dynamic[];
                BubbleSort(actual, true, "string");
                Array.Sort(expected);
                CollectionAssert.AreEqual(expected, actual);
            }

            for (int i = 0; i < 100; i++)
            {
                dynamic[] actual = Filling("int", 100);
                dynamic[] expected = actual.Clone() as dynamic[];
                BubbleSort(actual, false, "int");
                Array.Sort(expected);
                Array.Reverse(expected);
                CollectionAssert.AreEqual(expected, actual);
            }

            for (int i = 0; i < 100; i++)
            {
                dynamic[] actual = Filling("string", 100);
                dynamic[] expected = actual.Clone() as dynamic[];
                BubbleSort(actual, false, "string");
                Array.Sort(expected);
                Array.Reverse(expected);
                CollectionAssert.AreEqual(expected, actual);
            }
        }
        [TestMethod]
        public void TestInsertionSort()
        {
            for (int i = 0; i < 100; i++)
            {
                dynamic[] actual = Filling("int", 100);
                dynamic[] expected = actual.Clone() as dynamic[];
                InsertionSort(actual, true, "int");
                Array.Sort(expected);
                CollectionAssert.AreEqual(expected, actual);
            }

            for (int i = 0; i < 100; i++)
            {
                dynamic[] actual = Filling("string", 100);
                dynamic[] expected = actual.Clone() as dynamic[];
                InsertionSort(actual, true, "string");
                Array.Sort(expected);
                CollectionAssert.AreEqual(expected, actual);
            }

            for (int i = 0; i < 100; i++)
            {
                dynamic[] actual = Filling("int", 100);
                dynamic[] expected = actual.Clone() as dynamic[];
                InsertionSort(actual, false, "int");
                Array.Sort(expected);
                Array.Reverse(expected);
                CollectionAssert.AreEqual(expected, actual);
            }

            for (int i = 0; i < 100; i++)
            {
                dynamic[] actual = Filling("string", 100);
                dynamic[] expected = actual.Clone() as dynamic[];
                InsertionSort(actual, false, "string");
                Array.Sort(expected);
                Array.Reverse(expected);
                CollectionAssert.AreEqual(expected, actual);
            }
        }
        [TestMethod]
        public void TestMergeSort()
        {
            for (int i = 0; i < 100; i++)
            {
                dynamic[] actual = Filling("int", 100);
                dynamic[] expected = actual.Clone() as dynamic[];
                MergeSort(actual, 0, actual.Length - 1, true, "int");
                Array.Sort(expected);
                CollectionAssert.AreEqual(expected, actual);
            }

            for (int i = 0; i < 100; i++)
            {
                dynamic[] actual = Filling("string", 100);
                dynamic[] expected = actual.Clone() as dynamic[];
                MergeSort(actual, 0, actual.Length - 1, true, "string");
                Array.Sort(expected);
                CollectionAssert.AreEqual(expected, actual);
            }

            for (int i = 0; i < 100; i++)
            {
                dynamic[] actual = Filling("int", 100);
                dynamic[] expected = actual.Clone() as dynamic[];
                MergeSort(actual, 0, actual.Length - 1, false, "int");
                Array.Sort(expected);
                Array.Reverse(expected);
                CollectionAssert.AreEqual(expected, actual);
            }

            for (int i = 0; i < 100; i++)
            {
                dynamic[] actual = Filling("string", 100);
                dynamic[] expected = actual.Clone() as dynamic[];
                MergeSort(actual, 0, actual.Length - 1, false, "string");
                Array.Sort(expected);
                Array.Reverse(expected);
                CollectionAssert.AreEqual(expected, actual);
            }
        }
        [TestMethod]
        public void TestQuickSort()
        {
            for (int i = 0; i < 100; i++)
            {
                dynamic[] actual = Filling("int", 100);
                dynamic[] expected = actual.Clone() as dynamic[];
                QuickSort(actual, 0, actual.Length - 1, true, "int");
                Array.Sort(expected);
                CollectionAssert.AreEqual(expected, actual);
            }

            for (int i = 0; i < 100; i++)
            {
                dynamic[] actual = Filling("string", 100);
                dynamic[] expected = actual.Clone() as dynamic[];
                QuickSort(actual, 0, actual.Length - 1, true, "string");
                Array.Sort(expected);
                CollectionAssert.AreEqual(expected, actual);
            }

            for (int i = 0; i < 100; i++)
            {
                dynamic[] actual = Filling("int", 100);
                dynamic[] expected = actual.Clone() as dynamic[];
                QuickSort(actual, 0, actual.Length - 1, false, "int");
                Array.Sort(expected);
                Array.Reverse(expected);
                CollectionAssert.AreEqual(expected, actual);
            }

            for (int i = 0; i < 100; i++)
            {
                dynamic[] actual = Filling("string", 100);
                dynamic[] expected = actual.Clone() as dynamic[];
                QuickSort(actual, 0, actual.Length - 1, false, "string");
                Array.Sort(expected);
                Array.Reverse(expected);
                CollectionAssert.AreEqual(expected, actual);
            }
        }
        [TestMethod]
        public void TestHeapSort()
        {
            for (int i = 0; i < 100; i++)
            {
                dynamic[] actual = Filling("int", 100);
                dynamic[] expected = actual.Clone() as dynamic[];
                HeapSort(actual, actual.Length, true, "int");
                Array.Sort(expected);
                CollectionAssert.AreEqual(expected, actual);
            }

            for (int i = 0; i < 100; i++)
            {
                dynamic[] actual = Filling("string", 100);
                dynamic[] expected = actual.Clone() as dynamic[];
                HeapSort(actual,actual.Length, true, "string");
                Array.Sort(expected);
                CollectionAssert.AreEqual(expected, actual);
            }

            for (int i = 0; i < 100; i++)
            {
                dynamic[] actual = Filling("int", 100);
                dynamic[] expected = actual.Clone() as dynamic[];
                HeapSort(actual, actual.Length, false, "int");
                Array.Sort(expected);
                Array.Reverse(expected);
                CollectionAssert.AreEqual(expected, actual);
            }

            for (int i = 0; i < 100; i++)
            {
                dynamic[] actual = Filling("string", 100);
                dynamic[] expected = actual.Clone() as dynamic[];
                HeapSort(actual, actual.Length, false, "string");
                Array.Sort(expected);
                Array.Reverse(expected);
                CollectionAssert.AreEqual(expected, actual);
            }
        }
    }
}