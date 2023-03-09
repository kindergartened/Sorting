using Microsoft.VisualBasic;
using static Sorter.Sorting;

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
            string type = checkType();
            bool direction = true;
            switch (SortDirectionBox.Text)
            {
                case "По убыванию":
                    direction = false;
                    break;
                case "По возрастанию":
                    direction = true;
                    break;
            }
            switch (BoxSort.Text)
            {
                case "Пузырьковая":
                    BubbleSort(arr,direction,type);
                    richTextBox1.Text = string.Join("\n", arr);
                    break;
                case "Вставками":
                    InsertionSort(arr, direction, type);
                    richTextBox1.Text = string.Join("\n", arr);
                    break;
                case "Слиянием":
                    MergeSort(arr,0,arr.Length-1, direction, type);
                    richTextBox1.Text = string.Join("\n", arr);
                    break;
                case "Быстрая":
                    QuickSort(arr, 0, arr.Length - 1, direction, type);
                    richTextBox1.Text = string.Join("\n", arr);
                    break;
                case "Пирамидальная":
                    HeapSort(arr, arr.Length, direction, type);
                    richTextBox1.Text = string.Join("\n", arr);
                    break;
            }
        }
  
        private string checkType()
        {
            string type = "";
            switch (arr[0].GetType().ToString())
            {
                case "System.String":
                    type = "string";
                    break;
                case "System.Int32":
                    type = "int";
                    break;
                case "System.Double":
                    type = "double";
                    break;
            }
            return type;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (arr == null)
            {
                MessageBox.Show("Сгенерируйте массив");
                return;
            }
            bool direction = true;
            switch (CheckSortDirectionBox.Text)
            {
                case "По убыванию":
                    direction = false;
                    break;
                case "По возрастанию":
                    direction = true;
                    break;
            }
            string type = checkType();
            MessageBox.Show(CheckIsSorted(arr,direction,type).ToString());
        }
    }
}