using static Sorter.Sorting;

namespace TestProgram
{
    public class Program
    {
        public static void Main()
        {
            dynamic[] arr = Filling("string", 10);
            Console.WriteLine(string.Join(" ", arr));
            Console.WriteLine();
            SortStack(arr);
            Console.WriteLine(string.Join(" ", arr));
            Console.WriteLine(CheckIsSorted(arr, true, "string"));
        }   
    }
}
