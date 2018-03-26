using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Form2 f = new Form2();
        int nr = 0;
        Button fire = new Button();
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.W)
                if (pictureBox1.Location.Y > 0)
                {
                    pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - 7);
                    label1.Visible = false;
                }
            if (e.KeyCode == Keys.S)
                if (pictureBox1.Location.Y < ClientSize.Height - pictureBox1.Height)
                { label2.Visible = false; pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + 7); }
            if (e.KeyCode == Keys.D)
                if (pictureBox1.Location.X < ClientSize.Width - pictureBox1.Width)
                {
                    label4.Visible = false;
                    pictureBox1.Location = new Point(pictureBox1.Location.X + 7, pictureBox1.Location.Y);
                }
            if (e.KeyCode == Keys.A)
                if (pictureBox1.Location.X > 0)
                {
                   
                    
                    label3.Visible = false;
                    pictureBox1.Location = new Point(pictureBox1.Location.X - 7, pictureBox1.Location.Y);
                }
            if (e.KeyCode == Keys.Space)
            {
                if (fire.Location.Y < 0)
                {
                    fire.Location = new Point(pictureBox1.Location.X + pictureBox1.Width / 2 - 4, pictureBox1.Location.Y - 22);
                    fire.Size = new Size(10, 20);
                    this.Controls.Add(fire);
                    this.Focus();
                    timer1.Enabled = true;
                    label5.Visible = false;
                    nr++;
                }
            }



        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            fire.Location = new Point(fire.Location.X, fire.Location.Y - 15);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fire.Location = new Point(-20 - 20);
            fire.BackColor = Color.Yellow ;
            fire.FlatStyle = FlatStyle.Flat;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (label5.Visible == false && label4.Visible == false && label3.Visible == false && label2.Visible == false && label1.Visible == false)
            {
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
            }
            if (label7.Visible == true && nr > 1)
            {
                if (fire.Location.Y < label7.Location.Y + label7.Height && fire.Location.Y > label7.Location.Y && fire.Location.X < label7.Location.X + label7.Width && label7.Location.X < fire.Location.X)
                {
                    this.Close();
                }
                if (fire.Location.Y < label6.Location.Y + label6.Height && fire.Location.Y > label6.Location.Y && fire.Location.X < label6.Location.X + label6.Width && label6.Location.X < fire.Location.X)
                {
                    this.Hide();
                    f.Show();
                }
                if (fire.Location.Y < label8.Location.Y + label8.Height && fire.Location.Y > label8.Location.Y && fire.Location.X < label8.Location.X + label8.Width && label8.Location.X < fire.Location.X)
                {
                    string scor ;
                    scor = System.IO.File.ReadAllText(@"\scor.txt");
                    label9.Visible = true;
                    label9.Text = "Nivelul maxim atins este: " + scor;
                
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
