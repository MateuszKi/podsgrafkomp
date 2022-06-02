using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab5
{
    public partial class Form1 : Form
    {
        private int szer = 0, wys = 0;
        private double r1, g1, b1, r2, g2, b2;
        Color k1, k2;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
                szer = pictureBox1.Image.Width;
                wys = pictureBox1.Image.Height;
                pictureBox2.Image = new Bitmap(szer, wys);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                pictureBox3.Load(openFileDialog2.FileName);
                szer = pictureBox1.Image.Width;
                wys = pictureBox1.Image.Height;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bitmap img1 = (Bitmap)pictureBox1.Image;
            Bitmap img2 = (Bitmap)pictureBox3.Image;
            Bitmap img3 = (Bitmap)pictureBox2.Image;

            for (int x = 0; x < szer; x++)
            {
                for (int y = 0; y < wys; y++)
                {
                    k1 = img1.GetPixel(x, y);
                    k2 = img2.GetPixel(x, y);

                    r1 = k1.R;
                    g1 = k1.G;
                    b1 = k1.B;
                    r2 = k2.R;
                    g2 = k2.G;
                    b2 = k2.B;

                    r1 /= 255;
                    g1 /= 255;
                    b1 /= 255;
                    r2 /= 255;
                    g2 /= 255;
                    b2 /= 255;

                    r1 = (r1 + r2) * 255;
                    g1 = (g1 + g2) * 255;
                    b1 = (b1 + b2) * 255;

                    if (r1 > 255) r1 = 255;
                    else if (r1 < 0) r1 = 0;

                    if (g1 > 255) g1 = 255;
                    else if (g1 < 0) g1 = 0;

                    if (b1 > 255) b1 = 255;
                    else if (b1 < 0) b1 = 0;

                    k1 = Color.FromArgb((int)r1, (int)g1, (int)b1);

                    img3.SetPixel(x, y, k1);
                }
            }

            pictureBox2.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bitmap img1 = (Bitmap)pictureBox1.Image;
            Bitmap img2 = (Bitmap)pictureBox3.Image;
            Bitmap img3 = (Bitmap)pictureBox2.Image;


            for (int x = 0; x < szer; x++)
            {
                for (int y = 0; y < wys; y++)
                {
                    k1 = img1.GetPixel(x, y);
                    k2 = img2.GetPixel(x, y);

                    r1 = k1.R;
                    g1 = k1.G;
                    b1 = k1.B;
                    r2 = k2.R;
                    g2 = k2.G;
                    b2 = k2.B;

                    r1 /= 255;
                    g1 /= 255;
                    b1 /= 255;
                    r2 /= 255;
                    g2 /= 255;
                    b2 /= 255;

                    r1 = (r1 + r2 - 1) * 255;
                    g1 = (g1 + g2 - 1) * 255;
                    b1 = (b1 + b2 - 1) * 255;

                    if (r1 > 255) r1 = 255;
                    else if (r1 < 0) r1 = 0;

                    if (g1 > 255) g1 = 255;
                    else if (g1 < 0) g1 = 0;

                    if (b1 > 255) b1 = 255;
                    else if (b1 < 0) b1 = 0;

                    k1 = Color.FromArgb((int)r1, (int)g1, (int)b1);

                    img3.SetPixel(x, y, k1);
                }
            }
            pictureBox2.Refresh();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Bitmap img1 = (Bitmap)pictureBox1.Image;
            Bitmap img2 = (Bitmap)pictureBox3.Image;
            Bitmap img3 = (Bitmap)pictureBox2.Image;


            for (int x = 0; x < szer; x++)
            {
                for (int y = 0; y < wys; y++)
                {
                    k1 = img1.GetPixel(x, y);
                    k2 = img2.GetPixel(x, y);

                    r1 = k1.R;
                    g1 = k1.G;
                    b1 = k1.B;
                    r2 = k2.R;
                    g2 = k2.G;
                    b2 = k2.B;

                    r1 /= 255;
                    g1 /= 255;
                    b1 /= 255;
                    r2 /= 255;
                    g2 /= 255;
                    b2 /= 255;

                    r1 = Math.Abs(r1 - r2) * 255;
                    g1 = Math.Abs(g1 - g2) * 255;
                    b1 = Math.Abs(b1 - b2) * 255;

                    if (r1 > 255) r1 = 255;
                    else if (r1 < 0) r1 = 0;

                    if (g1 > 255) g1 = 255;
                    else if (g1 < 0) g1 = 0;

                    if (b1 > 255) b1 = 255;
                    else if (b1 < 0) b1 = 0;

                    k1 = Color.FromArgb((int)r1, (int)g1, (int)b1);

                    img3.SetPixel(x, y, k1);
                }
            }
            pictureBox2.Refresh();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Bitmap img1 = (Bitmap)pictureBox1.Image;
            Bitmap img2 = (Bitmap)pictureBox3.Image;
            Bitmap img3 = (Bitmap)pictureBox2.Image;   

            for (int x = 0; x < szer; x++)
            {
                for (int y = 0; y < wys; y++)
                {
                    k1 = img1.GetPixel(x, y);
                    k2 = img2.GetPixel(x, y);

                    r1 = k1.R;
                    g1 = k1.G;
                    b1 = k1.B;
                    r2 = k2.R;
                    g2 = k2.G;
                    b2 = k2.B;

                    r1 /= 255;
                    g1 /= 255;
                    b1 /= 255;
                    r2 /= 255;
                    g2 /= 255;
                    b2 /= 255;

                    r1 = (r1 * r2) * 255;
                    g1 = (g1 * g2) * 255;
                    b1 = (b1 * b2) * 255;

                    if (r1 > 255) r1 = 255;
                    else if (r1 < 0) r1 = 0;

                    if (g1 > 255) g1 = 255;
                    else if (g1 < 0) g1 = 0;

                    if (b1 > 255) b1 = 255;
                    else if (b1 < 0) b1 = 0;

                    k1 = Color.FromArgb((int)r1, (int)g1, (int)b1);

                    img3.SetPixel(x, y, k1);
                }
            }
            pictureBox2.Refresh();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Bitmap img1 = (Bitmap)pictureBox1.Image;
            Bitmap img2 = (Bitmap)pictureBox3.Image;
            Bitmap img3 = (Bitmap)pictureBox2.Image;

            for (int x = 0; x < szer; x++)
            {
                for (int y = 0; y < wys; y++)
                {
                    k1 = img1.GetPixel(x, y);
                    k2 = img2.GetPixel(x, y);

                    r1 = k1.R;
                    g1 = k1.G;
                    b1 = k1.B;
                    r2 = k2.R;
                    g2 = k2.G;
                    b2 = k2.B;

                    r1 /= 255;
                    g1 /= 255;
                    b1 /= 255;
                    r2 /= 255;
                    g2 /= 255;
                    b2 /= 255;

                    r1 = (1 - (1 - r1) * (1 - r2)) * 255;
                    g1 = (1 - (1 - g1) * (1 - g2)) * 255;
                    b1 = (1 - (1 - b1) * (1 - b2)) * 255;

                    if (r1 > 255) r1 = 255;
                    else if (r1 < 0) r1 = 0;

                    if (g1 > 255) g1 = 255;
                    else if (g1 < 0) g1 = 0;

                    if (b1 > 255) b1 = 255;
                    else if (b1 < 0) b1 = 0;

                    k1 = Color.FromArgb((int)r1, (int)g1, (int)b1);

                    img3.SetPixel(x, y, k1);
                }
            }
            pictureBox2.Refresh();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Bitmap img1 = (Bitmap)pictureBox1.Image;
            Bitmap img2 = (Bitmap)pictureBox3.Image;
            Bitmap img3 = (Bitmap)pictureBox2.Image;

            for (int x = 0; x < szer; x++)
            {
                for (int y = 0; y < wys; y++)
                {
                    k1 = img1.GetPixel(x, y);
                    k2 = img2.GetPixel(x, y);

                    r1 = k1.R;
                    g1 = k1.G;
                    b1 = k1.B;
                    r2 = k2.R;
                    g2 = k2.G;
                    b2 = k2.B;

                    r1 /= 255;
                    g1 /= 255;
                    b1 /= 255;
                    r2 /= 255;
                    g2 /= 255;
                    b2 /= 255;

                    r1 = (1 - Math.Abs(1 - r1 - r2)) * 255;
                    g1 = (1 - Math.Abs(1 - g1 - g2)) * 255;
                    b1 = (1 - Math.Abs(1 - b1 - b2)) * 255;

                    if (r1 > 255) r1 = 255;
                    else if (r1 < 0) r1 = 0;

                    if (g1 > 255) g1 = 255;
                    else if (g1 < 0) g1 = 0;

                    if (b1 > 255) b1 = 255;
                    else if (b1 < 0) b1 = 0;

                    k1 = Color.FromArgb((int)r1, (int)g1, (int)b1);

                    img3.SetPixel(x, y, k1);
                }
            }
            pictureBox2.Refresh();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Bitmap img1 = (Bitmap)pictureBox1.Image;
            Bitmap img2 = (Bitmap)pictureBox3.Image;
            Bitmap img3 = (Bitmap)pictureBox2.Image;

            for (int x = 0; x < szer; x++)
            {
                for (int y = 0; y < wys; y++)
                {
                    k1 = img1.GetPixel(x, y);
                    k2 = img2.GetPixel(x, y);

                    r1 = k1.R;
                    g1 = k1.G;
                    b1 = k1.B;
                    r2 = k2.R;
                    g2 = k2.G;
                    b2 = k2.B;

                    r1 /= 255;
                    g1 /= 255;
                    b1 /= 255;
                    r2 /= 255;
                    g2 /= 255;
                    b2 /= 255;

                    if (r1 < r2) 
                        r1 = r1 * 255;
                    else 
                        r1 = r2 * 255;

                    if (g1 < g2) 
                        g1 = g1 * 255;
                    else 
                        g1 = g2 * 255;

                    if (b1 < b2) 
                        b1 = b1 * 255;
                    else 
                        b1 = b2 * 255;

                    if (r1 > 255) r1 = 255;
                    else if (r1 < 0) r1 = 0;

                    if (g1 > 255) g1 = 255;
                    else if (g1 < 0) g1 = 0;

                    if (b1 > 255) b1 = 255;
                    else if (b1 < 0) b1 = 0;

                    k1 = Color.FromArgb((int)r1, (int)g1, (int)b1);

                    img3.SetPixel(x, y, k1);
                }
            }
            pictureBox2.Refresh();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Bitmap img1 = (Bitmap)pictureBox1.Image;
            Bitmap img2 = (Bitmap)pictureBox3.Image;
            Bitmap img3 = (Bitmap)pictureBox2.Image;

            for (int x = 0; x < szer; x++)
            {
                for (int y = 0; y < wys; y++)
                {
                    k1 = img1.GetPixel(x, y);
                    k2 = img2.GetPixel(x, y);

                    r1 = k1.R;
                    g1 = k1.G;
                    b1 = k1.B;
                    r2 = k2.R;
                    g2 = k2.G;
                    b2 = k2.B;

                    r1 /= 255;
                    g1 /= 255;
                    b1 /= 255;
                    r2 /= 255;
                    g2 /= 255;
                    b2 /= 255;

                    if (r1 > r2) 
                        r1 = r1 * 255;
                    else 
                        r1 = r2 * 255;

                    if (g1 > g2) 
                        g1 = g1 * 255;
                    else 
                        g1 = g2 * 255;


                    if (r1 > 255) r1 = 255;
                    else if (r1 < 0) r1 = 0;

                    if (g1 > 255) g1 = 255;
                    else if (g1 < 0) g1 = 0;

                    if (b1 > 255) b1 = 255;
                    else if (b1 < 0) b1 = 0;

                    k1 = Color.FromArgb((int)r1, (int)g1, (int)b1);

                    img3.SetPixel(x, y, k1);
                }
            }
            pictureBox2.Refresh();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Bitmap img1 = (Bitmap)pictureBox1.Image;
            Bitmap img2 = (Bitmap)pictureBox3.Image;
            Bitmap img3 = (Bitmap)pictureBox2.Image;

            for (int x = 0; x < szer; x++)
            {
                for (int y = 0; y < wys; y++)
                {
                    k1 = img1.GetPixel(x, y);
                    k2 = img2.GetPixel(x, y);

                    r1 = k1.R;
                    g1 = k1.G;
                    b1 = k1.B;
                    r2 = k2.R;
                    g2 = k2.G;
                    b2 = k2.B;

                    r1 /= 255;
                    g1 /= 255;
                    b1 /= 255;
                    r2 /= 255;
                    g2 /= 255;
                    b2 /= 255;

                    r1 = (r1 + r2 - 2 * r1 * r2) * 255;
                    g1 = (g1 + g2 - 2 * g1 * g2) * 255;
                    b1 = (b1 + b2 - 2 * b1 * b2) * 255;


                    if (r1 > 255) r1 = 255;
                    else if (r1 < 0) r1 = 0;

                    if (g1 > 255) g1 = 255;
                    else if (g1 < 0) g1 = 0;

                    if (b1 > 255) b1 = 255;
                    else if (b1 < 0) b1 = 0;

                    k1 = Color.FromArgb((int)r1, (int)g1, (int)b1);

                    img3.SetPixel(x, y, k1);
                }
            }
            pictureBox2.Refresh();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Bitmap img1 = (Bitmap)pictureBox1.Image;
            Bitmap img2 = (Bitmap)pictureBox3.Image;
            Bitmap img3 = (Bitmap)pictureBox2.Image;

            for (int x = 0; x < szer; x++)
            {
                for (int y = 0; y < wys; y++)
                {
                    k1 = img1.GetPixel(x, y);
                    k2 = img2.GetPixel(x, y);

                    r1 = k1.R;
                    g1 = k1.G;
                    b1 = k1.B;
                    r2 = k2.R;
                    g2 = k2.G;
                    b2 = k2.B;

                    r1 /= 255;
                    g1 /= 255;
                    b1 /= 255;
                    r2 /= 255;
                    g2 /= 255;
                    b2 /= 255;

                    if (r1 < 0.5) 
                        r1 = 2 * r1 * r2 * 255;
                    else 
                        r1 = (1 - 2 * (1 - r1) * (1 - r2)) * 255;

                    if (g1 < 0.5) 
                        g1 = 2 * g1 * g2 * 255;
                    else 
                        g1 = (1 - 2 * (1 - g1) * (1 - g2)) * 255;

                    if (b1 < 0.5) 
                        b1 = 2 * b1 * b2 * 255;
                    else 
                        b1 = (1 - 2 * (1 - b1) * (1 - b2)) * 255;


                    if (r1 > 255) r1 = 255;
                    else if (r1 < 0) r1 = 0;

                    if (g1 > 255) g1 = 255;
                    else if (g1 < 0) g1 = 0;

                    if (b1 > 255) b1 = 255;
                    else if (b1 < 0) b1 = 0;

                    k1 = Color.FromArgb((int)r1, (int)g1, (int)b1);

                    img3.SetPixel(x, y, k1);
                }
            }
            pictureBox2.Refresh();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Bitmap img1 = (Bitmap)pictureBox1.Image;
            Bitmap img2 = (Bitmap)pictureBox3.Image;
            Bitmap img3 = (Bitmap)pictureBox2.Image;

            for (int x = 0; x < szer; x++)
            {
                for (int y = 0; y < wys; y++)
                {
                    k1 = img1.GetPixel(x, y);
                    k2 = img2.GetPixel(x, y);

                    r1 = k1.R;
                    g1 = k1.G;
                    b1 = k1.B;
                    r2 = k2.R;
                    g2 = k2.G;
                    b2 = k2.B;

                    r1 /= 255;
                    g1 /= 255;
                    b1 /= 255;
                    r2 /= 255;
                    g2 /= 255;
                    b2 /= 255;

                    if (r2 < 0.0) 
                        r1 = 2 * r1 * r2 * 255;
                    else
                        r1 = (1 - 2 * (1 - r1) * (1 - r2)) * 255;

                    if (g2 < 0.0) 
                        g1 = 2 * g1 * g2 * 255;
                    else 
                        g1 = (1 - 2 * (1 - g1) * (1 - g2)) * 255;

                    if (b2 < 0.0)
                        b1 = 2 * b1 * b2 * 255;
                    else
                        b1 = (1 - 2 * (1 - b1) * (1 - b2)) * 255;

                    if (r1 > 255) r1 = 255;
                    else if (r1 < 0) r1 = 0;

                    if (g1 > 255) g1 = 255;
                    else if (g1 < 0) g1 = 0;

                    if (b1 > 255) b1 = 255;
                    else if (b1 < 0) b1 = 0;

                    k1 = Color.FromArgb((int)r1, (int)g1, (int)b1);

                    img3.SetPixel(x, y, k1);
                }
            }
            pictureBox2.Refresh();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Bitmap img1 = (Bitmap)pictureBox1.Image;
            Bitmap img2 = (Bitmap)pictureBox3.Image;
            Bitmap img3 = (Bitmap)pictureBox2.Image;

            for (int x = 0; x < szer; x++)
            {
                for (int y = 0; y < wys; y++)
                {
                    k1 = img1.GetPixel(x, y);
                    k2 = img2.GetPixel(x, y);

                    r1 = k1.R;
                    g1 = k1.G;
                    b1 = k1.B;
                    r2 = k2.R;
                    g2 = k2.G;
                    b2 = k2.B;

                    r1 /= 255;
                    g1 /= 255;
                    b1 /= 255;
                    r2 /= 255;
                    g2 /= 255;
                    b2 /= 255;

                    if (r2 < 0.5) 
                        r1 = (2 * r1 * r2 + Math.Pow(r1, 2) * (1 - 2 * r2)) * 255;
                    else 
                        r1 = (r1 * (2 * r2 - 1) + (2 * r1) * (1 - r2)) * 255;

                    if (g2 < 0.5) 
                        g1 = (2 * g1 * g2 + Math.Pow(g1, 2) * (1 - 2 * g2)) * 255;
                    else 
                        g1 = (g1 * (2 * g2 - 1) + (2 * g1) * (1 - g2)) * 255;

                    if (b2 < 0.5) 
                        b1 = (2 * b1 * b2 + Math.Pow(b1, 2) * (1 - 2 * b2)) * 255;
                    else 
                        b1 = (b1 * (2 * b2 - 1) + (2 * b1) * (1 - b2)) * 255;


                    if (r1 > 255) r1 = 255;
                    else if (r1 < 0) r1 = 0;

                    if (g1 > 255) g1 = 255;
                    else if (g1 < 0) g1 = 0;

                    if (b1 > 255) b1 = 255;
                    else if (b1 < 0) b1 = 0;

                    k1 = Color.FromArgb((int)r1, (int)g1, (int)b1);

                    img3.SetPixel(x, y, k1);
                }
            }
            pictureBox2.Refresh();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Bitmap img1 = (Bitmap)pictureBox1.Image;
            Bitmap img2 = (Bitmap)pictureBox3.Image;
            Bitmap img3 = (Bitmap)pictureBox2.Image;

            for (int x = 0; x < szer; x++)
            {
                for (int y = 0; y < wys; y++)
                {
                    k1 = img1.GetPixel(x, y);
                    k2 = img2.GetPixel(x, y);

                    r1 = k1.R;
                    g1 = k1.G;
                    b1 = k1.B;
                    r2 = k2.R;
                    g2 = k2.G;
                    b2 = k2.B;

                    r1 /= 255;
                    g1 /= 255;
                    b1 /= 255;
                    r2 /= 255;
                    g2 /= 255;
                    b2 /= 255;

                    r1 = (r1 / (1 - r2)) * 255;
                    g1 = (g1 / (1 - g2)) * 255;
                    b1 = (b1 / (1 - b2)) * 255;

                    if (r1 > 255) r1 = 255;
                    else if (r1 < 0) r1 = 0;

                    if (g1 > 255) g1 = 255;
                    else if (g1 < 0) g1 = 0;

                    if (b1 > 255) b1 = 255;
                    else if (b1 < 0) b1 = 0;

                    k1 = Color.FromArgb((int)r1, (int)g1, (int)b1);

                    img3.SetPixel(x, y, k1);
                }
            }
            pictureBox2.Refresh();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Bitmap img1 = (Bitmap)pictureBox1.Image;
            Bitmap img2 = (Bitmap)pictureBox3.Image;
            Bitmap img3 = (Bitmap)pictureBox2.Image;

            for (int x = 0; x < szer; x++)
            {
                for (int y = 0; y < wys; y++)
                {
                    k1 = img1.GetPixel(x, y);
                    k2 = img2.GetPixel(x, y);

                    r1 = k1.R;
                    g1 = k1.G;
                    b1 = k1.B;
                    r2 = k2.R;
                    g2 = k2.G;
                    b2 = k2.B;

                    r1 /= 255;
                    g1 /= 255;
                    b1 /= 255;
                    r2 /= 255;
                    g2 /= 255;
                    b2 /= 255;

                    r1 = (1 - (1 - r1) / r2) * 255;
                    g1 = (1 - (1 - g1) / g2) * 255;
                    b1 = (1 - (1 - b1) / b2) * 255;


                    if (r1 > 255) r1 = 255;
                    else if (r1 < 0) r1 = 0;

                    if (g1 > 255) g1 = 255;
                    else if (g1 < 0) g1 = 0;

                    if (b1 > 255) b1 = 255;
                    else if (b1 < 0) b1 = 0;

                    k1 = Color.FromArgb((int)r1, (int)g1, (int)b1);

                    img3.SetPixel(x, y, k1);
                }
            }
            pictureBox2.Refresh();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Bitmap img1 = (Bitmap)pictureBox1.Image;
            Bitmap img2 = (Bitmap)pictureBox3.Image;
            Bitmap img3 = (Bitmap)pictureBox2.Image;

            for (int x = 0; x < szer; x++)
            {
                for (int y = 0; y < wys; y++)
                {
                    k1 = img1.GetPixel(x, y);
                    k2 = img2.GetPixel(x, y);

                    r1 = k1.R;
                    g1 = k1.G;
                    b1 = k1.B;
                    r2 = k2.R;
                    g2 = k2.G;
                    b2 = k2.B;

                    r1 /= 255;
                    g1 /= 255;
                    b1 /= 255;
                    r2 /= 255;
                    g2 /= 255;
                    b2 /= 255;

                    r1 = (Math.Pow(r1, 2) / (1 - r2)) * 255;
                    g1 = (Math.Pow(g1, 2) / (1 - g2)) * 255;
                    b1 = (Math.Pow(b1, 2) / (1 - b2)) * 255;


                    if (r1 > 255) r1 = 255;
                    else if (r1 < 0) r1 = 0;

                    if (g1 > 255) g1 = 255;
                    else if (g1 < 0) g1 = 0;

                    if (b1 > 255) b1 = 255;
                    else if (b1 < 0) b1 = 0;

                    k1 = Color.FromArgb((int)r1, (int)g1, (int)b1);

                    img3.SetPixel(x, y, k1);
                }
            }
            pictureBox2.Refresh();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Bitmap img1 = (Bitmap)pictureBox1.Image;
            Bitmap img2 = (Bitmap)pictureBox3.Image;
            Bitmap img3 = (Bitmap)pictureBox2.Image;

            double a = 0.5;

            for (int x = 0; x < szer; x++)
            {
                for (int y = 0; y < wys; y++)
                {
                    k1 = img1.GetPixel(x, y);
                    k2 = img2.GetPixel(x, y);

                    r1 = k1.R;
                    g1 = k1.G;
                    b1 = k1.B;
                    r2 = k2.R;
                    g2 = k2.G;
                    b2 = k2.B;

                    r1 /= 255;
                    g1 /= 255;
                    b1 /= 255;
                    r2 /= 255;
                    g2 /= 255;
                    b2 /= 255;

                    r1 = ((1 - a) * r2 + a * r1) * 255;
                    g1 = ((1 - a) * g2 + a * g1) * 255;
                    b1 = ((1 - a) * b2 + a * b1) * 255;


                    if (r1 > 255) r1 = 255;
                    else if (r1 < 0) r1 = 0;

                    if (g1 > 255) g1 = 255;
                    else if (g1 < 0) g1 = 0;

                    if (b1 > 255) b1 = 255;
                    else if (b1 < 0) b1 = 0;

                    k1 = Color.FromArgb((int)r1, (int)g1, (int)b1);

                    img3.SetPixel(x, y, k1);
                }
            }
            pictureBox2.Refresh();
        }


       

    
    }
}


