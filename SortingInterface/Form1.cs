using Microsoft.VisualBasic;
using static Sorter.Sorting;
using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace SortingInterface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static dynamic[] arr;
        private void button2_Click(object sender, EventArgs e)
        {
            string type = "";
            dynamic count = 0;
            try
            {
                count = int.Parse(CountBox.Text);
            }
            catch
            {
                MessageBox.Show("Неверно задано кол-во элементов");
            }
            switch (BoxType.Text)
            {
                case "Строки":
                    type = "string";
                    break;
                case "Целые числа":
                    type = "int";
                    break;
                case "Числа с плавающей точкой":
                    type = "double";
                    break;
            }
            arr = Filling(type, count);
            richTextBox1.Text = String.Join("\n", arr);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (arr == null)
            {
                MessageBox.Show("Сгенерируйте массив");
                return;
            }
            string type = checkType() ?? "";
            Stopwatch stopWatch = new Stopwatch();
            bool direction = checkDirection(SortDirectionBox.Text) ?? true;
            switch (BoxSort.Text)
            {
                case "Пузырьковая":
                    stopWatch = Stopwatch.StartNew();
                    BubbleSort(arr,direction,type);
                    stopWatch.Stop();

                    timer.Text = stopWatch.ElapsedMilliseconds.ToString();
                    richTextBox1.Text = string.Join("\n", arr);
                    break;
                case "Вставками":
                    stopWatch = Stopwatch.StartNew();
                    InsertionSort(arr, direction, type);
                    stopWatch.Stop();

                    timer.Text = stopWatch.ElapsedMilliseconds.ToString();
                    richTextBox1.Text = string.Join("\n", arr);
                    break;
                case "Слиянием":
                    stopWatch = Stopwatch.StartNew();
                    MergeSort(arr,0,arr.Length-1, direction, type);
                    stopWatch.Stop();

                    timer.Text = stopWatch.ElapsedMilliseconds.ToString();
                    richTextBox1.Text = string.Join("\n", arr);
                    break;
                case "Быстрая":
                    stopWatch = Stopwatch.StartNew();
                    QuickSort(arr, 0, arr.Length - 1, direction, type);
                    stopWatch.Stop();

                    timer.Text = stopWatch.ElapsedMilliseconds.ToString();
                    richTextBox1.Text = string.Join("\n", arr);
                    break;
                case "Пирамидальная":
                    stopWatch = Stopwatch.StartNew();
                    HeapSort(arr, arr.Length, direction, type);
                    stopWatch.Stop();

                    timer.Text = stopWatch.ElapsedMilliseconds.ToString();
                    richTextBox1.Text = string.Join("\n", arr);
                    break;
            }
        }
        private bool? checkDirection(string box)
        {
            switch (box)
            {
                case "По убыванию":
                    return false;
                case "По возрастанию":
                    return true;
            }
            return null;
        }
  
        private string? checkType()
        {
            switch (arr[0].GetType().ToString())
            {
                case "System.String":
                    return "string";
                case "System.Int32":
                    return "int";
                case "System.Double":
                    return "double";
            }
            return null;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (arr == null)
            {
                MessageBox.Show("Сгенерируйте массив");
                return;
            }
            bool direction = checkDirection(CheckSortDirectionBox.Text) ?? true;
            string type = checkType() ?? "";
            MessageBox.Show(CheckIsSorted(arr,direction,type).ToString());
        }
    }
}