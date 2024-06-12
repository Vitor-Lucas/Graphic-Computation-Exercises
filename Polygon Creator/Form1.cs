/*Colegio Técnico Antônio Teixeira Fernandes (Univap)
 *Curso Técnico em Informática - Data de Entrega: 12 / 06 / 2024
 * Autores do Projeto: Isabelly Pacheco Marinho
 *                     Vitor Lucas Kolhs Correa
 *
 * Turma: 2F
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
using System.Drawing.Drawing2D;

namespace Polygon_Creator
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        HatchBrush GetHatch(HatchStyle style, Color line, Color fill)
        {
            HatchBrush hashura = new HatchBrush(style,line,fill);
            return hashura;
        }

        Pen Pen(Color cor)
        {
            return new Pen(cor);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_PaddingChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = Pen(Color.Black);
            HatchBrush hashura = GetHatch(HatchStyle.Vertical, Color.BlueViolet, Color.Magenta);
           
            //retangulo
            e.Graphics.DrawRectangle(pen,10,20,25,50);
            e.Graphics.FillRectangle(hashura, 10, 20, 25, 50);

            //circulo
            e.Graphics.DrawEllipse(pen, 100, 200, 50, 50);
            e.Graphics.FillEllipse(hashura, 100, 200, 50, 50);

            //elipse
            e.Graphics.DrawEllipse(pen, 150, 250, 50, 30);
            e.Graphics.FillEllipse(hashura, 150, 250, 50, 30);
        }
    }
}
