namespace CapaPresentacion
{
    partial class FrmConsultaVencimiento
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblVencimiento = new System.Windows.Forms.DataGridView();
            this.brnReporte = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lblVencimiento)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnBuscar.Location = new System.Drawing.Point(683, 420);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(165, 44);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "&Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblVencimiento
            // 
            this.lblVencimiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lblVencimiento.Location = new System.Drawing.Point(50, 145);
            this.lblVencimiento.Name = "lblVencimiento";
            this.lblVencimiento.RowHeadersWidth = 51;
            this.lblVencimiento.RowTemplate.Height = 24;
            this.lblVencimiento.Size = new System.Drawing.Size(1049, 248);
            this.lblVencimiento.TabIndex = 10;
            // 
            // brnReporte
            // 
            this.brnReporte.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.brnReporte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.brnReporte.Location = new System.Drawing.Point(297, 420);
            this.brnReporte.Name = "brnReporte";
            this.brnReporte.Size = new System.Drawing.Size(165, 44);
            this.brnReporte.TabIndex = 9;
            this.brnReporte.Text = "&Reporte";
            this.brnReporte.UseVisualStyleBackColor = true;
            this.brnReporte.Click += new System.EventHandler(this.brnReporte_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("UD Digi Kyokasho NP", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(139, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(906, 33);
            this.label1.TabIndex = 11;
            this.label1.Text = "Listado de productos apunto de vencer cercano a los 15 días.\r\n";
            // 
            // FrmConsultaVencimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 513);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblVencimiento);
            this.Controls.Add(this.brnReporte);
            this.Controls.Add(this.btnBuscar);
            this.Font = new System.Drawing.Font("UD Digi Kyokasho NP", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FrmConsultaVencimiento";
            this.Text = "FrmConsultaVencimiento";
            ((System.ComponentModel.ISupportInitialize)(this.lblVencimiento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView lblVencimiento;
        private System.Windows.Forms.Button brnReporte;
        private System.Windows.Forms.Label label1;
    }
}