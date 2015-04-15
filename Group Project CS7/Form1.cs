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

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.UseSystemPasswordChar == true)
            {
                textBox1.UseSystemPasswordChar = false;
                button2.Text = "Hide characters";
            }
            else
            {
                textBox1.UseSystemPasswordChar = true;
                button2.Text = "Show characters";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox2.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == "Show instruction")
            {
                ClientSize = new System.Drawing.Size(322, 130);
                button4.Text = "Hide instruction";
            }
            else
            {
                ClientSize = new System.Drawing.Size(322, 85);
                button4.Text = "Show instruction";
            }
        }
    }
}
