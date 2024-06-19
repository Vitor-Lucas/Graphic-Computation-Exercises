/*Colegio Técnico Antônio Teixeira Fernandes (Univap)
 *Curso Técnico em Informática - Data de Entrega: 19 / 06 / 2024
 * Autores do Projeto: Vitor Lucas Kohls Correa
 *                     Isabelly Pacheco Marinho
 *
 * Turma: 3F
 * Atividade Proposta em aula
 * Observação: < colocar se houver>
 * ******************************************************************/


using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primitivas_de_Preenchimento
{
    public partial class Form1 : Form
    {
        int mouse_x, mouse_y, width, height;
        bool erase;

        public Form1()
        {
            InitializeComponent();
        }

        Point[] GetPoints(int[] x, int[] y)
        {
            Point[] points = new Point[x.Length];
            for(int i = 0; i < x.Length; i++)
            {
                points[i] = new Point(x[i], y[i]);
            }
            return points;
        }

        public SolidBrush GetSolidBrush(Color cor)
        {
            return new SolidBrush(cor);
        }

        public HatchBrush GetHatchBrush(HatchStyle hatchStyle, Color lineColor, Color foreColor)
        {
            return new HatchBrush(hatchStyle, lineColor, foreColor);
        }

        public TextureBrush GetTextureBrush(string img_path)
        {
            return new TextureBrush(new Bitmap(img_path));
        }

        Pen GetPen(Color cor)
        {
            return new Pen(cor);
        }

        public void DrawEllipse(PaintEventArgs e, Pen pen, int x, int y, int width, int height)
        {
            e.Graphics.DrawArc(pen, x, y, width, height, 0, 360);
        }
        public void FillEllipse(PaintEventArgs e, SolidBrush brush, int x, int y, int width, int height)
        {
            e.Graphics.FillEllipse(brush, x, y, width, height);
        }
        public void FillEllipse(PaintEventArgs e, TextureBrush brush, int x, int y, int width, int height)
        {
            e.Graphics.FillEllipse(brush, x, y, width, height);
        }
        public void FillEllipse(PaintEventArgs e, HatchBrush brush, int x, int y, int width, int height)
        {
            e.Graphics.FillEllipse(brush, x, y, width, height);
        }

        public void DrawPolygon(PaintEventArgs e, Pen pen, Point[] points)
        {
            e.Graphics.DrawPolygon(pen, points);
        }

        public void DrawPoint(PaintEventArgs e, Pen pen, int x, int y)
        {
            e.Graphics.DrawLine(pen, x, y, x + 1, y);
        }

        public void FillPolygon(PaintEventArgs e, SolidBrush brush, Point[] points)
        {
            e.Graphics.FillPolygon(brush, points);
        }

        public void PreenchePoligono(PaintEventArgs e, HatchBrush brush, Point[] points)
        {
            e.Graphics.FillPolygon(brush, points);
        }

        public void PreenchePoligono(PaintEventArgs e, TextureBrush brush, Point[] points)
        {
            e.Graphics.FillPolygon(brush, points);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        void FillDrawing(PaintEventArgs e)
        {
            if (comboBox2.Text == "")
                return;


            if(comboBox2.Text == "Sólido")
            {
                FillEllipse(e, GetSolidBrush(Color.White), mouse_x, mouse_y, width, height);
                return;
            }

            HatchStyle style;
            switch (comboBox2.Text)
            {
                case "Diagonal Esquerda":
                    style = HatchStyle.ForwardDiagonal; break;
                case "Diagonal Direita":
                    style = HatchStyle.BackwardDiagonal; break;
                case "Cruzamento":
                    style = HatchStyle.Cross; break;
                case "Diagonal Cruzada":
                    style = HatchStyle.DiagonalCross; break;
                case "Horizontal":
                    style = HatchStyle.Horizontal; break;
                case "Vertical":
                    style = HatchStyle.Vertical; break;
                default:
                    style = HatchStyle.BackwardDiagonal;break;

            }

            FillEllipse(e, GetHatchBrush(style, Color.White, Color.Black), mouse_x - width/2, mouse_y - height/2, width, height);
            
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (erase)
            {
                erase = false; 
                return;
            }
            if (width == 0 || height == 0)
                return;

            Pen pen = GetPen(Color.White);
            DrawPoint(e, pen, mouse_x, mouse_y);

            if (comboBox1.Text == "")
                return;

            int c_x, c_y;
            if(comboBox1.Text == "Circle")
            {
                int radius = height;
                c_x = mouse_x - radius / 2;
                c_y = mouse_y - radius/ 2;
                height = radius;
                width = radius;
            }
            else
            {
                c_x = mouse_x - width / 2;
                c_y = mouse_y - height / 2;
            }
            
            DrawEllipse(e, pen, c_x, c_y, width, height);
            FillDrawing(e);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            mouse_x = e.X;
            mouse_y = e.Y;
            Invalidate();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            erase = true;
            comboBox1.Text = "";
            Invalidate();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            mouse_x = e.X;
            mouse_y = e.Y;
            height = int.Parse(HeightTextBox.Text);
            width = int.Parse(WidthTextBox.Text);
            Invalidate();
        }
    }
}
