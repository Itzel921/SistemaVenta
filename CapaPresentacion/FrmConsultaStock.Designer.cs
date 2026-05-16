namespace CapaPresentacion
{
    partial class FrmConsultaStock
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
            this.ldlStock = new System.Windows.Forms.DataGridView();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.btnreportes = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ldlStock)).BeginInit();
            this.SuspendLayout();
            // 
            // ldlStock
            // 
            this.ldlStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ldlStock.Location = new System.Drawing.Point(40, 130);
            this.ldlStock.Name = "ldlStock";
            this.ldlStock.RowHeadersWidth = 51;
            this.ldlStock.RowTemplate.Height = 24;
            this.ldlStock.Size = new System.Drawing.Size(903, 264);
            this.ldlStock.TabIndex = 0;
            // 
            // btnbuscar
            // 
            this.btnbuscar.FlatAppearance.BorderColor = System.Drawing.Color.DarkOliveGreen;
            this.btnbuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnbuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnbuscar.Font = new System.Drawing.Font("UD Digi Kyokasho NK", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnbuscar.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnbuscar.Location = new System.Drawing.Point(234, 426);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(180, 47);
            this.btnbuscar.TabIndex = 11;
            this.btnbuscar.Text = "&Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // btnreportes
            // 
            this.btnreportes.FlatAppearance.BorderColor = System.Drawing.Color.DarkOliveGreen;
            this.btnreportes.Font = new System.Drawing.Font("UD Digi Kyokasho NK", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnreportes.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnreportes.Location = new System.Drawing.Point(573, 426);
            this.btnreportes.Name = "btnreportes";
            this.btnreportes.Size = new System.Drawing.Size(180, 47);
            this.btnreportes.TabIndex = 12;
            this.btnreportes.Text = "&Reportes";
            this.btnreportes.UseVisualStyleBackColor = true;
            this.btnreportes.Click += new System.EventHandler(this.btnreportes_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("UD Digi Kyokasho NK", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(33, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(775, 33);
            this.label3.TabIndex = 13;
            this.label3.Text = "Listado de productos con poco stock en el inventario";
            // 
            // FrmConsultaStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 510);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnreportes);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.ldlStock);
            this.Font = new System.Drawing.Font("UD Digi Kyokasho NP", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FrmConsultaStock";
            this.Text = "FrmConsultaStock";
            ((System.ComponentModel.ISupportInitialize)(this.ldlStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ldlStock;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Button btnreportes;
        private System.Windows.Forms.Label label3;
    }
}