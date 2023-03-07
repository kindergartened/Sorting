namespace SorterTest
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TestBubbleSort()
        {
            for (int i = 0; i < 10; i++)
            {
                dynamic[] actual = Filling("int", 10);
                dynamic[] expected = actual.Clone() as dynamic[];
                BubbleSort(actual, true, "int");
                Array.Sort(expected);
                CollectionAssert.AreEqual(expected, actual);
            }

            for (int i = 0; i < 10; i++)
            {
                dynamic[] actual = Filling("string", 10);
                dynamic[] expected = actual.Clone() as dynamic[];
                BubbleSort(actual, true, "string");
                Array.Sort(expected);
                CollectionAssert.AreEqual(expected, actual);
            }

            for (int i = 0; i < 10; i++)
            {
                dynamic[] actual = Filling("int", 10);
                dynamic[] expected = actual.Clone() as dynamic[];
                BubbleSort(actual, false, "int");
                Array.Sort(expected);
                Array.Reverse(expected);
                CollectionAssert.AreEqual(expected, actual);
            }

            for (int i = 0; i < 10; i++)
            {
                dynamic[] actual = Filling("string", 10);
                dynamic[] expected = actual.Clone() as dynamic[];
                BubbleSort(actual, false, "string");
                Array.Sort(expected);
                Array.Reverse(expected);
                CollectionAssert.AreEqual(expected, actual);
            }
        }
    }
}