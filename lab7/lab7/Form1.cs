using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
 

namespace lab7
{
    public partial class Form1 : Form
    {
        int szer = 0, wys = 0;
        Color k, k1, k2, k3, k4, k5, k6, k7, k8, k9;
        int r, g, b;
        int filtr;
        int f1, f2, f3, f4, f5, f6, f7, f8, f9;

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
            Bitmap img1 = (Bitmap)pictureBox1.Image;
            Bitmap img2 = (Bitmap)pictureBox2.Image;
            f1 = 1;
            f2 = 1;
            f3 = 1;
            f4 = 1;
            f5 = 1;
            f6 = 1;
            f7 = 1;
            f8 = 1;
            f9 = 1;
            filtr = f1 + f2 + f3 + f4 + f5 + f6 + f7 + f8 + f9;

            for (int x = 0; x < szer; x++)
            {
                for (int y = 0; y < wys; y++)
                {
                    if (x > 0 && y > 0 && x < szer - 1 && y < wys - 1)
                    {
                        k1 = img1.GetPixel(x - 1, y - 1);
                        k2 = img1.GetPixel(x, y - 1);
                        k3 = img1.GetPixel(x + 1, y - 1);
                        k4 = img1.GetPixel(x - 1, y);
                        k5 = img1.GetPixel(x, y);
                        k6 = img1.GetPixel(x + 1, y);
                        k7 = img1.GetPixel(x - 1, y + 1);
                        k8 = img1.GetPixel(x, y + 1);
                        k9 = img1.GetPixel(x + 1, y + 1);

                        r = (k1.R * f1 + k2.R * f2 + k3.R * f3 + k4.R * f4 + k5.R * f5 + k6.R * f6 + k7.R * f7 + k8.R * f8 + k9.R * f9) / filtr;
                        g = (k1.G * f1 + k2.G * f2 + k3.G * f3 + k4.G * f4 + k5.G * f5 + k6.G * f6 + k7.G * f7 + k8.G * f8 + k9.G * f9) / filtr;
                        b = (k1.B * f1 + k2.B * f2 + k3.B * f3 + k4.B * f4 + k5.B * f5 + k6.B * f6 + k7.B * f7 + k8.B * f8 + k9.B * f9) / filtr;
                       
                        


                        if (r > 255) r = 255;
                        else if (r < 0) r = 0;

                        if (g > 255) g = 255;
                        else if (g < 0) g = 0;

                        if (b > 255) b = 255;
                        else if (b < 0) b = 0;

                        k = Color.FromArgb(r, g, b);
                        img2.SetPixel(x, y, k);
                    }
                    else
                    {
                        k1 = img1.GetPixel(x, y);
                        r = k1.R;
                        g = k1.G;
                        b = k1.B;
                        k = Color.FromArgb(r, g, b);
                        img2.SetPixel(x, y, k);
                    }
                }
            }
            pictureBox2.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bitmap img1 = (Bitmap)pictureBox1.Image;
            Bitmap img2 = (Bitmap)pictureBox2.Image;
            f1 = 1;
            f2 = 2;
            f3 = 1;
            f4 = 2;
            f5 = 4;
            f6 = 2;
            f7 = 1;
            f8 = 2;
            f9 = 1;
            filtr = f1 + f2 + f3 + f4 + f5 + f6 + f7 + f8 + f9;

            for (int x = 0; x < szer; x++)
            {
                for (int y = 0; y < wys; y++)
                {
                    if (x > 0 && y > 0 && x < szer - 1 && y < wys - 1)
                    {
                        k1 = img1.GetPixel(x - 1, y - 1);
                        k2 = img1.GetPixel(x, y - 1);
                        k3 = img1.GetPixel(x + 1, y - 1);
                        k4 = img1.GetPixel(x - 1, y);
                        k5 = img1.GetPixel(x, y);
                        k6 = img1.GetPixel(x + 1, y);
                        k7 = img1.GetPixel(x - 1, y + 1);
                        k8 = img1.GetPixel(x, y + 1);
                        k9 = img1.GetPixel(x + 1, y + 1);

                        
                        r = (k1.R * f1 + k2.R * f2 + k3.R * f3 + k4.R * f4 + k5.R * f5 + k6.R * f6 + k7.R * f7 + k8.R * f8 + k9.R * f9) / filtr;
                        g = (k1.G * f1 + k2.G * f2 + k3.G * f3 + k4.G * f4 + k5.G * f5 + k6.G * f6 + k7.G * f7 + k8.G * f8 + k9.G * f9) / filtr;
                        b = (k1.B * f1 + k2.B * f2 + k3.B * f3 + k4.B * f4 + k5.B * f5 + k6.B * f6 + k7.B * f7 + k8.B * f8 + k9.B * f9) / filtr;
                        


                        if (r > 255) r = 255;
                        else if (r < 0) r = 0;

                        if (g > 255) g = 255;
                        else if (g < 0) g = 0;

                        if (b > 255) b = 255;
                        else if (b < 0) b = 0;

                        k = Color.FromArgb(r, g, b);
                        img2.SetPixel(x, y, k);
                    }
                    else
                    {
                        k1 = img1.GetPixel(x, y);
                        r = k1.R;
                        g = k1.G;
                        b = k1.B;
                        k = Color.FromArgb(r, g, b);
                        img2.SetPixel(x, y, k);
                    }
                }
            }
            pictureBox2.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bitmap img1 = (Bitmap)pictureBox1.Image;
            Bitmap img2 = (Bitmap)pictureBox2.Image;
            f1 = 0;
            f2 = 0;
            f3 = 0;
            f4 = 0;
            f5 = 1;
            f6 = -1;
            f7 = 0;
            f8 = 0;
            f9 = 0;
            filtr = f1 + f2 + f3 + f4 + f5 + f6 + f7 + f8 + f9;

            for (int x = 0; x < szer; x++)
            {
                for (int y = 0; y < wys; y++)
                {
                    if (x > 0 && y > 0 && x < szer - 1 && y < wys - 1)
                    {
                        k1 = img1.GetPixel(x - 1, y - 1);
                        k2 = img1.GetPixel(x, y - 1);
                        k3 = img1.GetPixel(x + 1, y - 1);
                        k4 = img1.GetPixel(x - 1, y);
                        k5 = img1.GetPixel(x, y);
                        k6 = img1.GetPixel(x + 1, y);
                        k7 = img1.GetPixel(x - 1, y + 1);
                        k8 = img1.GetPixel(x, y + 1);
                        k9 = img1.GetPixel(x + 1, y + 1);

                        r = (k1.R * f1 + k2.R * f2 + k3.R * f3 + k4.R * f4 + k5.R * f5 + k6.R * f6 + k7.R * f7 + k8.R * f8 + k9.R * f9);
                        g = (k1.G * f1 + k2.G * f2 + k3.G * f3 + k4.G * f4 + k5.G * f5 + k6.G * f6 + k7.G * f7 + k8.G * f8 + k9.G * f9);
                        b = (k1.B * f1 + k2.B * f2 + k3.B * f3 + k4.B * f4 + k5.B * f5 + k6.B * f6 + k7.B * f7 + k8.B * f8 + k9.B * f9);
                        


                        if (r > 255) r = 255;
                        else if (r < 0) r = 0;

                        if (g > 255) g = 255;
                        else if (g < 0) g = 0;

                        if (b > 255) b = 255;
                        else if (b < 0) b = 0;

                        k = Color.FromArgb(r, g, b);
                        img2.SetPixel(x, y, k);
                    }
                    else
                    {
                        k1 = img1.GetPixel(x, y);
                        r = k1.R;
                        g = k1.G;
                        b = k1.B;
                        k = Color.FromArgb(r, g, b);
                        img2.SetPixel(x, y, k);
                    }
                }
            }
            pictureBox2.Refresh();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Bitmap img1 = (Bitmap)pictureBox1.Image;
            Bitmap img2 = (Bitmap)pictureBox2.Image;
            f1 = -1;
            f2 = -1;
            f3 = -1;
            f4 = 0;
            f5 = 0;
            f6 = 0;
            f7 = 1;
            f8 = 1;
            f9 = 1;
            filtr = f1 + f2 + f3 + f4 + f5 + f6 + f7 + f8 + f9;

            for (int x = 0; x < szer; x++)
            {
                for (int y = 0; y < wys; y++)
                {
                    if (x > 0 && y > 0 && x < szer - 1 && y < wys - 1)
                    {
                        k1 = img1.GetPixel(x - 1, y - 1);
                        k2 = img1.GetPixel(x, y - 1);
                        k3 = img1.GetPixel(x + 1, y - 1);
                        k4 = img1.GetPixel(x - 1, y);
                        k5 = img1.GetPixel(x, y);
                        k6 = img1.GetPixel(x + 1, y);
                        k7 = img1.GetPixel(x - 1, y + 1);
                        k8 = img1.GetPixel(x, y + 1);
                        k9 = img1.GetPixel(x + 1, y + 1);

                        r = (k1.R * f1 + k2.R * f2 + k3.R * f3 + k4.R * f4 + k5.R * f5 + k6.R * f6 + k7.R * f7 + k8.R * f8 + k9.R * f9);
                        g = (k1.G * f1 + k2.G * f2 + k3.G * f3 + k4.G * f4 + k5.G * f5 + k6.G * f6 + k7.G * f7 + k8.G * f8 + k9.G * f9);
                        b = (k1.B * f1 + k2.B * f2 + k3.B * f3 + k4.B * f4 + k5.B * f5 + k6.B * f6 + k7.B * f7 + k8.B * f8 + k9.B * f9);
                                             


                        if (r > 255) r = 255;
                        else if (r < 0) r = 0;

                        if (g > 255) g = 255;
                        else if (g < 0) g = 0;

                        if (b > 255) b = 255;
                        else if (b < 0) b = 0;

                        k = Color.FromArgb(r, g, b);
                        img2.SetPixel(x, y, k);
                    }
                    else
                    {
                        k1 = img1.GetPixel(x, y);
                        r = k1.R;
                        g = k1.G;
                        b = k1.B;
                        k = Color.FromArgb(r, g, b);
                        img2.SetPixel(x, y, k);
                    }
                }
            }
            pictureBox2.Refresh();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Bitmap img1 = (Bitmap)pictureBox1.Image;
            Bitmap img2 = (Bitmap)pictureBox2.Image;
            f1 = 1;
            f2 = 2;
            f3 = 1;
            f4 = 0;
            f5 = 0;
            f6 = 0;
            f7 = -1;
            f8 = -2;
            f9 = -1;
            filtr = f1 + f2 + f3 + f4 + f5 + f6 + f7 + f8 + f9;

            for (int x = 0; x < szer; x++)
            {
                for (int y = 0; y < wys; y++)
                {
                    if (x > 0 && y > 0 && x < szer - 1 && y < wys - 1)
                    {
                        k1 = img1.GetPixel(x - 1, y - 1);
                        k2 = img1.GetPixel(x, y - 1);
                        k3 = img1.GetPixel(x + 1, y - 1);
                        k4 = img1.GetPixel(x - 1, y);
                        k5 = img1.GetPixel(x, y);
                        k6 = img1.GetPixel(x + 1, y);
                        k7 = img1.GetPixel(x - 1, y + 1);
                        k8 = img1.GetPixel(x, y + 1);
                        k9 = img1.GetPixel(x + 1, y + 1);

                        r = (k1.R * f1 + k2.R * f2 + k3.R * f3 + k4.R * f4 + k5.R * f5 + k6.R * f6 + k7.R * f7 + k8.R * f8 + k9.R * f9);
                        g = (k1.G * f1 + k2.G * f2 + k3.G * f3 + k4.G * f4 + k5.G * f5 + k6.G * f6 + k7.G * f7 + k8.G * f8 + k9.G * f9);
                        b = (k1.B * f1 + k2.B * f2 + k3.B * f3 + k4.B * f4 + k5.B * f5 + k6.B * f6 + k7.B * f7 + k8.B * f8 + k9.B * f9);                       
                                                 


                        if (r > 255) r = 255;
                        else if (r < 0) r = 0;

                        if (g > 255) g = 255;
                        else if (g < 0) g = 0;

                        if (b > 255) b = 255;
                        else if (b < 0) b = 0;

                        k = Color.FromArgb(r, g, b);
                        img2.SetPixel(x, y, k);
                    }
                    else
                    {
                        k1 = img1.GetPixel(x, y);
                        r = k1.R;
                        g = k1.G;
                        b = k1.B;
                        k = Color.FromArgb(r, g, b);
                        img2.SetPixel(x, y, k);
                    }
                }
            }
            pictureBox2.Refresh();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Bitmap img1 = (Bitmap)pictureBox1.Image;
            Bitmap img2 = (Bitmap)pictureBox2.Image;
            f1 = 0;
            f2 = -1;
            f3 = 0;
            f4 = -1;
            f5 = 4;
            f6 = -1;
            f7 = 0;
            f8 = -1;
            f9 = 0;
            filtr = f1 + f2 + f3 + f4 + f5 + f6 + f7 + f8 + f9;

            for (int x = 0; x < szer; x++)
            {
                for (int y = 0; y < wys; y++)
                {
                    if (x > 0 && y > 0 && x < szer - 1 && y < wys - 1)
                    {
                        k1 = img1.GetPixel(x - 1, y - 1);
                        k2 = img1.GetPixel(x, y - 1);
                        k3 = img1.GetPixel(x + 1, y - 1);
                        k4 = img1.GetPixel(x - 1, y);
                        k5 = img1.GetPixel(x, y);
                        k6 = img1.GetPixel(x + 1, y);
                        k7 = img1.GetPixel(x - 1, y + 1);
                        k8 = img1.GetPixel(x, y + 1);
                        k9 = img1.GetPixel(x + 1, y + 1);

                        r = (k1.R * f1 + k2.R * f2 + k3.R * f3 + k4.R * f4 + k5.R * f5 + k6.R * f6 + k7.R * f7 + k8.R * f8 + k9.R * f9);
                        g = (k1.G * f1 + k2.G * f2 + k3.G * f3 + k4.G * f4 + k5.G * f5 + k6.G * f6 + k7.G * f7 + k8.G * f8 + k9.G * f9);
                        b = (k1.B * f1 + k2.B * f2 + k3.B * f3 + k4.B * f4 + k5.B * f5 + k6.B * f6 + k7.B * f7 + k8.B * f8 + k9.B * f9);



                        if (r > 255) r = 255;
                        else if (r < 0) r = 0;

                        if (g > 255) g = 255;
                        else if (g < 0) g = 0;

                        if (b > 255) b = 255;
                        else if (b < 0) b = 0;

                        k = Color.FromArgb(r, g, b);
                        img2.SetPixel(x, y, k);
                    }
                    else
                    {
                        k1 = img1.GetPixel(x, y);
                        r = k1.R;
                        g = k1.G;
                        b = k1.B;
                        k = Color.FromArgb(r, g, b);
                        img2.SetPixel(x, y, k);
                    }
                }
            }
            pictureBox2.Refresh();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Bitmap img1 = (Bitmap)pictureBox1.Image;
            Bitmap img2 = (Bitmap)pictureBox2.Image;
            
            Color[,] k = new Color[3, 3];
            int r, g, b, a;
            int[] red = new int[9];
            int[] green = new int[9];
            int[] blue = new int[9];

            for (int x = 0; x < szer; x++)
            {
                for (int y = 0; y < wys; y++)
                {
                    a = 0;
                    if (x > 0 && y > 0 && x < szer - 1 && y < wys - 1)
                    {
                        for (int i = -1; i < 2; i++)
                        {
                            for (int j = -1; j < 2; j++)
                            {
                                k[i + 1, j + 1] = img1.GetPixel(x + i, y + j);
                                red[a] = k[i + 1, j + 1].R;
                                green[a] = k[i + 1, j + 1].G;
                                blue[a] = k[i + 1, j + 1].B;
                                a++;
                            }
                        }
                    }
                    r = red.Min();
                    g = green.Min();
                    b = blue.Min();
                    k1 = Color.FromArgb(r, g, b);
                    img2.SetPixel(x, y, k1);
                }
            }
            pictureBox2.Refresh();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Bitmap img1 = (Bitmap)pictureBox1.Image;
            Bitmap img2 = (Bitmap)pictureBox2.Image;

            Color[,] k = new Color[3, 3];
            int r, g, b, a;
            int[] red = new int[9];
            int[] green = new int[9];
            int[] blue = new int[9];

            for (int x = 0; x < szer; x++)
            {
                for (int y = 0; y < wys; y++)
                {
                    a = 0;
                    if (x > 0 && y > 0 && x < szer - 1 && y < wys - 1)
                    {
                        for (int i = -1; i < 2; i++)
                        {
                            for (int j = -1; j < 2; j++)
                            {
                                k[i + 1, j + 1] = img1.GetPixel(x + i, y + j);
                                red[a] = k[i + 1, j + 1].R;
                                green[a] = k[i + 1, j + 1].G;
                                blue[a] = k[i + 1, j + 1].B;
                                a++;
                            }
                        }
                    }
                    r = red.Max();
                    g = green.Max();
                    b = blue.Max();
                    k1 = Color.FromArgb(r, g, b);
                    img2.SetPixel(x, y, k1);
                }
            }
            pictureBox2.Refresh();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Bitmap img1 = (Bitmap)pictureBox1.Image;
            Bitmap img2 = (Bitmap)pictureBox2.Image;

            Color[,] k = new Color[3, 3];
            int r, g, b, a;
            int[] red = new int[9];
            int[] green = new int[9];
            int[] blue = new int[9];

            for (int x = 0; x < szer; x++)
            {
                for (int y = 0; y < wys; y++)
                {
                    a = 0;
                    if (x > 0 && y > 0 && x < szer - 1 && y < wys - 1)
                    {
                        for (int i = -1; i < 2; i++)
                        {
                            for (int j = -1; j < 2; j++)
                            {
                                k[i + 1, j + 1] = img1.GetPixel(x + i, y + j);
                                red[a] = k[i + 1, j + 1].R;
                                green[a] = k[i + 1, j + 1].G;
                                blue[a] = k[i + 1, j + 1].B;
                                a++;
                            }
                        }
                    }
                    Array.Sort(red);
                    Array.Sort(blue);
                    Array.Sort(green);
                    double r1 = red.Length / 2;
                    int tmpr = Convert.ToInt32(Math.Floor(r1));
                    r = red[tmpr];
                    double g1 = green.Length / 2;
                    int tmpg = Convert.ToInt32(Math.Floor(g1));
                    g = green[tmpg];
                    double b1 = blue.Length / 2;
                    int tmrb = Convert.ToInt32(Math.Floor(b1));
                    b = blue[tmpr];
                    img2.SetPixel(x, y, Color.FromArgb(r, g, b));
                }
            }
            pictureBox2.Refresh();
        }

       
    }
}
