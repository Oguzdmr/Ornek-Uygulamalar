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

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        int x = 10;
        int y = 10;
        Button b = new Button();
        ArrayList butonlar = new ArrayList();
        int satır = 5, sutun = 5;
        public Form1()
        {
            InitializeComponent();
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            button1.Left += x;
            button1.Top += y;

            if (button1.Left > this.Width-button1.Width)
            {
                x = x * -1;

            }
            if (button1.Left < 0)
            {
                x = x * -1;
            }
            if (button1.Top > this.Height - button1.Height)
            {
                y = y * -1;
            }
            if (button1.Top < 0)
            {
                y = y * -1;
            }

            carpma();

           /* for (int i = 0; i < satır; i++){

                for (int j = 0; j < sutun; j++)
                {
                    if (button1.Top <= b[j].Bottom)
                    {
                        y = y * -1;
                        b[j].Dispose();
                        
                    }
                    
                }
            }
            */
           


        }

        private void carpma()
        {
            Rectangle r = new Rectangle();
            Rectangle t = new Rectangle();
            t.X = button1.Left;
            t.Y = button1.Top;
            t.Height = button1.Height;
            t.Width = button1.Width;
            for (int i = 0; i < butonlar.Count; i++)
            {
                Button b = (Button)butonlar[i];
                r.X = b.Left;
                r.Y = b.Top;
                r.Height = b.Height;
                r.Width = b.Width;
                if (r.IntersectsWith(t))
                {
                   
                    sutun--;
                    butonlar.RemoveAt(i);
                    b.Dispose();
                }
                
            }
        }
      
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;

        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            
            for (int j = 0; j < satır; j++)
            {
                for (int i = 0; i < sutun; i++)
                {
                    b = new Button();
                    b.Size = new Size(50, 50);
                    b.Location = new Point(j * 50, i * 50);
                    b.BackColor = Color.Black;
                    butonlar.Add(b);
                    this.Controls.Add(b);
                }
            }
        }
        
    }
}
