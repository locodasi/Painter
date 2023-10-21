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
    public abstract class Figura
    {
        private String nombre;

        public string Nombre { get => nombre; set => nombre = value; }

        //private Point pntInicial;

        // public Point PntInicial { get => pntInicial; set => pntInicial = value; }

        public virtual void MouseMove(object sender, MouseEventArgs e, Graphics grp) { }
        public virtual void MouseDown(object sender, MouseEventArgs e) { }
        public virtual void MouseUp(object sender, MouseEventArgs e, Graphics grp) { }      
        public abstract void Paint(Graphics g);


    }
}
