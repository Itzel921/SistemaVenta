namespace CapaPresentacion
{
    partial class FrmListadoProducto
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
            this.btneliminar = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.dlistado = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnnombre = new System.Windows.Forms.RadioButton();
            this.rbtncodigo = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dlistado)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btneliminar
            // 
            this.btneliminar.Font = new System.Drawing.Font("UD Digi Kyokasho NK", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btneliminar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btneliminar.Location = new System.Drawing.Point(761, 619);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(157, 34);
            this.btneliminar.TabIndex = 12;
            this.btneliminar.Text = "&Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btneditar
            // 
            this.btneditar.Font = new System.Drawing.Font("UD Digi Kyokasho NK", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btneditar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btneditar.Location = new System.Drawing.Point(547, 619);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(157, 34);
            this.btneditar.TabIndex = 11;
            this.btneditar.Text = "&Editar";
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.Font = new System.Drawing.Font("UD Digi Kyokasho NK", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnnuevo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnnuevo.Location = new System.Drawing.Point(323, 619);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(157, 34);
            this.btnnuevo.TabIndex = 10;
            this.btnnuevo.Text = "&Nuevo";
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // dlistado
            // 
            this.dlistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dlistado.Location = new System.Drawing.Point(42, 264);
            this.dlistado.Name = "dlistado";
            this.dlistado.RowHeadersWidth = 51;
            this.dlistado.RowTemplate.Height = 24;
            this.dlistado.Size = new System.Drawing.Size(1210, 303);
            this.dlistado.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnsalir);
            this.panel1.Controls.Add(this.btnbuscar);
            this.panel1.Controls.Add(this.txtbuscar);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(29, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1210, 155);
            this.panel1.TabIndex = 8;
            // 
            // btnsalir
            // 
            this.btnsalir.Font = new System.Drawing.Font("UD Digi Kyokasho NK", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnsalir.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnsalir.Location = new System.Drawing.Point(1061, 59);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(129, 34);
            this.btnsalir.TabIndex = 3;
            this.btnsalir.Text = "&Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Font = new System.Drawing.Font("UD Digi Kyokasho NK", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnbuscar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnbuscar.Location = new System.Drawing.Point(904, 59);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(129, 34);
            this.btnbuscar.TabIndex = 2;
            this.btnbuscar.Text = "&Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // txtbuscar
            // 
            this.txtbuscar.Font = new System.Drawing.Font("UD Digi Kyokasho NK", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtbuscar.Location = new System.Drawing.Point(391, 59);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(461, 27);
            this.txtbuscar.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnnombre);
            this.groupBox1.Controls.Add(this.rbtncodigo);
            this.groupBox1.Font = new System.Drawing.Font("UD Digi Kyokasho NK", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.groupBox1.Location = new System.Drawing.Point(17, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 107);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Críterio de búsqueda";
            // 
            // rbtnnombre
            // 
            this.rbtnnombre.AutoSize = true;
            this.rbtnnombre.Location = new System.Drawing.Point(26, 72);
            this.rbtnnombre.Name = "rbtnnombre";
            this.rbtnnombre.Size = new System.Drawing.Size(110, 28);
            this.rbtnnombre.TabIndex = 1;
            this.rbtnnombre.TabStop = true;
            this.rbtnnombre.Text = "Nombre";
            this.rbtnnombre.UseVisualStyleBackColor = true;
            // 
            // rbtncodigo
            // 
            this.rbtncodigo.AutoSize = true;
            this.rbtncodigo.Location = new System.Drawing.Point(26, 35);
            this.rbtncodigo.Name = "rbtncodigo";
            this.rbtncodigo.Size = new System.Drawing.Size(103, 28);
            this.rbtncodigo.TabIndex = 0;
            this.rbtncodigo.TabStop = true;
            this.rbtncodigo.Text = "Codigo";
            this.rbtncodigo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("UD Digi Kyokasho NK", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label1.Location = new System.Drawing.Point(37, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 26);
            this.label1.TabIndex = 7;
            this.label1.Text = "Productos";
            // 
            // FrmListadoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 710);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.dlistado);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmListadoProducto";
            this.Text = "FrmListadoProducto";
            this.Load += new System.EventHandler(this.FrmListadoProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dlistado)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.DataGridView dlistado;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnnombre;
        private System.Windows.Forms.RadioButton rbtncodigo;
        private System.Windows.Forms.Label label1;
    }
}