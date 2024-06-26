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
    public partial class PICT : Form
    {
        public PICT()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                
                Title = "Browse Text Files",

                CheckFileExists = true,
                CheckPathExists = true,
                Filter = "jpg files (*.jpg)|*.jpg| png files (*.png)|*.png|all files (*.*)|*.*",
                DefaultExt = ".txt",
                FilterIndex = 1,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                Image img = Image.FromFile(openFileDialog1.FileName);
                pictureBox1.Image = img;
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void PICT_Load(object sender, EventArgs e)
        {

        }
        

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PICT_FormClosing(object sender, FormClosingEventArgs e)
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

        



