using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp131
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string[] s = new string[] { textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text };
            System.Windows.Forms.OpenFileDialog op = new OpenFileDialog();
            op.Filter = "text files (*.txt)|*.txt|All files (*.*)|*.*";
            op.ShowDialog();
            System.IO.StreamWriter w = new System.IO.StreamWriter(op.FileName, true);
            w.WriteLine(string.Join(";", s));
            w.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.IO.StreamReader reader = new System.IO.StreamReader(textBox5.Text);
            while (reader.Peek() != -1)
            {
                string s = reader.ReadLine();
                string[] temp = s.Split(';');
                listBox1.Items.Add(temp[0]);
                listBox1.Items.Add(temp[1]);
                listBox1.Items.Add(temp[2]);
                listBox1.Items.Add(temp[3]);

            }
            reader.Close();
        }
    }
}
