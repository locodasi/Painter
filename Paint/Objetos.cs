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
    public partial class Objetos : Form
    {
        private Color color;
        private int tamanio;
        Form1 owner;
        Font fuente;

        public Color Color1 { get => color; set => color = value; }

        public Objetos()
        {
            InitializeComponent();
        }

        private void Objetos_Load(object sender, EventArgs e)
        {
            this.owner= Owner as Form1;
            this.color = System.Drawing.Color.Black;
            this.tamanio = 11;
            owner.meterFigura(new Mano(color, tamanio));
            owner.meterTamanio(tamanio);
            Color.BackColor = color;
            owner = Owner as Form1;           
            owner.meterColor(color);
            fuente = null;

            //Mano.BackgroundImage= imageList1.Images[0];
           // Linea.BackgroundImage = imageList1.Images[1];
            Circulo.BackgroundImage = imageList1.Images[0];
            Rectangulo.BackgroundImage = imageList1.Images[1];
            Imagen.BackgroundImage = imageList1.Images[2];
            Texto.BackgroundImage = Properties.Resources.tex;
        }

        private void Mano_Click(object sender, EventArgs e)
        {
            
            
            owner.meterFigura(new Mano(color, tamanio));
                
        }

        private void Linea_Click(object sender, EventArgs e)
        {
            
            owner.meterFigura(new Linea(color,tamanio));
        }

        private void Color_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                color=colorDialog1.Color;
                Color.BackColor=color;
                owner.meterColor(color);
            }
        }



        private void Objetos_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void Objetos_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            this.tamanio = (int)numericUpDown1.Value;                  
            owner.meterTamanio(this.tamanio);
        }

        private void Circulo_Click(object sender, EventArgs e)
        {

            owner.meterFigura(new Circulo(color));
        }

        private void Rectangulo_Click(object sender, EventArgs e)
        {

            owner.meterFigura(new Rectangulo(color));
        }

        private void Imagen_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                try
                {
                    Imagen img = new Imagen(new Bitmap(openFileDialog1.FileName));
                    img.Posicion = new Point(0, 0);//this.ClientSize.Height / 2 - img.Tamano.Height / 2, this.ClientSize.Width / 2 - img.Tamano.Width / 2);
                    owner.meterFigura(img);
                }catch(Exception )
                {
                    MessageBox.Show("Imagen no valida para ingresar");
                }
                
            }
            

            
        }

        private void Texto_Click(object sender, EventArgs e)
        {
            DialogResult dr = fontDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                this.fuente = fontDialog1.Font;
                owner.meterFigura(new Texto(fuente, textBox1.Text,color));
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(fuente != null)
            owner.meterFigura(new Texto(fuente, textBox1.Text,color));
        }

        private void Objetos_Deactivate(object sender, EventArgs e)
        {
           // MessageBox.Show("Flaco volve");
            //this.Activate();
        }
    }
}
