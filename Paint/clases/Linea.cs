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
    public class Linea : Figura
    {
        private Color color;
        private Point primerPunto;
        private Point segundoPunto;
        private int tamanio;
        private static int cantidad = 1;
        private int numero;


        public Linea(Color color, int tamanio)
        {
            this.color = color;
            primerPunto = new Point(-1, -1);
            segundoPunto = new Point(-1, -1);
            this.tamanio = tamanio;
            numero = cantidad;
            base.Nombre = "Linea " + numero;

        }
        public static void aumentarCant()
        {
            cantidad++;
        }
        public override string ToString()
        {
            return base.Nombre;
        }


        public Point SegundoPunto { get => segundoPunto; set => segundoPunto = value; }
        public Color Color { get => color; set => color = value; }
        public Point PrimerPunto { get => primerPunto; set => primerPunto = value; }
        public int Tamanio { get => tamanio; set => tamanio = value; }


        public override void MouseDown(object sender, MouseEventArgs e)
        {
            if(primerPunto.X>=0)
            {
                
                segundoPunto = new Point(e.X, e.Y);
            }
            else
                primerPunto = new Point(e.X, e.Y);
        }

        public override void Paint(Graphics grp)
        {      
            
           grp.DrawLine(new Pen(color, tamanio), primerPunto.X,primerPunto.Y,segundoPunto.X,segundoPunto.Y);
        }

    }
}
