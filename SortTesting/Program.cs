using static Array.Sorting;

namespace TestProgram
{
    public class Program
    {
        public static void Main()
        {
            dynamic[] arr = Array.Sorting.Filling("string", 10);
            Array.Sorting.HeapSort(arr, arr.Length, true, "string");
            Console.WriteLine(String.Join("\n", arr));
            Console.WriteLine(Array.Sorting.CheckIsSorted(arr, true, "string"));
        }   
    }
}
