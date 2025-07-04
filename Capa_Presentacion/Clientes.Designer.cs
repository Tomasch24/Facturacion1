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
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            lblCorreoC = new Label();
            lblRncC = new Label();
            lblTelef2 = new Label();
            lblNombreC = new Label();
            label1 = new Label();
            btnGuardarC = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DimGray;
            panel1.Controls.Add(btnGuardarC);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
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
            // textBox4
            // 
            textBox4.Location = new Point(128, 332);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(184, 31);
            textBox4.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(128, 266);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(184, 31);
            textBox3.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(128, 200);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(184, 31);
            textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(128, 126);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(184, 31);
            textBox1.TabIndex = 5;
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
        private TextBox textBox1;
        private Label lblCorreoC;
        private Label lblRncC;
        private Label lblTelef2;
        private Label lblNombreC;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox4;
        private TextBox textBox3;
        private Button btnGuardarC;
    }
}