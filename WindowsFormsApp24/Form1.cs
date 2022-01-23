using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            /*Na vstupu je řetězec slov, slova jsou oddělena jednou mezerou. Button1 - určete
            počet slov v řetězci.
            Na vstupu je řetězec slov, slova jsou oddělena jednou nebo více mezerami. Button2 -
            určete počet slov v řetězci.*/
        }
           private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            if (text == String.Empty) { MessageBox.Show("TextBox je prázdný"); return; }
            MessageBox.Show("Počet slov: "+(text.Split(' ').Count()).ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            if (text == String.Empty) { MessageBox.Show("TextBox je prázdný"); return; }
            text = Regex.Replace(text, @"\s+", " ");
            MessageBox.Show("Počet slov: " + (text.Split(' ').Count()).ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string text = textBox1.Text;
            if (text == String.Empty) { MessageBox.Show("TextBox je prázdný"); return; }
            string text2 = Regex.Replace(text, @"\s+", " ");
            string[] sub = text2.Split(' ');
            foreach (string str in sub) {if (str.Any(c => char.IsDigit(c))) { listBox1.Items.Add(str); } }
        }
    }
}
