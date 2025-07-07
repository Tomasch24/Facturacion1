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
            panel1 = new Panel();
            btnGuardarC = new Button();
            txtCorreoC = new TextBox();
            txtRncC = new TextBox();
            txtTelefC = new TextBox();
            txtNombreC = new TextBox();
            lblCorreoC = new Label();
            lblRncC = new Label();
            lblTelef2 = new Label();
            lblNombreC = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DimGray;
            panel1.Controls.Add(btnGuardarC);
            panel1.Controls.Add(txtCorreoC);
            panel1.Controls.Add(txtRncC);
            panel1.Controls.Add(txtTelefC);
            panel1.Controls.Add(txtNombreC);
            panel1.Controls.Add(lblCorreoC);
            panel1.Controls.Add(lblRncC);
            panel1.Controls.Add(lblTelef2);
            panel1.Controls.Add(lblNombreC);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(341, 675);
            panel1.TabIndex = 0;
            // 
            // btnGuardarC
            // 
            btnGuardarC.BackColor = Color.Gainsboro;
            btnGuardarC.FlatStyle = FlatStyle.Flat;
            btnGuardarC.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardarC.Location = new Point(85, 524);
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
            txtCorreoC.Size = new Size(184, 31);
            txtCorreoC.TabIndex = 8;
            // 
            // txtRncC
            // 
            txtRncC.Location = new Point(128, 266);
            txtRncC.Name = "txtRncC";
            txtRncC.Size = new Size(184, 31);
            txtRncC.TabIndex = 7;
            // 
            // txtTelefC
            // 
            txtTelefC.Location = new Point(128, 200);
            txtTelefC.Name = "txtTelefC";
            txtTelefC.Size = new Size(184, 31);
            txtTelefC.TabIndex = 6;
            // 
            // txtNombreC
            // 
            txtNombreC.Location = new Point(128, 126);
            txtNombreC.Name = "txtNombreC";
            txtNombreC.Size = new Size(184, 31);
            txtNombreC.TabIndex = 5;
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
            // Clientes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(994, 675);
            Controls.Add(panel1);
            Name = "Clientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clientes";
            Load += Clientes_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private TextBox txtTelefC;
        private TextBox txtCorreoC;
        private TextBox txtRncC;
        private Button btnGuardarC;
    }
}