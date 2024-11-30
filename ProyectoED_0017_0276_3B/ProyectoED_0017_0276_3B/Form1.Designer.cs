namespace ProyectoED_0017_0276_3B
{
    partial class frmLobby
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLobby));
            pnlMenuLateral = new Panel();
            pnlSubMenu = new Panel();
            btnSalir = new Button();
            button1 = new Button();
            btnMostrarBoletosComprados = new Button();
            btnCompra = new Button();
            btnOpcionesCompra = new Button();
            pnlLogo = new Panel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pnlFormularioHijo = new Panel();
            lbSegtxt = new Label();
            lbSeguridad = new Label();
            lbConftxt = new Label();
            lbConfort = new Label();
            lbFlextxt = new Label();
            lbFlexibilidad = new Label();
            lbExpPremtxt = new Label();
            lbExpPrem = new Label();
            label1 = new Label();
            btnRecomendaciones = new Button();
            pnlMenuLateral.SuspendLayout();
            pnlSubMenu.SuspendLayout();
            pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            pnlFormularioHijo.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMenuLateral
            // 
            pnlMenuLateral.AutoScroll = true;
            pnlMenuLateral.BackColor = Color.FromArgb(11, 7, 17);
            pnlMenuLateral.Controls.Add(pnlSubMenu);
            pnlMenuLateral.Controls.Add(btnOpcionesCompra);
            pnlMenuLateral.Controls.Add(pnlLogo);
            pnlMenuLateral.Dock = DockStyle.Left;
            pnlMenuLateral.Location = new Point(0, 0);
            pnlMenuLateral.Name = "pnlMenuLateral";
            pnlMenuLateral.Size = new Size(250, 470);
            pnlMenuLateral.TabIndex = 0;
            // 
            // pnlSubMenu
            // 
            pnlSubMenu.BackColor = Color.FromArgb(35, 32, 39);
            pnlSubMenu.Controls.Add(btnRecomendaciones);
            pnlSubMenu.Controls.Add(btnSalir);
            pnlSubMenu.Controls.Add(button1);
            pnlSubMenu.Controls.Add(btnMostrarBoletosComprados);
            pnlSubMenu.Controls.Add(btnCompra);
            pnlSubMenu.Dock = DockStyle.Top;
            pnlSubMenu.Location = new Point(0, 164);
            pnlSubMenu.Name = "pnlSubMenu";
            pnlSubMenu.Size = new Size(250, 192);
            pnlSubMenu.TabIndex = 2;
            // 
            // btnSalir
            // 
            btnSalir.Dock = DockStyle.Top;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            btnSalir.ForeColor = Color.LightGray;
            btnSalir.Location = new Point(0, 120);
            btnSalir.Name = "btnSalir";
            btnSalir.Padding = new Padding(35, 0, 0, 0);
            btnSalir.Size = new Size(250, 40);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.TextAlign = ContentAlignment.MiddleLeft;
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Top;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            button1.ForeColor = Color.LightGray;
            button1.Location = new Point(0, 80);
            button1.Name = "button1";
            button1.Padding = new Padding(35, 0, 0, 0);
            button1.Size = new Size(250, 40);
            button1.TabIndex = 3;
            button1.Text = "Aviones disponibles";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = true;
            // 
            // btnMostrarBoletosComprados
            // 
            btnMostrarBoletosComprados.Dock = DockStyle.Top;
            btnMostrarBoletosComprados.FlatAppearance.BorderSize = 0;
            btnMostrarBoletosComprados.FlatStyle = FlatStyle.Flat;
            btnMostrarBoletosComprados.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            btnMostrarBoletosComprados.ForeColor = Color.LightGray;
            btnMostrarBoletosComprados.Location = new Point(0, 40);
            btnMostrarBoletosComprados.Name = "btnMostrarBoletosComprados";
            btnMostrarBoletosComprados.Padding = new Padding(35, 0, 0, 0);
            btnMostrarBoletosComprados.Size = new Size(250, 40);
            btnMostrarBoletosComprados.TabIndex = 2;
            btnMostrarBoletosComprados.Text = "Ticket de compra";
            btnMostrarBoletosComprados.TextAlign = ContentAlignment.MiddleLeft;
            btnMostrarBoletosComprados.UseVisualStyleBackColor = true;
            btnMostrarBoletosComprados.Click += btnMostrarBoletosComprados_Click;
            // 
            // btnCompra
            // 
            btnCompra.Dock = DockStyle.Top;
            btnCompra.FlatAppearance.BorderSize = 0;
            btnCompra.FlatStyle = FlatStyle.Flat;
            btnCompra.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCompra.ForeColor = Color.LightGray;
            btnCompra.Location = new Point(0, 0);
            btnCompra.Name = "btnCompra";
            btnCompra.Padding = new Padding(35, 0, 0, 0);
            btnCompra.Size = new Size(250, 40);
            btnCompra.TabIndex = 0;
            btnCompra.Text = "Compra tu vuelo ";
            btnCompra.TextAlign = ContentAlignment.MiddleLeft;
            btnCompra.UseVisualStyleBackColor = true;
            btnCompra.Click += btnCompra_Click;
            // 
            // btnOpcionesCompra
            // 
            btnOpcionesCompra.Dock = DockStyle.Top;
            btnOpcionesCompra.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            btnOpcionesCompra.FlatAppearance.BorderSize = 0;
            btnOpcionesCompra.FlatStyle = FlatStyle.Flat;
            btnOpcionesCompra.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOpcionesCompra.ForeColor = Color.Red;
            btnOpcionesCompra.Location = new Point(0, 119);
            btnOpcionesCompra.Name = "btnOpcionesCompra";
            btnOpcionesCompra.Padding = new Padding(10, 0, 0, 0);
            btnOpcionesCompra.Size = new Size(250, 45);
            btnOpcionesCompra.TabIndex = 1;
            btnOpcionesCompra.Text = "Mostrar opciones de\r\ncompra de vuelo";
            btnOpcionesCompra.TextAlign = ContentAlignment.MiddleLeft;
            btnOpcionesCompra.UseVisualStyleBackColor = true;
            btnOpcionesCompra.Click += btnOpcionesCompra_Click;
            // 
            // pnlLogo
            // 
            pnlLogo.Controls.Add(pictureBox1);
            pnlLogo.Dock = DockStyle.Top;
            pnlLogo.Location = new Point(0, 0);
            pnlLogo.Name = "pnlLogo";
            pnlLogo.Size = new Size(250, 119);
            pnlLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(22, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(210, 71);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(175, 27);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(163, 177);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pnlFormularioHijo
            // 
            pnlFormularioHijo.BackColor = Color.FromArgb(23, 21, 32);
            pnlFormularioHijo.Controls.Add(lbSegtxt);
            pnlFormularioHijo.Controls.Add(lbSeguridad);
            pnlFormularioHijo.Controls.Add(lbConftxt);
            pnlFormularioHijo.Controls.Add(lbConfort);
            pnlFormularioHijo.Controls.Add(lbFlextxt);
            pnlFormularioHijo.Controls.Add(lbFlexibilidad);
            pnlFormularioHijo.Controls.Add(lbExpPremtxt);
            pnlFormularioHijo.Controls.Add(lbExpPrem);
            pnlFormularioHijo.Controls.Add(label1);
            pnlFormularioHijo.Controls.Add(pictureBox2);
            pnlFormularioHijo.Dock = DockStyle.Fill;
            pnlFormularioHijo.Location = new Point(250, 0);
            pnlFormularioHijo.Name = "pnlFormularioHijo";
            pnlFormularioHijo.Size = new Size(489, 470);
            pnlFormularioHijo.TabIndex = 1;
            // 
            // lbSegtxt
            // 
            lbSegtxt.AutoSize = true;
            lbSegtxt.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbSegtxt.ForeColor = Color.Gainsboro;
            lbSegtxt.Location = new Point(66, 402);
            lbSegtxt.Name = "lbSegtxt";
            lbSegtxt.Size = new Size(358, 14);
            lbSegtxt.TabIndex = 9;
            lbSegtxt.Text = "Los mas altos estandares de seguridad en cada vuelo";
            // 
            // lbSeguridad
            // 
            lbSeguridad.AutoSize = true;
            lbSeguridad.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbSeguridad.ForeColor = Color.Red;
            lbSeguridad.Location = new Point(161, 380);
            lbSeguridad.Name = "lbSeguridad";
            lbSeguridad.Size = new Size(195, 22);
            lbSeguridad.TabIndex = 8;
            lbSeguridad.Text = "Seguridad garantizada";
            // 
            // lbConftxt
            // 
            lbConftxt.AutoSize = true;
            lbConftxt.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbConftxt.ForeColor = Color.Gainsboro;
            lbConftxt.Location = new Point(56, 352);
            lbConftxt.Name = "lbConftxt";
            lbConftxt.Size = new Size(386, 14);
            lbConftxt.TabIndex = 7;
            lbConftxt.Text = "Espacios lujosos y servicios perzonalisonalizados a bordo";
            // 
            // lbConfort
            // 
            lbConfort.AutoSize = true;
            lbConfort.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbConfort.ForeColor = Color.Red;
            lbConfort.Location = new Point(180, 330);
            lbConfort.Name = "lbConfort";
            lbConfort.Size = new Size(141, 22);
            lbConfort.TabIndex = 6;
            lbConfort.Text = "Maximo confort";
            // 
            // lbFlextxt
            // 
            lbFlextxt.AutoSize = true;
            lbFlextxt.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbFlextxt.ForeColor = Color.Gainsboro;
            lbFlextxt.Location = new Point(66, 298);
            lbFlextxt.Name = "lbFlextxt";
            lbFlextxt.Size = new Size(366, 14);
            lbFlextxt.TabIndex = 5;
            lbFlextxt.Text = "Vuela cuando quieras donde quieras. Sin horarios fijos";
            // 
            // lbFlexibilidad
            // 
            lbFlexibilidad.AutoSize = true;
            lbFlexibilidad.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbFlexibilidad.ForeColor = Color.Red;
            lbFlexibilidad.Location = new Point(180, 276);
            lbFlexibilidad.Name = "lbFlexibilidad";
            lbFlexibilidad.Size = new Size(147, 22);
            lbFlexibilidad.TabIndex = 4;
            lbFlexibilidad.Text = "Flexibilidad total";
            // 
            // lbExpPremtxt
            // 
            lbExpPremtxt.AutoSize = true;
            lbExpPremtxt.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbExpPremtxt.ForeColor = Color.Gainsboro;
            lbExpPremtxt.Location = new Point(66, 236);
            lbExpPremtxt.Name = "lbExpPremtxt";
            lbExpPremtxt.Size = new Size(393, 28);
            lbExpPremtxt.TabIndex = 3;
            lbExpPremtxt.Text = "Descubre el lujo y la comodidad de volar en jets privados. \r\n                          Viaja a tu propio ritmo";
            // 
            // lbExpPrem
            // 
            lbExpPrem.AutoSize = true;
            lbExpPrem.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbExpPrem.ForeColor = Color.Red;
            lbExpPrem.Location = new Point(137, 214);
            lbExpPrem.Name = "lbExpPrem";
            lbExpPrem.Size = new Size(256, 22);
            lbExpPrem.TabIndex = 2;
            lbExpPrem.Text = "Experiencia de vuelo premium";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(195, 0);
            label1.Name = "label1";
            label1.Size = new Size(118, 23);
            label1.TabIndex = 1;
            label1.Text = "AeroWaos";
            // 
            // btnRecomendaciones
            // 
            btnRecomendaciones.Dock = DockStyle.Top;
            btnRecomendaciones.FlatAppearance.BorderSize = 0;
            btnRecomendaciones.FlatStyle = FlatStyle.Flat;
            btnRecomendaciones.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            btnRecomendaciones.ForeColor = Color.LightGray;
            btnRecomendaciones.Location = new Point(0, 160);
            btnRecomendaciones.Name = "btnRecomendaciones";
            btnRecomendaciones.Padding = new Padding(35, 0, 0, 0);
            btnRecomendaciones.Size = new Size(250, 40);
            btnRecomendaciones.TabIndex = 5;
            btnRecomendaciones.Text = "Recomendaciones";
            btnRecomendaciones.TextAlign = ContentAlignment.MiddleLeft;
            btnRecomendaciones.UseVisualStyleBackColor = true;
            btnRecomendaciones.Click += btnRecomendaciones_Click;
            // 
            // frmLobby
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(739, 470);
            Controls.Add(pnlFormularioHijo);
            Controls.Add(pnlMenuLateral);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmLobby";
            Text = "AeroWaos Pagina Oficial";
            pnlMenuLateral.ResumeLayout(false);
            pnlSubMenu.ResumeLayout(false);
            pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            pnlFormularioHijo.ResumeLayout(false);
            pnlFormularioHijo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMenuLateral;
        private ToolStrip tspMenu;
        private ToolStripButton toolStripButton1;
        private Button btnOpcionesCompra;
        private Panel pnlLogo;
        private Panel pnlSubMenu;
        private Button btnMostrarBoletosComprados;
        private Button btnCompra;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Panel pnlFormularioHijo;
        private Label label1;
        private Label lbExpPremtxt;
        private Label lbExpPrem;
        private Label lbConftxt;
        private Label lbConfort;
        private Label lbFlextxt;
        private Label lbFlexibilidad;
        private Label lbSegtxt;
        private Label lbSeguridad;
        private Button btnSalir;
        private Button button1;
        private Button btnRecomendaciones;
    }
}
