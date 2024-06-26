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
    public partial class Obj_M : Form
    {
        Rectangle rec = new Rectangle(0, 0, 100, 100);
        Pen pen = new Pen(Color.Blue, 3);
        SolidBrush sbrush = new SolidBrush(Color.LightBlue);
        private Point MouseDownLocation;
        public Obj_M()
        {
            InitializeComponent();
            this.DoubleBuffered = true;

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.DrawEllipse(pen, rec);
            e.Graphics.FillEllipse(sbrush, rec);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
           
            
            if (e.Button == MouseButtons.Right)
            {
                if (e.Location.X > 0)
                {
                    
                    MouseDownLocation = new Point(e.Location.X - 10, e.Location.Y);
                }
                MouseDownLocation = e.Location;
            }
        }
        protected override void OnMouseMove(MouseEventArgs e)
        {


            if (e.Button == MouseButtons.Left)
            {
                rec.Location = new Point((e.X - MouseDownLocation.X) + rec.Left, (e.Y - MouseDownLocation.Y) + rec.Top);
                MouseDownLocation = e.Location;
                this.Invalidate();
            }

           
        }

    

        private void Obj_M_Load(object sender, EventArgs e)
        {

        }

        private void Obj_M_FormClosing(object sender, FormClosingEventArgs e)
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
