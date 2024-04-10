using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Line_Drawer
{
    public partial class Form1 : Form
    {
        int click_count = 1;

        int first_x;
        int first_y;
        
        int second_x;
        int second_y;

        bool draw_line;

        float[] pattern;

        int r = 0;
        int g = 0;
        int b = 0;

        public Form1()
        {
            InitializeComponent();
        }
        float[] GetPattern(int index)
        {
            switch (index)
            {
                case 0:
                    return null;
                case 1:
                    return new float[] { 1 };
                case 2:
                    return new float[] { 5, 1 };
                case 3:
                    return new float[] { 5, 2, 1, 2 };
                case 4:
                    return new float[] { 5, 1, 1, 1, 1, 1 };
                default:
                    return new float[] { 1, 1 };
            }
        }
        int Distance(int x0, int y0, int x1, int y1)
        {
            return (int) Math.Sqrt(Math.Pow(x0 - x1, 2) + Math.Pow(y0 - y1, 2));
        }
        Pen GetPatternedPen(int r, int g, int b, float[] pattern)
        {
            int width = (int) widthUpDown.Value;
            Pen pen = new Pen(Color.FromArgb(r, g, b),width);
            pen.DashPattern = pattern;
            
            return pen;
        }
        void DrawLine(PaintEventArgs e, Pen pen, int x0, int y0, int x1, int y1)
        {
            e.Graphics.DrawLine(pen, x0, y0, x1, y1);
        }
        public void DrawRectangle(PaintEventArgs e, Pen pen, int x0, int y0, int x1, int y1)
        {
            DrawLine(e, pen, x0, y0, x1, y0);
            DrawLine(e, pen, x0, y0, x0, y1);
            DrawLine(e, pen, x0, y1, x1, y1);
            DrawLine(e, pen, x1, y0, x1, y1);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if(click_count % 2 == 1)
            {
                first_x = e.X;
                first_y = e.Y;
            }
            else
            {
                second_x = e.X;
                second_y = e.Y;
                draw_line = true;

                float m = (first_y - second_y) / (first_x - second_x);
                float b = first_y - m * first_x;

                functionLabel.Text = "f(x) = " + m + "x" + "+ "+b;
                distanceLabel.Text = "Distance: " + Distance(first_x,first_y,second_x,second_y);
                Invalidate();
            }

            click_count++;
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            float[] pattern = GetPattern(patternComboBox.SelectedIndex);
            if (pattern == null)
                return;

            Pen pen = GetPatternedPen(r,g,b,pattern);

            if (draw_line)
            {
                if (RectangleCheckBox.Checked)
                    DrawRectangle(e, pen, first_x, first_y, second_x, second_y);
                else
                    DrawLine(e, pen, first_x, first_y, second_x, second_y);
            }
        }

        private void widthUpDown_ValueChanged(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void RectangleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void patternComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void RedTextBox_TextChanged(object sender, EventArgs e)
        {
            if (RedTextBox.Text == "")
                RedTextBox.Text = "0";
            r = int.Parse(RedTextBox.Text);
            if (r < 0)
                r = 0;
            else if (r > 255)
                r = 255;
            Invalidate();
        }

        private void GreenTextBox_TextChanged(object sender, EventArgs e)
        {
            if (GreenTextBox.Text == "")
                GreenTextBox.Text = "0";
            g = int.Parse(GreenTextBox.Text);
            if (g < 0)
                g = 0;
            else if (g > 255)
                g = 255;
            Invalidate();
        }

        private void BlueTextBox_TextChanged(object sender, EventArgs e)
        {
            if (BlueTextBox.Text == "")
                BlueTextBox.Text = "0";
            b = int.Parse(BlueTextBox.Text);
            if (b < 0)
                b = 0;
            else if(b > 255)
                b = 255;
            Invalidate();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
