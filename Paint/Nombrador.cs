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
    public partial class Nombrador : Form
    {
        //private Boolean cerrar;
        private ListadoFiguras owner;
        private Figura f;
        public Nombrador()
        {
            InitializeComponent();
        }

        private void Nombrador_Load(object sender, EventArgs e)
        {
            this.owner = Owner as ListadoFiguras;
            this.MinimizeBox = false;
            this.Icon = Properties.Resources.icon;
           // cerrar = false;         
        }

        public void renombrar(Figura figura)
        {
            f = figura;
            textBox1.Text = figura.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            f.Nombre=textBox1.Text;
            //cerrar = true;
            this.Close();
        }

        private void Nombrador_Deactivate(object sender, EventArgs e)
        {
            owner.mostrarLista();
            /*if (cerrar)
            {
                owner.mostrarLista();
                this.Close();

            }
            else
            {
                MessageBox.Show("Complete");
                
                this.Activate();
            }*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //cerrar = true;
            this.Close();
        }

        private void Nombrador_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                this.button1_Click(sender, e);
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                this.button1_Click(sender, e);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
