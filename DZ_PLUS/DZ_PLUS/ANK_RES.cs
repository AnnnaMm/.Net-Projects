using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DZ_PLUS
{
    public partial class ANK_RES : Form
    {
        public ANK_RES()
        {
            InitializeComponent();
            label1.Text = Convert.ToString(ANKETA.count) + "/"+"10";
            label6.Text = Convert.ToString(((int)Math.Round((double)ANKETA.count*100))/10) + "%";

        }
        string[] str;
        private void ANK_RES_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //File.WriteAllText(@"C:\Users\Анна Мамчич\Desktop\PRGRMMNG\c#.net_projekts\DZ_PLUS\DZ_PLUS\For_Test\Test_Result\Result.txt", label1.Text, Encoding.Default);
            //File.WriteAllText(@"C:\Users\Анна Мамчич\Desktop\PRGRMMNG\c#.net_projekts\DZ_PLUS\DZ_PLUS\For_Test\Test_Result\Result.txt", label6.Text, Encoding.Default);
            StreamWriter writer = new StreamWriter(@"C:\Users\Анна Мамчич\Desktop\PRGRMMNG\c#.net_projekts\DZ_PLUS\DZ_PLUS\For_Test\Test_Result\Result.txt"); //указываем путь к файлу.
            writer.WriteLine("Ваш результат : " + " "+ label1.Text + " ||  " + label6.Text);
            //writer.WriteLine(label6.Text);
            writer.Close();


            MessageBox.Show(
        "       Успішно збережено!",
        ""
        );
        }
    }
}
