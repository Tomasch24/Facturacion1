namespace capa_presentacion
{
    partial class Facturacion
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            lblCliente = new Label();
            lblTelef = new Label();
            lblRnc = new Label();
            lblDescripcion = new Label();
            lblPrecio = new Label();
            lblCantidad = new Label();
            lblTipo = new Label();
            label9 = new Label();
            lblSistema = new Label();
            txtCliente = new TextBox();
            txtDescripcion = new TextBox();
            dtpFecha = new DateTimePicker();
            btnGuardar = new Button();
            cbTipo = new ComboBox();
            facturaDalBindingSource = new BindingSource(components);
            dgvFactura = new DataGridView();
            label1 = new Label();
            txtTelef1 = new MaskedTextBox();
            txtRnc = new MaskedTextBox();
            txtPrecio = new TextBox();
            txtCantidad = new NumericUpDown();
            btnAgregar = new Button();
            btnBuscarC = new Button();
            lblId = new Label();
            txtIdCliente = new TextBox();
            panel1 = new Panel();
            btnBuscarC2 = new Button();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            btnVolver = new Button();
            btnBuscarF2 = new Button();
            btnBuscarF = new Button();
            pbAtras = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)facturaDalBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvFactura).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtCantidad).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAtras).BeginInit();
            SuspendLayout();
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.BackColor = Color.FromArgb(46, 58, 89);
            lblCliente.FlatStyle = FlatStyle.Flat;
            lblCliente.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCliente.ForeColor = SystemColors.ControlLightLight;
            lblCliente.Location = new Point(32, 123);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(89, 32);
            lblCliente.TabIndex = 1;
            lblCliente.Text = "Cliente";
            // 
            // lblTelef
            // 
            lblTelef.AutoSize = true;
            lblTelef.BackColor = Color.FromArgb(46, 58, 89);
            lblTelef.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTelef.ForeColor = SystemColors.ControlLightLight;
            lblTelef.Location = new Point(32, 167);
            lblTelef.Name = "lblTelef";
            lblTelef.Size = new Size(107, 32);
            lblTelef.TabIndex = 100;
            lblTelef.Text = "Telefono";
            // 
            // lblRnc
            // 
            lblRnc.AutoSize = true;
            lblRnc.BackColor = Color.FromArgb(46, 58, 89);
            lblRnc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRnc.ForeColor = SystemColors.ControlLightLight;
            lblRnc.Location = new Point(32, 217);
            lblRnc.Name = "lblRnc";
            lblRnc.Size = new Size(61, 32);
            lblRnc.TabIndex = 3;
            lblRnc.Text = "RNC";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.BackColor = Color.FromArgb(46, 58, 89);
            lblDescripcion.Font = new Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescripcion.ForeColor = SystemColors.ControlLightLight;
            lblDescripcion.Location = new Point(14, 351);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(299, 36);
            lblDescripcion.TabIndex = 4;
            lblDescripcion.Text = "Descripcion de venta";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.BackColor = Color.FromArgb(46, 58, 89);
            lblPrecio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrecio.ForeColor = SystemColors.ControlLightLight;
            lblPrecio.Location = new Point(32, 489);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(79, 32);
            lblPrecio.TabIndex = 5;
            lblPrecio.Text = "Precio";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.BackColor = Color.Transparent;
            lblCantidad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCantidad.ForeColor = SystemColors.ControlLightLight;
            lblCantidad.Location = new Point(32, 533);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(109, 32);
            lblCantidad.TabIndex = 6;
            lblCantidad.Text = "Cantidad";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.BackColor = Color.FromArgb(46, 58, 89);
            lblTipo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTipo.ForeColor = SystemColors.ControlLightLight;
            lblTipo.Location = new Point(32, 580);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(61, 32);
            lblTipo.TabIndex = 8;
            lblTipo.Text = "Tipo";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(46, 58, 89);
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ControlLightLight;
            label9.Location = new Point(32, 277);
            label9.Name = "label9";
            label9.Size = new Size(76, 32);
            label9.TabIndex = 9;
            label9.Text = "Fecha";
            // 
            // lblSistema
            // 
            lblSistema.AutoSize = true;
            lblSistema.BackColor = Color.Transparent;
            lblSistema.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSistema.ForeColor = SystemColors.ControlLightLight;
            lblSistema.Location = new Point(69, 9);
            lblSistema.Name = "lblSistema";
            lblSistema.Size = new Size(105, 41);
            lblSistema.TabIndex = 11;
            lblSistema.Text = "Venta";
            // 
            // txtCliente
            // 
            txtCliente.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCliente.Location = new Point(175, 127);
            txtCliente.MaxLength = 20;
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(318, 28);
            txtCliente.TabIndex = 2;
            txtCliente.KeyPress += txtCliente_KeyPress;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescripcion.Location = new Point(175, 429);
            txtDescripcion.MaxLength = 50;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(318, 28);
            txtDescripcion.TabIndex = 6;
            // 
            // dtpFecha
            // 
            dtpFecha.CustomFormat = "dd/mm/aaaa";
            dtpFecha.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(175, 277);
            dtpFecha.MaxDate = new DateTime(2025, 7, 10, 0, 0, 0, 0);
            dtpFecha.MinDate = new DateTime(2025, 7, 10, 0, 0, 0, 0);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(318, 28);
            dtpFecha.TabIndex = 5;
            dtpFecha.Value = new DateTime(2025, 7, 10, 0, 0, 0, 0);
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Gainsboro;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(327, 659);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(155, 52);
            btnGuardar.TabIndex = 9;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += button1_Click;
            // 
            // cbTipo
            // 
            cbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTipo.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbTipo.FormattingEnabled = true;
            cbTipo.Location = new Point(175, 584);
            cbTipo.Name = "cbTipo";
            cbTipo.Size = new Size(318, 28);
            cbTipo.TabIndex = 9;
            // 
            // dgvFactura
            // 
            dgvFactura.AllowUserToAddRows = false;
            dgvFactura.AllowUserToDeleteRows = false;
            dgvFactura.AllowUserToResizeColumns = false;
            dgvFactura.AllowUserToResizeRows = false;
            dgvFactura.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvFactura.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = Color.SkyBlue;
            dataGridViewCellStyle9.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dgvFactura.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dgvFactura.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = SystemColors.Window;
            dataGridViewCellStyle10.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle10.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.False;
            dgvFactura.DefaultCellStyle = dataGridViewCellStyle10;
            dgvFactura.EnableHeadersVisualStyles = false;
            dgvFactura.Location = new Point(577, 94);
            dgvFactura.Name = "dgvFactura";
            dgvFactura.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = Color.White;
            dataGridViewCellStyle11.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle11.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            dgvFactura.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dgvFactura.RowHeadersWidth = 62;
            dataGridViewCellStyle12.BackColor = Color.White;
            dgvFactura.RowsDefaultCellStyle = dataGridViewCellStyle12;
            dgvFactura.Size = new Size(1195, 593);
            dgvFactura.TabIndex = 0;
            dgvFactura.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(46, 58, 89);
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(32, 409);
            label1.Name = "label1";
            label1.Size = new Size(132, 64);
            label1.TabIndex = 27;
            label1.Text = "Referencia \r\nProducto\r\n";
            // 
            // txtTelef1
            // 
            txtTelef1.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTelef1.Location = new Point(175, 167);
            txtTelef1.Mask = "+1 (999) 000-0000";
            txtTelef1.Name = "txtTelef1";
            txtTelef1.Size = new Size(318, 30);
            txtTelef1.TabIndex = 3;
            // 
            // txtRnc
            // 
            txtRnc.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRnc.Location = new Point(175, 221);
            txtRnc.Mask = "000-0000000-0";
            txtRnc.Name = "txtRnc";
            txtRnc.Size = new Size(318, 28);
            txtRnc.TabIndex = 4;
            // 
            // txtPrecio
            // 
            txtPrecio.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrecio.Location = new Point(175, 493);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(318, 28);
            txtPrecio.TabIndex = 7;
            txtPrecio.KeyPress += txtPrecio_KeyPress;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(175, 534);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(318, 31);
            txtCantidad.TabIndex = 8;
            txtCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Bottom;
            btnAgregar.BackColor = Color.Gainsboro;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(1061, 722);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(289, 52);
            btnAgregar.TabIndex = 101;
            btnAgregar.Text = "Agregar Cliente";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += button2_Click;
            // 
            // btnBuscarC
            // 
            btnBuscarC.BackColor = Color.Aquamarine;
            btnBuscarC.FlatStyle = FlatStyle.Flat;
            btnBuscarC.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscarC.Location = new Point(62, 659);
            btnBuscarC.Name = "btnBuscarC";
            btnBuscarC.Size = new Size(230, 52);
            btnBuscarC.TabIndex = 102;
            btnBuscarC.Text = "Buscar IdCliente";
            btnBuscarC.UseVisualStyleBackColor = false;
            btnBuscarC.Click += btnEdit_Click;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.BackColor = Color.FromArgb(46, 58, 89);
            lblId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblId.ForeColor = SystemColors.ControlLightLight;
            lblId.Location = new Point(32, 78);
            lblId.Name = "lblId";
            lblId.Size = new Size(34, 32);
            lblId.TabIndex = 105;
            lblId.Text = "Id";
            // 
            // txtIdCliente
            // 
            txtIdCliente.Location = new Point(175, 78);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.Size = new Size(318, 31);
            txtIdCliente.TabIndex = 1;
            txtIdCliente.KeyPress += txtIdCliente_KeyPress;
            // 
            // panel1
            // 
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.BackColor = Color.FromArgb(46, 58, 89);
            panel1.Controls.Add(btnBuscarC2);
            panel1.Controls.Add(lblId);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(btnBuscarC);
            panel1.Controls.Add(txtIdCliente);
            panel1.Controls.Add(txtCantidad);
            panel1.Controls.Add(cbTipo);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblSistema);
            panel1.Controls.Add(lblCantidad);
            panel1.Controls.Add(txtTelef1);
            panel1.Controls.Add(txtPrecio);
            panel1.Controls.Add(txtRnc);
            panel1.Controls.Add(lblCliente);
            panel1.Controls.Add(lblTelef);
            panel1.Controls.Add(txtCliente);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblRnc);
            panel1.Controls.Add(lblDescripcion);
            panel1.Controls.Add(dtpFecha);
            panel1.Controls.Add(lblPrecio);
            panel1.Controls.Add(lblTipo);
            panel1.Controls.Add(txtDescripcion);
            panel1.Controls.Add(label9);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(551, 834);
            panel1.TabIndex = 107;
            // 
            // btnBuscarC2
            // 
            btnBuscarC2.BackColor = Color.Gainsboro;
            btnBuscarC2.FlatStyle = FlatStyle.Flat;
            btnBuscarC2.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscarC2.Location = new Point(62, 659);
            btnBuscarC2.Name = "btnBuscarC2";
            btnBuscarC2.Size = new Size(230, 52);
            btnBuscarC2.TabIndex = 111;
            btnBuscarC2.Text = "Buscar IdCliente";
            btnBuscarC2.UseVisualStyleBackColor = false;
            btnBuscarC2.Click += button3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox2.Image = Capa_Presentacion.Properties.Resources.Logo;
            pictureBox2.Location = new Point(2, 747);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(101, 84);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 110;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Capa_Presentacion.Properties.Resources.IconVentas;
            pictureBox1.Location = new Point(3, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(69, 57);
            pictureBox1.TabIndex = 109;
            pictureBox1.TabStop = false;
            // 
            // btnVolver
            // 
            btnVolver.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnVolver.BackColor = Color.Gainsboro;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVolver.Location = new Point(577, 722);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(289, 52);
            btnVolver.TabIndex = 108;
            btnVolver.Text = "Volver al Menu";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnBuscarF2
            // 
            btnBuscarF2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnBuscarF2.BackColor = Color.Aquamarine;
            btnBuscarF2.FlatStyle = FlatStyle.Flat;
            btnBuscarF2.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscarF2.Location = new Point(1483, 722);
            btnBuscarF2.Name = "btnBuscarF2";
            btnBuscarF2.Size = new Size(289, 52);
            btnBuscarF2.TabIndex = 109;
            btnBuscarF2.Text = "Buscar IdFactura";
            btnBuscarF2.UseVisualStyleBackColor = false;
            btnBuscarF2.Click += button2_Click_1;
            // 
            // btnBuscarF
            // 
            btnBuscarF.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnBuscarF.BackColor = Color.Gainsboro;
            btnBuscarF.FlatStyle = FlatStyle.Flat;
            btnBuscarF.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscarF.Location = new Point(1483, 722);
            btnBuscarF.Name = "btnBuscarF";
            btnBuscarF.Size = new Size(289, 52);
            btnBuscarF.TabIndex = 110;
            btnBuscarF.Text = "Buscar IdFactura";
            btnBuscarF.UseVisualStyleBackColor = false;
            btnBuscarF.Click += btnBuscarF_Click;
            // 
            // pbAtras
            // 
            pbAtras.Image = Capa_Presentacion.Properties.Resources.Flecha_hacia_atras;
            pbAtras.Location = new Point(577, 40);
            pbAtras.Name = "pbAtras";
            pbAtras.Size = new Size(52, 48);
            pbAtras.SizeMode = PictureBoxSizeMode.Zoom;
            pbAtras.TabIndex = 111;
            pbAtras.TabStop = false;
            pbAtras.Visible = false;
            pbAtras.Click += pbAtras_Click;
            // 
            // Facturacion
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 242, 242);
            ClientSize = new Size(1794, 834);
            Controls.Add(pbAtras);
            Controls.Add(btnBuscarF);
            Controls.Add(btnBuscarF2);
            Controls.Add(btnVolver);
            Controls.Add(btnAgregar);
            Controls.Add(dgvFactura);
            Controls.Add(btnGuardar);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Facturacion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Facturacion";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)facturaDalBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvFactura).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtCantidad).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAtras).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label lblCliente;
        private Label lblTelef;
        private Label lblRnc;
        private Label lblDescripcion;
        private Label lblPrecio;
        private Label lblCantidad;
        private Label lblTipo;
        private Label label9;
        private Label lblSistema;
        private TextBox txtCliente;
        private TextBox txtTelef;
        private TextBox txtDescripcion;
        private DateTimePicker dtpFecha;
        private Button btnGuardar;
        private ComboBox cbTipo;
        private BindingSource facturaDalBindingSource;
        private DataGridView dgvFactura;
        private Label label1;
        private MaskedTextBox txtTelef1;
        private MaskedTextBox txtRnc;
        private TextBox txtPrecio;
        private NumericUpDown txtCantidad;
        private Button btnAgregar;
        private Button btnBuscarC;
        private Label lblId;
        private TextBox txtIdCliente;
        private Panel panel1;
        private Button btnVolver;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button btnBuscarF2;
        private Button btnBuscarC2;
        private Button btnBuscarF;
        private PictureBox pbAtras;
    }
}
