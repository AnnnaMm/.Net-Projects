using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace DZ_FULL
{
    public partial class TEXT : Form
    {
        public TEXT()
        {
            InitializeComponent();
            button1.Click += button1_Click;
            colorDialog1.FullOpen = true;
            colorDialog1.Color = this.BackColor;
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"C:\Users\Анна Мамчич\Desktop\PRGRMMNG\c#.net_projekts\DZ_FULL\DZ_FULL\Text.txt",
                Title = "Browse Text Files",

                CheckFileExists = true,
                CheckPathExists = true,
                Filter = "txt files (*.txt)|*.txt|png files (*.png)|*.png|all files (*.*)|*.*",
                DefaultExt = ".txt",
                FilterIndex = 1,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename = openFileDialog1.FileName;
                string fileText = File.ReadAllText(filename);
                label1.Text = "Відкрито файл :";
                label2.Text = filename;
                richTextBox1.Text = fileText;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(sfd.FileName, richTextBox1.Text);
                
               
            }
            MessageBox.Show("Файл збережено!");
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            
            richTextBox1.SelectionColor = colorDialog1.Color;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            
            richTextBox1.Font = fontDialog1.Font;
            richTextBox1.ForeColor = fontDialog1.Color;
            
        }

        private void TEXT_Load(object sender, EventArgs e)
        {

        }
        

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void TEXT_FormClosing(object sender, FormClosingEventArgs e)
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

