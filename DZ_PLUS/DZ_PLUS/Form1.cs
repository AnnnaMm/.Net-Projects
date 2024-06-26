using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DZ_PLUS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MATRIX_CALC newForm = new MATRIX_CALC();
            newForm.Show();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            CLOCK newForm = new CLOCK();
            newForm.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            GARFIKY newForm = new GARFIKY();
            newForm.Show();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            TEXT_ED newForm = new TEXT_ED();
            newForm.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {

            ANKETA newForm = new ANKETA();
            newForm.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*
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
            */
        }

        
    }
}
