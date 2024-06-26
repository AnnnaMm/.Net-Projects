using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DZ_FULL
{
    public partial class MLTPL : Form
    {
        public MLTPL()
        {
            InitializeComponent();
        }

        private void MLTPL_Load(object sender, EventArgs e)
        {

        }
        string s;
        double a;
        double b;
        double c;
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            DialogResult dialog = MessageBox.Show(
             "Зараз вікно буде закрите; чи дійсно потрібно це робити?",
             "Завершення програми",
             MessageBoxButtons.YesNo,
             MessageBoxIcon.Warning
            );
            if (dialog == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            try
            {
                s = textBox1.Text;
                a = Convert.ToDouble(s);
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Введіть цифру!");
                textBox1.Clear();
            }
            //textBox1.Clear();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
            try
            {
                s = textBox2.Text;
                b = Convert.ToDouble(s);
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Введіть цифру!");
                textBox2.Clear();
            }
            //textBox1.Clear();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            c = a * b;
            textBox3.Text = Convert.ToString(c);
            label5.Text = Convert.ToString(c);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
