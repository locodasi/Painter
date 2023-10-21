namespace Paint
{
    partial class Objetos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Objetos));
            this.Mano = new System.Windows.Forms.Button();
            this.Linea = new System.Windows.Forms.Button();
            this.Color = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.Circulo = new System.Windows.Forms.Button();
            this.Rectangulo = new System.Windows.Forms.Button();
            this.Imagen = new System.Windows.Forms.Button();
            this.Texto = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // Mano
            // 
            this.Mano.BackColor = System.Drawing.Color.White;
            this.Mano.BackgroundImage = global::Paint.Properties.Resources.hand__1_;
            this.Mano.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Mano.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Mano.Location = new System.Drawing.Point(12, 12);
            this.Mano.Name = "Mano";
            this.Mano.Padding = new System.Windows.Forms.Padding(50);
            this.Mano.Size = new System.Drawing.Size(66, 63);
            this.Mano.TabIndex = 0;
            this.Mano.UseVisualStyleBackColor = false;
            this.Mano.Click += new System.EventHandler(this.Mano_Click);
            // 
            // Linea
            // 
            this.Linea.BackColor = System.Drawing.Color.White;
            this.Linea.BackgroundImage = global::Paint.Properties.Resources.minus__1_;
            this.Linea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Linea.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Linea.Location = new System.Drawing.Point(117, 12);
            this.Linea.Name = "Linea";
            this.Linea.Size = new System.Drawing.Size(66, 63);
            this.Linea.TabIndex = 1;
            this.Linea.UseVisualStyleBackColor = false;
            this.Linea.Click += new System.EventHandler(this.Linea_Click);
            // 
            // Color
            // 
            this.Color.Location = new System.Drawing.Point(123, 273);
            this.Color.Name = "Color";
            this.Color.Size = new System.Drawing.Size(60, 40);
            this.Color.TabIndex = 2;
            this.Color.UseVisualStyleBackColor = true;
            this.Color.Click += new System.EventHandler(this.Color_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(12, 285);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(66, 20);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.Value = new decimal(new int[] {
            11,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // Circulo
            // 
            this.Circulo.BackColor = System.Drawing.Color.White;
            this.Circulo.Location = new System.Drawing.Point(12, 93);
            this.Circulo.Name = "Circulo";
            this.Circulo.Size = new System.Drawing.Size(66, 63);
            this.Circulo.TabIndex = 5;
            this.Circulo.UseVisualStyleBackColor = false;
            this.Circulo.Click += new System.EventHandler(this.Circulo_Click);
            // 
            // Rectangulo
            // 
            this.Rectangulo.BackColor = System.Drawing.Color.White;
            this.Rectangulo.Location = new System.Drawing.Point(117, 91);
            this.Rectangulo.Name = "Rectangulo";
            this.Rectangulo.Size = new System.Drawing.Size(66, 65);
            this.Rectangulo.TabIndex = 6;
            this.Rectangulo.UseVisualStyleBackColor = false;
            this.Rectangulo.Click += new System.EventHandler(this.Rectangulo_Click);
            // 
            // Imagen
            // 
            this.Imagen.BackColor = System.Drawing.Color.White;
            this.Imagen.Location = new System.Drawing.Point(12, 170);
            this.Imagen.Name = "Imagen";
            this.Imagen.Size = new System.Drawing.Size(66, 63);
            this.Imagen.TabIndex = 7;
            this.Imagen.UseVisualStyleBackColor = false;
            this.Imagen.Click += new System.EventHandler(this.Imagen_Click);
            // 
            // Texto
            // 
            this.Texto.BackColor = System.Drawing.Color.White;
            this.Texto.BackgroundImage = global::Paint.Properties.Resources.tex;
            this.Texto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Texto.Location = new System.Drawing.Point(117, 170);
            this.Texto.Name = "Texto";
            this.Texto.Padding = new System.Windows.Forms.Padding(10, 10, 50, 50);
            this.Texto.Size = new System.Drawing.Size(66, 63);
            this.Texto.TabIndex = 8;
            this.Texto.UseVisualStyleBackColor = false;
            this.Texto.Click += new System.EventHandler(this.Texto_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Archivos PNG(*.png)|*.png|Archivos JPG(*.jpg)|*.jpg";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(123, 247);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(60, 20);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "circulo-removebg-preview.png");
            this.imageList1.Images.SetKeyName(1, "images__1_-removebg-preview.png");
            this.imageList1.Images.SetKeyName(2, "imagen-removebg-preview.png");
            // 
            // Objetos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(210, 325);
            this.ControlBox = false;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Texto);
            this.Controls.Add(this.Imagen);
            this.Controls.Add(this.Rectangulo);
            this.Controls.Add(this.Circulo);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.Color);
            this.Controls.Add(this.Linea);
            this.Controls.Add(this.Mano);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(1100, 0);
            this.Name = "Objetos";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Herramientas";
            this.Deactivate += new System.EventHandler(this.Objetos_Deactivate);
            this.Load += new System.EventHandler(this.Objetos_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Objetos_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Objetos_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Mano;
        private System.Windows.Forms.Button Linea;
        private System.Windows.Forms.Button Color;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button Circulo;
        private System.Windows.Forms.Button Rectangulo;
        private System.Windows.Forms.Button Imagen;
        private System.Windows.Forms.Button Texto;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ImageList imageList1;
    }
}