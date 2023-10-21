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
    public class Texto:Figura
    {
        private Font fuente;
        private Point posicion;
        private String tex;
        private Color color;
        private static int cantidad = 1;
        private int numero;

        public Point Posicion { get => posicion; set => posicion = value; }
        public Font Fuente { get => fuente; set => fuente = value; }
        public string Tex { get => tex; set => tex = value; }
        public Color Color { get => color; set => color = value; }

        public Texto(Font fuente,String texto,Color color)
        {
            this.tex = texto;
            this.fuente = fuente;
            this.color = color;
            numero = cantidad;
            base.Nombre = "Texto" + numero;

        }
        public static void aumentarCant()
        {
            cantidad++;
        }
        public override string ToString()
        {
            return base.Nombre;
        }


        public override void Paint(Graphics g)
        {
            SolidBrush br = new SolidBrush(color);
            g.DrawString(tex,Fuente,br,Posicion);
        }
        public override void MouseDown(object sender, MouseEventArgs e)
        {
            this.posicion=e.Location;
        }
    }
}
