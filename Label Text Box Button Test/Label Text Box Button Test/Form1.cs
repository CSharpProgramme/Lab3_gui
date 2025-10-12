using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Label_Text_Box_Button_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //display user input in label
        private void displayPasswordButton_Click(object sender, EventArgs e)
        {
            //display the text that the user typed
            displayPasswordLabel.Text = inputPasswordTextBox.Text;
        }
    }
}
