
/*
*Colegio Técnico Antônio Teixeira Fernandes (Univap)
*Curso Técnico em Informática - Data de Entrega: DD / MM / 2020
* Autores do Projeto: Vitor Lucas Kohls Correa
*                     Isabelly Pacheco Marinho
*
* Turma: 3F
* Atividade Proposta em aula
* Observação: < colocar se houver>
* 
* 
* ******************************************************************/
using System.Drawing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paralel_Detecter_and_Rectangle_checker
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
        Pen GetPen(int r, int g, int b)
        {
            return new Pen(Color.FromArgb(r, g, b));
        }
        void DrawLine(PaintEventArgs e, Pen pen, int x0, int y0, int x1, int y1)
        {
            e.Graphics.DrawLine(pen, x0, y0, x1, y1);
        }

        bool isParalel(int x0, int y0, int x1, int y1, int x2, int y2, int x3, int y3)
        {
            float m1 = (y0-y1) / (x0-x1);
            float m2 = (y2-y3) / (x2-x3);
            return m1 == m2;
        }

        void DrawRectangle(PaintEventArgs e, Pen pen, int x, int y, int w, int h)
        {
            e.Graphics.DrawRectangle(pen, x, y, w, h);
        }

        String ClassifyRectangle(int x, int y, int w, int h)
        {
            if (w == h){
                return "Quadrado";
            }else{
                if (w > h)
                    return "Retângulo horizontal";
                else
                    return "Retângulo vertical";
            }
                
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            Pen pen = GetPen(0, 0, 0);

            int x0 = 125 + 100;
            int y0 = 125;

            int x1 = 150 + 100;
            int y1 = 150;

            int x2 = 50;
            int y2 = 50;

            int x3 = 100;
            int y3 = 100;

            DrawLine(e, pen, x0, y0, x1, y1);
            DrawLine(e, pen, x2, y2, x3, y3);
            Paralel_label.Text = "Paralela: "+isParalel(x0, y0, x1, y1, x2, y2, x3, y3).ToString();

            int x = 200;
            int y = 50;

            int w = 80;
            int h = 180;
            DrawRectangle(e, pen, x, y, w, h);
            Quadrilatero_label.Text = "Classificação do quadrilatreo: " + ClassifyRectangle(x, y, w, h);
        }

        
    }
}
