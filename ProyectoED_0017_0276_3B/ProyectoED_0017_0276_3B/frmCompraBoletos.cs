using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoED_0017_0276_3B
{
    public partial class frmCompraBoletos : Form
    {
        public frmCompraBoletos()
        {
            InitializeComponent();
        }

        private void tsbCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbVerAsiento_Click(object sender, EventArgs e)
        {
            // aqui abrirar el form del avion, ese form es solo una demostracion
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            try
            {
                //comrueba que ya eligieron asiento, que los datos se ingrsaron de manera correcta y esas madres
                Pasajero CPasajero= new Pasajero(txtNombre.Text, int.Parse(textBox1.Text), textBox2.Text, textBox3.Text);
                string origen = cbOrigen.Text, destino = cbDestino.Text;
                DateTime fecha = DateTime.Parse(dtpFecha.Text);
                if (origen == destino)
                {
                    MessageBox.Show("Su origen no puede ser igual al destino", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (fecha > DateTime.Today)
                    {
                        Boleto boleto = new Boleto(fecha, CPasajero.Nombre, origen, destino);
                        MessageBox.Show("Vuelo privado comprado con exito", "Gracias por su compra", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Fecha de vuelo inválida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese los datos correctamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void frmCompraBoletos_Load(object sender, EventArgs e)
        {

        }
    }
}
