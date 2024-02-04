using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_Cast_Int
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal myDecimalValue = 10;
            int myIntValue = (int)myDecimalValue;
            MessageBox.Show("The myIntValue is: " + myIntValue);
            int myInt = 10;
            byte myByte = (byte)myInt;
            double myDouble = (double)myByte;
            //bool myBool = (bool)myDouble;
            string myString = "false";
            //bool myBool = (bool)myString;
            //myString = (string)myInt;
            myString = myInt.ToString();
            //bool myBool = (bool)myByte;
            bool myBool = false;
            //myByte = (byte)myBool;
            short myShort = (short)myInt;
            char myChar = 'x';
            //myString = (string)myChar;
            long myLong = (long)myInt;
            decimal myDecimal = (decimal)myLong;
            myString = myString + myInt + myByte + myDouble + myChar;
            MessageBox.Show(myString);






        }
    }
}
