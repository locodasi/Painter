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
    public partial class ListadoFiguras : Form
    {
        private List<Figura> figuras = new List<Figura>();
        private Form1 owner;
        public ListadoFiguras()
        {
            
            InitializeComponent();
        }
        private void ListadoFiguras_Load(object sender, EventArgs e)
        {
            this.owner = Owner as Form1;
        }
      /*  public void actualizar()
        {
            owner.actualizar();
        }*/
        public void mostrarLista(List<Figura> figuras)
        {
            this.figuras=figuras;
            textBox1.Text = figuras.Count + "";
            listBox1.DataSource = null;
            listBox1.DataSource = this.figuras;
            listBox1.DisplayMember = "Figuras";
            listBox1.SelectedIndex = listBox1.Items.Count-1;
        }
        public void mostrarLista()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = this.figuras;
            listBox1.DisplayMember = "Figuras";
            listBox1.SelectedIndex = listBox1.Items.Count - 1;
        }
        public void mostrarListaMovida(List<Figura> figuras, int i)
        {
            this.figuras = figuras;
            textBox1.Text = figuras.Count + "";
            listBox1.DataSource = null;
            listBox1.DataSource = this.figuras;
            listBox1.DisplayMember = "Figuras";
            listBox1.SelectedIndex = i;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                Figura f = (Figura)listBox1.SelectedItem;
                owner.meterFiguraEditor(f);                           
            }
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            owner.moverFigura((Figura)listBox1.SelectedItem);
            owner.Activate();
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            Nombrador frn = new Nombrador();
            frn.Owner = this;
            frn.renombrar((Figura)listBox1.SelectedItem);
            frn.ShowDialog();
            //frn.Show();
            
        }
    }
}
