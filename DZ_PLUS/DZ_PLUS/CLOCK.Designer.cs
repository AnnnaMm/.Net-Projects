
namespace DZ_PLUS
{
    partial class CLOCK
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.backBox = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.hourBox = new System.Windows.Forms.PictureBox();
            this.minuteBox = new System.Windows.Forms.PictureBox();
            this.dotBox = new System.Windows.Forms.PictureBox();
            this.secondBox = new System.Windows.Forms.PictureBox();
            this.DC = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.backBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hourBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minuteBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dotBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondBox)).BeginInit();
            this.SuspendLayout();
            // 
            // backBox
            // 
            this.backBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.backBox.BackColor = System.Drawing.Color.Transparent;
            this.backBox.Location = new System.Drawing.Point(73, 37);
            this.backBox.Name = "backBox";
            this.backBox.Size = new System.Drawing.Size(500, 500);
            this.backBox.TabIndex = 0;
            this.backBox.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // hourBox
            // 
            this.hourBox.BackColor = System.Drawing.Color.Transparent;
            this.hourBox.Location = new System.Drawing.Point(81, 37);
            this.hourBox.Name = "hourBox";
            this.hourBox.Size = new System.Drawing.Size(500, 500);
            this.hourBox.TabIndex = 1;
            this.hourBox.TabStop = false;
            // 
            // minuteBox
            // 
            this.minuteBox.BackColor = System.Drawing.Color.Transparent;
            this.minuteBox.Location = new System.Drawing.Point(73, 37);
            this.minuteBox.Name = "minuteBox";
            this.minuteBox.Size = new System.Drawing.Size(500, 500);
            this.minuteBox.TabIndex = 2;
            this.minuteBox.TabStop = false;
            // 
            // dotBox
            // 
            this.dotBox.BackColor = System.Drawing.Color.Transparent;
            this.dotBox.Location = new System.Drawing.Point(96, 37);
            this.dotBox.Name = "dotBox";
            this.dotBox.Size = new System.Drawing.Size(500, 500);
            this.dotBox.TabIndex = 3;
            this.dotBox.TabStop = false;
            // 
            // secondBox
            // 
            this.secondBox.BackColor = System.Drawing.Color.Transparent;
            this.secondBox.Location = new System.Drawing.Point(73, 37);
            this.secondBox.Name = "secondBox";
            this.secondBox.Size = new System.Drawing.Size(500, 500);
            this.secondBox.TabIndex = 4;
            this.secondBox.TabStop = false;
            // 
            // DC
            // 
            this.DC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DC.AutoSize = true;
            this.DC.BackColor = System.Drawing.SystemColors.ControlLight;
            this.DC.Font = new System.Drawing.Font("Microsoft Uighur", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DC.ForeColor = System.Drawing.Color.Black;
            this.DC.Location = new System.Drawing.Point(646, 242);
            this.DC.Name = "DC";
            this.DC.Size = new System.Drawing.Size(296, 114);
            this.DC.TabIndex = 5;
            this.DC.Text = "00:00:00";
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(716, 378);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "Digital watch";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(241, 567);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = "Analog clock";
            // 
            // CLOCK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1016, 627);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DC);
            this.Controls.Add(this.secondBox);
            this.Controls.Add(this.dotBox);
            this.Controls.Add(this.minuteBox);
            this.Controls.Add(this.hourBox);
            this.Controls.Add(this.backBox);
            this.Name = "CLOCK";
            this.Text = "CLOCK";
            this.Load += new System.EventHandler(this.CLOCK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.backBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hourBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minuteBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dotBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox backBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox hourBox;
        private System.Windows.Forms.PictureBox minuteBox;
        private System.Windows.Forms.PictureBox dotBox;
        private System.Windows.Forms.PictureBox secondBox;
        private System.Windows.Forms.Label DC;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}