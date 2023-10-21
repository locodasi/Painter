using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint.clases
{
    [Serializable]
    public class Mano: Figura
    {
        private List<Point> puntos = new List<Point>();
        private Color color;
        private Point ultimoPunto;
        private int tamanio;
        private static int cantidad = 1;
        private int numero;

    

        public Color Color { get => color; set => color = value; }
        public int Tamanio { get => tamanio; set => tamanio = value; }


        public Mano(Color color, int tam)
        {
            this.color = color;
            this.tamanio = tam;
            numero = cantidad;
            base.Nombre = "Mano " + numero;

        }
        public static void aumentarCant()
        {
            cantidad++;
        }
        public override string ToString()
        {
            return base.Nombre;
        }


        public override void Paint(Graphics grp)
        {
            Pen pen = new Pen(color, tamanio);
            if (puntos.Count > 2)
            {
                
                if (tamanio<8)
                {
                    grp.DrawLines(pen, puntos.ToArray());
                }
                else
                {
                    foreach (Point p in puntos)
                    {
                        grp.DrawEllipse(pen, p.X, p.Y, tamanio, tamanio);
                    }
                }

            }
            else
            {
                grp.DrawEllipse(pen, ultimoPunto.X, ultimoPunto.Y, tamanio, tamanio);
            }
        }


        public override void MouseMove(object sender, MouseEventArgs e, Graphics grp)
        {
            if (e.Button == MouseButtons.Left)
            {
                Pen pen = new Pen(color, tamanio);

                if (tamanio < 8)
                {
                    grp.DrawLine(pen, ultimoPunto.X, ultimoPunto.Y, e.X, e.Y);
                }
                else
                {
                    grp.DrawEllipse(pen, ultimoPunto.X, ultimoPunto.Y, tamanio, tamanio);

                }             
                ultimoPunto = new Point(e.X, e.Y);
                puntos.Add(ultimoPunto);              
                grp.Dispose();
            }
        }

        public override void MouseDown(object sender, MouseEventArgs e)
        {
            ultimoPunto = new Point(e.X, e.Y);
            puntos.Add(ultimoPunto);
        }
        public override void MouseUp(object sender, MouseEventArgs e, Graphics grp) {
            if (puntos.Count < 2)
            {
                this.Paint(grp);
            }
        }
    }
}
