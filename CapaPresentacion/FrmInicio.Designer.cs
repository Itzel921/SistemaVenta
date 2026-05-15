namespace CapaPresentacion
{
    partial class FrmInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicio));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUsuarioLogueado = new System.Windows.Forms.Label();
            this.btnmaximizar = new System.Windows.Forms.PictureBox();
            this.btnminimizar = new System.Windows.Forms.PictureBox();
            this.btnrestaurar = new System.Windows.Forms.PictureBox();
            this.btncerrar = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mnualmacen = new System.Windows.Forms.Panel();
            this.categoria = new System.Windows.Forms.Button();
            this.producto = new System.Windows.Forms.Button();
            this.btnalmacen = new System.Windows.Forms.Button();
            this.mnucompra = new System.Windows.Forms.Panel();
            this.btnproveedor = new System.Windows.Forms.Button();
            this.btngenerarcompra = new System.Windows.Forms.Button();
            this.btncompras = new System.Windows.Forms.Button();
            this.mnuventa = new System.Windows.Forms.Panel();
            this.btnclientes = new System.Windows.Forms.Button();
            this.btngenerarventa = new System.Windows.Forms.Button();
            this.btnventas = new System.Windows.Forms.Button();
            this.mnureportes = new System.Windows.Forms.Panel();
            this.btnreporteempleado = new System.Windows.Forms.Button();
            this.btnreportecliente = new System.Windows.Forms.Button();
            this.btnreporteproducto = new System.Windows.Forms.Button();
            this.btnreportes = new System.Windows.Forms.Button();
            this.mnuconsultas = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.btnstockminimo = new System.Windows.Forms.Button();
            this.btncomprafechas = new System.Windows.Forms.Button();
            this.btnventafechas = new System.Windows.Forms.Button();
            this.btnconsultas = new System.Windows.Forms.Button();
            this.mnuconfiguraciones = new System.Windows.Forms.Panel();
            this.btnusuarios = new System.Windows.Forms.Button();
            this.btnempleados = new System.Windows.Forms.Button();
            this.btnconfiguraciones = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCerrarSesión = new System.Windows.Forms.Button();
            this.btnStockMin = new System.Windows.Forms.Button();
            this.btnAtajoEmpleados = new System.Windows.Forms.Button();
            this.btnAtajoCompras = new System.Windows.Forms.Button();
            this.btnAtajoVentas = new System.Windows.Forms.Button();
            this.btnAtajoProductos = new System.Windows.Forms.Button();
            this.btnAtajoClientes = new System.Windows.Forms.Button();
            this.tmrsubmenu = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnmaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnrestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.mnualmacen.SuspendLayout();
            this.mnucompra.SuspendLayout();
            this.mnuventa.SuspendLayout();
            this.mnureportes.SuspendLayout();
            this.mnuconsultas.SuspendLayout();
            this.mnuconfiguraciones.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.lblUsuarioLogueado);
            this.panel1.Controls.Add(this.btnmaximizar);
            this.panel1.Controls.Add(this.btnminimizar);
            this.panel1.Controls.Add(this.btnrestaurar);
            this.panel1.Controls.Add(this.btncerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1356, 67);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblUsuarioLogueado
            // 
            this.lblUsuarioLogueado.AutoSize = true;
            this.lblUsuarioLogueado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblUsuarioLogueado.Font = new System.Drawing.Font("UD Digi Kyokasho NK", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblUsuarioLogueado.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblUsuarioLogueado.Location = new System.Drawing.Point(0, 47);
            this.lblUsuarioLogueado.Name = "lblUsuarioLogueado";
            this.lblUsuarioLogueado.Size = new System.Drawing.Size(175, 20);
            this.lblUsuarioLogueado.TabIndex = 4;
            this.lblUsuarioLogueado.Text = "Nombre de Usuario";
            // 
            // btnmaximizar
            // 
            this.btnmaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnmaximizar.Image")));
            this.btnmaximizar.Location = new System.Drawing.Point(1284, 3);
            this.btnmaximizar.Name = "btnmaximizar";
            this.btnmaximizar.Size = new System.Drawing.Size(25, 25);
            this.btnmaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnmaximizar.TabIndex = 3;
            this.btnmaximizar.TabStop = false;
            this.btnmaximizar.Click += new System.EventHandler(this.btnmaximizar_Click);
            // 
            // btnminimizar
            // 
            this.btnminimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnminimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnminimizar.Image")));
            this.btnminimizar.Location = new System.Drawing.Point(1253, 3);
            this.btnminimizar.Name = "btnminimizar";
            this.btnminimizar.Size = new System.Drawing.Size(25, 25);
            this.btnminimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnminimizar.TabIndex = 2;
            this.btnminimizar.TabStop = false;
            this.btnminimizar.Click += new System.EventHandler(this.btnminimizar_Click);
            // 
            // btnrestaurar
            // 
            this.btnrestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnrestaurar.Image = ((System.Drawing.Image)(resources.GetObject("btnrestaurar.Image")));
            this.btnrestaurar.Location = new System.Drawing.Point(1284, 3);
            this.btnrestaurar.Name = "btnrestaurar";
            this.btnrestaurar.Size = new System.Drawing.Size(25, 25);
            this.btnrestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnrestaurar.TabIndex = 1;
            this.btnrestaurar.TabStop = false;
            this.btnrestaurar.Click += new System.EventHandler(this.btnrestaurar_Click);
            // 
            // btncerrar
            // 
            this.btncerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btncerrar.Image = ((System.Drawing.Image)(resources.GetObject("btncerrar.Image")));
            this.btncerrar.Location = new System.Drawing.Point(1319, 3);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(25, 25);
            this.btncerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btncerrar.TabIndex = 0;
            this.btncerrar.TabStop = false;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.flowLayoutPanel1.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel1.Controls.Add(this.mnualmacen);
            this.flowLayoutPanel1.Controls.Add(this.mnucompra);
            this.flowLayoutPanel1.Controls.Add(this.mnuventa);
            this.flowLayoutPanel1.Controls.Add(this.mnureportes);
            this.flowLayoutPanel1.Controls.Add(this.mnuconsultas);
            this.flowLayoutPanel1.Controls.Add(this.mnuconfiguraciones);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 67);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(262, 646);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.RoyalBlue;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(259, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // mnualmacen
            // 
            this.mnualmacen.Controls.Add(this.categoria);
            this.mnualmacen.Controls.Add(this.producto);
            this.mnualmacen.Controls.Add(this.btnalmacen);
            this.mnualmacen.Location = new System.Drawing.Point(3, 106);
            this.mnualmacen.MaximumSize = new System.Drawing.Size(255, 120);
            this.mnualmacen.MinimumSize = new System.Drawing.Size(240, 37);
            this.mnualmacen.Name = "mnualmacen";
            this.mnualmacen.Size = new System.Drawing.Size(255, 44);
            this.mnualmacen.TabIndex = 4;
            // 
            // categoria
            // 
            this.categoria.BackColor = System.Drawing.SystemColors.Highlight;
            this.categoria.FlatAppearance.BorderSize = 0;
            this.categoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoria.ForeColor = System.Drawing.Color.White;
            this.categoria.Location = new System.Drawing.Point(68, 80);
            this.categoria.Name = "categoria";
            this.categoria.Size = new System.Drawing.Size(184, 28);
            this.categoria.TabIndex = 0;
            this.categoria.Text = "Categoria";
            this.categoria.UseVisualStyleBackColor = false;
            this.categoria.Click += new System.EventHandler(this.categoria_Click);
            // 
            // producto
            // 
            this.producto.BackColor = System.Drawing.SystemColors.Highlight;
            this.producto.FlatAppearance.BorderSize = 0;
            this.producto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.producto.ForeColor = System.Drawing.Color.White;
            this.producto.Location = new System.Drawing.Point(68, 46);
            this.producto.Name = "producto";
            this.producto.Size = new System.Drawing.Size(184, 28);
            this.producto.TabIndex = 1;
            this.producto.Text = "Producto";
            this.producto.UseVisualStyleBackColor = false;
            this.producto.Click += new System.EventHandler(this.producto_Click);
            // 
            // btnalmacen
            // 
            this.btnalmacen.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnalmacen.FlatAppearance.BorderSize = 0;
            this.btnalmacen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnalmacen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnalmacen.ForeColor = System.Drawing.Color.White;
            this.btnalmacen.Image = ((System.Drawing.Image)(resources.GetObject("btnalmacen.Image")));
            this.btnalmacen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnalmacen.Location = new System.Drawing.Point(3, 3);
            this.btnalmacen.Name = "btnalmacen";
            this.btnalmacen.Size = new System.Drawing.Size(249, 37);
            this.btnalmacen.TabIndex = 1;
            this.btnalmacen.Text = "Almacén";
            this.btnalmacen.UseVisualStyleBackColor = false;
            this.btnalmacen.Click += new System.EventHandler(this.btnalmacen_Click);
            // 
            // mnucompra
            // 
            this.mnucompra.Controls.Add(this.btnproveedor);
            this.mnucompra.Controls.Add(this.btngenerarcompra);
            this.mnucompra.Controls.Add(this.btncompras);
            this.mnucompra.Location = new System.Drawing.Point(3, 156);
            this.mnucompra.MaximumSize = new System.Drawing.Size(255, 120);
            this.mnucompra.MinimumSize = new System.Drawing.Size(229, 37);
            this.mnucompra.Name = "mnucompra";
            this.mnucompra.Size = new System.Drawing.Size(255, 43);
            this.mnucompra.TabIndex = 7;
            // 
            // btnproveedor
            // 
            this.btnproveedor.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnproveedor.FlatAppearance.BorderSize = 0;
            this.btnproveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnproveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnproveedor.ForeColor = System.Drawing.Color.White;
            this.btnproveedor.Location = new System.Drawing.Point(68, 80);
            this.btnproveedor.Name = "btnproveedor";
            this.btnproveedor.Size = new System.Drawing.Size(184, 28);
            this.btnproveedor.TabIndex = 2;
            this.btnproveedor.Text = "Proveedor";
            this.btnproveedor.UseVisualStyleBackColor = false;
            this.btnproveedor.Click += new System.EventHandler(this.btnproveedor_Click);
            // 
            // btngenerarcompra
            // 
            this.btngenerarcompra.BackColor = System.Drawing.SystemColors.Highlight;
            this.btngenerarcompra.FlatAppearance.BorderSize = 0;
            this.btngenerarcompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngenerarcompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngenerarcompra.ForeColor = System.Drawing.Color.White;
            this.btngenerarcompra.Location = new System.Drawing.Point(68, 46);
            this.btngenerarcompra.Name = "btngenerarcompra";
            this.btngenerarcompra.Size = new System.Drawing.Size(184, 28);
            this.btngenerarcompra.TabIndex = 1;
            this.btngenerarcompra.Text = "Generar compra";
            this.btngenerarcompra.UseVisualStyleBackColor = false;
            // 
            // btncompras
            // 
            this.btncompras.BackColor = System.Drawing.SystemColors.Highlight;
            this.btncompras.FlatAppearance.BorderSize = 0;
            this.btncompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncompras.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncompras.ForeColor = System.Drawing.Color.White;
            this.btncompras.Image = ((System.Drawing.Image)(resources.GetObject("btncompras.Image")));
            this.btncompras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncompras.Location = new System.Drawing.Point(3, 3);
            this.btncompras.Name = "btncompras";
            this.btncompras.Size = new System.Drawing.Size(249, 37);
            this.btncompras.TabIndex = 0;
            this.btncompras.Text = "Compras";
            this.btncompras.UseVisualStyleBackColor = false;
            this.btncompras.Click += new System.EventHandler(this.btncompras_Click);
            // 
            // mnuventa
            // 
            this.mnuventa.Controls.Add(this.btnclientes);
            this.mnuventa.Controls.Add(this.btngenerarventa);
            this.mnuventa.Controls.Add(this.btnventas);
            this.mnuventa.Location = new System.Drawing.Point(3, 205);
            this.mnuventa.MaximumSize = new System.Drawing.Size(255, 120);
            this.mnuventa.MinimumSize = new System.Drawing.Size(229, 37);
            this.mnuventa.Name = "mnuventa";
            this.mnuventa.Size = new System.Drawing.Size(255, 44);
            this.mnuventa.TabIndex = 6;
            // 
            // btnclientes
            // 
            this.btnclientes.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnclientes.FlatAppearance.BorderSize = 0;
            this.btnclientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclientes.ForeColor = System.Drawing.Color.White;
            this.btnclientes.Location = new System.Drawing.Point(68, 80);
            this.btnclientes.Name = "btnclientes";
            this.btnclientes.Size = new System.Drawing.Size(184, 28);
            this.btnclientes.TabIndex = 2;
            this.btnclientes.Text = "Clientes";
            this.btnclientes.UseVisualStyleBackColor = false;
            this.btnclientes.Click += new System.EventHandler(this.btnclientes_Click);
            // 
            // btngenerarventa
            // 
            this.btngenerarventa.BackColor = System.Drawing.SystemColors.Highlight;
            this.btngenerarventa.FlatAppearance.BorderSize = 0;
            this.btngenerarventa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngenerarventa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngenerarventa.ForeColor = System.Drawing.Color.White;
            this.btngenerarventa.Location = new System.Drawing.Point(68, 46);
            this.btngenerarventa.Name = "btngenerarventa";
            this.btngenerarventa.Size = new System.Drawing.Size(184, 28);
            this.btngenerarventa.TabIndex = 1;
            this.btngenerarventa.Text = "Generar venta";
            this.btngenerarventa.UseVisualStyleBackColor = false;
            // 
            // btnventas
            // 
            this.btnventas.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnventas.FlatAppearance.BorderSize = 0;
            this.btnventas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnventas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnventas.ForeColor = System.Drawing.Color.White;
            this.btnventas.Image = ((System.Drawing.Image)(resources.GetObject("btnventas.Image")));
            this.btnventas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnventas.Location = new System.Drawing.Point(3, 3);
            this.btnventas.Name = "btnventas";
            this.btnventas.Size = new System.Drawing.Size(249, 37);
            this.btnventas.TabIndex = 0;
            this.btnventas.Text = "Ventas";
            this.btnventas.UseVisualStyleBackColor = false;
            this.btnventas.Click += new System.EventHandler(this.btnventas_Click);
            // 
            // mnureportes
            // 
            this.mnureportes.Controls.Add(this.btnreporteempleado);
            this.mnureportes.Controls.Add(this.btnreportecliente);
            this.mnureportes.Controls.Add(this.btnreporteproducto);
            this.mnureportes.Controls.Add(this.btnreportes);
            this.mnureportes.Location = new System.Drawing.Point(3, 255);
            this.mnureportes.MaximumSize = new System.Drawing.Size(255, 150);
            this.mnureportes.MinimumSize = new System.Drawing.Size(229, 37);
            this.mnureportes.Name = "mnureportes";
            this.mnureportes.Size = new System.Drawing.Size(255, 45);
            this.mnureportes.TabIndex = 8;
            // 
            // btnreporteempleado
            // 
            this.btnreporteempleado.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnreporteempleado.FlatAppearance.BorderSize = 0;
            this.btnreporteempleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreporteempleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreporteempleado.ForeColor = System.Drawing.Color.White;
            this.btnreporteempleado.Location = new System.Drawing.Point(50, 114);
            this.btnreporteempleado.Name = "btnreporteempleado";
            this.btnreporteempleado.Size = new System.Drawing.Size(202, 28);
            this.btnreporteempleado.TabIndex = 3;
            this.btnreporteempleado.Text = "Empleados";
            this.btnreporteempleado.UseVisualStyleBackColor = false;
            // 
            // btnreportecliente
            // 
            this.btnreportecliente.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnreportecliente.FlatAppearance.BorderSize = 0;
            this.btnreportecliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreportecliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreportecliente.ForeColor = System.Drawing.Color.White;
            this.btnreportecliente.Location = new System.Drawing.Point(50, 80);
            this.btnreportecliente.Name = "btnreportecliente";
            this.btnreportecliente.Size = new System.Drawing.Size(202, 28);
            this.btnreportecliente.TabIndex = 2;
            this.btnreportecliente.Text = "Clientes";
            this.btnreportecliente.UseVisualStyleBackColor = false;
            // 
            // btnreporteproducto
            // 
            this.btnreporteproducto.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnreporteproducto.FlatAppearance.BorderSize = 0;
            this.btnreporteproducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreporteproducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreporteproducto.ForeColor = System.Drawing.Color.White;
            this.btnreporteproducto.Location = new System.Drawing.Point(50, 46);
            this.btnreporteproducto.Name = "btnreporteproducto";
            this.btnreporteproducto.Size = new System.Drawing.Size(202, 28);
            this.btnreporteproducto.TabIndex = 1;
            this.btnreporteproducto.Text = "Productos";
            this.btnreporteproducto.UseVisualStyleBackColor = false;
            // 
            // btnreportes
            // 
            this.btnreportes.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnreportes.FlatAppearance.BorderSize = 0;
            this.btnreportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreportes.ForeColor = System.Drawing.Color.White;
            this.btnreportes.Image = ((System.Drawing.Image)(resources.GetObject("btnreportes.Image")));
            this.btnreportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnreportes.Location = new System.Drawing.Point(3, 3);
            this.btnreportes.Name = "btnreportes";
            this.btnreportes.Size = new System.Drawing.Size(249, 37);
            this.btnreportes.TabIndex = 0;
            this.btnreportes.Text = "Reportes";
            this.btnreportes.UseVisualStyleBackColor = false;
            this.btnreportes.Click += new System.EventHandler(this.btnreportes_Click);
            // 
            // mnuconsultas
            // 
            this.mnuconsultas.Controls.Add(this.button6);
            this.mnuconsultas.Controls.Add(this.btnstockminimo);
            this.mnuconsultas.Controls.Add(this.btncomprafechas);
            this.mnuconsultas.Controls.Add(this.btnventafechas);
            this.mnuconsultas.Controls.Add(this.btnconsultas);
            this.mnuconsultas.Location = new System.Drawing.Point(3, 306);
            this.mnuconsultas.MaximumSize = new System.Drawing.Size(255, 188);
            this.mnuconsultas.MinimumSize = new System.Drawing.Size(229, 37);
            this.mnuconsultas.Name = "mnuconsultas";
            this.mnuconsultas.Size = new System.Drawing.Size(255, 43);
            this.mnuconsultas.TabIndex = 7;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.Highlight;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(37, 148);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(215, 28);
            this.button6.TabIndex = 4;
            this.button6.Text = "Fecha de vencimiento";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // btnstockminimo
            // 
            this.btnstockminimo.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnstockminimo.FlatAppearance.BorderSize = 0;
            this.btnstockminimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnstockminimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstockminimo.ForeColor = System.Drawing.Color.White;
            this.btnstockminimo.Location = new System.Drawing.Point(37, 114);
            this.btnstockminimo.Name = "btnstockminimo";
            this.btnstockminimo.Size = new System.Drawing.Size(215, 28);
            this.btnstockminimo.TabIndex = 3;
            this.btnstockminimo.Text = "Stock mínimo";
            this.btnstockminimo.UseVisualStyleBackColor = false;
            // 
            // btncomprafechas
            // 
            this.btncomprafechas.BackColor = System.Drawing.SystemColors.Highlight;
            this.btncomprafechas.FlatAppearance.BorderSize = 0;
            this.btncomprafechas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncomprafechas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncomprafechas.ForeColor = System.Drawing.Color.White;
            this.btncomprafechas.Location = new System.Drawing.Point(37, 80);
            this.btncomprafechas.Name = "btncomprafechas";
            this.btncomprafechas.Size = new System.Drawing.Size(215, 28);
            this.btncomprafechas.TabIndex = 2;
            this.btncomprafechas.Text = "Compras por fecha";
            this.btncomprafechas.UseVisualStyleBackColor = false;
            // 
            // btnventafechas
            // 
            this.btnventafechas.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnventafechas.FlatAppearance.BorderSize = 0;
            this.btnventafechas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnventafechas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnventafechas.ForeColor = System.Drawing.Color.White;
            this.btnventafechas.Location = new System.Drawing.Point(37, 46);
            this.btnventafechas.Name = "btnventafechas";
            this.btnventafechas.Size = new System.Drawing.Size(215, 28);
            this.btnventafechas.TabIndex = 1;
            this.btnventafechas.Text = "Ventas por fecha";
            this.btnventafechas.UseVisualStyleBackColor = false;
            // 
            // btnconsultas
            // 
            this.btnconsultas.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnconsultas.FlatAppearance.BorderSize = 0;
            this.btnconsultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnconsultas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconsultas.ForeColor = System.Drawing.Color.White;
            this.btnconsultas.Image = ((System.Drawing.Image)(resources.GetObject("btnconsultas.Image")));
            this.btnconsultas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnconsultas.Location = new System.Drawing.Point(3, 3);
            this.btnconsultas.Name = "btnconsultas";
            this.btnconsultas.Size = new System.Drawing.Size(249, 37);
            this.btnconsultas.TabIndex = 0;
            this.btnconsultas.Text = "Consultas";
            this.btnconsultas.UseVisualStyleBackColor = false;
            this.btnconsultas.Click += new System.EventHandler(this.btnconsultas_Click);
            // 
            // mnuconfiguraciones
            // 
            this.mnuconfiguraciones.Controls.Add(this.btnusuarios);
            this.mnuconfiguraciones.Controls.Add(this.btnempleados);
            this.mnuconfiguraciones.Controls.Add(this.btnconfiguraciones);
            this.mnuconfiguraciones.Location = new System.Drawing.Point(3, 355);
            this.mnuconfiguraciones.MaximumSize = new System.Drawing.Size(255, 120);
            this.mnuconfiguraciones.MinimumSize = new System.Drawing.Size(229, 37);
            this.mnuconfiguraciones.Name = "mnuconfiguraciones";
            this.mnuconfiguraciones.Size = new System.Drawing.Size(255, 42);
            this.mnuconfiguraciones.TabIndex = 8;
            // 
            // btnusuarios
            // 
            this.btnusuarios.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnusuarios.FlatAppearance.BorderSize = 0;
            this.btnusuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnusuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnusuarios.ForeColor = System.Drawing.Color.White;
            this.btnusuarios.Location = new System.Drawing.Point(50, 80);
            this.btnusuarios.Name = "btnusuarios";
            this.btnusuarios.Size = new System.Drawing.Size(202, 28);
            this.btnusuarios.TabIndex = 2;
            this.btnusuarios.Text = "Usuarios";
            this.btnusuarios.UseVisualStyleBackColor = false;
            this.btnusuarios.Click += new System.EventHandler(this.btnusuarios_Click);
            // 
            // btnempleados
            // 
            this.btnempleados.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnempleados.FlatAppearance.BorderSize = 0;
            this.btnempleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnempleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnempleados.ForeColor = System.Drawing.Color.White;
            this.btnempleados.Location = new System.Drawing.Point(50, 46);
            this.btnempleados.Name = "btnempleados";
            this.btnempleados.Size = new System.Drawing.Size(202, 28);
            this.btnempleados.TabIndex = 1;
            this.btnempleados.Text = "Empleados";
            this.btnempleados.UseVisualStyleBackColor = false;
            this.btnempleados.Click += new System.EventHandler(this.btnempleados_Click);
            // 
            // btnconfiguraciones
            // 
            this.btnconfiguraciones.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnconfiguraciones.FlatAppearance.BorderSize = 0;
            this.btnconfiguraciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnconfiguraciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconfiguraciones.ForeColor = System.Drawing.Color.White;
            this.btnconfiguraciones.Image = ((System.Drawing.Image)(resources.GetObject("btnconfiguraciones.Image")));
            this.btnconfiguraciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnconfiguraciones.Location = new System.Drawing.Point(3, 3);
            this.btnconfiguraciones.Name = "btnconfiguraciones";
            this.btnconfiguraciones.Size = new System.Drawing.Size(249, 37);
            this.btnconfiguraciones.TabIndex = 0;
            this.btnconfiguraciones.Text = "Configuraciones";
            this.btnconfiguraciones.UseVisualStyleBackColor = false;
            this.btnconfiguraciones.Click += new System.EventHandler(this.btnconfiguraciones_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCerrarSesión);
            this.panel2.Controls.Add(this.btnStockMin);
            this.panel2.Controls.Add(this.btnAtajoEmpleados);
            this.panel2.Controls.Add(this.btnAtajoCompras);
            this.panel2.Controls.Add(this.btnAtajoVentas);
            this.panel2.Controls.Add(this.btnAtajoProductos);
            this.panel2.Controls.Add(this.btnAtajoClientes);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(262, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1094, 100);
            this.panel2.TabIndex = 2;
            // 
            // btnCerrarSesión
            // 
            this.btnCerrarSesión.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrarSesión.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCerrarSesión.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesión.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesión.Font = new System.Drawing.Font("UD Digi Kyokasho NK", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnCerrarSesión.ForeColor = System.Drawing.Color.Red;
            this.btnCerrarSesión.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarSesión.Image")));
            this.btnCerrarSesión.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSesión.Location = new System.Drawing.Point(894, 0);
            this.btnCerrarSesión.MaximumSize = new System.Drawing.Size(200, 50);
            this.btnCerrarSesión.Name = "btnCerrarSesión";
            this.btnCerrarSesión.Size = new System.Drawing.Size(200, 50);
            this.btnCerrarSesión.TabIndex = 6;
            this.btnCerrarSesión.Text = "Cerrar Sesión";
            this.btnCerrarSesión.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrarSesión.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCerrarSesión.UseVisualStyleBackColor = false;
            this.btnCerrarSesión.Click += new System.EventHandler(this.btnCerrarSesión_Click);
            // 
            // btnStockMin
            // 
            this.btnStockMin.BackColor = System.Drawing.Color.Transparent;
            this.btnStockMin.FlatAppearance.BorderSize = 0;
            this.btnStockMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStockMin.Font = new System.Drawing.Font("UD Digi Kyokasho NK", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnStockMin.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnStockMin.Image = ((System.Drawing.Image)(resources.GetObject("btnStockMin.Image")));
            this.btnStockMin.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnStockMin.Location = new System.Drawing.Point(522, -3);
            this.btnStockMin.Name = "btnStockMin";
            this.btnStockMin.Size = new System.Drawing.Size(115, 100);
            this.btnStockMin.TabIndex = 5;
            this.btnStockMin.Text = "Stock min.";
            this.btnStockMin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStockMin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnStockMin.UseVisualStyleBackColor = false;
            // 
            // btnAtajoEmpleados
            // 
            this.btnAtajoEmpleados.BackColor = System.Drawing.Color.Transparent;
            this.btnAtajoEmpleados.FlatAppearance.BorderSize = 0;
            this.btnAtajoEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtajoEmpleados.Font = new System.Drawing.Font("UD Digi Kyokasho NK", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnAtajoEmpleados.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnAtajoEmpleados.Image = ((System.Drawing.Image)(resources.GetObject("btnAtajoEmpleados.Image")));
            this.btnAtajoEmpleados.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAtajoEmpleados.Location = new System.Drawing.Point(413, -3);
            this.btnAtajoEmpleados.Name = "btnAtajoEmpleados";
            this.btnAtajoEmpleados.Size = new System.Drawing.Size(115, 100);
            this.btnAtajoEmpleados.TabIndex = 4;
            this.btnAtajoEmpleados.Text = "Empleados";
            this.btnAtajoEmpleados.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAtajoEmpleados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAtajoEmpleados.UseVisualStyleBackColor = false;
            this.btnAtajoEmpleados.Click += new System.EventHandler(this.btnAtajoEmpleados_Click);
            // 
            // btnAtajoCompras
            // 
            this.btnAtajoCompras.BackColor = System.Drawing.Color.Transparent;
            this.btnAtajoCompras.FlatAppearance.BorderSize = 0;
            this.btnAtajoCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtajoCompras.Font = new System.Drawing.Font("UD Digi Kyokasho NK", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnAtajoCompras.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnAtajoCompras.Image = ((System.Drawing.Image)(resources.GetObject("btnAtajoCompras.Image")));
            this.btnAtajoCompras.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAtajoCompras.Location = new System.Drawing.Point(321, 0);
            this.btnAtajoCompras.Name = "btnAtajoCompras";
            this.btnAtajoCompras.Size = new System.Drawing.Size(98, 100);
            this.btnAtajoCompras.TabIndex = 3;
            this.btnAtajoCompras.Text = "Compras";
            this.btnAtajoCompras.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAtajoCompras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAtajoCompras.UseVisualStyleBackColor = false;
            // 
            // btnAtajoVentas
            // 
            this.btnAtajoVentas.BackColor = System.Drawing.Color.Transparent;
            this.btnAtajoVentas.FlatAppearance.BorderSize = 0;
            this.btnAtajoVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtajoVentas.Font = new System.Drawing.Font("UD Digi Kyokasho NK", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnAtajoVentas.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnAtajoVentas.Image = ((System.Drawing.Image)(resources.GetObject("btnAtajoVentas.Image")));
            this.btnAtajoVentas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAtajoVentas.Location = new System.Drawing.Point(227, 0);
            this.btnAtajoVentas.Name = "btnAtajoVentas";
            this.btnAtajoVentas.Size = new System.Drawing.Size(98, 100);
            this.btnAtajoVentas.TabIndex = 2;
            this.btnAtajoVentas.Text = "Ventas";
            this.btnAtajoVentas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAtajoVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAtajoVentas.UseVisualStyleBackColor = false;
            this.btnAtajoVentas.Click += new System.EventHandler(this.btnAtajoVentas_Click);
            // 
            // btnAtajoProductos
            // 
            this.btnAtajoProductos.BackColor = System.Drawing.Color.Transparent;
            this.btnAtajoProductos.FlatAppearance.BorderSize = 0;
            this.btnAtajoProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtajoProductos.Font = new System.Drawing.Font("UD Digi Kyokasho NK", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnAtajoProductos.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnAtajoProductos.Image = ((System.Drawing.Image)(resources.GetObject("btnAtajoProductos.Image")));
            this.btnAtajoProductos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAtajoProductos.Location = new System.Drawing.Point(123, 0);
            this.btnAtajoProductos.Name = "btnAtajoProductos";
            this.btnAtajoProductos.Size = new System.Drawing.Size(98, 100);
            this.btnAtajoProductos.TabIndex = 1;
            this.btnAtajoProductos.Text = "Productos";
            this.btnAtajoProductos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAtajoProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAtajoProductos.UseVisualStyleBackColor = false;
            this.btnAtajoProductos.Click += new System.EventHandler(this.btnAtajoProductos_Click);
            // 
            // btnAtajoClientes
            // 
            this.btnAtajoClientes.BackColor = System.Drawing.Color.Transparent;
            this.btnAtajoClientes.FlatAppearance.BorderSize = 0;
            this.btnAtajoClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtajoClientes.Font = new System.Drawing.Font("UD Digi Kyokasho NK", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnAtajoClientes.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnAtajoClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnAtajoClientes.Image")));
            this.btnAtajoClientes.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAtajoClientes.Location = new System.Drawing.Point(19, 0);
            this.btnAtajoClientes.Name = "btnAtajoClientes";
            this.btnAtajoClientes.Size = new System.Drawing.Size(98, 100);
            this.btnAtajoClientes.TabIndex = 0;
            this.btnAtajoClientes.Text = "Clientes";
            this.btnAtajoClientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAtajoClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAtajoClientes.UseVisualStyleBackColor = false;
            this.btnAtajoClientes.Click += new System.EventHandler(this.btnAtajoClientes_Click);
            // 
            // tmrsubmenu
            // 
            this.tmrsubmenu.Interval = 10;
            this.tmrsubmenu.Tick += new System.EventHandler(this.tmrsubmenu_Tick);
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 713);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "FrmInicio";
            this.Text = "FrmInicio";
            this.Load += new System.EventHandler(this.FrmInicio_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnmaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnrestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.mnualmacen.ResumeLayout(false);
            this.mnucompra.ResumeLayout(false);
            this.mnuventa.ResumeLayout(false);
            this.mnureportes.ResumeLayout(false);
            this.mnuconsultas.ResumeLayout(false);
            this.mnuconfiguraciones.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox btncerrar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox btnmaximizar;
        private System.Windows.Forms.PictureBox btnminimizar;
        private System.Windows.Forms.PictureBox btnrestaurar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel mnualmacen;
        public System.Windows.Forms.Button btnalmacen;
        public System.Windows.Forms.Button producto;
        public System.Windows.Forms.Button categoria;
        private System.Windows.Forms.Panel mnuventa;
        public System.Windows.Forms.Button btnclientes;
        public System.Windows.Forms.Button btngenerarventa;
        public System.Windows.Forms.Button btnventas;
        private System.Windows.Forms.Panel mnucompra;
        public System.Windows.Forms.Button btnproveedor;
        public System.Windows.Forms.Button btngenerarcompra;
        public System.Windows.Forms.Button btncompras;
        private System.Windows.Forms.Panel mnuconsultas;
        public System.Windows.Forms.Button btncomprafechas;
        public System.Windows.Forms.Button btnventafechas;
        public System.Windows.Forms.Button btnconsultas;
        public System.Windows.Forms.Button btnstockminimo;
        private System.Windows.Forms.Panel mnuconfiguraciones;
        public System.Windows.Forms.Button btnusuarios;
        public System.Windows.Forms.Button btnempleados;
        public System.Windows.Forms.Button btnconfiguraciones;
        private System.Windows.Forms.Panel mnureportes;
        public System.Windows.Forms.Button btnreporteempleado;
        public System.Windows.Forms.Button btnreportecliente;
        public System.Windows.Forms.Button btnreporteproducto;
        public System.Windows.Forms.Button btnreportes;
        private System.Windows.Forms.Timer tmrsubmenu;
        private System.Windows.Forms.Label lblUsuarioLogueado;
        private System.Windows.Forms.Button btnAtajoClientes;
        private System.Windows.Forms.Button btnAtajoCompras;
        private System.Windows.Forms.Button btnAtajoVentas;
        private System.Windows.Forms.Button btnAtajoProductos;
        private System.Windows.Forms.Button btnStockMin;
        private System.Windows.Forms.Button btnAtajoEmpleados;
        private System.Windows.Forms.Button btnCerrarSesión;
        public System.Windows.Forms.Button button6;
    }
}