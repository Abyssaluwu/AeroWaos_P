namespace ProyectoED_0017_0276_3B
{
    partial class frmBoletosComprados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBoletosComprados));
            dgvBoletosConprados = new DataGridView();
            btnActualizar = new Button();
            btnOrdenar = new Button();
            toolStrip1 = new ToolStrip();
            tsbCerrar = new ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)dgvBoletosConprados).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvBoletosConprados
            // 
            dgvBoletosConprados.Anchor = AnchorStyles.None;
            dgvBoletosConprados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBoletosConprados.Location = new Point(-1, 90);
            dgvBoletosConprados.Name = "dgvBoletosConprados";
            dgvBoletosConprados.ReadOnly = true;
            dgvBoletosConprados.Size = new Size(472, 310);
            dgvBoletosConprados.TabIndex = 0;
            // 
            // btnActualizar
            // 
            btnActualizar.FlatAppearance.BorderSize = 0;
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.Font = new Font("Verdana", 9F, FontStyle.Bold);
            btnActualizar.ForeColor = Color.Red;
            btnActualizar.Location = new Point(12, 49);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(92, 35);
            btnActualizar.TabIndex = 1;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnOrdenar
            // 
            btnOrdenar.FlatAppearance.BorderSize = 0;
            btnOrdenar.FlatStyle = FlatStyle.Flat;
            btnOrdenar.Font = new Font("Verdana", 9F, FontStyle.Bold);
            btnOrdenar.ForeColor = Color.Red;
            btnOrdenar.Location = new Point(358, 49);
            btnOrdenar.Name = "btnOrdenar";
            btnOrdenar.Size = new Size(92, 35);
            btnOrdenar.TabIndex = 2;
            btnOrdenar.Text = "Ordenar";
            btnOrdenar.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.Black;
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbCerrar });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(473, 25);
            toolStrip1.TabIndex = 3;
            toolStrip1.Text = "toolstrip";
            // 
            // tsbCerrar
            // 
            tsbCerrar.Alignment = ToolStripItemAlignment.Right;
            tsbCerrar.BackColor = Color.Red;
            tsbCerrar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbCerrar.ForeColor = Color.Red;
            tsbCerrar.Image = (Image)resources.GetObject("tsbCerrar.Image");
            tsbCerrar.ImageTransparentColor = Color.Magenta;
            tsbCerrar.Name = "tsbCerrar";
            tsbCerrar.Size = new Size(23, 22);
            tsbCerrar.Text = "cerrar";
            tsbCerrar.Click += toolStripButton1_Click;
            // 
            // frmBoletosComprados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 21, 32);
            ClientSize = new Size(473, 431);
            Controls.Add(toolStrip1);
            Controls.Add(btnOrdenar);
            Controls.Add(btnActualizar);
            Controls.Add(dgvBoletosConprados);
            Name = "frmBoletosComprados";
            Text = "Boletos comprados";
            ((System.ComponentModel.ISupportInitialize)dgvBoletosConprados).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvBoletosConprados;
        private Button btnActualizar;
        private Button btnOrdenar;
        private ToolStrip toolStrip1;
        private ToolStripButton tsbCerrar;
    }
}