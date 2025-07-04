namespace Capa_Presentacion
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            pnMenuV = new Panel();
            btnEmpleados = new Button();
            btnClientes = new Button();
            btnVentas = new Button();
            lblTitulo = new Label();
            pictureBox7 = new PictureBox();
            pnBarraTitulo = new Panel();
            IconCerrar = new PictureBox();
            iconMinimizar = new PictureBox();
            iconRestaurar = new PictureBox();
            pbMenu = new PictureBox();
            iconMaximizar = new PictureBox();
            pictureBox1 = new PictureBox();
            pnMenuV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            pnBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)IconCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconRestaurar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbMenu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconMaximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnMenuV
            // 
            pnMenuV.BackColor = Color.DimGray;
            pnMenuV.Controls.Add(btnEmpleados);
            pnMenuV.Controls.Add(btnClientes);
            pnMenuV.Controls.Add(btnVentas);
            pnMenuV.Controls.Add(lblTitulo);
            pnMenuV.Controls.Add(pictureBox7);
            pnMenuV.Dock = DockStyle.Left;
            pnMenuV.Location = new Point(0, 0);
            pnMenuV.Name = "pnMenuV";
            pnMenuV.Size = new Size(350, 799);
            pnMenuV.TabIndex = 0;
            // 
            // btnEmpleados
            // 
            btnEmpleados.BackColor = Color.DimGray;
            btnEmpleados.FlatAppearance.BorderColor = Color.DimGray;
            btnEmpleados.FlatAppearance.BorderSize = 0;
            btnEmpleados.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            btnEmpleados.FlatStyle = FlatStyle.Flat;
            btnEmpleados.Font = new Font("Times New Roman", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEmpleados.ForeColor = SystemColors.ControlText;
            btnEmpleados.Image = (Image)resources.GetObject("btnEmpleados.Image");
            btnEmpleados.ImageAlign = ContentAlignment.MiddleLeft;
            btnEmpleados.Location = new Point(0, 372);
            btnEmpleados.Name = "btnEmpleados";
            btnEmpleados.Size = new Size(350, 70);
            btnEmpleados.TabIndex = 4;
            btnEmpleados.Text = "Coming Soon";
            btnEmpleados.UseVisualStyleBackColor = false;
            // 
            // btnClientes
            // 
            btnClientes.BackColor = Color.DimGray;
            btnClientes.FlatAppearance.BorderColor = Color.DimGray;
            btnClientes.FlatAppearance.BorderSize = 0;
            btnClientes.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Font = new Font("Times New Roman", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClientes.ForeColor = SystemColors.ControlText;
            btnClientes.Image = (Image)resources.GetObject("btnClientes.Image");
            btnClientes.ImageAlign = ContentAlignment.MiddleLeft;
            btnClientes.Location = new Point(0, 269);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(350, 70);
            btnClientes.TabIndex = 3;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = false;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnVentas
            // 
            btnVentas.BackColor = Color.DimGray;
            btnVentas.FlatAppearance.BorderColor = Color.DimGray;
            btnVentas.FlatAppearance.BorderSize = 0;
            btnVentas.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            btnVentas.FlatStyle = FlatStyle.Flat;
            btnVentas.Font = new Font("Times New Roman", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVentas.ForeColor = SystemColors.ControlText;
            btnVentas.Image = (Image)resources.GetObject("btnVentas.Image");
            btnVentas.ImageAlign = ContentAlignment.MiddleLeft;
            btnVentas.Location = new Point(0, 162);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(350, 70);
            btnVentas.TabIndex = 2;
            btnVentas.Text = "Ventas";
            btnVentas.UseVisualStyleBackColor = false;
            btnVentas.Click += btnVentas_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(89, 34);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(255, 41);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Menu Principal";
            lblTitulo.Click += lblTitulo_Click;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(0, 0);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(100, 100);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 0;
            pictureBox7.TabStop = false;
            // 
            // pnBarraTitulo
            // 
            pnBarraTitulo.BackColor = Color.WhiteSmoke;
            pnBarraTitulo.Controls.Add(IconCerrar);
            pnBarraTitulo.Controls.Add(iconMinimizar);
            pnBarraTitulo.Controls.Add(iconRestaurar);
            pnBarraTitulo.Controls.Add(pbMenu);
            pnBarraTitulo.Controls.Add(iconMaximizar);
            pnBarraTitulo.Dock = DockStyle.Top;
            pnBarraTitulo.Location = new Point(350, 0);
            pnBarraTitulo.Name = "pnBarraTitulo";
            pnBarraTitulo.Size = new Size(999, 50);
            pnBarraTitulo.TabIndex = 1;
            pnBarraTitulo.MouseDown += pnBarraTitulo_MouseDown;
            // 
            // IconCerrar
            // 
            IconCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            IconCerrar.Cursor = Cursors.Hand;
            IconCerrar.Image = (Image)resources.GetObject("IconCerrar.Image");
            IconCerrar.Location = new Point(952, 10);
            IconCerrar.Name = "IconCerrar";
            IconCerrar.Size = new Size(35, 35);
            IconCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            IconCerrar.TabIndex = 4;
            IconCerrar.TabStop = false;
            IconCerrar.Click += IconCerrar_Click;
            // 
            // iconMinimizar
            // 
            iconMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconMinimizar.BackColor = Color.WhiteSmoke;
            iconMinimizar.Cursor = Cursors.Hand;
            iconMinimizar.Image = (Image)resources.GetObject("iconMinimizar.Image");
            iconMinimizar.Location = new Point(870, 10);
            iconMinimizar.Name = "iconMinimizar";
            iconMinimizar.Size = new Size(35, 35);
            iconMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            iconMinimizar.TabIndex = 3;
            iconMinimizar.TabStop = false;
            iconMinimizar.Click += iconMinimizar_Click;
            // 
            // iconRestaurar
            // 
            iconRestaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconRestaurar.Cursor = Cursors.Hand;
            iconRestaurar.Image = (Image)resources.GetObject("iconRestaurar.Image");
            iconRestaurar.Location = new Point(911, 10);
            iconRestaurar.Name = "iconRestaurar";
            iconRestaurar.Size = new Size(35, 35);
            iconRestaurar.SizeMode = PictureBoxSizeMode.Zoom;
            iconRestaurar.TabIndex = 2;
            iconRestaurar.TabStop = false;
            iconRestaurar.Visible = false;
            iconRestaurar.Click += iconRestaurar_Click;
            // 
            // pbMenu
            // 
            pbMenu.Cursor = Cursors.Hand;
            pbMenu.Image = (Image)resources.GetObject("pbMenu.Image");
            pbMenu.Location = new Point(15, 10);
            pbMenu.Name = "pbMenu";
            pbMenu.Size = new Size(35, 35);
            pbMenu.SizeMode = PictureBoxSizeMode.Zoom;
            pbMenu.TabIndex = 1;
            pbMenu.TabStop = false;
            pbMenu.Click += pbMenu_Click;
            // 
            // iconMaximizar
            // 
            iconMaximizar.Cursor = Cursors.Hand;
            iconMaximizar.Image = (Image)resources.GetObject("iconMaximizar.Image");
            iconMaximizar.Location = new Point(913, 10);
            iconMaximizar.Name = "iconMaximizar";
            iconMaximizar.Size = new Size(35, 35);
            iconMaximizar.SizeMode = PictureBoxSizeMode.Zoom;
            iconMaximizar.TabIndex = 0;
            iconMaximizar.TabStop = false;
            iconMaximizar.Click += iconMaximizar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackColor = Color.WhiteSmoke;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(573, 117);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(600, 600);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1349, 799);
            Controls.Add(pictureBox1);
            Controls.Add(pnBarraTitulo);
            Controls.Add(pnMenuV);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Principal";
            Load += MenuPrincipal_Load;
            pnMenuV.ResumeLayout(false);
            pnMenuV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            pnBarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)IconCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconRestaurar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbMenu).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconMaximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnMenuV;
        private Panel pnBarraTitulo;
        private PictureBox pictureBox1;
        private PictureBox iconMaximizar;
        private PictureBox pbMenu;
        private PictureBox IconCerrar;
        private PictureBox iconMinimizar;
        private PictureBox iconRestaurar;
        private PictureBox pictureBox7;
        private Label lblTitulo;
        private Button btnVentas;
        private Button btnEmpleados;
        private Button btnClientes;
    }
}