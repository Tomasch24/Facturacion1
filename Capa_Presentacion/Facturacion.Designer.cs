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
            btnEliminar = new Button();
            btnEdit = new Button();
            lblDescuento = new Label();
            txtDescuento = new TextBox();
            lblId = new Label();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)facturaDalBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvFactura).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtCantidad).BeginInit();
            SuspendLayout();
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.BackColor = Color.Transparent;
            lblCliente.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCliente.Location = new Point(30, 127);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(81, 27);
            lblCliente.TabIndex = 1;
            lblCliente.Text = "Cliente";
            // 
            // lblTelef
            // 
            lblTelef.AutoSize = true;
            lblTelef.BackColor = Color.Transparent;
            lblTelef.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTelef.Location = new Point(29, 173);
            lblTelef.Name = "lblTelef";
            lblTelef.Size = new Size(96, 27);
            lblTelef.TabIndex = 100;
            lblTelef.Text = "Telefono";
            // 
            // lblRnc
            // 
            lblRnc.AutoSize = true;
            lblRnc.BackColor = Color.Transparent;
            lblRnc.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRnc.Location = new Point(29, 225);
            lblRnc.Name = "lblRnc";
            lblRnc.Size = new Size(61, 27);
            lblRnc.TabIndex = 3;
            lblRnc.Text = "RNC";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.BackColor = Color.Transparent;
            lblDescripcion.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescripcion.Location = new Point(30, 365);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(262, 32);
            lblDescripcion.TabIndex = 4;
            lblDescripcion.Text = "Descripcion de venta";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.BackColor = Color.Transparent;
            lblPrecio.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
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
            lblCantidad.Location = new Point(29, 539);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(99, 27);
            lblCantidad.TabIndex = 6;
            lblCantidad.Text = "Cantidad";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.BackColor = Color.Transparent;
            lblTipo.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTipo.Location = new Point(29, 586);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(55, 27);
            lblTipo.TabIndex = 8;
            lblTipo.Text = "Tipo";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(29, 276);
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
            lblSistema.Location = new Point(57, 15);
            lblSistema.Name = "lblSistema";
            lblSistema.Size = new Size(575, 41);
            lblSistema.TabIndex = 11;
            lblSistema.Text = "Facturacion Clientes No Registrados";
            // 
            // txtCliente
            // 
            txtCliente.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCliente.Location = new Point(164, 126);
            txtCliente.MaxLength = 20;
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(318, 28);
            txtCliente.TabIndex = 1;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescripcion.Location = new Point(164, 430);
            txtDescripcion.MaxLength = 50;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(318, 28);
            txtDescripcion.TabIndex = 5;
            // 
            // dtpFecha
            // 
            dtpFecha.CustomFormat = "dd/mm/aaaa";
            dtpFecha.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(164, 276);
            dtpFecha.MaxDate = new DateTime(2025, 6, 3, 0, 0, 0, 0);
            dtpFecha.MinDate = new DateTime(2025, 6, 3, 0, 0, 0, 0);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(318, 28);
            dtpFecha.TabIndex = 4;
            dtpFecha.Value = new DateTime(2025, 6, 3, 0, 0, 0, 0);
            // 
            // button1
            // 
            button1.BackColor = Color.Gainsboro;
            button1.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(327, 659);
            button1.Name = "button1";
            button1.Size = new Size(155, 51);
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
            cbTipo.TabIndex = 8;
            // 
            // dgvFactura
            // 
            dgvFactura.AllowUserToAddRows = false;
            dgvFactura.AllowUserToDeleteRows = false;
            dgvFactura.AllowUserToResizeColumns = false;
            dgvFactura.AllowUserToResizeRows = false;
            dgvFactura.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
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
            dgvFactura.Location = new Point(556, 94);
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
            dgvFactura.Size = new Size(761, 530);
            dgvFactura.TabIndex = 26;
            dgvFactura.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
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
            txtTelef1.TabIndex = 2;
            // 
            // txtRnc
            // 
            txtRnc.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRnc.Location = new Point(164, 221);
            txtRnc.Mask = "000-0000000-0";
            txtRnc.Name = "txtRnc";
            txtRnc.Size = new Size(318, 28);
            txtRnc.TabIndex = 3;
            // 
            // txtPrecio
            // 
            txtPrecio.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrecio.Location = new Point(164, 493);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(318, 28);
            txtPrecio.TabIndex = 6;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(164, 535);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(318, 31);
            txtCantidad.TabIndex = 7;
            txtCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Gainsboro;
            btnEliminar.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(1028, 659);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(289, 51);
            btnEliminar.TabIndex = 101;
            btnEliminar.Text = "Eliminar Factura";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += button2_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.Gainsboro;
            btnEdit.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEdit.Location = new Point(100, 659);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(192, 51);
            btnEdit.TabIndex = 102;
            btnEdit.Text = "Buscar por Id";
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescuento.Location = new Point(29, 322);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(114, 27);
            lblDescuento.TabIndex = 103;
            lblDescuento.Text = "Descuento";
            // 
            // txtDescuento
            // 
            txtDescuento.Location = new Point(164, 318);
            txtDescuento.Name = "txtDescuento";
            txtDescuento.Size = new Size(318, 31);
            txtDescuento.TabIndex = 104;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblId.Location = new Point(30, 83);
            lblId.Name = "lblId";
            lblId.Size = new Size(32, 27);
            lblId.TabIndex = 105;
            lblId.Text = "Id";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(164, 79);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(318, 31);
            textBox1.TabIndex = 106;
            // 
            // Facturacion
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(1392, 792);
            Controls.Add(textBox1);
            Controls.Add(lblId);
            Controls.Add(txtDescuento);
            Controls.Add(lblDescuento);
            Controls.Add(btnEdit);
            Controls.Add(btnEliminar);
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
            Controls.Add(lblSistema);
            Controls.Add(label9);
            Controls.Add(lblTipo);
            Controls.Add(lblCantidad);
            Controls.Add(lblPrecio);
            Controls.Add(lblDescripcion);
            Controls.Add(lblRnc);
            Controls.Add(lblTelef);
            Controls.Add(lblCliente);
            ForeColor = SystemColors.ControlText;
            Name = "Facturacion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)facturaDalBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvFactura).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtCantidad).EndInit();
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
        private Button btnEliminar;
        private Button btnEdit;
        private Label lblDescuento;
        private TextBox txtDescuento;
        private Label lblId;
        private TextBox textBox1;
    }
}
