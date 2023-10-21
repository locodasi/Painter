using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Paint.clases;

namespace Paint
{
    public partial class Editor : Form
    {
        private Figura figura;
        private Form1 owner;
        private Boolean cam;
        private Font fue;
        private Boolean cambiarFuente;
        public Editor()
        {
            InitializeComponent();
        }



        private void Editor_Load(object sender, EventArgs e)
        {
            this.owner = Owner as Form1;
            textBox2.ReadOnly = true;
            textBox1.ReadOnly = true;
            fuente.BackgroundImage= imageList1.Images[0];
            pnt1_x.Enabled = false;
            pnt1_y.Enabled = false;
            pnt2_x.Enabled = false;
            pnt2_y.Enabled = false;
            fuente.Enabled = false;
            texto.Enabled = false;
            ancho.Enabled = false;
            alto.Enabled = false;
            tamanio.Enabled= false;
            color.Enabled = false;
        }

        public void ingresarFigura(Figura figura)
        {
            this.figura = figura;
            cam = false;
            textBox1.Text="";
            textBox2.Text ="";
            alto.Value = 0;
            ancho.Value = 0;
            pnt1_x.Value = 0;
            pnt2_x.Value = 0;
            pnt1_y.Value = 0;
            pnt2_y.Value = 0;
            tamanio.Value = 1;
            if (figura.GetType() == typeof(Mano))
            {
                pnt1_x.Enabled = false;
                pnt1_y.Enabled = false;
                pnt2_x.Enabled = false;
                pnt2_y.Enabled = false;
                fuente.Enabled= false;
                texto.Enabled= false;
                ancho.Enabled = false;
                alto.Enabled = false;
                tamanio.Enabled = true;
                color.Enabled = true;
                texto.Text = "";
                this.trabajarConMano((Mano)figura);

            }
            else if (figura.GetType() == typeof(Linea))
            {
                ancho.Enabled = false;
                alto.Enabled = false;
                fuente.Enabled = false;
                texto.Enabled = false;
                pnt1_x.Enabled = true;
                pnt1_y.Enabled = true;
                pnt2_x.Enabled = true;
                pnt2_y.Enabled = true;
                tamanio.Enabled = true;
                color.Enabled = true;
                texto.Text = "";
                this.trabajarConLinea((Linea)figura);

            }
            else if (figura.GetType() == typeof(Rectangulo))
            {
                pnt2_x.Enabled = false;
                pnt2_y.Enabled = false;
                tamanio.Enabled = false;
                fuente.Enabled = false;
                texto.Enabled = false;
                color.Enabled = true;
                pnt1_x.Enabled = true;
                pnt1_y.Enabled = true;
                ancho.Enabled = true;
                alto.Enabled = true;
                texto.Text = "";
                this.trabajarConRectangulo((Rectangulo)figura);

            }
            else if (figura.GetType() == typeof(Circulo))
            {
                pnt2_x.Enabled = false;
                pnt2_y.Enabled = false;
                tamanio.Enabled = false;
                fuente.Enabled = false;
                texto.Enabled = false;
                color.Enabled = true;
                pnt1_x.Enabled = true;
                pnt1_y.Enabled = true;
                ancho.Enabled = true;
                alto.Enabled = true;
                texto.Text = "";
                this.trabajarConCirculo((Circulo)figura);

            }
            else if (figura.GetType() == typeof(Texto))
            {
                ancho.Enabled = false;
                alto.Enabled = false;
                pnt2_x.Enabled = false;
                pnt2_y.Enabled = false;
                tamanio.Enabled = false;
                texto.Enabled = true;
                pnt1_x.Enabled = true;
                pnt1_y.Enabled = true;
                color.Enabled = true;
                fuente.Enabled = true;
                this.cambiarFuente = false;
                this.trabajarConTexto((Texto)figura);
            }
            else if (figura.GetType() == typeof(Imagen))
            {
                pnt1_x.Enabled = true;
                pnt1_y.Enabled = true;
                pnt2_x.Enabled = false;
                pnt2_y.Enabled = false;
                fuente.Enabled = false;
                texto.Enabled = false;
                ancho.Enabled = true;
                alto.Enabled = true;
                tamanio.Enabled = false;
                color.Enabled = false;
                texto.Text = "";
                this.trabajarConImagen((Imagen)figura);
            }

        }

        public void trabajarConImagen(Imagen f)
        {
            pnt1_x.Value = f.Posicion.X;
            pnt1_y.Value = f.Posicion.Y;
            ancho.Value = f.Fisicas.Width;
            alto.Value = f.Fisicas.Height;
            cam = true;
        }
        public void trabajarConMano(Mano f)
        {
            color.BackColor = f.Color;
            tamanio.Value = f.Tamanio;
            cam = true;
        }
        public void trabajarConLinea(Linea f)
        {
            color.BackColor = f.Color;
            tamanio.Value = f.Tamanio;
            pnt1_x.Value = f.PrimerPunto.X;
            pnt1_y.Value = f.PrimerPunto.Y;
            pnt2_x.Value = f.SegundoPunto.X;
            pnt2_y.Value = f.SegundoPunto.Y;
            cam = true;
        }
        public void trabajarConRectangulo(Rectangulo f)
        {
            color.BackColor = f.Color;
            pnt1_x.Value = f.Rect.Location.X;
            pnt1_y.Value = f.Rect.Location.Y;
            ancho.Value = (f.PntFinal.X - f.PntInicial.X);
            alto.Value = (f.PntFinal.Y - f.PntInicial.Y);
            cam = true;
        }

        public void trabajarConCirculo(Circulo f)
        {
            color.BackColor = f.Color;
            pnt1_x.Value = f.Rect.Location.X;
            pnt1_y.Value = f.Rect.Location.Y;
            ancho.Value = f.Rect.Width;
            alto.Value = f.Rect.Height;
            cam = true;
        }
        public void trabajarConTexto(Texto f)
        {
            color.BackColor = f.Color;
            texto.Text = f.Tex;
            pnt1_x.Value = f.Posicion.X;
            pnt1_y.Value = f.Posicion.Y;
            textBox1.Text = f.Fuente.Name;
            textBox2.Text = Math.Round(f.Fuente.Size).ToString();
            cam = true;
        }

        public void modificar()
        {
            if (figura.GetType() == typeof(Mano))
            { 
                Mano f= (Mano)figura;
                f.Tamanio = (int)tamanio.Value;
                f.Color = color.BackColor;

            }
            else if (figura.GetType() == typeof(Linea))
            {
                Linea f = (Linea)figura;
                f.Tamanio = (int)tamanio.Value;
                f.Color = color.BackColor;
                f.PrimerPunto = this.obtenerPnt1();
                f.SegundoPunto = this.obtenerPnt2();

            }
            else if (figura.GetType() == typeof(Rectangulo))
            {
                Rectangulo f = (Rectangulo)figura;
                f.Color = color.BackColor;
                Rectangle r = new Rectangle();
                r.Location= this.obtenerPnt1();
                r.Width = (int)ancho.Value;
                r.Height = (int)alto.Value;
                f.Rect = r;
               

            }
            else if (figura.GetType() == typeof(Circulo))
            {
                Circulo f = (Circulo)figura;
                f.Color = color.BackColor;
                Rectangle r = f.Rect;
                r.Location = this.obtenerPnt1();
                r.Width = (int)ancho.Value;
                r.Height = (int)alto.Value;
                f.Rect = r;

            }
            else if (figura.GetType() == typeof(Texto))
            {
                Texto f = (Texto)figura;
                f.Tex = texto.Text;
                f.Posicion = this.obtenerPnt1();
                f.Color = color.BackColor;
                if(cambiarFuente)
                f.Fuente = fue;
            }
            else if (figura.GetType() == typeof(Imagen))
            {
                Imagen f= (Imagen)figura;
                Rectangle r = new Rectangle();
                r.Location = this.obtenerPnt1();
                r.Width = (int)ancho.Value;
                r.Height = (int)alto.Value;
                f.Posicion = this.obtenerPnt1();
                f.Fisicas = new Size((int)ancho.Value, (int)alto.Value);
            }

            owner.actualizar();

            if(figura.GetType() != typeof(Texto))
                owner.Activate();
        }

        public Point obtenerPnt1()
        {
            return new Point((int)pnt1_x.Value, (int)pnt1_y.Value);
        }
        public Point obtenerPnt2()
        {
            return new Point((int)pnt2_x.Value, (int)pnt2_y.Value);
        }
        private void tamanio_ValueChanged(object sender, EventArgs e)
        {
           if(cam)
            this.modificar();
        }

        private void color_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                color.BackColor = colorDialog1.Color;
                this.modificar();
            }
        }

        private void pnt1_x_ValueChanged(object sender, EventArgs e)
        {
            if (cam)
            this.modificar();
        }

        private void pnt2_x_ValueChanged(object sender, EventArgs e)
        {
            if (cam)
            this.modificar();
        }

        private void pnt1_y_ValueChanged(object sender, EventArgs e)
        {
            if (cam)
            this.modificar();
        }

        private void pnt2_y_ValueChanged(object sender, EventArgs e)
        {
            if (cam)
            this.modificar();
        }

        private void ancho_ValueChanged(object sender, EventArgs e)
        {
            if (cam)
                this.modificar();
        }

        private void alto_ValueChanged(object sender, EventArgs e)
        {
            if (cam)
                this.modificar();
        }

        private void texto_TextChanged(object sender, EventArgs e)
        {
            if (cam)
                this.modificar();

                
                
        }

        private void fuente_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                this.cambiarFuente = true;
                fue = fontDialog1.Font;
                textBox1.Text = fue.Name;
                textBox2.Text = Math.Round(fue.Size).ToString();
                this.modificar();
            }
        }
    }
}
