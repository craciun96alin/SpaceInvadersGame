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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Craciun\The_Best_Arcade_Music_vol_1.wav");
         Button b6 = new Button(); Button b13 = new Button();
        Button b7 = new Button(); Button b14 = new Button();
        Button b8 = new Button(); Button b15 = new Button();
        Button b9 = new Button(); Button b16 = new Button();
        Button b10 = new Button(); Button b17 = new Button();
        Button b11 = new Button();
        Button b12 = new Button();
        int nr = 2, nr1 = 3,nr2=1,nr3=2;
        int viteza = 4;
        
        Button fire = new Button();
        private void Form2_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.O)
            {
                if (nr3 % 2 == 0)
                    player.Stop();
                else
                    player.Play();
                nr3++;
            }
            if (e.KeyCode == Keys.W)
                if (nava.Location.Y > 0)
                {
                    nava.Location = new Point(nava.Location.X, nava.Location.Y - 9);
                                }
            if (e.KeyCode == Keys.S)
                if (nava.Location.Y < ClientSize.Height - nava.Height)
                {  nava.Location = new Point(nava.Location.X, nava.Location.Y + 9); }
            if (e.KeyCode == Keys.D)
                if (nava.Location.X < ClientSize.Width - nava.Width)
                {
                  
                    nava.Location = new Point(nava.Location.X + 9, nava.Location.Y);
                }
            if (e.KeyCode == Keys.A)
                if (nava.Location.X > 0)
                {
                      nava.Location = new Point(nava.Location.X - 9, nava.Location.Y);
                }

            if(fire.Location.Y<0 && label6.Visible==false)
            if (e.KeyCode == Keys.Space)
            {

                fire.Location = new Point(nava.Location.X + nava.Width / 2 - 4, nava.Location.Y - 22);
                fire.Size = new Size(10, 20);
                this.Controls.Add(fire);
                this.Focus();
                timer1.Enabled = true;
              
               
            }
            if (e.KeyCode == Keys.Y)
            {
                timer2.Enabled = true;
                timer3.Enabled = true;
                timer4.Enabled = true;
                timer5.Enabled = true;
                label6.Visible = false;
            }
            if (e.KeyCode == Keys.Q)
            { Application.Exit(); }



        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            fire.Location = new Point(fire.Location.X, fire.Location.Y - 15);
            if ( fire.Location.Y < pictureBox6.Location.Y + pictureBox6.Height && fire.Location.Y > pictureBox6.Location.Y && fire.Location.X < pictureBox6.Location.X + pictureBox6.Width && pictureBox6.Location.X < fire.Location.X)
            { if(pictureBox6.Visible==true)
                fire.Location = new Point(fire.Location.X, -150);
                
                pictureBox6.Visible = false;  }
            if (fire.Location.Y < pictureBox7.Location.Y + pictureBox7.Height && fire.Location.Y > pictureBox7.Location.Y && fire.Location.X < pictureBox7.Location.X + pictureBox7.Width && pictureBox7.Location.X < fire.Location.X)
            {if(pictureBox7.Visible==true)
                fire.Location = new Point(fire.Location.X, -150);
                
                
                pictureBox7.Visible = false;  }
            if (fire.Location.Y < pictureBox8.Location.Y + pictureBox8.Height && fire.Location.Y > pictureBox8.Location.Y && fire.Location.X < pictureBox8.Location.X + pictureBox8.Width && pictureBox8.Location.X < fire.Location.X)
            {
                if (pictureBox8.Visible == true)
                    fire.Location = new Point(fire.Location.X, -150);
                
                pictureBox8.Visible = false;  }
            if (fire.Location.Y < pictureBox9.Location.Y + pictureBox9.Height && fire.Location.Y > pictureBox9.Location.Y && fire.Location.X < pictureBox9.Location.X + pictureBox9.Width && pictureBox9.Location.X < fire.Location.X)
            {
                if (pictureBox9.Visible == true)
                    fire.Location = new Point(fire.Location.X, -150);
                
                pictureBox9.Visible = false;  }
            if (fire.Location.Y < pictureBox10.Location.Y + pictureBox10.Height && fire.Location.Y > pictureBox10.Location.Y && fire.Location.X < pictureBox10.Location.X + pictureBox10.Width && pictureBox10.Location.X < fire.Location.X)
            {
                if (pictureBox10.Visible == true)
                    fire.Location = new Point(fire.Location.X, -150);
                
                pictureBox10.Visible = false;  }
            if (fire.Location.Y < pictureBox11.Location.Y + pictureBox11.Height && fire.Location.Y > pictureBox11.Location.Y && fire.Location.X < pictureBox11.Location.X + pictureBox11.Width && pictureBox11.Location.X < fire.Location.X)
            {
                if (pictureBox11.Visible == true)
                    fire.Location = new Point(fire.Location.X, -150);
                pictureBox11.Visible = false;  }
            if (fire.Location.Y < pictureBox12.Location.Y + pictureBox12.Height && fire.Location.Y > pictureBox12.Location.Y && fire.Location.X < pictureBox12.Location.X + pictureBox12.Width && pictureBox12.Location.X < fire.Location.X)
            {
                if (pictureBox12.Visible == true)
                    fire.Location = new Point(fire.Location.X, -150);
                
                pictureBox12.Visible = false;  }
            if (fire.Location.Y < pictureBox13.Location.Y + pictureBox13.Height && fire.Location.Y > pictureBox13.Location.Y && fire.Location.X < pictureBox13.Location.X + pictureBox13.Width && pictureBox13.Location.X < fire.Location.X)
            {
                if (pictureBox13.Visible == true)
                    fire.Location = new Point(fire.Location.X, -150);
                pictureBox13.Visible = false;  }
            if (fire.Location.Y < pictureBox14.Location.Y + pictureBox14.Height && fire.Location.Y > pictureBox14.Location.Y && fire.Location.X < pictureBox14.Location.X + pictureBox14.Width && pictureBox14.Location.X < fire.Location.X)
            {
                if (pictureBox14.Visible == true)
                    fire.Location = new Point(fire.Location.X, -150);
                pictureBox14.Visible = false; }
            if (fire.Location.Y < pictureBox15.Location.Y + pictureBox15.Height && fire.Location.Y > pictureBox15.Location.Y && fire.Location.X < pictureBox15.Location.X + pictureBox15.Width && pictureBox15.Location.X < fire.Location.X)
            {
                if (pictureBox15.Visible == true)
                    fire.Location = new Point(fire.Location.X, -150);
                pictureBox15.Visible = false;  }
            if (fire.Location.Y < pictureBox16.Location.Y + pictureBox16.Height && fire.Location.Y > pictureBox16.Location.Y && fire.Location.X < pictureBox16.Location.X + pictureBox16.Width && pictureBox16.Location.X < fire.Location.X)
            {
                if (pictureBox16.Visible == true)
                    fire.Location = new Point(fire.Location.X, -150);
                pictureBox16.Visible = false; }
            if (fire.Location.Y < pictureBox17.Location.Y + pictureBox17.Height && fire.Location.Y > pictureBox17.Location.Y && fire.Location.X < pictureBox17.Location.X + pictureBox17.Width && pictureBox17.Location.X < fire.Location.X)
            {
                if (pictureBox17.Visible == true)
                    fire.Location = new Point(fire.Location.X, -150);
                pictureBox17.Visible = false;  }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           b6.Size=new Size(10,20);
             b7.Size=new Size(10,20);
             b8.Size=new Size(10,20);
             b9.Size=new Size(10,20);
             b10.Size=new Size(10,20);
             b11.Size=new Size(10,20);
             b12.Size=new Size(10,20);
             b13.Size=new Size(10,20);
             b14.Size=new Size(10,20);
             b15.Size=new Size(10,20);
             b16.Size=new Size(10,20);
             b17.Size=new Size(10,20);
             fire.Location = new Point(-20, -20);
             fire.BackColor = Color.Red;
             b6.Location = new Point(b6.Location.X, ClientSize.Height + 322);
             b9.Location = new Point(b6.Location.X, ClientSize.Height + 322);
             timer6.Enabled = true;
             b6.BackColor = Color.Red;
             b6.FlatStyle = FlatStyle.Popup;
             b7.BackColor = Color.Red;
             b7.FlatStyle = FlatStyle.Popup;
         b8.BackColor = Color.Red;
             b8.FlatStyle = FlatStyle.Popup;
             b9.BackColor = Color.Red;
             b9.FlatStyle = FlatStyle.Popup; b10.BackColor = Color.Red;
             b10.FlatStyle = FlatStyle.Popup; b11.BackColor = Color.Red;
             b11.FlatStyle = FlatStyle.Popup; b12.BackColor = Color.Red;
             b12.FlatStyle = FlatStyle.Popup; b13.BackColor = Color.Red;
             b13.FlatStyle = FlatStyle.Popup; b14.BackColor = Color.Red;
             b14.FlatStyle = FlatStyle.Popup; b15.BackColor = Color.Red;
             b15.FlatStyle = FlatStyle.Popup; b17.BackColor = Color.Red;
             b17.FlatStyle = FlatStyle.Popup; b16.BackColor = Color.Red;
             b16.FlatStyle = FlatStyle.Popup;
             fire.BackColor = Color.Yellow;
             fire.FlatStyle = FlatStyle.Flat;

             
            // player.Play();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            b10.Visible = true;
            b11.Visible = true;
            b12.Visible = true;
            b13.Visible = true;
            b14.Visible = true;
            b15.Visible = true;
            b16.Visible = true;
            b17.Visible = true;
            b6.Visible = true;
            b7.Visible = true;
            b8.Visible = true;
            b9.Visible = true;
                

            if (pictureBox6.Location.X > 0 && nr%2==0)
            {
                if (pictureBox6.Location.X - 5 <= 0)
                    nr = 3;
                pictureBox6.Location = new Point(pictureBox6.Location.X - 5, pictureBox6.Location.Y);
                pictureBox10.Location = new Point(pictureBox10.Location.X - 5, pictureBox10.Location.Y);
                pictureBox8.Location = new Point(pictureBox8.Location.X - 5, pictureBox8.Location.Y);
                pictureBox7.Location = new Point(pictureBox7.Location.X - 5, pictureBox7.Location.Y);
                pictureBox14.Location = new Point(pictureBox14.Location.X - 5, pictureBox14.Location.Y);
                pictureBox17.Location = new Point(pictureBox17.Location.X - 5, pictureBox17.Location.Y);
              
            }
           if (pictureBox7.Location.X + pictureBox7.Width < ClientSize.Width && nr%2!=0)
            {
                if (pictureBox7.Location.X + 5+pictureBox7.Width >= ClientSize.Width)
                 nr=2;
                pictureBox6.Location = new Point(pictureBox6.Location.X + 5, pictureBox6.Location.Y);
                pictureBox10.Location = new Point(pictureBox10.Location.X + 5, pictureBox10.Location.Y);
                pictureBox8.Location = new Point(pictureBox8.Location.X + 5, pictureBox8.Location.Y);
                pictureBox7.Location = new Point(pictureBox7.Location.X + 5, pictureBox7.Location.Y);
                pictureBox14.Location = new Point(pictureBox14.Location.X + 5, pictureBox14.Location.Y);
                pictureBox17.Location = new Point(pictureBox17.Location.X + 5, pictureBox17.Location.Y);
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (pictureBox16.Location.X + pictureBox16.Width < ClientSize.Width && nr1 % 2 != 0)
            {
                if (pictureBox16.Location.X + 5 + pictureBox16.Width >=ClientSize.Width)
                    nr1 = 2;
                pictureBox16.Location = new Point(pictureBox16.Location.X + 5, pictureBox16.Location.Y);
                pictureBox15.Location = new Point(pictureBox15.Location.X + 5, pictureBox15.Location.Y);
                pictureBox11.Location = new Point(pictureBox11.Location.X + 5, pictureBox11.Location.Y);
                pictureBox9.Location = new Point(pictureBox9.Location.X + 5, pictureBox9.Location.Y);
                pictureBox12.Location = new Point(pictureBox12.Location.X + 5, pictureBox12.Location.Y);
                pictureBox13.Location = new Point(pictureBox13.Location.X + 5, pictureBox13.Location.Y);
            }
            if (pictureBox12.Location.X>0 && nr1 % 2 == 0)
            {
                if (pictureBox12.Location.X -5 <= 0)
                    nr1 = 3;
                pictureBox16.Location = new Point(pictureBox16.Location.X - 5, pictureBox16.Location.Y);
                pictureBox15.Location = new Point(pictureBox15.Location.X - 5, pictureBox15.Location.Y);
                pictureBox11.Location = new Point(pictureBox11.Location.X - 5, pictureBox11.Location.Y);
                pictureBox9.Location = new Point(pictureBox9.Location.X - 5, pictureBox9.Location.Y);
                pictureBox12.Location = new Point(pictureBox12.Location.X - 5, pictureBox12.Location.Y);
                pictureBox13.Location = new Point(pictureBox13.Location.X - 5, pictureBox13.Location.Y);
            }
        }

       private void timer4_Tick(object sender, EventArgs e)
        {
            if ((b6.Location.Y > ClientSize.Height && pictureBox6.Visible == true) || (b7.Location.Y > ClientSize.Height && pictureBox7.Visible == true) || (b8.Location.Y > ClientSize.Height && pictureBox8.Visible == true) || (b10.Location.Y > ClientSize.Height && pictureBox10.Visible == true) || (b14.Location.Y > ClientSize.Height && pictureBox14.Visible == true) || (b17.Location.Y > ClientSize.Height && pictureBox17.Visible == true))
            {
                if (pictureBox6.Visible == true)
                    b6.Location = new Point(pictureBox6.Location.X + pictureBox6.Width / 2, pictureBox6.Location.Y + 22 + pictureBox6.Height);
                if (pictureBox7.Visible == true)
                    b7.Location = new Point(pictureBox7.Location.X + pictureBox7.Width / 2, pictureBox7.Location.Y + 22 + pictureBox6.Height);
                if (pictureBox8.Visible == true)
                    b8.Location = new Point(pictureBox8.Location.X + pictureBox8.Width / 2, pictureBox8.Location.Y + 22 + pictureBox6.Height);
                if (pictureBox10.Visible == true)
                    b10.Location = new Point(pictureBox10.Location.X + pictureBox10.Width / 2, pictureBox10.Location.Y + 22 + pictureBox6.Height);
                if (pictureBox14.Visible == true)
                    b14.Location = new Point(pictureBox14.Location.X + pictureBox14.Width / 2, pictureBox14.Location.Y + 22 + pictureBox6.Height);
                if (pictureBox17.Visible == true)
                    b17.Location = new Point(pictureBox17.Location.X + pictureBox17.Width / 2, pictureBox17.Location.Y + 22 + pictureBox6.Height);
                Controls.Add(b6); Controls.Add(b7); Controls.Add(b8); Controls.Add(b10); Controls.Add(b14); Controls.Add(b17);
            }
            b6.Location = new Point(b6.Location.X, b6.Location.Y + viteza);
            if (b6.Location.Y < nava.Location.Y + nava.Height && b6.Location.Y > nava.Location.Y && b6.Location.X < nava.Location.X + nava.Width && nava.Location.X < b6.Location.X)
                if (pictureBox5.Visible == true)
                { pictureBox5.Visible = false; b6.Location = new Point(-20, b6.Location.Y); }
                else if (pictureBox4.Visible == true)
                { pictureBox4.Visible = false; b6.Location = new Point(-20, b6.Location.Y); }
                else if (pictureBox3.Visible == true)
                { pictureBox3.Visible = false; b6.Location = new Point(-20, b6.Location.Y); }
                else if (pictureBox2.Visible == true)
                { pictureBox2.Visible = false; b6.Location = new Point(-20, b6.Location.Y); }
                else if (pictureBox1.Visible == true)
                { pictureBox1.Visible = false; b6.Location = new Point(-20, b6.Location.Y); }
            b7.Location = new Point(b7.Location.X, b7.Location.Y + viteza);
            if (b7.Location.Y < nava.Location.Y + nava.Height && b7.Location.Y > nava.Location.Y && b7.Location.X < nava.Location.X + nava.Width && nava.Location.X < b7.Location.X)
                if (pictureBox5.Visible == true)
                { pictureBox5.Visible = false; b7.Location = new Point(-20, b7.Location.Y); }
                else if (pictureBox4.Visible == true)
                { pictureBox4.Visible = false; b7.Location = new Point(-20, b7.Location.Y); }
                else if (pictureBox3.Visible == true)
                { pictureBox3.Visible = false; b7.Location = new Point(-20, b7.Location.Y); }
                else if (pictureBox2.Visible == true)
                { pictureBox2.Visible = false; b7.Location = new Point(-20, b7.Location.Y); }
                else if (pictureBox1.Visible == true)
                { pictureBox1.Visible = false; b7.Location = new Point(-20, b7.Location.Y); }
            b8.Location = new Point(b8.Location.X, b8.Location.Y + viteza);
            if (b8.Location.Y < nava.Location.Y + nava.Height && b8.Location.Y > nava.Location.Y && b8.Location.X < nava.Location.X + nava.Width && nava.Location.X < b8.Location.X)
                if (pictureBox5.Visible == true)
                { pictureBox5.Visible = false; b8.Location = new Point(-20, b8.Location.Y); }
                else if (pictureBox4.Visible == true)
                { pictureBox4.Visible = false; b8.Location = new Point(-20, b8.Location.Y); }
                else if (pictureBox3.Visible == true)
                { pictureBox3.Visible = false; b8.Location = new Point(-20, b8.Location.Y); }
                else if (pictureBox2.Visible == true)
                { pictureBox2.Visible = false; b8.Location = new Point(-20, b8.Location.Y); }
                else if (pictureBox1.Visible == true)
                { pictureBox1.Visible = false; b8.Location = new Point(-20, b8.Location.Y); }
            b10.Location = new Point(b10.Location.X, b10.Location.Y + viteza);
            if (b10.Location.Y < nava.Location.Y + nava.Height && b10.Location.Y > nava.Location.Y && b10.Location.X < nava.Location.X + nava.Width && nava.Location.X < b10.Location.X)
                if (pictureBox5.Visible == true)
                { pictureBox5.Visible = false; b10.Location = new Point(-20, b10.Location.Y); }
                else if (pictureBox4.Visible == true)
                { pictureBox4.Visible = false; b10.Location = new Point(-20, b10.Location.Y); }
                else if (pictureBox3.Visible == true)
                { pictureBox3.Visible = false; b10.Location = new Point(-20, b10.Location.Y); }
                else if (pictureBox2.Visible == true)
                { pictureBox2.Visible = false; b10.Location = new Point(-20, b10.Location.Y); }
                else if (pictureBox1.Visible == true)
                { pictureBox1.Visible = false; b10.Location = new Point(-20, b10.Location.Y); }
            b14.Location = new Point(b14.Location.X, b14.Location.Y + viteza);
            if (b14.Location.Y < nava.Location.Y + nava.Height && b14.Location.Y > nava.Location.Y && b14.Location.X < nava.Location.X + nava.Width && nava.Location.X < b14.Location.X)
                if (pictureBox5.Visible == true)
                { pictureBox5.Visible = false; b14.Location = new Point(-20, b14.Location.Y); }
                else if (pictureBox4.Visible == true)
                { pictureBox4.Visible = false; b14.Location = new Point(-20, b14.Location.Y); }
                else if (pictureBox3.Visible == true)
                { pictureBox3.Visible = false; b14.Location = new Point(-20, b14.Location.Y); }
                else if (pictureBox2.Visible == true)
                { pictureBox2.Visible = false; b14.Location = new Point(-20, b14.Location.Y); }
                else if (pictureBox1.Visible == true)
                { pictureBox1.Visible = false; b14.Location = new Point(-20, b14.Location.Y); }
            b17.Location = new Point(b17.Location.X, b17.Location.Y + viteza);
            if (b17.Location.Y < nava.Location.Y + nava.Height && b17.Location.Y > nava.Location.Y && b17.Location.X < nava.Location.X + nava.Width && nava.Location.X < b17.Location.X)
                if (pictureBox5.Visible == true)
                { pictureBox5.Visible = false; b17.Location = new Point(-20, b17.Location.Y); }
                else if (pictureBox4.Visible == true)
                { pictureBox4.Visible = false; b17.Location = new Point(-20, b17.Location.Y); }
                else if (pictureBox3.Visible == true)
                { pictureBox3.Visible = false; b17.Location = new Point(-20, b17.Location.Y); }
                else if (pictureBox2.Visible == true)
                { pictureBox2.Visible = false; b17.Location = new Point(-20, b17.Location.Y); }
                else if (pictureBox1.Visible == true)
                { pictureBox1.Visible = false; b17.Location = new Point(-20, b17.Location.Y); }

            
            if ((b9.Location.Y > ClientSize.Height && pictureBox9.Visible == true) || (b11.Location.Y > ClientSize.Height && pictureBox11.Visible == true) || (b12.Location.Y > ClientSize.Height && pictureBox12.Visible == true) || (b13.Location.Y > ClientSize.Height && pictureBox13.Visible == true) || (b15.Location.Y > ClientSize.Height && pictureBox15.Visible == true) || (b16.Location.Y > ClientSize.Height && pictureBox16.Visible == true))
            {
                if (pictureBox9.Visible == true)
                    b9.Location = new Point(pictureBox9.Location.X + pictureBox9.Width / 2, pictureBox9.Location.Y + 22 + pictureBox9.Height);
                if (pictureBox11.Visible == true)
                    b11.Location = new Point(pictureBox11.Location.X + pictureBox11.Width / 2, pictureBox11.Location.Y + 22 + pictureBox11.Height);
                if (pictureBox12.Visible == true)
                    b12.Location = new Point(pictureBox12.Location.X + pictureBox12.Width / 2, pictureBox12.Location.Y + 22 + pictureBox12.Height);
                if (pictureBox13.Visible == true)
                    b13.Location = new Point(pictureBox13.Location.X + pictureBox13.Width / 2, pictureBox13.Location.Y + 22 + pictureBox13.Height);
                if (pictureBox15.Visible == true)
                    b15.Location = new Point(pictureBox15.Location.X + pictureBox15.Width / 2, pictureBox15.Location.Y + 22 + pictureBox15.Height);
                if (pictureBox16.Visible == true)
                    b16.Location = new Point(pictureBox16.Location.X + pictureBox16.Width / 2, pictureBox16.Location.Y + 22 + pictureBox16.Height);
                Controls.Add(b16); Controls.Add(b15); Controls.Add(b13); Controls.Add(b11); Controls.Add(b12); Controls.Add(b9);
            }
            b9.Location = new Point(b9.Location.X, b9.Location.Y + viteza);
            if (b9.Location.Y < nava.Location.Y + nava.Height && b9.Location.Y > nava.Location.Y && b9.Location.X < nava.Location.X + nava.Width && nava.Location.X < b9.Location.X)
                if (pictureBox5.Visible == true)
                { pictureBox5.Visible = false; b9.Location = new Point(-20, b9.Location.Y); }
                else if (pictureBox4.Visible == true)
                { pictureBox4.Visible = false; b9.Location = new Point(-20, b9.Location.Y); }
                else if (pictureBox3.Visible == true)
                { pictureBox3.Visible = false; b9.Location = new Point(-20, b9.Location.Y); }
                else if (pictureBox2.Visible == true)
                { pictureBox2.Visible = false; b9.Location = new Point(-20, b9.Location.Y); }
                else if (pictureBox1.Visible == true)
                { pictureBox1.Visible = false; b9.Location = new Point(-20, b9.Location.Y); }
            b11.Location = new Point(b11.Location.X, b11.Location.Y + viteza);
            if (b11.Location.Y < nava.Location.Y + nava.Height && b11.Location.Y > nava.Location.Y && b11.Location.X < nava.Location.X + nava.Width && nava.Location.X < b11.Location.X)
                if (pictureBox5.Visible == true)
                { pictureBox5.Visible = false; b11.Location = new Point(-20, b11.Location.Y); }
                else if (pictureBox4.Visible == true)
                { pictureBox4.Visible = false; b11.Location = new Point(-20, b11.Location.Y); }
                else if (pictureBox3.Visible == true)
                { pictureBox3.Visible = false; b11.Location = new Point(-20, b11.Location.Y); }
                else if (pictureBox2.Visible == true)
                { pictureBox2.Visible = false; b11.Location = new Point(-20, b11.Location.Y); }
                else if (pictureBox1.Visible == true)
                { pictureBox1.Visible = false; b11.Location = new Point(-20, b11.Location.Y); }
            b12.Location = new Point(b12.Location.X, b12.Location.Y + viteza);
            if (b12.Location.Y < nava.Location.Y + nava.Height && b12.Location.Y > nava.Location.Y && b12.Location.X < nava.Location.X + nava.Width && nava.Location.X < b12.Location.X)
                if (pictureBox5.Visible == true)
                { pictureBox5.Visible = false; b12.Location = new Point(-20, b12.Location.Y); }
                else if (pictureBox4.Visible == true)
                { pictureBox4.Visible = false; b12.Location = new Point(-20, b12.Location.Y); }
                else if (pictureBox3.Visible == true)
                { pictureBox3.Visible = false; b12.Location = new Point(-20, b12.Location.Y); }
                else if (pictureBox2.Visible == true)
                { pictureBox2.Visible = false; b12.Location = new Point(-20, b12.Location.Y); }
                else if (pictureBox1.Visible == true)
                { pictureBox1.Visible = false; b12.Location = new Point(-20, b12.Location.Y); }
            b13.Location = new Point(b13.Location.X, b13.Location.Y + viteza);
            if (b13.Location.Y < nava.Location.Y + nava.Height && b13.Location.Y > nava.Location.Y && b13.Location.X < nava.Location.X + nava.Width && nava.Location.X < b13.Location.X)
                if (pictureBox5.Visible == true)
                { pictureBox5.Visible = false; b13.Location = new Point(-20, b13.Location.Y); }
                else if (pictureBox4.Visible == true)
                { pictureBox4.Visible = false; b13.Location = new Point(-20, b13.Location.Y); }
                else if (pictureBox3.Visible == true)
                { pictureBox3.Visible = false; b13.Location = new Point(-20, b13.Location.Y); }
                else if (pictureBox2.Visible == true)
                { pictureBox2.Visible = false; b13.Location = new Point(-20, b13.Location.Y); }
                else if (pictureBox1.Visible == true)
                { pictureBox1.Visible = false; b13.Location = new Point(-20, b13.Location.Y); }
            b15.Location = new Point(b15.Location.X, b15.Location.Y + viteza);
            if (b15.Location.Y < nava.Location.Y + nava.Height && b15.Location.Y > nava.Location.Y && b15.Location.X < nava.Location.X + nava.Width && nava.Location.X < b15.Location.X)
                if (pictureBox5.Visible == true)
                { pictureBox5.Visible = false; b15.Location = new Point(-20, b15.Location.Y); }
                else if (pictureBox4.Visible == true)
                { pictureBox4.Visible = false; b15.Location = new Point(-20, b15.Location.Y); }
                else if (pictureBox3.Visible == true)
                { pictureBox3.Visible = false; b15.Location = new Point(-20, b15.Location.Y); }
                else if (pictureBox2.Visible == true)
                { pictureBox2.Visible = false; b15.Location = new Point(-20, b15.Location.Y); }
                else if (pictureBox1.Visible == true)
                { pictureBox1.Visible = false; b15.Location = new Point(-20, b15.Location.Y); }
            b16.Location = new Point(b16.Location.X, b16.Location.Y + viteza);
            if (b16.Location.Y < nava.Location.Y + nava.Height && b16.Location.Y > nava.Location.Y && b16.Location.X < nava.Location.X + nava.Width && nava.Location.X < b16.Location.X)
                if (pictureBox5.Visible == true)
                { pictureBox5.Visible = false; b16.Location = new Point(-20, b16.Location.Y); }
                else if (pictureBox4.Visible == true)
                { pictureBox4.Visible = false; b16.Location = new Point(-20, b16.Location.Y); }
                else if (pictureBox3.Visible == true)
                { pictureBox3.Visible = false; b16.Location = new Point(-20, b16.Location.Y); }
                else if (pictureBox2.Visible == true)
                { pictureBox2.Visible = false; b16.Location = new Point(-20, b16.Location.Y); }
                else if (pictureBox1.Visible == true)
                { pictureBox1.Visible = false; b16.Location = new Point(-20, b16.Location.Y); }

        }

        private void timer5_Tick(object sender, EventArgs e)
       {
           
            if (pictureBox1.Visible == false && pictureBox2.Visible == false && pictureBox3.Visible == false && pictureBox4.Visible == false && pictureBox5.Visible == false)
            {
                string scor = System.IO.File.ReadAllText(@"\scor.txt");
                timer5.Enabled = false;
                if (Convert.ToInt32(scor) < viteza - 3)
                {
                    System.IO.File.WriteAllText(@"\scor.txt", (viteza - 3).ToString());
                }
                MessageBox.Show("Game Over! Ati murit la nivelul "+(viteza-3).ToString(),"Game Over",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                Application.Exit();
            }
            if (pictureBox6.Visible == false && pictureBox7.Visible == false && pictureBox8.Visible == false && pictureBox9.Visible == false && pictureBox10.Visible == false && pictureBox11.Visible == false && pictureBox12.Visible == false && pictureBox13.Visible == false && pictureBox14.Visible == false && pictureBox15.Visible == false && pictureBox16.Visible == false && pictureBox17.Visible == false)
            {
                timer5.Enabled = false;
                label6.Text = "Felicitari ati terminat nivelul " + (viteza - 3).ToString() + " Apasati Y pentru a continua sau Q pentru a iesi. Pentru a opri/incepe sunetul apasati O.";
                label6.Visible = true;
                viteza++;
                pictureBox6.Visible = true;
                pictureBox7.Visible = true;
                pictureBox8.Visible = true;
                pictureBox9.Visible = true;
                pictureBox10.Visible = true;
                pictureBox11.Visible = true;
                pictureBox12.Visible = true;
                pictureBox13.Visible = true;
                pictureBox14.Visible = true;
                pictureBox15.Visible = true;
                pictureBox16.Visible = true;
                pictureBox17.Visible = true;
                timer2.Enabled = false;
                timer3.Enabled = false;
                timer4.Enabled = false;
                if (pictureBox2.Visible == false)
                    pictureBox2.Visible = true;
                else if (pictureBox3.Visible == false)
                    pictureBox3.Visible = true;
                else if (pictureBox4.Visible == false)
                    pictureBox4.Visible = true;
                else if (pictureBox5.Visible == false)
                    pictureBox5.Visible = true;
                b10.Visible = false;
                b11.Visible = false;
                b12.Visible = false;
                b13.Visible = false;
                b14.Visible = false;
                b15.Visible = false;
                b16.Visible = false;
                b17.Visible = false;
                b6.Visible = false;
                b7.Visible = false;
                b8.Visible = false;
                b9.Visible = false;
                

            }
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            nr2++;
                if(nr2%10==0)
                    player.Play();
         
                

                
        }
    }
}
