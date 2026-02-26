namespace CapaPresentacion
{
    partial class FrmRegistrarProducto
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
            this.txtidproducto = new System.Windows.Forms.TextBox();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateFingreso = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dateFvencimiento = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPcompra = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPventa = new System.Windows.Forms.TextBox();
            this.txtidcategoria = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rbActivo = new System.Windows.Forms.RadioButton();
            this.rbPasivo = new System.Windows.Forms.RadioButton();
            this.txtdescripcion = new System.Windows.Forms.RichTextBox();
            this.txtStock = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtStock)).BeginInit();
            this.SuspendLayout();
            // 
            // txtidproducto
            // 
            this.txtidproducto.Location = new System.Drawing.Point(316, 37);
            this.txtidproducto.Name = "txtidproducto";
            this.txtidproducto.Size = new System.Drawing.Size(100, 22);
            this.txtidproducto.TabIndex = 33;
            this.txtidproducto.Visible = false;
            // 
            // btncancelar
            // 
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancelar.Font = new System.Drawing.Font("UD Digi Kyokasho NK", 10.2F, System.Drawing.FontStyle.Bold);
            this.btncancelar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btncancelar.Location = new System.Drawing.Point(333, 653);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(115, 34);
            this.btncancelar.TabIndex = 32;
            this.btncancelar.Text = "&Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardar.Font = new System.Drawing.Font("UD Digi Kyokasho NK", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnguardar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnguardar.Location = new System.Drawing.Point(172, 653);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(113, 34);
            this.btnguardar.TabIndex = 31;
            this.btnguardar.Text = "&Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // txtcodigo
            // 
            this.txtcodigo.Font = new System.Drawing.Font("UD Digi Kyokasho NK", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtcodigo.Location = new System.Drawing.Point(316, 123);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(231, 27);
            this.txtcodigo.TabIndex = 27;
            // 
            // txtnombre
            // 
            this.txtnombre.Font = new System.Drawing.Font("UD Digi Kyokasho NK", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtnombre.Location = new System.Drawing.Point(37, 123);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(227, 27);
            this.txtnombre.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("UD Digi Kyokasho NK", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label5.Location = new System.Drawing.Point(313, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 24);
            this.label5.TabIndex = 21;
            this.label5.Text = "Codigo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("UD Digi Kyokasho NK", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label3.Location = new System.Drawing.Point(35, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 24);
            this.label3.TabIndex = 19;
            this.label3.Text = "Descripción:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("UD Digi Kyokasho NK", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label2.Location = new System.Drawing.Point(33, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 24);
            this.label2.TabIndex = 18;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("UD Digi Kyokasho NK", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label1.Location = new System.Drawing.Point(24, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "Registrar Nuevo Producto";
            // 
            // dateFingreso
            // 
            this.dateFingreso.Font = new System.Drawing.Font("UD Digi Kyokasho NK", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dateFingreso.Location = new System.Drawing.Point(37, 369);
            this.dateFingreso.Name = "dateFingreso";
            this.dateFingreso.Size = new System.Drawing.Size(217, 27);
            this.dateFingreso.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("UD Digi Kyokasho NK", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label8.Location = new System.Drawing.Point(35, 333);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(193, 24);
            this.label8.TabIndex = 35;
            this.label8.Text = "Fecha de ingreso:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("UD Digi Kyokasho NK", 12F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label9.Location = new System.Drawing.Point(324, 333);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(240, 24);
            this.label9.TabIndex = 37;
            this.label9.Text = "Fecha de vencimiento:";
            // 
            // dateFvencimiento
            // 
            this.dateFvencimiento.Font = new System.Drawing.Font("UD Digi Kyokasho NK", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dateFvencimiento.Location = new System.Drawing.Point(324, 369);
            this.dateFvencimiento.Name = "dateFvencimiento";
            this.dateFvencimiento.Size = new System.Drawing.Size(224, 27);
            this.dateFvencimiento.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("UD Digi Kyokasho NK", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label4.Location = new System.Drawing.Point(35, 433);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 24);
            this.label4.TabIndex = 20;
            this.label4.Text = "Precio de compra:";
            // 
            // txtPcompra
            // 
            this.txtPcompra.Font = new System.Drawing.Font("UD Digi Kyokasho NK", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtPcompra.Location = new System.Drawing.Point(39, 469);
            this.txtPcompra.Name = "txtPcompra";
            this.txtPcompra.Size = new System.Drawing.Size(216, 27);
            this.txtPcompra.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("UD Digi Kyokasho NK", 12F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label10.Location = new System.Drawing.Point(324, 433);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(177, 24);
            this.label10.TabIndex = 38;
            this.label10.Text = "Precio de venta:";
            // 
            // txtPventa
            // 
            this.txtPventa.Font = new System.Drawing.Font("UD Digi Kyokasho NK", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtPventa.Location = new System.Drawing.Point(324, 469);
            this.txtPventa.Name = "txtPventa";
            this.txtPventa.Size = new System.Drawing.Size(224, 27);
            this.txtPventa.TabIndex = 39;
            // 
            // txtidcategoria
            // 
            this.txtidcategoria.Font = new System.Drawing.Font("UD Digi Kyokasho NK", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtidcategoria.Location = new System.Drawing.Point(316, 231);
            this.txtidcategoria.Name = "txtidcategoria";
            this.txtidcategoria.Size = new System.Drawing.Size(231, 27);
            this.txtidcategoria.TabIndex = 43;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label11.Location = new System.Drawing.Point(340, 534);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 24);
            this.label11.TabIndex = 42;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("UD Digi Kyokasho NK", 12F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label12.Location = new System.Drawing.Point(35, 526);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 24);
            this.label12.TabIndex = 40;
            this.label12.Text = "Stock:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("UD Digi Kyokasho NK", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label6.Location = new System.Drawing.Point(324, 526);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 24);
            this.label6.TabIndex = 44;
            this.label6.Text = "Activo o pasivo:";
            // 
            // rbActivo
            // 
            this.rbActivo.AutoSize = true;
            this.rbActivo.Checked = true;
            this.rbActivo.Font = new System.Drawing.Font("UD Digi Kyokasho NK", 10.2F, System.Drawing.FontStyle.Bold);
            this.rbActivo.Location = new System.Drawing.Point(333, 565);
            this.rbActivo.Name = "rbActivo";
            this.rbActivo.Size = new System.Drawing.Size(84, 24);
            this.rbActivo.TabIndex = 45;
            this.rbActivo.TabStop = true;
            this.rbActivo.Text = "Activo";
            this.rbActivo.UseVisualStyleBackColor = true;
            // 
            // rbPasivo
            // 
            this.rbPasivo.AutoSize = true;
            this.rbPasivo.Font = new System.Drawing.Font("UD Digi Kyokasho NK", 10.2F, System.Drawing.FontStyle.Bold);
            this.rbPasivo.Location = new System.Drawing.Point(447, 565);
            this.rbPasivo.Name = "rbPasivo";
            this.rbPasivo.Size = new System.Drawing.Size(87, 24);
            this.rbPasivo.TabIndex = 46;
            this.rbPasivo.TabStop = true;
            this.rbPasivo.Text = "Pasivo";
            this.rbPasivo.UseVisualStyleBackColor = true;
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(39, 231);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(225, 62);
            this.txtdescripcion.TabIndex = 47;
            this.txtdescripcion.Text = "";
            // 
            // txtStock
            // 
            this.txtStock.Font = new System.Drawing.Font("UD Digi Kyokasho NK", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtStock.Location = new System.Drawing.Point(39, 565);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(217, 27);
            this.txtStock.TabIndex = 48;
            this.txtStock.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("UD Digi Kyokasho NK", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label7.Location = new System.Drawing.Point(313, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 24);
            this.label7.TabIndex = 49;
            this.label7.Text = "Categoria:";
            // 
            // FrmRegistrarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 729);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.txtdescripcion);
            this.Controls.Add(this.rbPasivo);
            this.Controls.Add(this.rbActivo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtidcategoria);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtPventa);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dateFvencimiento);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateFingreso);
            this.Controls.Add(this.txtidproducto);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.txtPcompra);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRegistrarProducto";
            this.Text = "FrmRegistrarProducto";
            this.Load += new System.EventHandler(this.FrmRegistrarProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtidproducto;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnguardar;
        public System.Windows.Forms.TextBox txtcodigo;
        public System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateFingreso;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateFvencimiento;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtPcompra;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox txtPventa;
        public System.Windows.Forms.TextBox txtidcategoria;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rbActivo;
        private System.Windows.Forms.RadioButton rbPasivo;
        private System.Windows.Forms.RichTextBox txtdescripcion;
        private System.Windows.Forms.NumericUpDown txtStock;
        private System.Windows.Forms.Label label7;
    }
}