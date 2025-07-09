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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
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
            button1 = new Button();
            cbTipo = new ComboBox();
            facturaDalBindingSource = new BindingSource(components);
            dgvFactura = new DataGridView();
            label1 = new Label();
            txtTelef1 = new MaskedTextBox();
            txtRnc = new MaskedTextBox();
            txtPrecio = new TextBox();
            txtCantidad = new NumericUpDown();
            btnAgregar = new Button();
            btnEdit = new Button();
            lblId = new Label();
            txtIdCliente = new TextBox();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            btnVolver = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)facturaDalBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvFactura).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtCantidad).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.BackColor = Color.FromArgb(46, 58, 89);
            lblCliente.FlatStyle = FlatStyle.Flat;
            lblCliente.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCliente.ForeColor = SystemColors.ControlLightLight;
            lblCliente.Location = new Point(30, 128);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(81, 27);
            lblCliente.TabIndex = 1;
            lblCliente.Text = "Cliente";
            // 
            // lblTelef
            // 
            lblTelef.AutoSize = true;
            lblTelef.BackColor = Color.FromArgb(46, 58, 89);
            lblTelef.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTelef.ForeColor = SystemColors.ControlLightLight;
            lblTelef.Location = new Point(29, 172);
            lblTelef.Name = "lblTelef";
            lblTelef.Size = new Size(96, 27);
            lblTelef.TabIndex = 100;
            lblTelef.Text = "Telefono";
            // 
            // lblRnc
            // 
            lblRnc.AutoSize = true;
            lblRnc.BackColor = Color.FromArgb(46, 58, 89);
            lblRnc.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRnc.ForeColor = SystemColors.ControlLightLight;
            lblRnc.Location = new Point(30, 222);
            lblRnc.Name = "lblRnc";
            lblRnc.Size = new Size(61, 27);
            lblRnc.TabIndex = 3;
            lblRnc.Text = "RNC";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.BackColor = Color.FromArgb(46, 58, 89);
            lblDescripcion.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescripcion.ForeColor = SystemColors.ControlLightLight;
            lblDescripcion.Location = new Point(30, 366);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(262, 32);
            lblDescripcion.TabIndex = 4;
            lblDescripcion.Text = "Descripcion de venta";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.BackColor = Color.FromArgb(46, 58, 89);
            lblPrecio.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrecio.ForeColor = SystemColors.ControlLightLight;
            lblPrecio.Location = new Point(29, 497);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(74, 27);
            lblPrecio.TabIndex = 5;
            lblPrecio.Text = "Precio";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.BackColor = Color.Transparent;
            lblCantidad.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCantidad.ForeColor = SystemColors.ControlLightLight;
            lblCantidad.Location = new Point(30, 538);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(99, 27);
            lblCantidad.TabIndex = 6;
            lblCantidad.Text = "Cantidad";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.BackColor = Color.FromArgb(46, 58, 89);
            lblTipo.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTipo.ForeColor = SystemColors.ControlLightLight;
            lblTipo.Location = new Point(29, 586);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(55, 27);
            lblTipo.TabIndex = 8;
            lblTipo.Text = "Tipo";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(46, 58, 89);
            label9.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ControlLightLight;
            label9.Location = new Point(29, 277);
            label9.Name = "label9";
            label9.Size = new Size(70, 27);
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
            txtCliente.Location = new Point(164, 127);
            txtCliente.MaxLength = 20;
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(318, 28);
            txtCliente.TabIndex = 2;
            txtCliente.KeyPress += txtCliente_KeyPress;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescripcion.Location = new Point(164, 430);
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
            dtpFecha.Location = new Point(164, 277);
            dtpFecha.MaxDate = new DateTime(2025, 7, 9, 0, 0, 0, 0);
            dtpFecha.MinDate = new DateTime(2025, 7, 9, 0, 0, 0, 0);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(318, 28);
            dtpFecha.TabIndex = 5;
            dtpFecha.Value = new DateTime(2025, 7, 9, 0, 0, 0, 0);
            // 
            // button1
            // 
            button1.BackColor = Color.Gainsboro;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(327, 659);
            button1.Name = "button1";
            button1.Size = new Size(155, 52);
            button1.TabIndex = 9;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // cbTipo
            // 
            cbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTipo.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbTipo.FormattingEnabled = true;
            cbTipo.Location = new Point(164, 584);
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.SkyBlue;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvFactura.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvFactura.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvFactura.DefaultCellStyle = dataGridViewCellStyle2;
            dgvFactura.EnableHeadersVisualStyles = false;
            dgvFactura.Location = new Point(577, 94);
            dgvFactura.Name = "dgvFactura";
            dgvFactura.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvFactura.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvFactura.RowHeadersWidth = 62;
            dataGridViewCellStyle4.BackColor = Color.White;
            dgvFactura.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvFactura.Size = new Size(1195, 593);
            dgvFactura.TabIndex = 0;
            dgvFactura.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(46, 58, 89);
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(29, 420);
            label1.Name = "label1";
            label1.Size = new Size(129, 54);
            label1.TabIndex = 27;
            label1.Text = "Referencia \r\nde Producto\r\n";
            // 
            // txtTelef1
            // 
            txtTelef1.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTelef1.Location = new Point(164, 169);
            txtTelef1.Mask = "+1 (999) 000-0000";
            txtTelef1.Name = "txtTelef1";
            txtTelef1.Size = new Size(318, 30);
            txtTelef1.TabIndex = 3;
            // 
            // txtRnc
            // 
            txtRnc.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRnc.Location = new Point(164, 221);
            txtRnc.Mask = "000-0000000-0";
            txtRnc.Name = "txtRnc";
            txtRnc.Size = new Size(318, 28);
            txtRnc.TabIndex = 4;
            // 
            // txtPrecio
            // 
            txtPrecio.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrecio.Location = new Point(164, 493);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(318, 28);
            txtPrecio.TabIndex = 7;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(164, 534);
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
            // btnEdit
            // 
            btnEdit.BackColor = Color.Gainsboro;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEdit.Location = new Point(62, 659);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(230, 52);
            btnEdit.TabIndex = 102;
            btnEdit.Text = "Buscar IdCliente";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.BackColor = Color.FromArgb(46, 58, 89);
            lblId.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblId.ForeColor = SystemColors.ControlLightLight;
            lblId.Location = new Point(30, 83);
            lblId.Name = "lblId";
            lblId.Size = new Size(32, 27);
            lblId.TabIndex = 105;
            lblId.Text = "Id";
            // 
            // txtIdCliente
            // 
            txtIdCliente.Location = new Point(164, 79);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.Size = new Size(318, 31);
            txtIdCliente.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.BackColor = Color.FromArgb(46, 58, 89);
            panel1.Controls.Add(lblId);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(btnEdit);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblSistema);
            panel1.Controls.Add(lblCantidad);
            panel1.Controls.Add(lblCliente);
            panel1.Controls.Add(lblTelef);
            panel1.Controls.Add(lblRnc);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(539, 834);
            panel1.TabIndex = 107;
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
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.BackColor = Color.Gainsboro;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(1483, 722);
            button2.Name = "button2";
            button2.Size = new Size(289, 52);
            button2.TabIndex = 109;
            button2.Text = "Buscar IdFactura";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // Facturacion
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 242, 242);
            ClientSize = new Size(1794, 834);
            Controls.Add(button2);
            Controls.Add(btnVolver);
            Controls.Add(txtIdCliente);
            Controls.Add(btnAgregar);
            Controls.Add(txtCantidad);
            Controls.Add(txtRnc);
            Controls.Add(txtTelef1);
            Controls.Add(label1);
            Controls.Add(dgvFactura);
            Controls.Add(cbTipo);
            Controls.Add(button1);
            Controls.Add(dtpFecha);
            Controls.Add(txtPrecio);
            Controls.Add(txtDescripcion);
            Controls.Add(txtCliente);
            Controls.Add(label9);
            Controls.Add(lblTipo);
            Controls.Add(lblPrecio);
            Controls.Add(lblDescripcion);
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
            ResumeLayout(false);
            PerformLayout();
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
        private Button button1;
        private ComboBox cbTipo;
        private BindingSource facturaDalBindingSource;
        private DataGridView dgvFactura;
        private Label label1;
        private MaskedTextBox txtTelef1;
        private MaskedTextBox txtRnc;
        private TextBox txtPrecio;
        private NumericUpDown txtCantidad;
        private Button btnAgregar;
        private Button btnEdit;
        private Label lblId;
        private TextBox txtIdCliente;
        private Panel panel1;
        private Button btnVolver;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button button2;
    }
}
