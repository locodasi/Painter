namespace Paint
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarcomoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deshacerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rehacerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.adelantarAlFrenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atrasarAlFondoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adelantarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atrasarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contenidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informacionGeneralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventanaDeListadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventanaDeEdicionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaDeMenuEditarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.acercadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agradecimientoEspecialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.toolStripSeparator,
            this.guardarToolStripMenuItem,
            this.guardarcomoToolStripMenuItem,
            this.toolStripSeparator1,
            this.toolStripSeparator2});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "&Archivo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("abrirToolStripMenuItem.Image")));
            this.abrirToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.abrirToolStripMenuItem.Text = "&Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(177, 6);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("guardarToolStripMenuItem.Image")));
            this.guardarToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.guardarToolStripMenuItem.Text = "&Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // guardarcomoToolStripMenuItem
            // 
            this.guardarcomoToolStripMenuItem.Name = "guardarcomoToolStripMenuItem";
            this.guardarcomoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.guardarcomoToolStripMenuItem.Text = "G&uardar como";
            this.guardarcomoToolStripMenuItem.Click += new System.EventHandler(this.guardarcomoToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deshacerToolStripMenuItem,
            this.rehacerToolStripMenuItem,
            this.toolStripSeparator3,
            this.toolStripSeparator4,
            this.adelantarAlFrenteToolStripMenuItem,
            this.atrasarAlFondoToolStripMenuItem,
            this.adelantarToolStripMenuItem,
            this.atrasarToolStripMenuItem});
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.editarToolStripMenuItem.Text = "&Editar";
            // 
            // deshacerToolStripMenuItem
            // 
            this.deshacerToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deshacerToolStripMenuItem.Image = global::Paint.Properties.Resources.deshacer;
            this.deshacerToolStripMenuItem.Name = "deshacerToolStripMenuItem";
            this.deshacerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.deshacerToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.deshacerToolStripMenuItem.Text = "&Deshacer";
            this.deshacerToolStripMenuItem.Click += new System.EventHandler(this.deshacerToolStripMenuItem_Click);
            // 
            // rehacerToolStripMenuItem
            // 
            this.rehacerToolStripMenuItem.Image = global::Paint.Properties.Resources.tijera;
            this.rehacerToolStripMenuItem.Name = "rehacerToolStripMenuItem";
            this.rehacerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.rehacerToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.rehacerToolStripMenuItem.Text = "Recortar";
            this.rehacerToolStripMenuItem.Click += new System.EventHandler(this.rehacerToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(220, 6);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(220, 6);
            // 
            // adelantarAlFrenteToolStripMenuItem
            // 
            this.adelantarAlFrenteToolStripMenuItem.Image = global::Paint.Properties.Resources.arribas;
            this.adelantarAlFrenteToolStripMenuItem.Name = "adelantarAlFrenteToolStripMenuItem";
            this.adelantarAlFrenteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Up)));
            this.adelantarAlFrenteToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.adelantarAlFrenteToolStripMenuItem.Text = "Adelantar al frente";
            this.adelantarAlFrenteToolStripMenuItem.Click += new System.EventHandler(this.adelantarAlFrenteToolStripMenuItem_Click);
            // 
            // atrasarAlFondoToolStripMenuItem
            // 
            this.atrasarAlFondoToolStripMenuItem.Image = global::Paint.Properties.Resources.abajos;
            this.atrasarAlFondoToolStripMenuItem.Name = "atrasarAlFondoToolStripMenuItem";
            this.atrasarAlFondoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Down)));
            this.atrasarAlFondoToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.atrasarAlFondoToolStripMenuItem.Text = "Atrasar al fondo";
            this.atrasarAlFondoToolStripMenuItem.Click += new System.EventHandler(this.atrasarAlFondoToolStripMenuItem_Click);
            // 
            // adelantarToolStripMenuItem
            // 
            this.adelantarToolStripMenuItem.Image = global::Paint.Properties.Resources.arriba;
            this.adelantarToolStripMenuItem.Name = "adelantarToolStripMenuItem";
            this.adelantarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Up)));
            this.adelantarToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.adelantarToolStripMenuItem.Text = "Adelantar";
            this.adelantarToolStripMenuItem.Click += new System.EventHandler(this.adelantarToolStripMenuItem_Click);
            // 
            // atrasarToolStripMenuItem
            // 
            this.atrasarToolStripMenuItem.Image = global::Paint.Properties.Resources.abajo;
            this.atrasarToolStripMenuItem.Name = "atrasarToolStripMenuItem";
            this.atrasarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Down)));
            this.atrasarToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.atrasarToolStripMenuItem.Text = "Atrasar";
            this.atrasarToolStripMenuItem.Click += new System.EventHandler(this.atrasarToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contenidoToolStripMenuItem,
            this.toolStripSeparator5,
            this.acercadeToolStripMenuItem,
            this.agradecimientoEspecialToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ay&uda";
            // 
            // contenidoToolStripMenuItem
            // 
            this.contenidoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informacionGeneralToolStripMenuItem,
            this.ventanaDeListadoToolStripMenuItem,
            this.ventanaDeEdicionToolStripMenuItem,
            this.ayudaDeMenuEditarToolStripMenuItem});
            this.contenidoToolStripMenuItem.Name = "contenidoToolStripMenuItem";
            this.contenidoToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.contenidoToolStripMenuItem.Text = "&Contenido";
            this.contenidoToolStripMenuItem.Click += new System.EventHandler(this.contenidoToolStripMenuItem_Click);
            // 
            // informacionGeneralToolStripMenuItem
            // 
            this.informacionGeneralToolStripMenuItem.Name = "informacionGeneralToolStripMenuItem";
            this.informacionGeneralToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.informacionGeneralToolStripMenuItem.Text = "Informacion general";
            this.informacionGeneralToolStripMenuItem.Click += new System.EventHandler(this.informacionGeneralToolStripMenuItem_Click);
            // 
            // ventanaDeListadoToolStripMenuItem
            // 
            this.ventanaDeListadoToolStripMenuItem.Name = "ventanaDeListadoToolStripMenuItem";
            this.ventanaDeListadoToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.ventanaDeListadoToolStripMenuItem.Text = "Ventana de listado";
            this.ventanaDeListadoToolStripMenuItem.Click += new System.EventHandler(this.ventanaDeListadoToolStripMenuItem_Click);
            // 
            // ventanaDeEdicionToolStripMenuItem
            // 
            this.ventanaDeEdicionToolStripMenuItem.Name = "ventanaDeEdicionToolStripMenuItem";
            this.ventanaDeEdicionToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.ventanaDeEdicionToolStripMenuItem.Text = "Ventana de edicion";
            this.ventanaDeEdicionToolStripMenuItem.Click += new System.EventHandler(this.ventanaDeEdicionToolStripMenuItem_Click);
            // 
            // ayudaDeMenuEditarToolStripMenuItem
            // 
            this.ayudaDeMenuEditarToolStripMenuItem.Name = "ayudaDeMenuEditarToolStripMenuItem";
            this.ayudaDeMenuEditarToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.ayudaDeMenuEditarToolStripMenuItem.Text = "Ayuda de menu \"Editar\"";
            this.ayudaDeMenuEditarToolStripMenuItem.Click += new System.EventHandler(this.ayudaDeMenuEditarToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(201, 6);
            // 
            // acercadeToolStripMenuItem
            // 
            this.acercadeToolStripMenuItem.Name = "acercadeToolStripMenuItem";
            this.acercadeToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.acercadeToolStripMenuItem.Text = "&Acerca de...";
            this.acercadeToolStripMenuItem.Click += new System.EventHandler(this.acercadeToolStripMenuItem_Click);
            // 
            // agradecimientoEspecialToolStripMenuItem
            // 
            this.agradecimientoEspecialToolStripMenuItem.Name = "agradecimientoEspecialToolStripMenuItem";
            this.agradecimientoEspecialToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.agradecimientoEspecialToolStripMenuItem.Text = "Agradecimiento especial";
            this.agradecimientoEspecialToolStripMenuItem.Click += new System.EventHandler(this.agradecimientoEspecialToolStripMenuItem_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "bin";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Archivo BIN|*.bin*";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(270, 50);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Lienzo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarcomoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deshacerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rehacerToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contenidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem acercadeToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem adelantarAlFrenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atrasarAlFondoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adelantarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atrasarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informacionGeneralToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventanaDeListadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventanaDeEdicionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaDeMenuEditarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agradecimientoEspecialToolStripMenuItem;
    }
}

