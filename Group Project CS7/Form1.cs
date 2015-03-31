using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group_Project_CS7
{
    public partial class Form1 : Form
    {
        Algorithm encrypt = new Algorithm();
        string userInput = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            userInput = textBox1.Text;                                  //any chances to the text box changes the value of the userInput variable. 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = encrypt.Encryptor(userInput);              //when the button is pressed, it runs the encryption 
        }

    }
}
