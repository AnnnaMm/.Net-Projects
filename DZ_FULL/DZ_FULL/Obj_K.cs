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
    public partial class Obj_K : Form
    {
        

        Rectangle rec = new Rectangle(0, 0, 100, 100);
        Pen pen = new Pen(Color.Yellow, 5);
        SolidBrush sbrush = new SolidBrush(Color.LightYellow);

        public Obj_K()
        {
            InitializeComponent();
            this.DoubleBuffered = true;


        }


        void Obj_K_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
                if (rec.Location.X > 0)
                {
                    
                    rec.Location = new Point(rec.Location.X - 10, rec.Location.Y);
                }
            //rec.Location = new Point(rec.Left - 10, rec.Top);
            if (e.KeyCode == Keys.Right)
                if (rec.Location.X < this.Width - 120)
                {
                    
                    rec.Location = new Point(rec.Location.X + 10, rec.Location.Y);
                }
            //rec.Location = new Point(rec.Left + 10, rec.Top);
            if (e.KeyCode == Keys.Up)
                if (rec.Location.Y > 0)
                {
                   
                    rec.Location = new Point(rec.Location.X, rec.Location.Y - 10);
                }
            //rec.Location = new Point(rec.Left, rec.Top - 10);
            if (e.KeyCode == Keys.Down)
                if (rec.Location.Y < this.Height - 140)
                {
                    
                    rec.Location = new Point(rec.Location.X, rec.Location.Y + 10);
                }
            //rec.Location = new Point(rec.Left, rec.Top + 10);


            Refresh();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(pen, rec);
            e.Graphics.FillRectangle(sbrush, rec);


        }


        private void Obj_K_Load(object sender, EventArgs e)
        {

        }

        private void Obj_K_FormClosing(object sender, FormClosingEventArgs e)
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
