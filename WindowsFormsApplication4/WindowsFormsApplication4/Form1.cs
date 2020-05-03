using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        int x = 10, y = 10, a = 3;
        public Form1()
        {
            InitializeComponent();
        }

        private void capma()
        {
            label19.Text = Convert.ToString(a);

            Rectangle o1 = new Rectangle();
            Rectangle c1 = new Rectangle();
            Rectangle c2 = new Rectangle();
            Rectangle c3 = new Rectangle();
            Rectangle c4 = new Rectangle();
            Rectangle d1 = new Rectangle();
            Rectangle d2 = new Rectangle();
            Rectangle d3 = new Rectangle();
            Rectangle d4 = new Rectangle();
            Rectangle d5 = new Rectangle();
            Rectangle d6 = new Rectangle();
            Rectangle d7 = new Rectangle();
            Rectangle d8 = new Rectangle();
            Rectangle d9 = new Rectangle();
            Rectangle d10 = new Rectangle();
            Rectangle d11 = new Rectangle();
            Rectangle d12 = new Rectangle();
            Rectangle d13 = new Rectangle();

            o1.Y = picOyuncu.Top;
            o1.X = picOyuncu.Left;
            o1.Height = picOyuncu.Height;
            o1.Width = picOyuncu.Width;

            c1.Y = picCanavar1.Top;
            c1.X = picCanavar1.Left;
            c1.Height = picCanavar1.Height;
            c1.Width = picCanavar1.Width;

            c2.Y = picCanavar2.Top;
            c2.X = picCanavar2.Left;
            c2.Height = picCanavar2.Height;
            c2.Width = picCanavar2.Width;

            c3.Y = picCanavar3.Top;
            c3.X = picCanavar3.Left;
            c3.Height = picCanavar3.Height;
            c3.Width = picCanavar3.Width;

            c4.Y = picCanavar4.Top;
            c4.X = picCanavar4.Left;
            c4.Height = picCanavar4.Height;
            c4.Width = picCanavar4.Width;

            d1.Y = label1.Top;
            d1.X = label1.Left;
            d1.Height = label1.Height;
            d1.Width = label1.Width;

            d2.Y = label2.Top;
            d2.X = label2.Left;
            d2.Height = label2.Height;
            d2.Width = label2.Width;

            d3.Y = label3.Top;
            d3.X = label3.Left;
            d3.Height = label3.Height;
            d3.Width = label3.Width;

            d4.Y = label4.Top;
            d4.X = label4.Left;
            d4.Height = label4.Height;
            d4.Width = label4.Width;

            d5.Y = label5.Top;
            d5.X = label5.Left;
            d5.Height = label5.Height;
            d5.Width = label5.Width;

            d6.Y = label6.Top;
            d6.X = label6.Left;
            d6.Height = label6.Height;
            d6.Width = label6.Width;

            d7.Y = label7.Top;
            d7.X = label7.Left;
            d7.Height = label7.Height;
            d7.Width = label7.Width;

            d8.Y = label8.Top;
            d8.X = label8.Left;
            d8.Height = label8.Height;
            d8.Width = label8.Width;

            d9.Y = label9.Top;
            d9.X = label9.Left;
            d9.Height = label9.Height;
            d9.Width = label9.Width;

            d10.Y = label10.Top;
            d10.X = label10.Left;
            d10.Height = label10.Height;
            d10.Width = label10.Width;

            d11.Y = label11.Top;
            d11.X = label11.Left;
            d11.Height = label11.Height;
            d11.Width = label11.Width;

            d12.Y = label12.Top;
            d12.X = label12.Left;
            d12.Height = label12.Height;
            d12.Width = label12.Width;

            d13.Y = label13.Top;
            d13.X = label13.Left;
            d13.Height = label13.Height;
            d13.Width = label13.Width;

            /*if (o1.IntersectsWith(c1) || o1.IntersectsWith(c2) || o1.IntersectsWith(c3) ||o1.IntersectsWith(c4))
            {
                a--;
                label19.Text = Convert.ToString(a);
                picOyuncu.Location=new Point(775, 332);

            }

            if (a == 0)
            {
                MessageBox.Show("Kaybettiniz!!!");
                
            }*/

            //canavar 1-----------------------------------------------------------------------------------------------------------------

            if (c1.IntersectsWith(d1))
            {
                if (y > 0 && x > 0)
                {
                    if (c1.Top <= d1.Bottom && c1.Left >= d1.Right)
                        y = y * -1;
                    else
                        x = x * -1;
                }
                else if (y > 0 && x < 0)
                {
                    if (c1.Top <= d1.Bottom && c1.Right >= d1.Left)
                        y = y * -1;
                    else
                        x = x * -1;
                }
                else if (y < 0 && x > 0)
                {
                    if (c1.Bottom >= d1.Top && c1.Left >= d1.Right)
                        y = y * -1;
                    else
                        x = x * -1;
                }
                else if (x < 0 && y < 0)
                {
                    if (c1.Bottom <= d1.Top && c1.Right >= d1.Left)
                        y = y * -1;
                    else
                        x = x * -1;
                }

            }

            if (c1.IntersectsWith(d2))
            {
                if (y > 0 && x > 0)
                {
                    if (c1.Top <= d2.Bottom && c1.Left >= d2.Right)
                        y = y * -1;
                    else
                        x = x * -1;
                }
                else if (y > 0 && x < 0)
                {
                    if (c1.Top <= d2.Bottom && c1.Right >= d2.Left)
                        y = y * -1;
                    else
                        x = x * -1;
                }
                else if (y < 0 && x > 0)
                {
                    if (c1.Bottom >= d2.Top && c1.Left >= d2.Right)
                        y = y * -1;
                    else
                        x = x * -1;
                }
                else if (x < 0 && y < 0)
                {
                    if (c1.Bottom <= d2.Top && c1.Right >= d2.Left)
                        y = y * -1;
                    else
                        x = x * -1;
                }

            }

            if (c1.IntersectsWith(d3))
            {
                if (y > 0 && x > 0)
                {
                    if (c1.Top <= d3.Bottom && c1.Left >= d3.Right)
                        y = y * -1;
                    else
                        x = x * -1;
                }
                else if (y > 0 && x < 0)
                {
                    if (c1.Top <= d3.Bottom && c1.Right >= d3.Left)
                        y = y * -1;
                    else
                        x = x * -1;
                }
                else if (y < 0 && x > 0)
                {
                    if (c1.Bottom >= d3.Top && c1.Left >= d3.Right)
                        y = y * -1;
                    else
                        x = x * -1;
                }
                else if (x < 0 && y < 0)
                {
                    if (c1.Bottom <= d3.Top && c1.Right >= d3.Left)
                        y = y * -1;
                    else
                        x = x * -1;
                }

            }

            if (c1.IntersectsWith(d4))
            {
                if (y > 0 && x > 0)
                {
                    if (c1.Top <= d4.Bottom && c1.Left >= d4.Right)
                        y = y * -1;
                    else
                        x = x * -1;
                }
                else if (y > 0 && x < 0)
                {
                    if (c1.Top <= d4.Bottom && c1.Right >= d4.Left)
                        y = y * -1;
                    else
                        x = x * -1;
                }
                else if (y < 0 && x > 0)
                {
                    if (c1.Bottom >= d4.Top && c1.Left >= d4.Right)
                        y = y * -1;
                    else
                        x = x * -1;
                }
                else if (x < 0 && y < 0)
                {
                    if (c1.Bottom <= d4.Top && c1.Right >= d4.Left)
                        y = y * -1;
                    else
                        x = x * -1;
                }

            }

            if (c1.IntersectsWith(d5))
            {
                if (y > 0 && x > 0)
                {
                    if (c1.Top <= d5.Bottom && c1.Left >= d5.Right)
                        y = y * -1;
                    else
                        x = x * -1;
                }
                else if (y > 0 && x < 0)
                {
                    if (c1.Top <= d5.Bottom && c1.Right >= d5.Left)
                        y = y * -1;
                    else
                        x = x * -1;
                }
                else if (y < 0 && x > 0)
                {
                    if (c1.Bottom >= d5.Top && c1.Left >= d5.Right)
                        y = y * -1;
                    else
                        x = x * -1;
                }
                else if (x < 0 && y < 0)
                {
                    if (c1.Bottom <= d5.Top && c1.Right >= d5.Left)
                        y = y * -1;
                    else
                        x = x * -1;
                }

            }
            if (c1.IntersectsWith(d6))
            {
                if (y > 0 && x > 0)
                {
                    if (c1.Top <= d6.Bottom && c1.Left >= d6.Right)
                        y = y * -1;
                    else
                        x = x * -1;
                }
                else if (y > 0 && x < 0)
                {
                    if (c1.Top <= d6.Bottom && c1.Right >= d6.Left)
                        y = y * -1;
                    else
                        x = x * -1;
                }
                else if (y < 0 && x > 0)
                {
                    if (c1.Bottom >= d6.Top && c1.Left >= d6.Right)
                        y = y * -1;
                    else
                        x = x * -1;
                }
                else if (x < 0 && y < 0)
                {
                    if (c1.Bottom <= d6.Top && c1.Right >= d6.Left)
                        y = y * -1;
                    else
                        x = x * -1;
                }

            }
            if (c1.IntersectsWith(d7))
            {
                if (y > 0 && x > 0)
                {
                    if (c1.Top <= d7.Bottom && c1.Left >= d7.Right)
                        y = y * -1;
                    else
                        x = x * -1;
                }
                else if (y > 0 && x < 0)
                {
                    if (c1.Top <= d7.Bottom && c1.Right >= d7.Left)
                        y = y * -1;
                    else
                        x = x * -1;
                }
                else if (y < 0 && x > 0)
                {
                    if (c1.Bottom >= d7.Top && c1.Left >= d7.Right)
                        y = y * -1;
                    else
                        x = x * -1;
                }
                else if (x < 0 && y < 0)
                {
                    if (c1.Bottom <= d7.Top && c1.Right >= d7.Left)
                        y = y * -1;
                    else
                        x = x * -1;
                }

            }
            if (c1.IntersectsWith(d8))
            {
                if (y > 0 && x > 0)
                {
                    if (c1.Top <= d8.Bottom && c1.Left >= d8.Right)
                        y = y * -1;
                    else
                        x = x * -1;
                }
                else if (y > 0 && x < 0)
                {
                    if (c1.Top <= d8.Bottom && c1.Right >= d8.Left)
                        y = y * -1;
                    else
                        x = x * -1;
                }
                else if (y < 0 && x > 0)
                {
                    if (c1.Bottom >= d8.Top && c1.Left >= d8.Right)
                        y = y * -1;
                    else
                        x = x * -1;
                }
                else if (x < 0 && y < 0)
                {
                    if (c1.Bottom <= d8.Top && c1.Right >= d8.Left)
                        y = y * -1;
                    else
                        x = x * -1;
                }

            }
            if (c1.IntersectsWith(d9))
            {
                if (y > 0 && x > 0)
                {
                    if (c1.Top <= d9.Bottom && c1.Left >= d9.Right)
                        y = y * -1;
                    else
                        x = x * -1;
                }
                else if (y > 0 && x < 0)
                {
                    if (c1.Top <= d9.Bottom && c1.Right >= d9.Left)
                        y = y * -1;
                    else
                        x = x * -1;
                }
                else if (y < 0 && x > 0)
                {
                    if (c1.Bottom >= d9.Top && c1.Left >= d9.Right)
                        y = y * -1;
                    else
                        x = x * -1;
                }
                else if (x < 0 && y < 0)
                {
                    if (c1.Bottom <= d9.Top && c1.Right >= d9.Left)
                        y = y * -1;
                    else
                        x = x * -1;
                }

            }
            if (c1.IntersectsWith(d10))
            {
                if (y > 0 && x > 0)
                {
                    if (c1.Top <= d10.Bottom && c1.Left >= d10.Right)
                        y = y * -1;
                    else
                        x = x * -1;
                }
                else if (y > 0 && x < 0)
                {
                    if (c1.Top <= d10.Bottom && c1.Right >= d10.Left)
                        y = y * -1;
                    else
                        x = x * -1;
                }
                else if (y < 0 && x > 0)
                {
                    if (c1.Bottom >= d10.Top && c1.Left >= d10.Right)
                        y = y * -1;
                    else
                        x = x * -1;
                }
                else if (x < 0 && y < 0)
                {
                    if (c1.Bottom <= d10.Top && c1.Right >= d10.Left)
                        y = y * -1;
                    else
                        x = x * -1;
                }

            }
            if (c1.IntersectsWith(d11))
            {
                if (y > 0 && x > 0)
                {
                    if (c1.Top <= d11.Bottom && c1.Left >= d11.Right)
                        y = y * -1;
                    else
                        x = x * -1;
                }
                else if (y > 0 && x < 0)
                {
                    if (c1.Top <= d11.Bottom && c1.Right >= d11.Left)
                        y = y * -1;
                    else
                        x = x * -1;
                }
                else if (y < 0 && x > 0)
                {
                    if (c1.Bottom >= d11.Top && c1.Left >= d11.Right)
                        y = y * -1;
                    else
                        x = x * -1;
                }
                else if (x < 0 && y < 0)
                {
                    if (c1.Bottom <= d11.Top && c1.Right >= d11.Left)
                        y = y * -1;
                    else
                        x = x * -1;
                }

            }

            if (c1.IntersectsWith(d12))
            {
                if (y > 0 && x > 0)
                {
                    if (c1.Top <= d12.Bottom && c1.Left >= d12.Right)
                        y = y * -1;
                    else
                        x = x * -1;
                }
                else if (y > 0 && x < 0)
                {
                    if (c1.Top <= d12.Bottom && c1.Right >= d12.Left)
                        y = y * -1;
                    else
                        x = x * -1;
                }
                else if (y < 0 && x > 0)
                {
                    if (c1.Bottom >= d12.Top && c1.Left >= d12.Right)
                        y = y * -1;
                    else
                        x = x * -1;
                }
                else if (x < 0 && y < 0)
                {
                    if (c1.Bottom <= d12.Top && c1.Right >= d12.Left)
                        y = y * -1;
                    else
                        x = x * -1;
                }

            }
            if (c1.IntersectsWith(d13))
            {
                if (y > 0 && x > 0)
                {
                    if (c1.Top <= d13.Bottom && c1.Left >= d13.Right)
                        y = y * -1;
                    else
                        x = x * -1;
                }
                else if (y > 0 && x < 0)
                {
                    if (c1.Top <= d13.Bottom && c1.Right >= d13.Left)
                        y = y * -1;
                    else
                        x = x * -1;
                }
                else if (y < 0 && x > 0)
                {
                    if (c1.Bottom >= d13.Top && c1.Left >= d13.Right)
                        y = y * -1;
                    else
                        x = x * -1;
                }
                else if (x < 0 && y < 0)
                {
                    if (c1.Bottom <= d13.Top && c1.Right >= d13.Left)
                        y = y * -1;
                    else
                        x = x * -1;
                }

            }
            //-----------------------------------------------------------------------------------------------------------------

        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                picOyuncu.Top -= x;
            }
            if (e.KeyCode == Keys.Down)
            {
                picOyuncu.Top += x;
            }
            if (e.KeyCode == Keys.Left)
            {
                picOyuncu.Left -= x;
            }
            if (e.KeyCode == Keys.Right)
            {
                picOyuncu.Left += x;
            }

           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            picCanavar1.Left += x;
                picCanavar1.Top+=y;
                capma();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            
        }
    }
}

