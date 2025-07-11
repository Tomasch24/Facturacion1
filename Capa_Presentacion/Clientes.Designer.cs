namespace Capa_Presentacion
{
    partial class Clientes
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            txtCorreoC = new TextBox();
            btnBuscarC2 = new Button();
            btnBuscarC = new Button();
            lblIdC = new Label();
            txtIdClienteC = new TextBox();
            pictureBox2 = new PictureBox();
            btnEditar = new Button();
            pictureBox1 = new PictureBox();
            txtRncC = new MaskedTextBox();
            txtTelefC = new MaskedTextBox();
            btnGuardarC = new Button();
            txtNombreC = new TextBox();
            lblCorreoC = new Label();
            lblRncC = new Label();
            lblTelef2 = new Label();
            lblNombreC = new Label();
            label1 = new Label();
            btnVolverC = new Button();
            dgvClientes = new DataGridView();
            btnEliminar = new Button();
            button1 = new Button();
            pbAtras = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAtras).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(46, 58, 89);
            panel1.Controls.Add(txtCorreoC);
            panel1.Controls.Add(btnBuscarC2);
            panel1.Controls.Add(btnBuscarC);
            panel1.Controls.Add(lblIdC);
            panel1.Controls.Add(txtIdClienteC);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(btnEditar);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(txtRncC);
            panel1.Controls.Add(txtTelefC);
            panel1.Controls.Add(btnGuardarC);
            panel1.Controls.Add(txtNombreC);
            panel1.Controls.Add(lblCorreoC);
            panel1.Controls.Add(lblRncC);
            panel1.Controls.Add(lblTelef2);
            panel1.Controls.Add(lblNombreC);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(420, 768);
            panel1.TabIndex = 0;
            // 
            // txtCorreoC
            // 
            txtCorreoC.Location = new Point(128, 352);
            txtCorreoC.Name = "txtCorreoC";
            txtCorreoC.Size = new Size(210, 31);
            txtCorreoC.TabIndex = 5;
            // 
            // btnBuscarC2
            // 
            btnBuscarC2.BackColor = Color.Gainsboro;
            btnBuscarC2.Cursor = Cursors.Hand;
            btnBuscarC2.FlatStyle = FlatStyle.Flat;
            btnBuscarC2.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscarC2.Location = new Point(84, 440);
            btnBuscarC2.Name = "btnBuscarC2";
            btnBuscarC2.Size = new Size(230, 52);
            btnBuscarC2.TabIndex = 6;
            btnBuscarC2.Text = "Buscar IdCliente";
            btnBuscarC2.UseVisualStyleBackColor = false;
            btnBuscarC2.Click += btnBuscarC2_Click;
            // 
            // btnBuscarC
            // 
            btnBuscarC.BackColor = Color.Aquamarine;
            btnBuscarC.FlatStyle = FlatStyle.Flat;
            btnBuscarC.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscarC.Location = new Point(84, 440);
            btnBuscarC.Name = "btnBuscarC";
            btnBuscarC.Size = new Size(230, 52);
            btnBuscarC.TabIndex = 113;
            btnBuscarC.TabStop = false;
            btnBuscarC.Text = "Buscar IdCliente";
            btnBuscarC.UseVisualStyleBackColor = false;
            btnBuscarC.Click += btnBuscarC_Click;
            // 
            // lblIdC
            // 
            lblIdC.AutoSize = true;
            lblIdC.BackColor = Color.FromArgb(46, 58, 89);
            lblIdC.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIdC.ForeColor = SystemColors.ControlLightLight;
            lblIdC.Location = new Point(10, 112);
            lblIdC.Name = "lblIdC";
            lblIdC.Size = new Size(34, 32);
            lblIdC.TabIndex = 106;
            lblIdC.Text = "Id";
            // 
            // txtIdClienteC
            // 
            txtIdClienteC.Location = new Point(128, 112);
            txtIdClienteC.Name = "txtIdClienteC";
            txtIdClienteC.Size = new Size(210, 31);
            txtIdClienteC.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox2.Image = Properties.Resources.Logo;
            pictureBox2.Location = new Point(0, 684);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(101, 84);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // btnEditar
            // 
            btnEditar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEditar.BackColor = Color.Gainsboro;
            btnEditar.Cursor = Cursors.Hand;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditar.Location = new Point(84, 508);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(230, 44);
            btnEditar.TabIndex = 7;
            btnEditar.Text = "Editar Cliente";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.IconoClientes;
            pictureBox1.Location = new Point(10, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 56);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // txtRncC
            // 
            txtRncC.Location = new Point(128, 292);
            txtRncC.Mask = "000-0000000-0";
            txtRncC.Name = "txtRncC";
            txtRncC.Size = new Size(210, 31);
            txtRncC.TabIndex = 4;
            // 
            // txtTelefC
            // 
            txtTelefC.Location = new Point(128, 233);
            txtTelefC.Mask = "+1 (999) 000-0000";
            txtTelefC.Name = "txtTelefC";
            txtTelefC.Size = new Size(210, 31);
            txtTelefC.TabIndex = 3;
            // 
            // btnGuardarC
            // 
            btnGuardarC.BackColor = Color.Gainsboro;
            btnGuardarC.Cursor = Cursors.Hand;
            btnGuardarC.FlatStyle = FlatStyle.Flat;
            btnGuardarC.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardarC.Location = new Point(84, 572);
            btnGuardarC.Name = "btnGuardarC";
            btnGuardarC.Size = new Size(230, 52);
            btnGuardarC.TabIndex = 8;
            btnGuardarC.Text = "Guardar";
            btnGuardarC.UseVisualStyleBackColor = false;
            btnGuardarC.Click += btnGuardarC_Click;
            // 
            // txtNombreC
            // 
            txtNombreC.Location = new Point(128, 166);
            txtNombreC.Name = "txtNombreC";
            txtNombreC.Size = new Size(210, 31);
            txtNombreC.TabIndex = 2;
            txtNombreC.KeyPress += txtNombreC_KeyPress;
            // 
            // lblCorreoC
            // 
            lblCorreoC.AutoSize = true;
            lblCorreoC.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCorreoC.ForeColor = SystemColors.ControlLightLight;
            lblCorreoC.Location = new Point(10, 351);
            lblCorreoC.Name = "lblCorreoC";
            lblCorreoC.Size = new Size(86, 32);
            lblCorreoC.TabIndex = 4;
            lblCorreoC.Text = "Correo";
            // 
            // lblRncC
            // 
            lblRncC.AutoSize = true;
            lblRncC.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRncC.ForeColor = SystemColors.ControlLightLight;
            lblRncC.Location = new Point(10, 292);
            lblRncC.Name = "lblRncC";
            lblRncC.Size = new Size(61, 32);
            lblRncC.TabIndex = 3;
            lblRncC.Text = "RNC";
            // 
            // lblTelef2
            // 
            lblTelef2.AutoSize = true;
            lblTelef2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTelef2.ForeColor = SystemColors.ControlLightLight;
            lblTelef2.Location = new Point(10, 233);
            lblTelef2.Name = "lblTelef2";
            lblTelef2.Size = new Size(107, 32);
            lblTelef2.TabIndex = 2;
            lblTelef2.Text = "Telefono";
            // 
            // lblNombreC
            // 
            lblNombreC.AutoSize = true;
            lblNombreC.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombreC.ForeColor = SystemColors.ControlLightLight;
            lblNombreC.Location = new Point(10, 166);
            lblNombreC.Name = "lblNombreC";
            lblNombreC.Size = new Size(102, 32);
            lblNombreC.TabIndex = 1;
            lblNombreC.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(70, 21);
            label1.Name = "label1";
            label1.Size = new Size(276, 41);
            label1.TabIndex = 0;
            label1.Text = "Registro Clientes";
            // 
            // btnVolverC
            // 
            btnVolverC.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnVolverC.BackColor = Color.Gainsboro;
            btnVolverC.Cursor = Cursors.Hand;
            btnVolverC.FlatStyle = FlatStyle.Flat;
            btnVolverC.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVolverC.Location = new Point(494, 654);
            btnVolverC.Name = "btnVolverC";
            btnVolverC.Size = new Size(233, 44);
            btnVolverC.TabIndex = 9;
            btnVolverC.Text = "Volver al Menu";
            btnVolverC.UseVisualStyleBackColor = false;
            btnVolverC.Click += btnVolverC_Click;
            // 
            // dgvClientes
            // 
            dgvClientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Aqua;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvClientes.DefaultCellStyle = dataGridViewCellStyle2;
            dgvClientes.EnableHeadersVisualStyles = false;
            dgvClientes.Location = new Point(494, 78);
            dgvClientes.Name = "dgvClientes";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvClientes.RowHeadersWidth = 62;
            dgvClientes.Size = new Size(1018, 534);
            dgvClientes.TabIndex = 1;
            dgvClientes.TabStop = false;
            dgvClientes.CellContentClick += dgvClientes_CellContentClick;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEliminar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEliminar.BackColor = Color.Gainsboro;
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(1275, 654);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(237, 44);
            btnEliminar.TabIndex = 11;
            btnEliminar.Text = "Eliminar Cliente";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom;
            button1.BackColor = Color.Gainsboro;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(897, 654);
            button1.Name = "button1";
            button1.Size = new Size(233, 44);
            button1.TabIndex = 10;
            button1.Text = "Venta";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pbAtras
            // 
            pbAtras.Cursor = Cursors.Hand;
            pbAtras.Image = Properties.Resources.Flecha_hacia_atras;
            pbAtras.Location = new Point(494, 24);
            pbAtras.Name = "pbAtras";
            pbAtras.Size = new Size(52, 48);
            pbAtras.SizeMode = PictureBoxSizeMode.Zoom;
            pbAtras.TabIndex = 112;
            pbAtras.TabStop = false;
            pbAtras.Visible = false;
            pbAtras.Click += pbAtras_Click;
            // 
            // Clientes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1561, 768);
            Controls.Add(pbAtras);
            Controls.Add(button1);
            Controls.Add(btnEliminar);
            Controls.Add(btnVolverC);
            Controls.Add(dgvClientes);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Clientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clientes";
            Load += Clientes_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAtras).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtNombreC;
        private Label lblCorreoC;
        private Label lblRncC;
        private Label lblTelef2;
        private Label lblNombreC;
        private Label label1;
        private Button btnGuardarC;
        private DataGridView dgvClientes;
        private MaskedTextBox txtRncC;
        private MaskedTextBox txtTelefC;
        private Button btnEditar;
        private Button btnVolverC;
        private Button btnEliminar;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button button1;
        private TextBox txtIdClienteC;
        private Label lblIdC;
        private Button btnBuscarC2;
        private Button btnBuscarC;
        private PictureBox pbAtras;
        private TextBox txtCorreoC;
    }
}