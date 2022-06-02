using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab6
{
    public partial class Form1 : Form
    {
        int szer, wys;
        private int[] red = null;
        private int[] green = null;
        private int[] blue = null;

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
            Bitmap img1 = (Bitmap)pictureBox1.Image;
            Color k;
            int r, g, b;
            red = new int[256];
            green = new int[256];
            blue = new int[256];
            for (int x = 0; x < szer; x++)
            {
                for (int y = 0; y < wys; y++)
                {
                    k = img1.GetPixel(x, y);
                    r = k.R;
                    g = k.G;
                    b = k.B;

                    red[r]++;
                    green[g]++;
                    blue[b]++;
                }
            }
            chart1.Series["Red"].Points.Clear();
            chart1.Series["Green"].Points.Clear();
            chart1.Series["Blue"].Points.Clear();
            for (int i = 0; i < 256; i++)
            {
                chart1.Series["Red"].Points.AddXY(i, red[i]);
                chart1.Series["Green"].Points.AddXY(i, green[i]);
                chart1.Series["Blue"].Points.AddXY(i, blue[i]);
            }
            chart1.Invalidate();

        }

        private int[] calculateLUT(int[] values, int size)
        {
            double minValue = 0;
            for (int i = 0; i < 256; i++)
            {
                if (values[i] != 0)
                {
                    minValue = values[i];
                    break;
                }
            }
            int[] result = new int[256];
            double sum = 0;
            for (int i = 0; i < 256; i++)
            {
                sum += values[i];
                result[i] = (int)(((sum - minValue) / (size - minValue)) * 255.0);
            }

            return result;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bitmap img1 = (Bitmap)pictureBox1.Image;
            Bitmap img2 = (Bitmap)pictureBox2.Image;
            Color k;
            int r, g, b;

            int[] LUTred = calculateLUT(red, szer * wys);
            int[] LUTgreen = calculateLUT(green, szer * wys);
            int[] LUTblue = calculateLUT(blue, szer * wys);

            red = new int[256];
            green = new int[256];
            blue = new int[256];

            for (int x = 0; x < szer; x++)
            {
                for (int y = 0; y < wys; y++)
                {
                    k = img1.GetPixel(x, y);
                    r = k.R;
                    g = k.G;
                    b = k.B;

                    k = Color.FromArgb(LUTred[r], LUTgreen[g], LUTblue[b]);
                    img2.SetPixel(x, y, k);

                    red[r]++;
                    green[g]++;
                    blue[b]++;
                }
            }
            pictureBox2.Refresh();

            chart2.Series["Red"].Points.Clear();
            chart2.Series["Green"].Points.Clear();
            chart2.Series["Blue"].Points.Clear();
            for (int i = 0; i < 256; i++)
            {
                chart2.Series["Red"].Points.AddXY(i, LUTred[i]);
                chart2.Series["Green"].Points.AddXY(i, LUTgreen[i]);
                chart2.Series["Blue"].Points.AddXY(i, LUTblue[i]);
            }
            chart1.Invalidate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bitmap img1 = (Bitmap)pictureBox1.Image;
            Bitmap img2 = (Bitmap)pictureBox2.Image;
            Color k;
            int r, g, b;

            int[] LUTred = calculateLUT2(red);
            int[] LUTgreen = calculateLUT2(green);
            int[] LUTblue = calculateLUT2(blue);

            red = new int[256];
            green = new int[256];
            blue = new int[256];

            for (int x = 0; x < szer; x++)
            {
                for (int y = 0; y < wys; y++)
                {
                    k = img1.GetPixel(x, y);
                    r = k.R;
                    g = k.G;
                    b = k.B;

                    k = Color.FromArgb(LUTred[r], LUTgreen[g], LUTblue[b]);
                    img2.SetPixel(x, y, k);

                    red[r]++;
                    green[g]++;
                    blue[b]++;
                }
            }
            pictureBox2.Refresh();

            chart2.Series["Red"].Points.Clear();
            chart2.Series["Green"].Points.Clear();
            chart2.Series["Blue"].Points.Clear();
            for (int i = 0; i < 256; i++)
            {
                chart2.Series["Red"].Points.AddXY(i, LUTred[i]);
                chart2.Series["Green"].Points.AddXY(i, LUTgreen[i]);
                chart2.Series["Blue"].Points.AddXY(i, LUTblue[i]);
            }
            chart2.Invalidate();
        }

        private int[] calculateLUT2(int[] values)
        {
            int minValue = 0;
            for (int i = 0; i < 256; i++)
            {
                if (values[i] != 0)
                {
                    minValue = i;
                    break;
                }
            }

            int maxValue = 255;
            for (int i = 255; i >= 0; i--)
            {
                if (values[i] != 0)
                {
                    maxValue = i;
                    break;
                }
            }
            int[] result = new int[256];
            double a = 255.0 / (maxValue - minValue);
            for (int i = 0; i < 256; i++)
            {
                result[i] = (int)(a * (i - minValue));
            }

            return result;
        }
        
    }
}
