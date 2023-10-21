using Paint.clases;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    [Serializable]
    public class Circulo : Figura
    {
        private Color color;
        private Point pntInicial;
        private Point pntFinal;
        private Point pntInicialUp;
        private static int cantidad = 1;
        private int numero;
        private Rectangle rect;

        public Color Color { get => color; set => color = value; }
        public Rectangle Rect { get => rect; set => rect = value; }
        public Point PntFinal { get => pntFinal; set => pntFinal = value; }

        public Circulo(Color color)
        {
            this.rect = new Rectangle(0, 0, 0, 0);
            this.color = color;
            numero = cantidad;
            base.Nombre = "Circulo " + this.numero;
        }
        public static void aumentarCant()
        {
            cantidad++;
        }

        public override void MouseDown(object sender, MouseEventArgs e)
        {

            pntInicial = new Point(e.X, e.Y);

        }
        public override void MouseMove(object sender, MouseEventArgs e, Graphics grp)
        {

            if (e.Button == MouseButtons.Left)
            {
                pntFinal = new Point(e.X, e.Y);
                this.PaintInicial(grp);

            }


        }

        public override void Paint(Graphics g)
        {

            SolidBrush br = new SolidBrush(color);
            g.FillEllipse(br, rect);


        }

        public override string ToString()
        {
            return base.Nombre;
        }

        public void crearRectangulo()
        {
            this.rect.Location = pntInicial;
            this.rect.Height = (pntFinal.Y - pntInicial.Y);
            this.rect.Width = (pntFinal.X - pntInicial.X);
        }
        public void PaintInicial(Graphics g)
        {

            Point p = this.ordenarPuntos();
            this.crearRectangulo();
            this.Paint(g);
            pntInicial = p;
        }
        public override void MouseUp(object sender, MouseEventArgs e, Graphics grp)
        {

            pntInicial = pntInicialUp;
        }

        public Point ordenarPuntos()
        {

            Point p = pntInicial;
            if (pntInicial.Y > pntFinal.Y)
            {
                pntInicial.Y = pntFinal.Y;
                pntFinal.Y = p.Y;
            }
            if (pntInicial.X > pntFinal.X)
            {
                pntInicial.X = pntFinal.X;
                pntFinal.X = p.X;
            }
            pntInicialUp = pntInicial;
            return p;
        }

    }
}

