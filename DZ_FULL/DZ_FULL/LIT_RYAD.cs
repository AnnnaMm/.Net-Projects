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
    public partial class LIT_RYAD : Form
    {
        public LIT_RYAD()
        {
            InitializeComponent();
           
        }
        

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            label1.Text = index.ToString();
            textBox1.Text = index.ToString();
            comboBox1.SelectedIndex = index;
            this.Text = index.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index1 = comboBox1.SelectedIndex;
            label1.Text = index1.ToString();
            textBox1.Text = index1.ToString();
            listBox1.SelectedIndex = index1;
            this.Text = index1.ToString();
        }

        private void LIT_RYAD_Load(object sender, EventArgs e)
        {

        }
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LIT_RYAD_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}