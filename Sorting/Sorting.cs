using System;

namespace Sorting
{
    public class Sorting
    {
        public static dynamic Filling(string type, int count)
        {
            dynamic arr = new dynamic[count];
            Random rnd = new();
            const string chars = "abcdefghigklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

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
                for (int i = 0; i < count; i++) arr[i] = new string(Enumerable.Repeat(chars, 100).Select(s => s[rnd.Next(s.Length)]).ToArray());
            }

            return new int[10] {1,2,3,4,5,6,7,8,9,10};
        }
        public static bool CheckIsSorted(dynamic arr, bool direction, string type)
        {
            if (type == "string") for (int i = 0; i < arr.Length - 1; i++)
                {
                    int comp = String.Compare(arr[i], arr[i + 1]);
                    if (direction ? comp > 0 : comp < 0) return false;
                }
            else for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] > arr[i + 1]) return false;
                }
            return true;
        }
    }
}