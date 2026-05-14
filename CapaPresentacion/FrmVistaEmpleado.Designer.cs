namespace CapaPresentacion
{
    partial class FrmVistaEmpleado
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dlistado = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtndni = new System.Windows.Forms.RadioButton();
            this.rbtnnombre = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dlistado)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dlistado
            // 
            this.dlistado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("UD Digi Kyokasho NK", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dlistado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dlistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("UD Digi Kyokasho NK", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dlistado.DefaultCellStyle = dataGridViewCellStyle4;
            this.dlistado.Location = new System.Drawing.Point(64, 255);
            this.dlistado.Name = "dlistado";
            this.dlistado.RowHeadersWidth = 51;
            this.dlistado.RowTemplate.Height = 24;
            this.dlistado.Size = new System.Drawing.Size(1012, 248);
            this.dlistado.TabIndex = 15;
            this.dlistado.DoubleClick += new System.EventHandler(this.dlistado_DoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnsalir);
            this.panel1.Controls.Add(this.btnbuscar);
            this.panel1.Controls.Add(this.txtbuscar);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(35, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1060, 155);
            this.panel1.TabIndex = 14;
            // 
            // btnsalir
            // 
            this.btnsalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalir.Font = new System.Drawing.Font("UD Digi Kyokasho NK", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnsalir.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnsalir.Location = new System.Drawing.Point(929, 64);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(112, 35);
            this.btnsalir.TabIndex = 3;
            this.btnsalir.Text = "&Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscar.Font = new System.Drawing.Font("UD Digi Kyokasho NK", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnbuscar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnbuscar.Location = new System.Drawing.Point(785, 64);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(112, 35);
            this.btnbuscar.TabIndex = 2;
            this.btnbuscar.Text = "&Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // txtbuscar
            // 
            this.txtbuscar.Font = new System.Drawing.Font("UD Digi Kyokasho NK", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtbuscar.Location = new System.Drawing.Point(314, 64);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(429, 31);
            this.txtbuscar.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtndni);
            this.groupBox1.Controls.Add(this.rbtnnombre);
            this.groupBox1.Font = new System.Drawing.Font("UD Digi Kyokasho NK", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.groupBox1.Location = new System.Drawing.Point(17, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 107);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Críterio de búsqueda";
            // 
            // rbtndni
            // 
            this.rbtndni.AutoSize = true;
            this.rbtndni.Location = new System.Drawing.Point(26, 72);
            this.rbtndni.Name = "rbtndni";
            this.rbtndni.Size = new System.Drawing.Size(72, 28);
            this.rbtndni.TabIndex = 1;
            this.rbtndni.TabStop = true;
            this.rbtndni.Text = "DNI";
            this.rbtndni.UseVisualStyleBackColor = true;
            // 
            // rbtnnombre
            // 
            this.rbtnnombre.AutoSize = true;
            this.rbtnnombre.Location = new System.Drawing.Point(26, 35);
            this.rbtnnombre.Name = "rbtnnombre";
            this.rbtnnombre.Size = new System.Drawing.Size(110, 28);
            this.rbtnnombre.TabIndex = 0;
            this.rbtnnombre.TabStop = true;
            this.rbtnnombre.Text = "Nombre";
            this.rbtnnombre.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("UD Digi Kyokasho NK", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label1.Location = new System.Drawing.Point(47, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 26);
            this.label1.TabIndex = 13;
            this.label1.Text = "Empleados";
            // 
            // FrmVistaEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1171, 536);
            this.Controls.Add(this.dlistado);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmVistaEmpleado";
            this.Text = "FrmVistaEmpleado";
            this.Load += new System.EventHandler(this.FrmVistaEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dlistado)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtndni;
        private System.Windows.Forms.RadioButton rbtnnombre;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dlistado;
    }
}