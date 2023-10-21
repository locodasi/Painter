using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint.clases
{
    [Serializable]
    public class Rectangulo:Figura
    {
        private Color color;
        private Point pntInicial;
        private Point pntFinal;
        private Point pntInicialUp;
        private Rectangle rect;
        private static int cantidad = 1;
        private int numero;

        public Color Color { get => color; set => color = value; }
        public Point PntInicial { get => pntInicial; set => pntInicial = value; }
        public Point PntFinal { get => pntFinal; set => pntFinal = value; }
        public Rectangle Rect { get => rect; set => rect = value; }
        public Point PntInicialUp { get => pntInicialUp; set => pntInicialUp = value; }


        public Rectangulo(Color color)
        {
            this.rect = new Rectangle(0, 0, 0, 0);
            this.color = color;
            numero=cantidad;
            base.Nombre = "Rectangulo " + numero;

        }
        public static void aumentarCant()
        {
            cantidad++;
        }
        public override string ToString()
        {
            return base.Nombre;
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
        public void crearRectanguo()
        {
            this.rect.Location = pntInicial;
            this.rect.Height = (pntFinal.Y - pntInicial.Y);
            this.rect.Width = (pntFinal.X - pntInicial.X);
        }
        public override void Paint(Graphics g)
        {
            
            SolidBrush br = new SolidBrush(color);
            g.FillRectangle(br, rect);

        }
        public void PaintInicial(Graphics g)
        {

            Point p = this.ordenarPuntos();
            this.crearRectanguo();
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
            if(pntInicial.X > pntFinal.X)
            {
                pntInicial.X = pntFinal.X;
                pntFinal.X = p.X;
            }
            pntInicialUp = pntInicial;
            return p;
        }


    }
}
