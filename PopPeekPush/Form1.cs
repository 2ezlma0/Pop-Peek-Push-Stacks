using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PopPeekPush
{
    public partial class Form1 : Form
    {
        public int[] intArray = new int[10];
        public int i, pointer;
        public string arrayLabelString, outputString;


        public Form1()
        {
            InitializeComponent();
            pointer = -1;
            ArrayLabelUpdate();
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
                MessageBox.Show("Number outputted is: " + outputString + "\nPointer moved down");
                ArrayLabelUpdate();
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
    }
}
