namespace ProyectoED_0017_0276_3B
{
    public partial class frmLobby : Form
    {

        public frmLobby()
        {
            InitializeComponent();
            PersonalizarForm();
            OcultarInfo();
        }
        #region menus
        private void PersonalizarForm()
        {
            pnlSubMenu.Visible = false;

        }
        private void EsconderSubMenu()
        {
            if (pnlSubMenu.Visible == true)
            {
                pnlSubMenu.Visible = false;
            }
        }
        private void MostrarSubMenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                EsconderSubMenu();
                pnlSubMenu.Visible = true;
            }
            else
            {
                pnlSubMenu.Visible = false;
            }
        }
        #endregion
        #region botones
        private void btnOpcionesCompra_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(pnlSubMenu);
        }

        private void btnMostrarVuelos_Click(object sender, EventArgs e)
        {
            //aqui mostraras los destinos disponibles segun tu ciudad de origenEs
            AbrirFormularioHijos(new frmCentroDeInformacion());
            EsconderSubMenu();
        }

        private void btnMostrarBoletosComprados_Click(object sender, EventArgs e)
        {
            //aqui mostraras un form con los boletos que han sido comprados}
            AbrirFormularioHijos(new frmBoletosComprados());
            EsconderSubMenu();

        }

        private void btnCompra_Click(object sender, EventArgs e)
        {
            //aqui mostraras un menu form de compra
            AbrirFormularioHijos(new frmCompraBoletos());
            EsconderSubMenu();

        }
        #endregion
        #region Confurgurar formularios en el panel 
        private Form formActivo = null;
        private void AbrirFormularioHijos(Form formulario_hijo)
        {
            if (formActivo != null)
            {
                formActivo.Close();
            }
            formActivo = formulario_hijo;
            formulario_hijo.TopLevel = false;
            formulario_hijo.FormBorderStyle = FormBorderStyle.None;
            formulario_hijo.Dock = DockStyle.Fill;
            pnlFormularioHijo.Controls.Add(formulario_hijo);
            pnlFormularioHijo.Tag = formulario_hijo;
            formulario_hijo.BringToFront();
            formulario_hijo.Show();

        }
        #endregion
        #region acerca de aero waos
        private void OcultarInfo()
        {
            lbConfort.Hide();
            lbConftxt.Hide();
            lbExpPrem.Hide();
            lbExpPremtxt.Hide();
            lbFlexibilidad.Hide();
            lbFlextxt.Hide();
            lbSegtxt.Hide();
            lbSeguridad.Hide();
        }
        #endregion

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            if (!lbSeguridad.Visible)
            {
                lbConfort.Show();
                lbConftxt.Show();
                lbExpPrem.Show();
                lbExpPremtxt.Show();
                lbFlexibilidad.Show();
                lbFlextxt.Show();
                lbSegtxt.Show();
                lbSeguridad.Show();
            }
            else
            {
                OcultarInfo();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRecomendaciones_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijos(new frmRecomendaciones());
        }
    }
}
