using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba_S4
{
    public partial class Form2 : Form
    {
        Logic.Logic logic = new Logic.Logic();

        public Form2()
        {

            InitializeComponent();



            richTextBox1.Text = "";
            richTextBox2.Text = "";
            richTextBox3.Text = "";
            richTextBox4.Text = "";

            string[][] strings = logic.GetFileStrings();

            foreach (string str in strings[0])
            {
                richTextBox1.Text += $"{str}\n";
            }

            foreach (string str in strings[1])
            {
                richTextBox2.Text += $"{str}\n";
            }

            foreach (string str in strings[2])
            {
                richTextBox3.Text += $"{str}\n";
            }

            foreach (string str in strings[3])
            {
                richTextBox4.Text += $"{str}\n";
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            logic.Save([
                richTextBox1.Text.Split('\n'),
                richTextBox2.Text.Split('\n'),
                richTextBox3.Text.Split('\n'),
                richTextBox4.Text.Split('\n')
                ]);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
