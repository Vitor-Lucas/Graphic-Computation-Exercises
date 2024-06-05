
/*Colegio Técnico Antônio Teixeira Fernandes (Univap)
 *Curso Técnico em Informática - Data de Entrega: 05 / 06 / 2024
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

namespace Sin_Cos_Visualizer
{
    public partial class Form1 : Form
    {
        int WIDTH;
        int HEIGHT;
        int a = 1;
        int f = 1;
        Color cor;
        //int offset = -25;
        int offset = 0;
        bool desenhar;

        public Form1()
        {
            InitializeComponent();
        }
        Pen GetPen(int r, int g, int b)
        {
            Color color = Color.FromArgb(r, g, b);
            return new Pen(color);
        }

        double fun(double x)
        {
            if(comboBox1.Text == "Sin")
            {
                return a * Math.Sin(x * f * Math.PI/180);
            }
            else
            {
                return a * Math.Cos(x* f * Math.PI / 180);
            }
        }

        float[] CoordenadaDoPlano_CoordenadaDoFormulario(float x, float y)
        {
            y *= -1;
            x += WIDTH / 2;
            y += HEIGHT / 2;

            return new float[] { x, y };
        }
        float[] CoordenadaDoFormulario_CoordenadaDoPlano(float x, float y)
        {
            x -= WIDTH / 2;
            y -= HEIGHT / 2;

            return new float[] { x, y * -1 };
        }

        void DrawPoint(PaintEventArgs e, Pen pen, float x, float y)
        {
            e.Graphics.DrawLine(pen, x, y, x+1, y);
        }

        void DesenharEixos(PaintEventArgs e)
        {
            //Desenha as retas do exio X e do eixo Y
            Pen pen = GetPen(0, 0, 0);

            float xOrigin = WIDTH / 2;
            float yOrigin = HEIGHT / 2;

            e.Graphics.DrawLine(pen, 0, yOrigin + offset, WIDTH, yOrigin + offset);//  X

            for (int i = 0; i <= WIDTH; i += 10)
                DesenharMarcasX(e, pen, i);
        }

        void DesenharMarcasX(PaintEventArgs e, Pen pen, int x)
        {
            float y1 = CoordenadaDoPlano_CoordenadaDoFormulario(0, 1)[1] + offset;
            float y2 = CoordenadaDoPlano_CoordenadaDoFormulario(0, -1)[1] + offset;
            e.Graphics.DrawLine(pen, x, y1, x, y2);
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            WIDTH = ActiveForm.Size.Width;
            HEIGHT = ActiveForm.Size.Height;
            cor = button1.BackColor;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            DesenharEixos(e);

            if (!desenhar)
                return;

            Pen pen = GetPen(cor.R, cor.G, cor.B);

            for (float x = 0; x < WIDTH; x+= 0.1f)
            {
                float y = (float)fun(x);
                float y_form = CoordenadaDoPlano_CoordenadaDoFormulario(0, y)[1];
                DrawPoint(e, pen, x, y_form);

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void prepareDraw()
        {
            desenhar = true;
            if (amplitudeTextBox.Text != "")
                a = int.Parse(amplitudeTextBox.Text);
            else
                a = 1;

            if (frequenciaTextBox.Text != "")
                f = int.Parse(frequenciaTextBox.Text);
            else
                f = 1;

            amplitudeTextBox.Text = a.ToString();
            frequenciaTextBox.Text = f.ToString();

            //atualizar a formula:
            formula.Text = "f(x) = " + a + " * " + comboBox1.Text.ToLower() + "(θ * " + f + ")";

            Invalidate();
        }
        private void desenharButton_Click(object sender, EventArgs e)
        {
            prepareDraw();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            prepareDraw();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            cor = colorDialog1.Color;
            button1.BackColor = cor;
        }

        private void formula_Click(object sender, EventArgs e)
        {

        }
    }
}
