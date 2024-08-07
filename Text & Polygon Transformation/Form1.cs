/*Colegio Técnico Antônio Teixeira Fernandes (Univap)
 *Curso Técnico em Informática - Data de Entrega: 07 / 08 / 2024
 * Autores do Projeto: Isabelly Pacheco Marinho
 *                     Vitor Lucas Kohls Correa
 *
 * Turma: 3F
 * Atividade Proposta em aula
 * Observação: < colocar se houver>
 * 
 * 
 * ******************************************************************/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Text___Polygon_Transformation
{
    public partial class Form1 : Form
    {
        int value_x, value_y; 
        public Form1()
        {
            InitializeComponent();
        }

        public void DrawPolygon(PaintEventArgs e, Pen pen, Point[] points)
        {
            e.Graphics.DrawPolygon(pen, points);
        }

        Pen GetPen(Color cor)
        {
            return new Pen(cor);
        }

        private void DrawICosaedro(PaintEventArgs e, Pen pen)
        {
            int[] pontos_iso = { 278, 35, 76, 116,
                     138, 176, 278, 35,
                     357, 217, 138, 176,
                     357, 218, 438, 190,
                     438, 190, 278, 29,
                      360,219 , 278, 35,
                      73, 118, 138, 172,
                      75, 124, 31, 311,
                      133, 170, 40, 304,
                      132, 179, 206, 386,
                      207, 386, 359, 218,
                      358, 217, 398, 402,
                      397, 401, 440, 191,
                       37, 311, 208, 386,
                      206, 385, 402, 402,
                      402, 402, 195, 474,
                      195, 474, 208, 389,
                      195, 474, 32, 308};

            Point[] pontos = new Point[pontos_iso.Length/2];
            int j = 0;
            for(int i = 0; i < pontos_iso.Length; i += 2)
            {
                int x = pontos_iso[0 + i] + value_x;
                int y = pontos_iso[1 + i] + value_y;

                pontos[j] = new Point(x, y);
                j++;
            }

            DrawPolygon(e, pen, pontos);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = GetPen(Color.Blue);
            DrawICosaedro(e, pen);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            value_x = trackBar1.Value;
            Invalidate();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            value_y = trackBar2.Value;
            Invalidate();
        }
    }
}
