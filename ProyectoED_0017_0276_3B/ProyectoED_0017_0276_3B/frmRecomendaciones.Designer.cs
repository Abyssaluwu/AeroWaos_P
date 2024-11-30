namespace ProyectoED_0017_0276_3B
{
    partial class frmRecomendaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecomendaciones));
            pcbMapa = new PictureBox();
            cbDestino = new ComboBox();
            cbOrigen = new ComboBox();
            label9 = new Label();
            label10 = new Label();
            label1 = new Label();
            pbAvion = new PictureBox();
            label2 = new Label();
            lbPrecio = new Label();
            ((System.ComponentModel.ISupportInitialize)pcbMapa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAvion).BeginInit();
            SuspendLayout();
            // 
            // pcbMapa
            // 
            pcbMapa.Image = (Image)resources.GetObject("pcbMapa.Image");
            pcbMapa.Location = new Point(12, 49);
            pcbMapa.Name = "pcbMapa";
            pcbMapa.Size = new Size(449, 267);
            pcbMapa.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbMapa.TabIndex = 11;
            pcbMapa.TabStop = false;
            // 
            // cbDestino
            // 
            cbDestino.Font = new Font("Georgia", 8F, FontStyle.Bold);
            cbDestino.FormattingEnabled = true;
            cbDestino.Items.AddRange(new object[] { "Ciudad de Mexico", "Los Angeles", "Culiacan", "New York", "Toronto", "Monterrey" });
            cbDestino.Location = new Point(315, 21);
            cbDestino.Name = "cbDestino";
            cbDestino.Size = new Size(121, 22);
            cbDestino.TabIndex = 17;
            // 
            // cbOrigen
            // 
            cbOrigen.Font = new Font("Georgia", 8F, FontStyle.Bold);
            cbOrigen.FormattingEnabled = true;
            cbOrigen.Items.AddRange(new object[] { "Ciudad de Mexico", "Los Angeles", "Culiacan", "New York", "Toronto", "Monterrey" });
            cbOrigen.Location = new Point(91, 21);
            cbOrigen.Name = "cbOrigen";
            cbOrigen.Size = new Size(121, 22);
            cbOrigen.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F);
            label9.ForeColor = Color.White;
            label9.Location = new Point(254, 21);
            label9.Name = "label9";
            label9.Size = new Size(56, 19);
            label9.TabIndex = 15;
            label9.Text = "Destino";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10F);
            label10.ForeColor = Color.White;
            label10.Location = new Point(34, 21);
            label10.Name = "label10";
            label10.Size = new Size(51, 19);
            label10.TabIndex = 14;
            label10.Text = "Origen";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 13F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(136, 319);
            label1.Name = "label1";
            label1.Size = new Size(196, 21);
            label1.TabIndex = 18;
            label1.Text = "Avión recomendado";
            // 
            // pbAvion
            // 
            pbAvion.Location = new Point(305, 343);
            pbAvion.Name = "pbAvion";
            pbAvion.Size = new Size(156, 76);
            pbAvion.SizeMode = PictureBoxSizeMode.AutoSize;
            pbAvion.TabIndex = 19;
            pbAvion.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(10, 383);
            label2.Name = "label2";
            label2.Size = new Size(207, 14);
            label2.TabIndex = 20;
            label2.Text = "Precio estimado por 10 horas:";
            // 
            // lbPrecio
            // 
            lbPrecio.AutoSize = true;
            lbPrecio.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbPrecio.ForeColor = Color.Gainsboro;
            lbPrecio.Location = new Point(223, 383);
            lbPrecio.Name = "lbPrecio";
            lbPrecio.Size = new Size(39, 14);
            lbPrecio.TabIndex = 21;
            lbPrecio.Text = "0000";
            // 
            // frmRecomendaciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 21, 32);
            ClientSize = new Size(473, 431);
            Controls.Add(lbPrecio);
            Controls.Add(label2);
            Controls.Add(pbAvion);
            Controls.Add(label1);
            Controls.Add(cbDestino);
            Controls.Add(cbOrigen);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(pcbMapa);
            Name = "frmRecomendaciones";
            Text = "frmRecomendaciones";
            ((System.ComponentModel.ISupportInitialize)pcbMapa).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAvion).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pcbMapa;
        private ComboBox cbDestino;
        private ComboBox cbOrigen;
        private Label label9;
        private Label label10;
        private Label label1;
        private PictureBox pbAvion;
        private Label label2;
        private Label lbPrecio;
    }
}