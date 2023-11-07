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
using System.Drawing.Drawing2D;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Paint
{
    public partial class Form1 : Form
    {
        private List<Figura> figuras= new List<Figura>();
        private Figura figura;
        private Color color;
        private int tamanio;
        private String archivo=null;
        private ListadoFiguras listado;
        private Editor editor;
        private Boolean mover;
        private Boolean moverValido;
        private Point puntoDeMover;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            editor = new Editor();
            editor.Owner = this;
            editor.Show();
            this.Icon = Properties.Resources.icon;
            Objetos fObj = new Objetos();
            fObj.Owner = this;
            fObj.Show();
            this.listado = new ListadoFiguras();
            listado.Owner = this;
            listado.Show();
        }
        public void actualizar()
        {
            this.Refresh();
        }
        public void meterFiguraEditor(Figura f)
        {
            editor.ingresarFigura(f);
        }
        public void moverFigura(Figura f)
        {
            this.figura = f;
            this.mover = true;
        }
        public void meterFigura(Figura figura)
        {
            this.figura = figura;
            this.mover = false;
            if(this.figura.GetType() == typeof(Imagen))
            {
                this.aumentar();
                figuras.Add(figura);
                this.listado.mostrarLista(figuras);
                this.Refresh();
            }
 
        }


        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            Graphics grp = this.CreateGraphics();
            if (mover)
            {
                moverValido = false;
                editor.ingresarFigura(figura);
            }else if (this.figura != null)
            {
                if (this.figura.GetType() == typeof(Imagen))
                {
                    this.figura = this.nuevaFigura();
                }else if(this.figura.GetType() == typeof(Texto))
                {
                    Texto t = (Texto)figura;
                    if (t.Tex != "")
                    {
                        this.aumentar();
                        this.figuras.Add(figura);
                        this.listado.mostrarLista(figuras);
                        this.figura = this.nuevaFigura();

                        
                        figura.Paint(grp);
                    }
                }
                else if (this.figura.GetType() != typeof(Linea))
                {
                    this.figura.MouseUp(sender,e,grp);
                    this.aumentar();
                    this.figuras.Add(figura);
                    this.listado.mostrarLista(figuras);
                    this.figura = this.nuevaFigura();

                   
                    figura.Paint(grp);

                    if((figura.GetType() == typeof(Rectangulo) || figura.GetType() == typeof(Circulo)))
                    {
                        this.Invalidate();
                    }
                    
                }
                else
                {
                    Linea l = (Linea)this.figura;
                    
                    if (l.SegundoPunto.X>=0 )
                    {                    
                        
                        l.Paint(grp);
                        this.aumentar();
                        this.figuras.Add(figura);
                        this.listado.mostrarLista(figuras);
                        this.figura=this.nuevaFigura();
                    }
                }
            }
               
            
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            //DoubleBuffered = true;
           
            Graphics grp = this.CreateGraphics();
            if (this.figura != null && !mover)
            {
                if ((figura.GetType() == typeof(Rectangulo) || figura.GetType() == typeof(Circulo)) && e.Button == MouseButtons.Left)
                {
                  
                    //this.Invalidate();
                    this.Refresh();

                }
                this.figura.MouseMove(sender, e, grp);
            }else if (this.figura != null && moverValido)
            {
                if(this.figura.GetType() == typeof(Imagen))
                {
                    Imagen img = (Imagen)figura;
                    img.Posicion = new Point(img.Posicion.X + e.X - puntoDeMover.X, img.Posicion.Y + e.Y - puntoDeMover.Y);
                    puntoDeMover = e.Location;
                }else if(this.figura.GetType() == typeof(Rectangulo))
                {
                    Rectangulo r = (Rectangulo)figura;
                    Rectangle rec = r.Rect;
                    rec.Location = new Point(rec.Location.X + e.X - puntoDeMover.X, rec.Location.Y + e.Y - puntoDeMover.Y);
                    r.Rect = rec;
                    puntoDeMover = e.Location;
                }else if(this.figura.GetType() == typeof(Circulo))
                {
                    Circulo c = (Circulo)figura;
                    Rectangle rec = c.Rect;
                    rec.Location = new Point(rec.Location.X + e.X - puntoDeMover.X, rec.Location.Y + e.Y - puntoDeMover.Y);
                    c.Rect = rec;
                    puntoDeMover = e.Location;
                }else if(this.figura.GetType() == typeof(Texto))
                {
                    Texto t=(Texto)figura;
                    t.Posicion = new Point(t.Posicion.X + e.X - puntoDeMover.X, t.Posicion.Y + e.Y - puntoDeMover.Y);
                    puntoDeMover = e.Location;
                }else if(this.figura.GetType() == typeof(Linea))
                {
                    Linea l = (Linea)figura;
                    l.PrimerPunto = new Point(l.PrimerPunto.X + e.X - puntoDeMover.X, l.PrimerPunto.Y + e.Y - puntoDeMover.Y);
                    l.SegundoPunto = new Point(l.SegundoPunto.X + e.X - puntoDeMover.X, l.SegundoPunto.Y + e.Y - puntoDeMover.Y);
                    puntoDeMover = e.Location;
                }
                
                this.Invalidate();
            }
            


        }
        public void validarMover(MouseEventArgs e)
        {
            if (this.figura.GetType() == typeof(Linea))
            {
                Linea l = (Linea)figura;
                if (((e.X >= l.PrimerPunto.X - 10 && e.X <= l.PrimerPunto.X + 10) && (e.Y >= l.PrimerPunto.Y - 10 && e.Y <= l.PrimerPunto.Y + 10))||
                    (e.X >= l.SegundoPunto.X - 10 && e.X <= l.SegundoPunto.X + 10) && (e.Y >= l.SegundoPunto.Y - 10 && e.Y <= l.SegundoPunto.Y + 10))
                {
                    moverValido = true;
                    puntoDeMover = e.Location;
                }
            }
            else if (this.figura.GetType() == typeof(Rectangulo))
            {
                Rectangulo r = (Rectangulo)figura;
                Rectangle rec = r.Rect;
                if (e.X >= rec.Location.X && e.X <= (rec.Width + rec.Location.X) && e.Y >= rec.Location.Y && e.Y <= (rec.Height + rec.Location.Y))
                {
                    moverValido = true;
                    puntoDeMover = e.Location;
                }
            }
            else if (this.figura.GetType() == typeof(Circulo))
            {
                Circulo c = (Circulo)figura;
                Rectangle rec = c.Rect;
                if (e.X >= rec.Location.X && e.X <= (rec.Width + rec.Location.X) && e.Y >= rec.Location.Y && e.Y <= (rec.Height + rec.Location.Y))
                {
                    moverValido = true;
                    puntoDeMover = e.Location;
                }
            }
            else if (this.figura.GetType() == typeof(Texto))
            {
                Texto t = (Texto)figura;
              
                if ((e.X >= t.Posicion.X - 10 && e.X <= t.Posicion.X + 10) && (e.Y >= t.Posicion.Y - 10 && e.Y <= t.Posicion.Y + 10))
                {
                    moverValido = true;
                    puntoDeMover = e.Location;
                }
            }
            else if(this.figura.GetType() == typeof(Imagen))
            {
                Imagen img = (Imagen)figura;
                if (e.X >= img.Posicion.X && e.X <= (img.Tamano.Width + img.Posicion.X) && e.Y >= img.Posicion.Y && e.Y <= (img.Tamano.Height + img.Posicion.Y))
                {
                    moverValido = true;
                    puntoDeMover = e.Location;
                }
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
       
            if (this.figura != null)
            {
                if (mover)
                {
                    this.validarMover(e);   
                }
                else
                {
                    this.figura.MouseDown(sender, e);
                    if ((figura.GetType() == typeof(Texto)))
                    {
                        Texto t = (Texto)this.figura;
                        if (t.Tex != "")
                        {
                            Graphics grp = this.CreateGraphics();
                            t.Paint(grp);
                        }
                        //this.Refresh();
                    }
                }             

            }
                
        }
 

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics grp = e.Graphics;
            foreach (Figura figura in figuras)
                figura.Paint(grp);
            
        }
        
        public Figura nuevaFigura()
        {
            if (this.figura.GetType() == typeof(Mano))
                return new Mano(color, tamanio);
            else if (this.figura.GetType() == typeof(Linea))
                return new Linea(color, tamanio);
            else if (this.figura.GetType() == typeof(Rectangulo))
                return new Rectangulo(color);
            else if (this.figura.GetType() == typeof(Circulo))
                return new Circulo(color);
            else if (this.figura.GetType() == typeof(Texto))
                return new Texto(((Texto)figura).Fuente, ((Texto)figura).Tex, color);
            else
                return null;            
        }
        public void meterColor(Color color)
        {
            this.color = color;
            this.figura = this.nuevaFigura();
        }
        public void meterTamanio(int tam)
        {
            this.tamanio = tam;
            this.figura = this.nuevaFigura();
        }


        private void deshacerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (figuras.Count > 0)
            {
                figuras.RemoveAt(figuras.Count - 1);
                this.listado.mostrarLista(figuras);
                this.Invalidate();
            }
        }


        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    IFormatter formatter = new BinaryFormatter();
                    Stream stream = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                    this.archivo = openFileDialog1.FileName;
                    figuras = (List<Figura>)formatter.Deserialize(stream);
                    stream.Close();

                    this.Refresh();
                }
                catch (Exception)
                {
                    MessageBox.Show("Imagen no valida para ingresar");
                }

            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.archivo == null)
            {
                DialogResult resultado = MessageBox.Show("¿Desea guardar en formato binario o como imagen?", "Guardar", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes) // Si el usuario elige guardar como imagen
                {
                    this.comoImagenToolStripMenuItem1_Click(sender, e);
                }
                else if (resultado == DialogResult.No) // Si el usuario elige guardar en binario
                {
                    this.comoBinarioToolStripMenuItem1_Click(sender, e);
                }
                // Si el usuario elige Cancelar, no se realiza ninguna acción.
               
            }
            else
            {
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream(this.archivo, FileMode.Create, FileAccess.Write);

                formatter.Serialize(stream, figuras);
                stream.Close();
            }
        }

        public void aumentar()
        {
            if (this.figura.GetType() == typeof(Linea))
            {         
                Linea.aumentarCant();
            }
            else if (this.figura.GetType() == typeof(Rectangulo))
            {
                Rectangulo.aumentarCant();
            }
            else if (this.figura.GetType() == typeof(Circulo))
            {
                Circulo.aumentarCant();
            }
            else if (this.figura.GetType() == typeof(Texto))
            {
                Texto.aumentarCant();
            }
            else if (this.figura.GetType() == typeof(Imagen))
            {
                Imagen.aumentarCant();
            }else if(this.figura.GetType() == typeof(Mano))
            {
                Mano.aumentarCant();
            }
        }

        private void adelantarAlFrenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mover)
            {
                figuras.Remove(figura);
                figuras.Add(figura);
                this.listado.mostrarLista(figuras);
                this.Refresh();

            }
        }

        private void atrasarAlFondoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mover)
            {
                figuras.Remove(figura);
                figuras.Insert(0, figura);
                this.listado.mostrarListaMovida(figuras,0);
                this.Refresh();
            }
            
        }

        private void adelantarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mover)
            {
                int posicion = figuras.IndexOf(figura);
                if (posicion != figuras.Count - 1)
                {
                    figuras.Remove(figura);
                    figuras.Insert(posicion + 1, figura);
                    this.listado.mostrarListaMovida(figuras,posicion+1);
                    this.Refresh();
                }
              
            }
        }

        private void atrasarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mover)
            {
                int posicion = figuras.IndexOf(figura);
                if (posicion != 0)
                {
                    figuras.Remove(figura);
                    figuras.Insert(posicion - 1, figura);
                    this.listado.mostrarListaMovida(figuras,posicion-1);
                    this.Refresh();
                }

            }
        }

        private void rehacerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mover)
            {
                figuras.Remove(figura);
                this.listado.mostrarLista(figuras);
                this.Refresh();
            }
        }

        private void contenidoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void informacionGeneralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Properties.Resources.InfoGeneral);
        }

        private void ventanaDeListadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Properties.Resources.infoVentanaListado);
        }

        private void ventanaDeEdicionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Properties.Resources.InfoVentanaEditor);
        }

        private void ayudaDeMenuEditarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Properties.Resources.infoDeMenuEditar);
        }

        private void acercadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Properties.Resources.acercaDe);
        }

        private void agradecimientoEspecialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Properties.Resources.agradezco);
        }

        private void comoImagenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialogImagen.ShowDialog() == DialogResult.OK)
            {
                

                int anchoFormulario = ClientSize.Width;
                int altoFormulario = ClientSize.Height;

                
                int alturaMenu = menuStrip1.Height; ; 
                int altoDisponible = altoFormulario - alturaMenu;
                // Crea un nuevo Bitmap con el mismo tamaño que tu área de dibujo
                Bitmap bitmap = new Bitmap(anchoFormulario, altoDisponible);

                // Crea un objeto Graphics a partir del Bitmap
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    g.Clear(Color.White);

                    // Dibuja todas las figuras en el objeto Graphics
                    foreach (Figura figura in figuras)
                    {
                        figura.Paint(g); // Suponiendo que tengas un método Dibujar en tu clase Figura
                    }
                }

                // Guarda el Bitmap en el archivo seleccionado en el formato de imagen que desees (por ejemplo, JPG)
                bitmap.Save(saveFileDialogImagen.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);

                // Libera los recursos del Bitmap
                bitmap.Dispose();
            }
        }

        private void comoBinarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.Write);

                formatter.Serialize(stream, figuras);
                stream.Close();

            }
        }

        private void comoImagenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (saveFileDialogImagen.ShowDialog() == DialogResult.OK)
            {


                int anchoFormulario = ClientSize.Width;
                int altoFormulario = ClientSize.Height;


                int alturaMenu = menuStrip1.Height; ;
                int altoDisponible = altoFormulario - alturaMenu;
                // Crea un nuevo Bitmap con el mismo tamaño que tu área de dibujo
                Bitmap bitmap = new Bitmap(anchoFormulario, altoDisponible);

                // Crea un objeto Graphics a partir del Bitmap
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    g.Clear(Color.White);

                    // Dibuja todas las figuras en el objeto Graphics
                    foreach (Figura figura in figuras)
                    {
                        figura.Paint(g); // Suponiendo que tengas un método Dibujar en tu clase Figura
                    }
                }

                // Guarda el Bitmap en el archivo seleccionado en el formato de imagen que desees (por ejemplo, JPG)
                bitmap.Save(saveFileDialogImagen.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);

                // Libera los recursos del Bitmap
                bitmap.Dispose();
            }
        }
    }
}
