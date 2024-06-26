
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DZ_PLUS
{
    public partial class ANKETA : Form
    {
        const string image1FilePath = @"C:\Users\Анна Мамчич\Desktop\PRGRMMNG\c#.net_projekts\DZ_PLUS\DZ_PLUS\For_Test\moai.jpg";
        const string image2FilePath = @"C:\Users\Анна Мамчич\Desktop\PRGRMMNG\c#.net_projekts\DZ_PLUS\DZ_PLUS\For_Test\ocean.png";
        const string image3FilePath = @"C:\Users\Анна Мамчич\Desktop\PRGRMMNG\c#.net_projekts\DZ_PLUS\DZ_PLUS\For_Test\kolibri.jpg";
        const string image4FilePath = @"C:\Users\Анна Мамчич\Desktop\PRGRMMNG\c#.net_projekts\DZ_PLUS\DZ_PLUS\For_Test\tv.jpg";
        const string image5FilePath = @"C:\Users\Анна Мамчич\Desktop\PRGRMMNG\c#.net_projekts\DZ_PLUS\DZ_PLUS\For_Test\Hagelin.jpg";
        const string image6FilePath = @"C:\Users\Анна Мамчич\Desktop\PRGRMMNG\c#.net_projekts\DZ_PLUS\DZ_PLUS\For_Test\Lorenz.jpg";
        const string image7FilePath = @"C:\Users\Анна Мамчич\Desktop\PRGRMMNG\c#.net_projekts\DZ_PLUS\DZ_PLUS\For_Test\fialka.jpg";
        const string image8FilePath = @"C:\Users\Анна Мамчич\Desktop\PRGRMMNG\c#.net_projekts\DZ_PLUS\DZ_PLUS\For_Test\Enigma.jpg";
        const string image9FilePath = @"C:\Users\Анна Мамчич\Desktop\PRGRMMNG\c#.net_projekts\DZ_PLUS\DZ_PLUS\For_Test\2.jpg";
        const string image10FilePath = @"C:\Users\Анна Мамчич\Desktop\PRGRMMNG\c#.net_projekts\DZ_PLUS\DZ_PLUS\For_Test\4.jpg";

        internal static double count = 0;

        public ANKETA()
        {
            InitializeComponent();
            tabControl1.Visible = false;
            Image img = Image.FromFile(image1FilePath);
            Clipboard.SetImage(img);
            richTextBox1.Paste();
            richTextBox1.Focus();
            Image img2 = Image.FromFile(image2FilePath);
            Clipboard.SetImage(img2);
            richTextBox2.Paste();
            richTextBox2.Focus();
            Image img3 = Image.FromFile(image3FilePath);
            Clipboard.SetImage(img3);
            richTextBox3.Paste();
            richTextBox3.Focus();
            Image img4 = Image.FromFile(image4FilePath);
            Clipboard.SetImage(img4);
            richTextBox4.Paste();
            richTextBox4.Focus();
            Image img5 = Image.FromFile(image5FilePath);
            Clipboard.SetImage(img5);
            richTextBox5.Paste();
            richTextBox5.Focus();
            Image img6 = Image.FromFile(image6FilePath);
            Clipboard.SetImage(img6);
            richTextBox6.Paste();
            richTextBox6.Focus();
            Image img7 = Image.FromFile(image7FilePath);
            Clipboard.SetImage(img7);
            richTextBox7.Paste();
            richTextBox7.Focus();
            Image img8 = Image.FromFile(image8FilePath);
            Clipboard.SetImage(img8);
            richTextBox8.Paste();
            richTextBox8.Focus();
            Image img9 = Image.FromFile(image10FilePath);
            Clipboard.SetImage(img9);
            richTextBox9.Paste();
            richTextBox9.Focus();
            Image img10 = Image.FromFile(image9FilePath);
            Clipboard.SetImage(img10);
            richTextBox10.Paste();
            richTextBox10.Focus();

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.TextLength == 0 || !maskedTextBox2.MaskCompleted || textBox3.TextLength == 0)
            {
                MessageBox.Show("Не всі дані введено");

            }
            else
            {
                progressBar1.Maximum = 8;
                progressBar1.Value = 1;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                textBox1.Visible = false;
                maskedTextBox2.Visible = false;
                textBox3.Visible = false;
                button1.Visible = false;
                button2.Visible = false;
                button4.Visible = false;
                tabControl1.Visible = true;
            }
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            progressBar2.Maximum = 8;
            progressBar3.Maximum = 8;
            progressBar4.Maximum = 8;
            progressBar5.Maximum = 8;
            progressBar6.Maximum = 8;
            progressBar7.Maximum = 8;
            progressBar8.Maximum = 8;
            if (tabControl1.SelectedIndex == 1)
            {
                progressBar2.Value = 2;
            }
            if (tabControl1.SelectedIndex == 2)
            {
                progressBar3.Value = 3;
            }
            if (tabControl1.SelectedIndex == 3)
            {
                progressBar4.Value = 4;
            }
            if (tabControl1.SelectedIndex == 4)
            {
                progressBar5.Value = 5;
            }
            if (tabControl1.SelectedIndex == 5)
            {
                progressBar6.Value = 6;
            }
            if (tabControl1.SelectedIndex == 6)
            {
                progressBar7.Value = 7;
            }
            if (tabControl1.SelectedIndex == 7)
            {
                progressBar8.Value = 8;
            }


        }


        private void button3_Click_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                count += 1;
            }
            if (radioButton5.Checked)
            {
                count += 1;
            }
            if (radioButton8.Checked)
            {
                count += 1;
            }
            if (radioButton11.Checked)
            {
                count += 1;
            }
            if (maskedTextBox1.Text == "1")
            {
                count += 1;
            }
            if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 1)
            {
                count += 1;
            }
            if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 0)
            {
                count += 0.5;
            }
            if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 1)
            {
                count += 0.5;
            }
            if (comboBox4.SelectedIndex == 0 && comboBox3.SelectedIndex == 0)
            {
                count += 1;
            }
            if (comboBox4.SelectedIndex == 0 && comboBox3.SelectedIndex == 1)
            {
                count += 0.5;
            }
            if (comboBox4.SelectedIndex == 1 && comboBox3.SelectedIndex == 0)
            {
                count += 0.5;
            }
            for (int i1 = 0; i1 < checkedListBox2.CheckedItems.Count; i1++)
            {
                textBox2.Text += checkedListBox2.CheckedItems[i1].ToString() + ',';
            }
            if (textBox2.Text == "Католицтво, Протестантизм, Православ'я,")
            {
                count += 1;
            }

            ANK_RES newForm = new ANK_RES();
            newForm.Show();

            // "your result" + count + " / " + "9";


            //MessageBox.Show("your result" + count+"/"+"9");


        }

       

        private void button2_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("У даному тесті Вам потрібно відповисти на питання " +
                "різного формату що потребують знань з різних дисциплін. " +
                "Всього в тесті 9 питань. Щоб перейти до наступного питання або повернутися на попереднє, натисніть на вкладення зверху з номером питання, на яке хочете перейти. " +
                
                "Зверніть увагу на те, що деякі питання можуть мати більше аніж 1 правильну відповідь. " +
                "Після надання відповідей на усі питання натисніть кнопку 'Завершити' та отримайте свій результат. Щасти :)");
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}





