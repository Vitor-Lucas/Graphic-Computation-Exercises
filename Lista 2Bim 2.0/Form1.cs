using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista_2Bim_2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Pen PenPatterned(int r, int g, int b, float[] pattern)
        {
            Pen pen = new Pen(Color.FromArgb(r, g, b));
            pen.DashPattern = pattern;
            return pen;
        }

        Pen pen(int r, int g, int b)
        {
            Pen pen = new Pen(Color.FromArgb(r, g, b));
            return pen;
        }
        void DrawLine(PaintEventArgs e, Pen pen, int x0, int y0, int x1, int y1)
        {
            e.Graphics.DrawLine(pen, x0, y0, x1, y1);
        }
    

        void DrawRectangle(PaintEventArgs e, Pen pen, int x, int y, int l, int h)
        {
            e.Graphics.DrawRectangle(pen, x, y, l, h);
        }

        void DrawA1(PaintEventArgs e, Pen pen, int x,int y,int x0, int y0)
        {
            float[] pattern = { 5, 2, 1, 2 };
            pen = PenPatterned(0, 0, 0, pattern);
            DrawLine(e, pen, x, 100, x+25, 100);//reta horizontal superior -- ajustar o comprimento dessa
            DrawLine(e, pen, x, y, x0, y0+50);//reta vertical esquerda
            DrawLine(e,pen , x+25, y, x0+25, y0);//reta vertical direita - ajustar essa mais para o lado
            DrawLine(e, pen, 150,200,250,200);//reta horizontal media
            DrawLine(e, pen, 100,250,300,250);//reta horizontal inferior

        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            DrawA1(e, pen(255, 0, 0), 100, 100, 100, 200);
            
            //float[] pattern = { 5, 1, 5, 1 };


            //DrawRectangle(e, pen, 200, 100, 10, 10);
        }
    }
}
