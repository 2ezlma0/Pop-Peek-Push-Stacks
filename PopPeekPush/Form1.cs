using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PopPeekPush
{
    public partial class Form1 : Form
    {
        public int[] intArray = new int[10];
        public int i, pointer, rnd;
        public string arrayLabelString, arrayString, outputString, pathDoc, path;

        public Form1()
        {
            InitializeComponent();
            pointer = -1;
            ArrayLabelUpdate();
            pathDoc = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        }

        private void popButton_Click(object sender, EventArgs e)
        {
            POP();
        }

        private void peekButton_Click(object sender, EventArgs e)
        {
            PEEK();
        }

        private void pushButton_Click(object sender, EventArgs e)
        {
            PUSH();
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            EXPORT();
        }

        private void arrayLabel_Click(object sender, EventArgs e)
        {

        }

        private void ArrayLabelUpdate()
        {
            i = 0;
            if (Convert.ToString(arrayLabel.Text).Length > 18)
            {
                arrayLabel.Text = "intArray contains: ";
            }

            for (i = 0; i < intArray.Length; i++)
            {
                arrayLabelString = Convert.ToString(intArray[i]);
                if(intArray[i] == 0)
                {
                    arrayLabelString = "null";
                }

                if (i == pointer)
                {
                    arrayLabel.Text += "(" + arrayLabelString + ")";
                }
                else
                {
                    arrayLabel.Text += arrayLabelString;
                }

                if (i + 1 != intArray.Length)
                {
                    arrayLabel.Text += ", ";
                }
            }
        }

        private void POP()
        {           
            if (pointer > -1)
            {
                outputString = Convert.ToString(intArray[pointer]);
                pointer--;
                if (pointer == -1)
                {
                    pointer++;
                    MessageBox.Show("Pointer cannot move down, number outputted is: " + outputString);
                }
                else
                {
                    MessageBox.Show("Number outputted is: " + outputString + "\nPointer moved down");
                    ArrayLabelUpdate();
                }
            }
            else
            {
                MessageBox.Show("Stack is empty!");
            }
        }

        private void PEEK()
        {
            if (pointer > -1)
            {
                outputString = Convert.ToString(intArray[pointer]);
                MessageBox.Show("Number outputted is: " + outputString);
            }
            else
            {
                MessageBox.Show("Stack empty!");
            }
        }

        private void PUSH()
        {
            if (pointer < 9)
            {
                int num = Convert.ToInt32(pushNum.Value);
                pointer++;
                intArray[pointer] = num;
                ArrayLabelUpdate();
                outputString = Convert.ToString(intArray[pointer]);
                MessageBox.Show("Number pushed and outputted is: " + outputString);
            }
            else
            {
                MessageBox.Show("Stack is full!");
            }
        }

        private void EXPORT()
        {
            var rand = new Random();
            rnd = rand.Next();
            path = Path.Combine(pathDoc, "array" + rnd + ".txt");

            for (i = 0; i < intArray.Length; i++)
            {
                arrayString += Convert.ToString(intArray[i]) + ", ";
            }

            File.WriteAllText(path, arrayString);
            MessageBox.Show("Exported to " + path);
        }
    }
}
