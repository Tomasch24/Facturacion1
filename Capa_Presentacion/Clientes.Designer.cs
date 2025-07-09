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
            btnVolverC = new Button();
            txtRncC = new MaskedTextBox();
            txtTelefC = new MaskedTextBox();
            btnGuardarC = new Button();
            txtCorreoC = new TextBox();
            txtNombreC = new TextBox();
            lblCorreoC = new Label();
            lblRncC = new Label();
            lblTelef2 = new Label();
            lblNombreC = new Label();
            label1 = new Label();
            dgvClientes = new DataGridView();
            btnEditar = new Button();
            btnEliminar = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DimGray;
            panel1.Controls.Add(btnVolverC);
            panel1.Controls.Add(txtRncC);
            panel1.Controls.Add(txtTelefC);
            panel1.Controls.Add(btnGuardarC);
            panel1.Controls.Add(txtCorreoC);
            panel1.Controls.Add(txtNombreC);
            panel1.Controls.Add(lblCorreoC);
            panel1.Controls.Add(lblRncC);
            panel1.Controls.Add(lblTelef2);
            panel1.Controls.Add(lblNombreC);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(397, 706);
            panel1.TabIndex = 0;
            // 
            // btnVolverC
            // 
            btnVolverC.BackColor = Color.Gainsboro;
            btnVolverC.FlatStyle = FlatStyle.Flat;
            btnVolverC.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVolverC.Location = new Point(74, 564);
            btnVolverC.Name = "btnVolverC";
            btnVolverC.Size = new Size(233, 52);
            btnVolverC.TabIndex = 14;
            btnVolverC.Text = "Volver al Menu";
            btnVolverC.UseVisualStyleBackColor = false;
            btnVolverC.Click += btnVolverC_Click;
            // 
            // txtRncC
            // 
            txtRncC.Location = new Point(128, 266);
            txtRncC.Mask = "000-0000000-0";
            txtRncC.Name = "txtRncC";
            txtRncC.Size = new Size(210, 31);
            txtRncC.TabIndex = 12;
            // 
            // txtTelefC
            // 
            txtTelefC.Location = new Point(128, 200);
            txtTelefC.Mask = "+1 (999) 000-0000";
            txtTelefC.Name = "txtTelefC";
            txtTelefC.Size = new Size(210, 31);
            txtTelefC.TabIndex = 11;
            // 
            // btnGuardarC
            // 
            btnGuardarC.BackColor = Color.Gainsboro;
            btnGuardarC.FlatStyle = FlatStyle.Flat;
            btnGuardarC.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardarC.Location = new Point(111, 467);
            btnGuardarC.Name = "btnGuardarC";
            btnGuardarC.Size = new Size(155, 52);
            btnGuardarC.TabIndex = 10;
            btnGuardarC.Text = "Guardar";
            btnGuardarC.UseVisualStyleBackColor = false;
            btnGuardarC.Click += btnGuardarC_Click;
            // 
            // txtCorreoC
            // 
            txtCorreoC.Location = new Point(128, 332);
            txtCorreoC.Name = "txtCorreoC";
            txtCorreoC.Size = new Size(210, 31);
            txtCorreoC.TabIndex = 8;
            // 
            // txtNombreC
            // 
            txtNombreC.Location = new Point(128, 126);
            txtNombreC.Name = "txtNombreC";
            txtNombreC.Size = new Size(210, 31);
            txtNombreC.TabIndex = 5;
            txtNombreC.KeyPress += txtNombreC_KeyPress;
            // 
            // lblCorreoC
            // 
            lblCorreoC.AutoSize = true;
            lblCorreoC.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCorreoC.Location = new Point(22, 334);
            lblCorreoC.Name = "lblCorreoC";
            lblCorreoC.Size = new Size(79, 27);
            lblCorreoC.TabIndex = 4;
            lblCorreoC.Text = "Correo";
            // 
            // lblRncC
            // 
            lblRncC.AutoSize = true;
            lblRncC.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRncC.Location = new Point(22, 270);
            lblRncC.Name = "lblRncC";
            lblRncC.Size = new Size(61, 27);
            lblRncC.TabIndex = 3;
            lblRncC.Text = "RNC";
            // 
            // lblTelef2
            // 
            lblTelef2.AutoSize = true;
            lblTelef2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTelef2.Location = new Point(22, 204);
            lblTelef2.Name = "lblTelef2";
            lblTelef2.Size = new Size(96, 27);
            lblTelef2.TabIndex = 2;
            lblTelef2.Text = "Telefono";
            // 
            // lblNombreC
            // 
            lblNombreC.AutoSize = true;
            lblNombreC.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombreC.Location = new Point(22, 130);
            lblNombreC.Name = "lblNombreC";
            lblNombreC.Size = new Size(90, 27);
            lblNombreC.TabIndex = 1;
            lblNombreC.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(31, 21);
            label1.Name = "label1";
            label1.Size = new Size(276, 41);
            label1.TabIndex = 0;
            label1.Text = "Registro Clientes";
            // 
            // dgvClientes
            // 
            dgvClientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.SkyBlue;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.SkyBlue;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvClientes.DefaultCellStyle = dataGridViewCellStyle2;
            dgvClientes.Location = new Point(438, 32);
            dgvClientes.Name = "dgvClientes";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.SkyBlue;
            dataGridViewCellStyle3.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvClientes.RowHeadersWidth = 62;
            dgvClientes.Size = new Size(896, 472);
            dgvClientes.TabIndex = 1;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEditar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEditar.BackColor = Color.Gainsboro;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditar.Location = new Point(1121, 572);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(195, 44);
            btnEditar.TabIndex = 13;
            btnEditar.Text = "Editar Cliente";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEliminar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEliminar.BackColor = Color.Gainsboro;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(534, 572);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(133, 44);
            btnEliminar.TabIndex = 15;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // Clientes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1371, 706);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(dgvClientes);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Clientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clientes";
            Load += Clientes_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
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
        private TextBox txtCorreoC;
        private Button btnGuardarC;
        private DataGridView dgvClientes;
        private MaskedTextBox txtRncC;
        private MaskedTextBox txtTelefC;
        private Button btnEditar;
        private Button btnVolverC;
        private Button btnEliminar;
    }
}