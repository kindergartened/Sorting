using static Sorter.Sorting;

namespace TestProgram
{
    public class Program
    {
        public static void Main()
        {
            dynamic[] arr = Sorter.Sorting.Filling("int", 10);
            Sorter.Sorting.BubbleSort(arr, true, "int");
            Console.WriteLine(String.Join("\n", arr));
            Console.WriteLine(Sorter.Sorting.CheckIsSorted(arr, true, "int"));
        }   
    }
}
