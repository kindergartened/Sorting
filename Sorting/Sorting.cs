using System;

namespace Sorter
{
    public static class Sorting
    {
        public static dynamic[] Filling(string type, int count)
        {
            dynamic[] arr = new dynamic[count];
            Random rnd = new();
            // const string chars = " abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            const string chars = "ABC"; // Легко проверить сортировку

            if (type == "int")
            {
                for (int i = 0; i < count; i++) arr[i] = rnd.Next(-1000, 1000);
            }
            else if (type == "double")
            {
                for (int i = 0; i < count; i++) arr[i] = (double)rnd.Next(-100000, 100000) / 100;
            }
            else
            {
                for (int i = 0; i < count; i++) arr[i] = new string(Enumerable.Repeat(chars, 2).Select(s => s[rnd.Next(s.Length)]).ToArray());
            }

            return arr;
        }
        public static bool CheckIsSorted(dynamic arr, bool direction, string type)
        {
            for (int i = 0; i < arr.Length - 1; i++)
                if (type == "string" ? direction ? string.Compare(arr[i], arr[i + 1]) > 0 : string.Compare(arr[i], arr[i + 1]) < 0 : direction ? arr[i] > arr[i + 1] : arr[i] < arr[i + 1]) 
                    return false;
            
            return true;
        }
        public static dynamic[] BubbleSort(dynamic[] arr, bool direction, string type)
        {
            for (int i = 0; i < arr.Length; i++)
                for (int j = 0; j < arr.Length; j++)
                    if (type == "string" ? IsAlphabeticallySmaller(arr[j], arr[i], direction) : direction ? arr[i] < arr[j] : arr[i] > arr[j]) Swap(ref arr[i], ref arr[j]);
            
            return arr;
        }
        public static dynamic[] InsertionSort(dynamic[] arr, bool direction, string type)
        {
            dynamic x;
            dynamic j;
            for (int i = 1; i < arr.Length; i++)
            {
                x = arr[i];
                j = i;
                while (type == "string" ? j > 0 && IsAlphabeticallySmaller(arr[j - 1], x, direction) : direction ? j > 0 && arr[j - 1] > x : j > 0 && arr[j - 1] < x)
                    Swap(ref arr[j], ref arr[--j]);
                arr[j] = x;
            }
            return arr;
        }
        static void Merge(dynamic[] a, int l, int m, int r, bool direction, string type)
        {
            int i, j, k;

            int n1 = m - l + 1;
            int n2 = r - m;

            dynamic[] left = new dynamic[n1 + 1];
            dynamic[] right = new dynamic[n2 + 1];

            for (i = 0; i < n1; i++)
            {
                left[i] = a[l + i];
            }

            for (j = 1; j <= n2; j++)
            {
                right[j - 1] = a[m + j];
            }

            left[n1] = direction ? type == "string" ? string.Join("", Enumerable.Repeat("ZZ", 100).ToArray()) : int.MaxValue : type == "string" ? "" : int.MinValue;
            right[n2] = direction ? type == "string" ? string.Join("", Enumerable.Repeat("ZZ", 100).ToArray()) : int.MaxValue : type == "string" ? "" : int.MinValue;

            i = 0;
            j = 0;

            for (k = l; k <= r; k++)
            {
                if (type == "string" ? !IsAlphabeticallySmaller(left[i], right[j], direction) : direction ? left[i] < right[j] : left[i] > right[j])
                {
                    a[k] = left[i];
                    i++;
                }
                else
                {
                    a[k] = right[j];
                    j++;
                }
            }
        }
        public static dynamic[] MergeSort(dynamic[] a, int l, int r, bool direction, string type)
        {
            int q;

            if (l < r)
            {
                q = (l + r) / 2;
                MergeSort(a, l, q, direction, type);
                MergeSort(a, q + 1, r, direction, type);
                Merge(a, l, q, r, direction, type);
            }
            return a;
        }
        static int Partition(dynamic[] array, int minIndex, int maxIndex, bool direction, string type)
        {
            var pivot = minIndex - 1;
            for (var i = minIndex; i < maxIndex; i++)
            {
                if (type == "string" ? IsAlphabeticallySmaller(array[maxIndex], array[i], direction) : direction ? array[i] < array[maxIndex] : array[i] > array[maxIndex])
                    Swap(ref array[++pivot], ref array[i]);
            }

            pivot++;
            Swap(ref array[pivot], ref array[maxIndex]);
            return pivot;
        }

        public static dynamic[] QuickSort(dynamic[] array, int minIndex, int maxIndex, bool direction, string type)
        {
            if (minIndex >= maxIndex)
            {
                return array;
            }

            var pivotIndex = Partition(array, minIndex, maxIndex, direction, type);
            QuickSort(array, minIndex, pivotIndex - 1, direction, type);
            QuickSort(array, pivotIndex + 1, maxIndex, direction, type);

            return array;
        }
        public static dynamic[] HeapSort(dynamic[] arr, int n, bool direction, string type)
        {
            for (int i = n / 2 - 1; i >= 0; i--)
                Heapify(arr, n, i, direction, type);
            for (int i = n - 1; i >= 0; i--)
            {
                Swap(ref arr[i], ref arr[0]);
                Heapify(arr, i, 0, direction, type);
            }
            return arr;
        }
        static void Heapify(dynamic[] arr, int n, int i, bool direction, string type)
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;
            if (type == "string" ? left < n && IsAlphabeticallySmaller(arr[left], arr[largest], direction) : direction ? left < n && arr[left] > arr[largest] : left < n && arr[left] < arr[largest])
                largest = left;
            if (type == "string" ? right < n && IsAlphabeticallySmaller(arr[right], arr[largest], direction) : direction ? right < n && arr[right] > arr[largest] : right < n && arr[right] < arr[largest])
                largest = right;
            if (largest != i)
            {
                Swap(ref arr[i], ref arr[largest]);
                Heapify(arr, n, largest, direction, type);
            }
        }
        static void SortCompareAndPush(Stack<dynamic> stack, ref dynamic item)
        {
            if (stack.Count > 0)
            {    // if(!stack.IsEmpty) {
                do
                {
                    var next_item = stack.Pop();
                    if (item.CompareTo(next_item) == 1)
                    {   // if(item > next_item) {
                        (item, next_item) = (next_item, item);
                    }
                    SortCompareAndPush(stack, ref next_item);
                } while (item.CompareTo(stack.Peek()) == 1);  // } while(item > stack.Top);
            }
            stack.Push(item);
        }

        public static dynamic[] SortStack(dynamic[] arr)
        {
            Stack<dynamic> stack = new(arr);
            if (stack.Count > 1)
            {     // if(!stack.IsEmpty) {
                dynamic item = stack.Pop();
                SortCompareAndPush(stack, ref item);
            }
            return arr.ToArray();
        }
        static bool IsAlphabeticallySmaller(string str1, string str2, bool direction)
        {
            str1 = str1.ToUpper();
            str2 = str2.ToUpper();
            if (string.Compare(str1, str2) < 0)
            {
                return direction ? false : true;
            }
            return direction ? true : false;
        }
        public static void Swap(ref dynamic a, ref dynamic b)
        {
            (b, a) = (a, b);
        }
    }
}