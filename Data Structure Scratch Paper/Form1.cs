using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Data_Structure_Scratch_Paper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Array_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            int[] lotterry_numbers;
            lotterry_numbers = new int[100];

            for (int i = 0; i != lotterry_numbers.Length; i++)
            {
                lotterry_numbers[i] = i + 1;
                listBox1.Items.Add(lotterry_numbers[i]);
            }
        }

        private void SetArray_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int aNumber = int.Parse(textBox1.Text);

            int[] arraySize; arraySize = new int[aNumber];

            for (int i = 0; i != arraySize.Length; i++)
            {
                arraySize[i] = i + 1;
                listBox1.Items.Add(arraySize[i]);
            }

        }

        private void Exercise_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            int[] times;
            times = new int[10];

            int Times = int.Parse(textBox1.Text);

            for (int i = 0; i != (times.Length); i++)
            {
                times[i] = (i+1) * Times;
                listBox1.Items.Add(Times + " times " + (i+1) + " = " + times[i]);
            }
        }

        private void Multi_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            int arrayRows = 5;
            int arrayCols = 3;

            int[,] arrayTimes;
            arrayTimes = new int[arrayRows, arrayCols];

            int multi = 0;

            for (int i = 0; i != arrayRows; i++)
            {
                multi = multi + 10;

                for (int j = 0; j != arrayCols; j++)
                {
                    arrayTimes[i, j] = multi;
                    multi = multi * 10;
                }
                multi = multi / 100;
            }
        }
        private void Queue_Click(object sender, EventArgs e)
        {
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("1"); queue.Enqueue("2");
            queue.Enqueue("3");

            while (queue.Count > 0)
            {
                MessageBox.Show(queue.Dequeue());
            }
        }

        private void Stack_Click(object sender, EventArgs e)
        {
            Stack<string> stack1 = new Stack<string>();
            stack1.Push("1"); stack1.Push("2");
            stack1.Push("3");

            while (stack1.Count > 0)
            {
                MessageBox.Show(stack1.Pop());
            }
        }
    }
}