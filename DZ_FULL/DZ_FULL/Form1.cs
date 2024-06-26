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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MLTPL newForm = new MLTPL();
            newForm.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Obj_K newForm = new Obj_K();
            newForm.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Obj_M newForm = new Obj_M();
            newForm.Show();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            LIT_RYAD newForm = new LIT_RYAD();
            newForm.Show();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Нажміть на червоний хрестик!");
        }
        private void button6_Click(object sender, EventArgs e)
        {
            Obj_Timer newForm = new Obj_Timer();
            newForm.Show();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            MenuStrip newForm = new MenuStrip();
            newForm.Show();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            PICT newForm = new PICT();
            newForm.Show();
        }
        private void button9_Click(object sender, EventArgs e)
        {
            TEXT newForm = new TEXT();
            newForm.Show();
        }
        private void button10_Click(object sender, EventArgs e)
        {
            MenuStrip newForm = new MenuStrip();
            newForm.Show();
        }
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
    }
}
