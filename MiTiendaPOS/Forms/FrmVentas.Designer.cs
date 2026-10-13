namespace MiTiendaPOS.Forms
{
    partial class FrmVentas
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
            grpHistorial = new GroupBox();
            dgvVentas = new DataGridView();
            grpEncabezado = new GroupBox();
            lblVenta = new Label();
            cboUsuario = new ComboBox();
            cboCliente = new ComboBox();
            lblUsuario = new Label();
            lblCliente = new Label();
            grpDetalle = new GroupBox();
            lblTotal = new Label();
            dgvDetalle = new DataGridView();
            btnQuitar = new Button();
            btnAgregar = new Button();
            nudCantidad = new NumericUpDown();
            cboProducto = new ComboBox();
            lblCantidad = new Label();
            lblProducto = new Label();
            btnNueva = new Button();
            btnGuardar = new Button();
            btnEliminar = new Button();
            grpHistorial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            grpEncabezado.SuspendLayout();
            grpDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            SuspendLayout();
            // 
            // grpHistorial
            // 
            grpHistorial.Controls.Add(dgvVentas);
            grpHistorial.Location = new Point(570, 12);
            grpHistorial.Name = "grpHistorial";
            grpHistorial.Size = new Size(420, 589);
            grpHistorial.TabIndex = 1;
            grpHistorial.TabStop = false;
            grpHistorial.Text = "Historial de ventas";
            // 
            // dgvVentas
            // 
            dgvVentas.AllowUserToAddRows = false;
            dgvVentas.AllowUserToDeleteRows = false;
            dgvVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentas.Dock = DockStyle.Fill;
            dgvVentas.Location = new Point(3, 23);
            dgvVentas.MultiSelect = false;
            dgvVentas.Name = "dgvVentas";
            dgvVentas.ReadOnly = true;
            dgvVentas.RowHeadersWidth = 51;
            dgvVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVentas.Size = new Size(414, 563);
            dgvVentas.TabIndex = 9;
            dgvVentas.CellClick += dgvVentas_CellClick;
            // 
            // grpEncabezado
            // 
            grpEncabezado.Controls.Add(lblVenta);
            grpEncabezado.Controls.Add(cboUsuario);
            grpEncabezado.Controls.Add(cboCliente);
            grpEncabezado.Controls.Add(lblUsuario);
            grpEncabezado.Controls.Add(lblCliente);
            grpEncabezado.Location = new Point(12, 12);
            grpEncabezado.Name = "grpEncabezado";
            grpEncabezado.Size = new Size(552, 164);
            grpEncabezado.TabIndex = 2;
            grpEncabezado.TabStop = false;
            grpEncabezado.Text = "Encabezado de la venta";
            // 
            // lblVenta
            // 
            lblVenta.AutoSize = true;
            lblVenta.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVenta.Location = new Point(23, 129);
            lblVenta.Name = "lblVenta";
            lblVenta.Size = new Size(95, 20);
            lblVenta.TabIndex = 4;
            lblVenta.Text = "Venta nueva";
            // 
            // cboUsuario
            // 
            cboUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            cboUsuario.FormattingEnabled = true;
            cboUsuario.Location = new Point(355, 35);
            cboUsuario.Name = "cboUsuario";
            cboUsuario.Size = new Size(191, 28);
            cboUsuario.TabIndex = 3;
            // 
            // cboCliente
            // 
            cboCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCliente.FormattingEnabled = true;
            cboCliente.Location = new Point(89, 37);
            cboCliente.Name = "cboCliente";
            cboCliente.Size = new Size(187, 28);
            cboCliente.TabIndex = 2;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(282, 35);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(67, 20);
            lblUsuario.TabIndex = 1;
            lblUsuario.Text = "Usuario:";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCliente.Location = new Point(27, 35);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(61, 20);
            lblCliente.TabIndex = 0;
            lblCliente.Text = "Cliente:";
            // 
            // grpDetalle
            // 
            grpDetalle.Controls.Add(lblTotal);
            grpDetalle.Controls.Add(dgvDetalle);
            grpDetalle.Controls.Add(btnQuitar);
            grpDetalle.Controls.Add(btnAgregar);
            grpDetalle.Controls.Add(nudCantidad);
            grpDetalle.Controls.Add(cboProducto);
            grpDetalle.Controls.Add(lblCantidad);
            grpDetalle.Controls.Add(lblProducto);
            grpDetalle.Location = new Point(12, 191);
            grpDetalle.Name = "grpDetalle";
            grpDetalle.Size = new Size(552, 346);
            grpDetalle.TabIndex = 3;
            grpDetalle.TabStop = false;
            grpDetalle.Text = " Detalle de productos";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(355, 302);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(137, 31);
            lblTotal.TabIndex = 9;
            lblTotal.Text = "Total: $0.00";
            // 
            // dgvDetalle
            // 
            dgvDetalle.AllowUserToAddRows = false;
            dgvDetalle.AllowUserToDeleteRows = false;
            dgvDetalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalle.Location = new Point(7, 99);
            dgvDetalle.MultiSelect = false;
            dgvDetalle.Name = "dgvDetalle";
            dgvDetalle.ReadOnly = true;
            dgvDetalle.RowHeadersWidth = 51;
            dgvDetalle.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetalle.Size = new Size(539, 188);
            dgvDetalle.TabIndex = 8;
            // 
            // btnQuitar
            // 
            btnQuitar.Location = new Point(7, 302);
            btnQuitar.Name = "btnQuitar";
            btnQuitar.Size = new Size(111, 29);
            btnQuitar.TabIndex = 7;
            btnQuitar.Text = "Quitar";
            btnQuitar.UseVisualStyleBackColor = true;
            btnQuitar.Click += btnQuitar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(428, 56);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(118, 29);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(380, 58);
            nudCantidad.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(42, 27);
            nudCantidad.TabIndex = 5;
            nudCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cboProducto
            // 
            cboProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProducto.FormattingEnabled = true;
            cboProducto.Location = new Point(89, 60);
            cboProducto.Name = "cboProducto";
            cboProducto.Size = new Size(187, 28);
            cboProducto.TabIndex = 4;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCantidad.Location = new Point(299, 60);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(75, 20);
            lblCantidad.TabIndex = 1;
            lblCantidad.Text = "Cantidad:";
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProducto.Location = new Point(7, 60);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(81, 20);
            lblProducto.TabIndex = 0;
            lblProducto.Text = " Producto:";
            // 
            // btnNueva
            // 
            btnNueva.Location = new Point(19, 556);
            btnNueva.Name = "btnNueva";
            btnNueva.Size = new Size(155, 45);
            btnNueva.TabIndex = 5;
            btnNueva.Text = "Nueva venta";
            btnNueva.UseVisualStyleBackColor = true;
            btnNueva.Click += btnNueva_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(206, 556);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(155, 45);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Guardar venta";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(386, 556);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(155, 45);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "Eliminar venta";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // FrmVentas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1002, 613);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(btnNueva);
            Controls.Add(grpDetalle);
            Controls.Add(grpEncabezado);
            Controls.Add(grpHistorial);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FrmVentas";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Registro de Ventas";
            Load += FrmVentas_Load;
            grpHistorial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            grpEncabezado.ResumeLayout(false);
            grpEncabezado.PerformLayout();
            grpDetalle.ResumeLayout(false);
            grpDetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpHistorial;
        private GroupBox grpEncabezado;
        private Label lblUsuario;
        private Label lblCliente;
        private ComboBox cboUsuario;
        private ComboBox cboCliente;
        private GroupBox grpDetalle;
        private ComboBox cboProducto;
        private Label lblCantidad;
        private Label lblProducto;
        private Button btnQuitar;
        private Button btnAgregar;
        private NumericUpDown nudCantidad;
        private Label lblVenta;
        private DataGridView dgvDetalle;
        private DataGridView dgvVentas;
        private Label lblTotal;
        private Button btnNueva;
        private Button btnGuardar;
        private Button btnEliminar;
    }
}