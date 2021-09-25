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

namespace App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            saveFileDialog1.Filter = "Text files|*.txt";
            openFileDialog1.Filter = "Text files| *.txt";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            listBox1.Items.Add(textBox2.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter stream = new
                StreamWriter(saveFileDialog1.FileName);
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    stream.WriteLine(listBox1.Items[i]);
                }
                stream.Close();
            }
            }

        private void button4_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader s = new
                    StreamReader(openFileDialog1.FileName);
                while(s.EndOfStream)
                {
                    listBox1.Items.Add(s.ReadLine());
                }
                s.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
    }

