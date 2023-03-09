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
                MessageBox.Show("������� ������ ���-�� ���������");
            }
            switch (BoxType.Text)
            {
                case "������":
                    type = "string";
                    break;
                case "����� �����":
                    type = "int";
                    break;
                case "����� � ��������� ������":
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
                MessageBox.Show("������������ ������");
                return;
            }
            string type = checkType();
            bool direction = true;
            switch (SortDirectionBox.Text)
            {
                case "�� ��������":
                    direction = false;
                    break;
                case "�� �����������":
                    direction = true;
                    break;
            }
            switch (BoxSort.Text)
            {
                case "�����������":
                    BubbleSort(arr,direction,type);
                    richTextBox1.Text = string.Join("\n", arr);
                    break;
                case "���������":
                    InsertionSort(arr, direction, type);
                    richTextBox1.Text = string.Join("\n", arr);
                    break;
                case "��������":
                    MergeSort(arr,0,arr.Length-1, direction, type);
                    richTextBox1.Text = string.Join("\n", arr);
                    break;
                case "�������":
                    QuickSort(arr, 0, arr.Length - 1, direction, type);
                    richTextBox1.Text = string.Join("\n", arr);
                    break;
                case "�������������":
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
                MessageBox.Show("������������ ������");
                return;
            }
            bool direction = true;
            switch (CheckSortDirectionBox.Text)
            {
                case "�� ��������":
                    direction = false;
                    break;
                case "�� �����������":
                    direction = true;
                    break;
            }
            string type = checkType();
            MessageBox.Show(CheckIsSorted(arr,direction,type).ToString());
        }
    }
}