/*******************************************************************
* Colegio Técnico Antônio Teixeira Fernandes (Univap)
* Curso Técnico em Informática - Data de Entrega: 19 / 03 / 2024
* Autores do Projeto: Isabelly Pacheco Marinho
*                     Vitor Lucas Kohls Correa
*
* Turma: 3F
* Atividade Proposta em aula
********************************************************************/

using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lista_ICG_1BIM
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
        Pen GetPenColor(int r, int g, int b)
        {
            Color color = Color.FromArgb(r, g, b);
            return new Pen(color);
        }
        void DrawLineBreseham(int x0, int y0, int x1, int y1, Pen pen, PaintEventArgs e)
        {
            e.Graphics.DrawLine(pen, x0, y0, x1, y1);
        }
        public void Triangle(PaintEventArgs e, int x0, int y0, int x1, int y1, int x2, int y2, Pen pen)
        {
            DrawLineBreseham(x0, y0, x1, y1, pen, e);
            DrawLineBreseham(x1, y1, x2, y2, pen, e);
            DrawLineBreseham(x2, y2, x0, y0, pen, e);
        }
        public void Star(PaintEventArgs e, int[] x, int[] y, Pen pen)
        {
            for (int i = 0; i < x.Length - 1; i += 2)
            {
                DrawLineBreseham(x[i], y[i], x[i + 1], y[i + 1], pen, e);
            }
            DrawLineBreseham(x[0], y[0], x[x.Length - 1], y[y.Length - 1], pen, e);
        }
        public void Rectangle(PaintEventArgs e, int x0, int y0, int x1, int y1, Pen pen)
        {
            e.Graphics.DrawLine(pen, x0, y0, x1, y0);
            e.Graphics.DrawLine(pen, x0, y0, x0, y1);
            e.Graphics.DrawLine(pen, x0, y1, x1, y1);
            e.Graphics.DrawLine(pen, x1, y0, x1, y1);
        }
        public void Pentagon(PaintEventArgs e, int[] pontos, Pen pen)
        {
            int x0 = pontos[0];
            int y0 = pontos[1];

            int x1 = pontos[2];
            int y1 = pontos[3];

            int x2 = pontos[4];
            int y2 = pontos[5];

            e.Graphics.DrawLine(pen, x0, y0, x1, y1);
            e.Graphics.DrawLine(pen, x1, y1, x2, y2);


            e.Graphics.DrawLine(pen, x0 + 2*(x2 - x0), y0, x0, y0);
            e.Graphics.DrawLine(pen, x0 + 2*(x2 - x0), y0, x1 + 2*(x2 - x1), y1);

            e.Graphics.DrawLine(pen, x2, y2, x1 + 2 * (x2 - x1), y1);
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = GetPenColor(255, 0, 255);
            Triangle(e, 150, 100, 210, 200, 300, 100, pen);

            int[] x = new int[10];
            int[] y = new int[10];
            for (int i = 0; i < 10; i++)
            {
                x[i] = i * 100;
                y[i] = i * 100;
            }
            Star(e, x, y, pen);

            Rectangle(e, 300, 300, 500, 400, pen);

            //Lowest Coord
            int x0 = 20;
            int y0 = 40;

            //Middle Coord
            int x1 = 15;
            int y1 = 25;

            //Highest Coord
            int x2 = 30;
            int y2 = 15;

            int[] Coords = { x0,y0,x1,y1,x2,y2 };
            Pentagon(e, Coords, pen);
        }
    }
}
