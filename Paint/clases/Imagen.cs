using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint.clases
{
    [Serializable]
    public class Imagen:Figura
    {

        Point posicion;
        Bitmap bmp;
        private static int cantidad = 1;
        private Size fisicas;
        private int numero;


        public Point Posicion { get => posicion; set => posicion = value; }
        public Size Tamano { get => bmp.Size; }
        public Size Fisicas { get => fisicas; set => fisicas = value; }
  

        public Imagen(Bitmap bmp)
        {
            fisicas= new Size(100,100);
            this.bmp = bmp;
            numero = cantidad;
            base.Nombre = "Imagen " + numero;

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
            paint(this.Posicion, grp);
        }

        private void paint(Point punto, Graphics grp)
        {
            
            grp.DrawImage(bmp, new Rectangle(punto,fisicas));
            // grp.DrawImage(bmp, punto);
        }
    }
}
