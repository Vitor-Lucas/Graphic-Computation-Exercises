using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Line_Drawer
{
    public partial class Form1 : Form
    {
        List<Line> lines;
        int click_count = 0;

        int temp_x;
        int temp_y;

        int mouse_x;
        int mouse_y;
        bool draw_to_mouse;

        int r = 0;
        int g = 0;
        int b = 0;

        public Form1()
        {
            InitializeComponent();
        }
        Pen GetPatternedPen(int r, int g, int b, float[] pattern)
        {
            Pen pen = new Pen(Color.FromArgb(r, g, b));
            pen.DashPattern = pattern;
            return pen;
        }
        void DrawLine(PaintEventArgs e, Pen pen, Line line)
        {
            int x0 = line.x0;
            int y0 = line.y0;
            int x1 = line.x1;
            int y1 = line.y1;

            e.Graphics.DrawLine(pen, x0, y0, x1, y1);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            lines = new List<Line>();
        }
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            click_count++;
            if(click_count % 2 == 1)
            {
                temp_x = e.X;
                temp_y = e.Y;
                draw_to_mouse = true;
            }
            else
            {
                draw_to_mouse = false;
                lines.Add(new Line(temp_x, temp_y, mouse_x,mouse_y));
            }
            Invalidate();
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            float[] pattern = {1};
            Pen pen = GetPatternedPen(r,b,g,pattern);

            foreach (Line line in lines)
            {
                DrawLine(e, pen, line);
            }

            if (draw_to_mouse)
            {
                Line mouse_line= new Line(temp_x,temp_y, mouse_x, mouse_y);
                DrawLine(e,pen,mouse_line);
            }
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            mouse_x = e.X; 
            mouse_y = e.Y;
            if(draw_to_mouse)
                Invalidate();
        }

    }
    public class Line
    {
        public int x0, y0;
        public int x1, y1;
        public Line(int x0, int y0, int x1, int y1)
        {
            this.x0 = x0; this.y0 = y0;
            this.x1 = x1; this.y1 = y1;
        }
    }

}
