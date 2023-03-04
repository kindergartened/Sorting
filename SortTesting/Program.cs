using static Sorting.Sorting;

namespace TestProgram
{
    public class Program
    {
        public static void Main()
        {
            int[] arr = Sorting.Sorting.Filling("string", 10);
            Console.WriteLine(Sorting.Sorting.CheckIsSorted(arr, true, "int"));
        }   
    }
}
