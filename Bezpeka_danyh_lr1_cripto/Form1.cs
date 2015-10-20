using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bezpeka_danyh_lr1_cripto
{
    public partial class Form1 : Form
    {
        protected string toScript;
        protected string fromScript;
        public Form1()
        {
            InitializeComponent();
            toScript = "";
            fromScript = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tmp1 = "";
            toScript = textBox1.Text;
            fromScript = "";

            for (int i = 0; i < toScript.Length; i++)
            {
                tmp1 += toScript[toScript.Length - i - 1];
                fromScript += (char)(tmp1[i] + 8);
            }

            textBox3.Text = "";
            textBox3.Text = fromScript;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string result = "";
            string tmp = "";

            for (int i = 0; i < textBox2.Text.Length; i++)
                tmp += (char)(textBox2.Text[i] - 8);

            for (int i = 0; i < tmp.Length; i++)
                result += tmp[tmp.Length - i - 1];

            textBox4.Text = "";
            textBox4.Text = result;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
                button1.Enabled = true;
            else
                button1.Enabled = false;
            textBox3.Clear();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text.Length != 0)
                button2.Enabled = true;
            else
                button2.Enabled = false;
            textBox4.Clear();
        }
    }
}
