namespace ProyectoED_0017_0276_3B
{
    partial class frmCompraBoletos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCompraBoletos));
            toolStrip1 = new ToolStrip();
            tsbCerrar = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            tsbVerAsiento = new ToolStripButton();
            btnComprar = new Button();
            txtNombre = new TextBox();
            lbNombreCliente = new Label();
            gbDatosCliente = new GroupBox();
            label6 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            textBox2 = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            groupBox1 = new GroupBox();
            dtpFecha = new DateTimePicker();
            label2 = new Label();
            cbModeloAvion = new ComboBox();
            cbDestino = new ComboBox();
            cbOrigen = new ComboBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            toolStrip1.SuspendLayout();
            gbDatosCliente.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.FromArgb(23, 21, 32);
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbCerrar, toolStripSeparator1, tsbVerAsiento });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(473, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsbCerrar
            // 
            tsbCerrar.Alignment = ToolStripItemAlignment.Right;
            tsbCerrar.BackColor = Color.Red;
            tsbCerrar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbCerrar.ForeColor = Color.White;
            tsbCerrar.Image = (Image)resources.GetObject("tsbCerrar.Image");
            tsbCerrar.ImageTransparentColor = Color.Magenta;
            tsbCerrar.Name = "tsbCerrar";
            tsbCerrar.Size = new Size(23, 22);
            tsbCerrar.Text = "tsbCerrar";
            tsbCerrar.Click += tsbCerrar_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // tsbVerAsiento
            // 
            tsbVerAsiento.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbVerAsiento.Image = (Image)resources.GetObject("tsbVerAsiento.Image");
            tsbVerAsiento.ImageTransparentColor = Color.Magenta;
            tsbVerAsiento.Name = "tsbVerAsiento";
            tsbVerAsiento.Size = new Size(23, 22);
            tsbVerAsiento.Text = "Avion";
            tsbVerAsiento.Click += tsbVerAsiento_Click;
            // 
            // btnComprar
            // 
            btnComprar.BackColor = Color.DarkGreen;
            btnComprar.FlatAppearance.BorderSize = 0;
            btnComprar.FlatStyle = FlatStyle.Flat;
            btnComprar.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnComprar.ForeColor = Color.White;
            btnComprar.Location = new Point(375, 183);
            btnComprar.Name = "btnComprar";
            btnComprar.Size = new Size(76, 41);
            btnComprar.TabIndex = 3;
            btnComprar.Text = "Comprar Boleto";
            btnComprar.UseVisualStyleBackColor = false;
            btnComprar.Click += btnComprar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Georgia", 9.1F);
            txtNombre.Location = new Point(71, 34);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(200, 21);
            txtNombre.TabIndex = 4;
            // 
            // lbNombreCliente
            // 
            lbNombreCliente.AutoSize = true;
            lbNombreCliente.Font = new Font("Segoe UI", 10F);
            lbNombreCliente.ForeColor = Color.White;
            lbNombreCliente.Location = new Point(6, 34);
            lbNombreCliente.Name = "lbNombreCliente";
            lbNombreCliente.Size = new Size(59, 19);
            lbNombreCliente.TabIndex = 5;
            lbNombreCliente.Text = "Nombre";
            // 
            // gbDatosCliente
            // 
            gbDatosCliente.BackColor = Color.FromArgb(20, 20, 20);
            gbDatosCliente.Controls.Add(label6);
            gbDatosCliente.Controls.Add(textBox3);
            gbDatosCliente.Controls.Add(label5);
            gbDatosCliente.Controls.Add(textBox2);
            gbDatosCliente.Controls.Add(label1);
            gbDatosCliente.Controls.Add(textBox1);
            gbDatosCliente.Controls.Add(lbNombreCliente);
            gbDatosCliente.Controls.Add(txtNombre);
            gbDatosCliente.Font = new Font("Georgia", 12F, FontStyle.Bold);
            gbDatosCliente.ForeColor = SystemColors.ControlLight;
            gbDatosCliente.Location = new Point(12, 28);
            gbDatosCliente.Name = "gbDatosCliente";
            gbDatosCliente.Size = new Size(342, 172);
            gbDatosCliente.TabIndex = 12;
            gbDatosCliente.TabStop = false;
            gbDatosCliente.Text = "Ingrese los datos del cliente";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(13, 129);
            label6.Name = "label6";
            label6.Size = new Size(51, 19);
            label6.TabIndex = 11;
            label6.Text = "Correo";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Georgia", 9.1F);
            textBox3.Location = new Point(69, 129);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(200, 21);
            textBox3.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(5, 100);
            label5.Name = "label5";
            label5.Size = new Size(60, 19);
            label5.TabIndex = 9;
            label5.Text = "Teléfono";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Georgia", 9.1F);
            textBox2.Location = new Point(69, 98);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 21);
            textBox2.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(26, 67);
            label1.Name = "label1";
            label1.Size = new Size(39, 19);
            label1.TabIndex = 7;
            label1.Text = "Edad";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Georgia", 9.1F);
            textBox1.Location = new Point(71, 67);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(42, 21);
            textBox1.TabIndex = 6;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(20, 20, 20);
            groupBox1.Controls.Add(dtpFecha);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cbModeloAvion);
            groupBox1.Controls.Add(cbDestino);
            groupBox1.Controls.Add(cbOrigen);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label10);
            groupBox1.Font = new Font("Georgia", 12F, FontStyle.Bold);
            groupBox1.ForeColor = SystemColors.ControlLight;
            groupBox1.Location = new Point(12, 206);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(342, 172);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ingrese los datos del vuelo";
            // 
            // dtpFecha
            // 
            dtpFecha.Font = new Font("Georgia", 8F, FontStyle.Bold);
            dtpFecha.Location = new Point(118, 133);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(200, 20);
            dtpFecha.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(31, 133);
            label2.Name = "label2";
            label2.Size = new Size(82, 19);
            label2.TabIndex = 15;
            label2.Text = "Escoja fecha";
            // 
            // cbModeloAvion
            // 
            cbModeloAvion.Font = new Font("Georgia", 8F, FontStyle.Bold);
            cbModeloAvion.FormattingEnabled = true;
            cbModeloAvion.Location = new Point(118, 105);
            cbModeloAvion.Name = "cbModeloAvion";
            cbModeloAvion.Size = new Size(121, 22);
            cbModeloAvion.TabIndex = 14;
            // 
            // cbDestino
            // 
            cbDestino.Font = new Font("Georgia", 8F, FontStyle.Bold);
            cbDestino.FormattingEnabled = true;
            cbDestino.Items.AddRange(new object[] { "Ciudad de México", "Los Ángeles", "Culiacán", "New York", "Toronto", "Monterrey" });
            cbDestino.Location = new Point(118, 70);
            cbDestino.Name = "cbDestino";
            cbDestino.Size = new Size(121, 22);
            cbDestino.TabIndex = 13;
            // 
            // cbOrigen
            // 
            cbOrigen.Font = new Font("Georgia", 8F, FontStyle.Bold);
            cbOrigen.FormattingEnabled = true;
            cbOrigen.Items.AddRange(new object[] { "Ciudad de México", "Los Ángeles", "Culiacán", "New York", "Toronto", "Monterrey" });
            cbOrigen.Location = new Point(118, 38);
            cbOrigen.Name = "cbOrigen";
            cbOrigen.Size = new Size(121, 22);
            cbOrigen.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.ForeColor = Color.White;
            label7.Location = new Point(6, 105);
            label7.Name = "label7";
            label7.Size = new Size(115, 19);
            label7.TabIndex = 11;
            label7.Text = "Modelo del avion";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F);
            label8.ForeColor = Color.White;
            label8.Location = new Point(6, 105);
            label8.Name = "label8";
            label8.Size = new Size(0, 19);
            label8.TabIndex = 9;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F);
            label9.ForeColor = Color.White;
            label9.Location = new Point(57, 70);
            label9.Name = "label9";
            label9.Size = new Size(56, 19);
            label9.TabIndex = 7;
            label9.Text = "Destino";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10F);
            label10.ForeColor = Color.White;
            label10.Location = new Point(62, 34);
            label10.Name = "label10";
            label10.Size = new Size(51, 19);
            label10.TabIndex = 5;
            label10.Text = "Origen";
            // 
            // frmCompraBoletos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 21, 32);
            ClientSize = new Size(473, 388);
            Controls.Add(groupBox1);
            Controls.Add(gbDatosCliente);
            Controls.Add(btnComprar);
            Controls.Add(toolStrip1);
            Name = "frmCompraBoletos";
            Text = "frmCompraBoletos";
            Load += frmCompraBoletos_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            gbDatosCliente.ResumeLayout(false);
            gbDatosCliente.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolStrip toolStrip1;
        private ToolStripButton tsbCerrar;
        private Button btnComprar;
        private TextBox txtNombre;
        private Label lbNombreCliente;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton tsbVerAsiento;
        private GroupBox gbDatosCliente;
        private Label label6;
        private TextBox textBox3;
        private Label label5;
        private TextBox textBox2;
        private Label label1;
        private TextBox textBox1;
        private GroupBox groupBox1;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private ComboBox cbModeloAvion;
        private ComboBox cbDestino;
        private ComboBox cbOrigen;
        private DateTimePicker dtpFecha;
        private Label label2;
    }
}