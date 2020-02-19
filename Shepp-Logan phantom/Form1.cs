using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shepp_Logan_phantom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics phantom = this.pictureBox1.CreateGraphics();
            double[,] t;

            int i, j;
            t = new double[256, 256];

            double a = 0.69;
            double b = 0.92;


            for (i = 0; i <= 255; i++)
            {
                for (j = 0; j <= 255; j++)
                {
                    if (((Math.Pow((i - 127.5), 2) / Math.Pow((a * 127.5), 2)) + (Math.Pow((127.5 - j), 2) / Math.Pow((b * 127.5), 2))) <= 1)
                    {
                        t[i, j] = 2;
                    }
                }
            }

            double C = 1.02;
            double W = 0.11;

            for (i = 0; i <= 255; i++)
            {
                for (j = 0; j <= 255; j++)
                {

                    if (t[i, j] <= C - (W / 2)) 
                    {
                        t[i, j] = 0; // = 0
                    }
                    else if (t[i, j] >= C + (W / 2)) 
                    {
                        t[i, j] = 255;
                    }
                    else
                    {
                        t[i, j] = ((t[i, j] - C + (W / 2)) * (255 / W));
                    }

                }
            }

            for (i = 0; i <= 255; i++)
            {
                for (j = 0; j <= 255; j++)
                {
                    Color color1 = Color.FromArgb((int)t[i, j], (int)t[i, j], (int)t[i, j]);

                    Brush pedzel = new SolidBrush(color1);
                    phantom.FillRectangle(pedzel, i, j, 1, 1);
                    pedzel.Dispose();
                }
            }
            phantom.Dispose();
        }
    }
}
