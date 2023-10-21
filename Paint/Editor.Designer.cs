namespace Paint
{
    partial class Editor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editor));
            this.pnt1_x = new System.Windows.Forms.NumericUpDown();
            this.Tamaño = new System.Windows.Forms.Label();
            this.punto2 = new System.Windows.Forms.Label();
            this.tamanio = new System.Windows.Forms.NumericUpDown();
            this.punto1 = new System.Windows.Forms.Label();
            this.Y = new System.Windows.Forms.Label();
            this.X = new System.Windows.Forms.Label();
            this.pnt2_y = new System.Windows.Forms.NumericUpDown();
            this.pnt2_x = new System.Windows.Forms.NumericUpDown();
            this.pnt1_y = new System.Windows.Forms.NumericUpDown();
            this.fuente = new System.Windows.Forms.Button();
            this.color = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.texto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.alto = new System.Windows.Forms.NumericUpDown();
            this.ancho = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pnt1_x)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tamanio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnt2_y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnt2_x)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnt1_y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ancho)).BeginInit();
            this.SuspendLayout();
            // 
            // pnt1_x
            // 
            this.pnt1_x.Location = new System.Drawing.Point(45, 38);
            this.pnt1_x.Maximum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            0});
            this.pnt1_x.Minimum = new decimal(new int[] {
            276447232,
            23283,
            0,
            -2147483648});
            this.pnt1_x.Name = "pnt1_x";
            this.pnt1_x.Size = new System.Drawing.Size(63, 20);
            this.pnt1_x.TabIndex = 7;
            this.pnt1_x.ValueChanged += new System.EventHandler(this.pnt1_x_ValueChanged);
            // 
            // Tamaño
            // 
            this.Tamaño.AutoSize = true;
            this.Tamaño.Location = new System.Drawing.Point(234, 9);
            this.Tamaño.Name = "Tamaño";
            this.Tamaño.Size = new System.Drawing.Size(46, 13);
            this.Tamaño.TabIndex = 3;
            this.Tamaño.Text = "Tamaño";
            // 
            // punto2
            // 
            this.punto2.AutoSize = true;
            this.punto2.Location = new System.Drawing.Point(125, 9);
            this.punto2.Name = "punto2";
            this.punto2.Size = new System.Drawing.Size(80, 13);
            this.punto2.TabIndex = 4;
            this.punto2.Text = "Segundo punto";
            // 
            // tamanio
            // 
            this.tamanio.Location = new System.Drawing.Point(237, 38);
            this.tamanio.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tamanio.Name = "tamanio";
            this.tamanio.Size = new System.Drawing.Size(49, 20);
            this.tamanio.TabIndex = 5;
            this.tamanio.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tamanio.ValueChanged += new System.EventHandler(this.tamanio_ValueChanged);
            // 
            // punto1
            // 
            this.punto1.AutoSize = true;
            this.punto1.Location = new System.Drawing.Point(42, 9);
            this.punto1.Name = "punto1";
            this.punto1.Size = new System.Drawing.Size(66, 13);
            this.punto1.TabIndex = 0;
            this.punto1.Text = "Primer punto";
            // 
            // Y
            // 
            this.Y.AutoSize = true;
            this.Y.Location = new System.Drawing.Point(4, 73);
            this.Y.Name = "Y";
            this.Y.Size = new System.Drawing.Size(17, 13);
            this.Y.TabIndex = 8;
            this.Y.Text = "Y:";
            // 
            // X
            // 
            this.X.AutoSize = true;
            this.X.Location = new System.Drawing.Point(4, 40);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(17, 13);
            this.X.TabIndex = 9;
            this.X.Text = "X:";
            // 
            // pnt2_y
            // 
            this.pnt2_y.Location = new System.Drawing.Point(128, 71);
            this.pnt2_y.Maximum = new decimal(new int[] {
            -1530494976,
            232830,
            0,
            0});
            this.pnt2_y.Minimum = new decimal(new int[] {
            276447232,
            23283,
            0,
            -2147483648});
            this.pnt2_y.Name = "pnt2_y";
            this.pnt2_y.Size = new System.Drawing.Size(77, 20);
            this.pnt2_y.TabIndex = 10;
            this.pnt2_y.ValueChanged += new System.EventHandler(this.pnt2_y_ValueChanged);
            // 
            // pnt2_x
            // 
            this.pnt2_x.Location = new System.Drawing.Point(128, 40);
            this.pnt2_x.Maximum = new decimal(new int[] {
            -559939584,
            902409669,
            54,
            0});
            this.pnt2_x.Minimum = new decimal(new int[] {
            -1530494976,
            232830,
            0,
            -2147483648});
            this.pnt2_x.Name = "pnt2_x";
            this.pnt2_x.Size = new System.Drawing.Size(77, 20);
            this.pnt2_x.TabIndex = 11;
            this.pnt2_x.ValueChanged += new System.EventHandler(this.pnt2_x_ValueChanged);
            // 
            // pnt1_y
            // 
            this.pnt1_y.Location = new System.Drawing.Point(45, 71);
            this.pnt1_y.Maximum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            0});
            this.pnt1_y.Minimum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            -2147483648});
            this.pnt1_y.Name = "pnt1_y";
            this.pnt1_y.Size = new System.Drawing.Size(63, 20);
            this.pnt1_y.TabIndex = 12;
            this.pnt1_y.ValueChanged += new System.EventHandler(this.pnt1_y_ValueChanged);
            // 
            // fuente
            // 
            this.fuente.Location = new System.Drawing.Point(489, 9);
            this.fuente.Name = "fuente";
            this.fuente.Size = new System.Drawing.Size(66, 59);
            this.fuente.TabIndex = 13;
            this.fuente.UseVisualStyleBackColor = true;
            this.fuente.Click += new System.EventHandler(this.fuente_Click);
            // 
            // color
            // 
            this.color.Location = new System.Drawing.Point(561, 9);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(64, 58);
            this.color.TabIndex = 14;
            this.color.UseVisualStyleBackColor = true;
            this.color.Click += new System.EventHandler(this.color_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "texto-removebg-preview.png");
            // 
            // texto
            // 
            this.texto.Location = new System.Drawing.Point(649, 25);
            this.texto.Name = "texto";
            this.texto.Size = new System.Drawing.Size(100, 20);
            this.texto.TabIndex = 15;
            this.texto.TextChanged += new System.EventHandler(this.texto_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(646, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Texto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(396, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Alto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(316, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Ancho";
            // 
            // alto
            // 
            this.alto.Location = new System.Drawing.Point(399, 38);
            this.alto.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.alto.Name = "alto";
            this.alto.Size = new System.Drawing.Size(67, 20);
            this.alto.TabIndex = 19;
            this.alto.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.alto.ValueChanged += new System.EventHandler(this.alto_ValueChanged);
            // 
            // ancho
            // 
            this.ancho.Location = new System.Drawing.Point(319, 38);
            this.ancho.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ancho.Name = "ancho";
            this.ancho.Size = new System.Drawing.Size(62, 20);
            this.ancho.TabIndex = 20;
            this.ancho.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ancho.ValueChanged += new System.EventHandler(this.ancho_ValueChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(674, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(75, 20);
            this.textBox1.TabIndex = 21;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(674, 73);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(75, 20);
            this.textBox2.TabIndex = 22;
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(761, 95);
            this.ControlBox = false;
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ancho);
            this.Controls.Add(this.alto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.texto);
            this.Controls.Add(this.color);
            this.Controls.Add(this.fuente);
            this.Controls.Add(this.pnt1_y);
            this.Controls.Add(this.pnt2_x);
            this.Controls.Add(this.pnt2_y);
            this.Controls.Add(this.X);
            this.Controls.Add(this.Y);
            this.Controls.Add(this.pnt1_x);
            this.Controls.Add(this.tamanio);
            this.Controls.Add(this.punto2);
            this.Controls.Add(this.Tamaño);
            this.Controls.Add(this.punto1);
            this.Location = new System.Drawing.Point(280, 550);
            this.Name = "Editor";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Editor";
            this.Load += new System.EventHandler(this.Editor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnt1_x)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tamanio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnt2_y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnt2_x)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnt1_y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ancho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown pnt1_x;
        private System.Windows.Forms.Label Tamaño;
        private System.Windows.Forms.Label punto2;
        private System.Windows.Forms.NumericUpDown tamanio;
        private System.Windows.Forms.Label punto1;
        private System.Windows.Forms.Label Y;
        private System.Windows.Forms.Label X;
        private System.Windows.Forms.NumericUpDown pnt2_y;
        private System.Windows.Forms.NumericUpDown pnt2_x;
        private System.Windows.Forms.NumericUpDown pnt1_y;
        private System.Windows.Forms.Button fuente;
        private System.Windows.Forms.Button color;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox texto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown alto;
        private System.Windows.Forms.NumericUpDown ancho;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}