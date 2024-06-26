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
    public partial class CLOCK : Form
    {
        Bitmap back, hour, minute, dot, second;

        private void timer2_Tick(object sender, EventArgs e)
        {
            DC.Text = DateTime.Now.ToString("T");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime Now = DateTime.Now;
            int Hour  = Now.Hour;
            int Minute = Now.Minute;
            int Second = Now.Second;

            Single AngleS = Second * 6;
            Single AngleM = Minute * 6 + AngleS / 60;
            Single AngleH = Hour * 30 + AngleM / 12;

            backBox.Image = back;

            backBox.Controls.Add(hourBox);
            hourBox.Location = new Point(0, 0);
            hourBox.Image = rotateImage(hour, AngleH);

            hourBox.Controls.Add(minuteBox);
            minuteBox.Location = new Point(0, 0);
            minuteBox.Image = rotateImage(minute, AngleM);

            minuteBox.Controls.Add(dotBox);
            dotBox.Location = new Point(0, 0);
            dotBox.Image = dot;

            dotBox.Controls.Add(secondBox);
            secondBox.Location = new Point(0, 0);
            secondBox.Image = rotateImage(second, AngleS);


        }

        public CLOCK()
        {
            InitializeComponent();
            back = new Bitmap(".\\back.png");
            hour = new Bitmap(".\\hour2.png");
            minute = new Bitmap(".\\minute2.png");
            dot = new Bitmap(".\\dot.png");
            second = new Bitmap(".\\second2.png");
        }

        private void CLOCK_Load(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private Bitmap rotateImage(Bitmap rotateMe, float angle)
        {
            Bitmap rotatedImage = new Bitmap(rotateMe.Width, rotateMe.Height);
            using(Graphics g = Graphics.FromImage(rotatedImage))
            {
                g.TranslateTransform(rotateMe.Width / 2, rotateMe.Height / 2);
                g.RotateTransform(angle);
                g.TranslateTransform(-rotateMe.Width / 2, -rotateMe.Height / 2);
                g.DrawImage(rotateMe, new Point(0, 0));
            }
            return rotatedImage;
        }
    }
}
