/********************************************************************
*Colegio Técnico Antônio Teixeira Fernandes (Univap)
*Curso Técnico em Informática - Data de Entrega: 04 / 04 / 2024
* Autores do Projeto: Vitor Lucas Kohls Correa
*                     Isabelly Pacheco Marinho
*
* Turma: 3F
* Atividade Proposta em aula
********************************************************************/

using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lista_2BIM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        void DrawLine(int x0, int y0, int x1, int y1, Pen pen, PaintEventArgs e)
        {
            e.Graphics.DrawLine(pen, x0, y0, x1, y1);
        }
        Pen PenPatterned(int r, int g, int b, float[] pattern)
        {
            Pen pen = new Pen(Color.FromArgb(r,g,b));
            pen.DashPattern = pattern;
            return pen;
        }
        Pen PenPatterned(int r, int g, int b)
        {
            Pen pen = new Pen(Color.FromArgb(r, g, b));
            return pen;
        }
        void DrawRectangle(PaintEventArgs e, Pen pen, int x, int y, int l, int h)
        {
            e.Graphics.DrawRectangle(pen, x, y, l, h);
        }
        public void DrawTriangle(PaintEventArgs e, Pen pen, int x0, int y0, int x1, int y1, int x2, int y2)
        {
            //Computes the Euclidian distance between the coords
            float a = (float) Math.Sqrt(Math.Pow(x0 - x1,2) + Math.Pow(y0 - y1,2));
            float b = (float) Math.Sqrt(Math.Pow(x1 - x2,2) + Math.Pow(y1 - y2,2));
            float c = (float) Math.Sqrt(Math.Pow(x2 - x0,2) + Math.Pow(y2 - y0,2));

            if (a == 0 || b == 0 || c == 0)
            {
                MessageBox.Show("Not a Triangle.");
                return;
            }

            if (a == b && b == c)
                label1.Text = "Equilateral";
            else if(a == b && b != c)
                label1.Text = "Isoceles";
            else
                label1.Text = "Scalene";

            DrawLine(x0, y0, x1, y1, pen, e);
            DrawLine(x1, y1, x2, y2, pen, e);
            DrawLine(x2, y2, x0, y0, pen, e);
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            float[] pattern = {5,1,5,1};
            Pen pen = PenPatterned(0, 0, 0, pattern);
            DrawLine(100,100,400,400,pen,e);

            DrawRectangle(e,pen, 200,100,10,10);

            DrawTriangle(e,pen, 250,130, 100, 90, 160, 90);
        }
    }
}
