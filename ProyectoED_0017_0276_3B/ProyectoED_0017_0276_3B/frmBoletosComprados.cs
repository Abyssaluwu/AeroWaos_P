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
    public partial class frmBoletosComprados : Form
    {
        public frmBoletosComprados()
        {
            InitializeComponent();
            ConfiguraGrid();
        }
        private void ConfiguraGrid()
        {
            //si quieres agregar mas datos como la distancia o el costo total del boleto solo agreglo 
            dgvBoletosConprados.ColumnCount = 5;
            dgvBoletosConprados.Columns[0].Name = "Nombre del pasajero";
            dgvBoletosConprados.Columns[1].Name = "Fecha de vuelo";
            dgvBoletosConprados.Columns[2].Name = "Origen";
            dgvBoletosConprados.Columns[3].Name = "Destino";
            dgvBoletosConprados.Columns[4].Name = "Asiento";
        }
        private void ActualizaData()
        {
            //crea un metodo para que cargue automaticamente los boletos comprados al momento de entrar a este  form
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
