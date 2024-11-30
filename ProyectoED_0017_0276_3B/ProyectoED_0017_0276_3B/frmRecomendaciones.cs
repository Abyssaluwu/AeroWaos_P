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
    public partial class frmRecomendaciones : Form
    {
        public frmRecomendaciones()
        {
            InitializeComponent();
            cbOrigen.SelectedIndexChanged += new EventHandler(Seleccion_Combo); 
            cbDestino.SelectedIndexChanged += new EventHandler(Seleccion_Combo);
        }
        private void Seleccion_Combo(object sender, EventArgs e)
        {
            string origen = cbOrigen.Text;
            string destino = cbDestino.Text;
            pbAvion.Image = Cargar_Avion(origen, destino);
        }
        private Image Cargar_Avion (string origen, string destino)
        {
            string rutaimagen="";
            switch (origen)
            {
                case "Ciudad de Mexico":
                    switch (destino)
                    {
                        case "Monterrey":
                            rutaimagen= "C:\\Users\\52871\\Desktop\\ProyectoED_0017_0276_3B\\Gulfstram G7001.jpg";
                            lbPrecio.Text = "$13,500";
                            break;
                        case "Culiacan":
                            rutaimagen = "C:\\Users\\52871\\Desktop\\ProyectoED_0017_0276_3B\\Gulfstram G7001.jpg";
                            lbPrecio.Text = "$22,500";
                            break;
                        case "Toronto":
                            rutaimagen = "C:\\Users\\52871\\Desktop\\ProyectoED_0017_0276_3B\\Bormbardier Global-8000-landing-shot.jpg";
                            lbPrecio.Text = "$40,500";
                            break;
                        case "Los Angeles":
                            rutaimagen = "C:\\Users\\52871\\Desktop\\ProyectoED_0017_0276_3B\\Dessauly Falcon 7X.jpg";
                            lbPrecio.Text = "$31,500";
                            break;
                        case "New York":
                            rutaimagen = "C:\\Users\\52871\\Desktop\\ProyectoED_0017_0276_3B\\Dessauly Falcon 7X.jpg";
                            lbPrecio.Text = "$22,500";
                            break;
                    }
                    break;
                case "Monterrey":
                    switch (destino)
                    {
                        case "Ciudad de Mexico":
                            rutaimagen = "C:\\Users\\52871\\Desktop\\ProyectoED_0017_0276_3B\\Gulfstram G7001.jpg";
                            lbPrecio.Text = "$13,500";
                            break;
                        case "Culiacan":
                            rutaimagen = "C:\\Users\\52871\\Desktop\\ProyectoED_0017_0276_3B\\Gulfstram G7001.jpg";
                            lbPrecio.Text = "$14,400";
                            break;
                        case "Toronto":
                            rutaimagen = "C:\\Users\\52871\\Desktop\\ProyectoED_0017_0276_3B\\Bormbardier Global-8000-landing-shot.jpg";
                            lbPrecio.Text = "$24,750";
                            break;
                        case "Los Angeles":
                            rutaimagen = "C:\\Users\\52871\\Desktop\\ProyectoED_0017_0276_3B\\Dessauly Falcon 7X.jpg";
                            lbPrecio.Text = "$21,000";
                            break;
                        case "New York":
                            rutaimagen = "C:\\Users\\52871\\Desktop\\ProyectoED_0017_0276_3B\\Dessauly Falcon 7X.jpg";
                            lbPrecio.Text = "$40,500";
                            break;
                    }
                    break;
                case "Culiacan":
                    switch (destino)
                    {
                        case "Ciudad de Mexico":
                            rutaimagen = "C:\\Users\\52871\\Desktop\\ProyectoED_0017_0276_3B\\Gulfstram G7001.jpg";
                            lbPrecio.Text = "$22,500";
                            break;
                        case "Monterrey":
                            rutaimagen = "C:\\Users\\52871\\Desktop\\ProyectoED_0017_0276_3B\\Gulfstram G7001.jpg";
                            lbPrecio.Text = "$13,500";
                            break;
                        case "Toronto":
                            rutaimagen = "C:\\Users\\52871\\Desktop\\ProyectoED_0017_0276_3B\\Bormbardier Global-8000-landing-shot.jpg";
                            lbPrecio.Text = "$40,500";
                            break;
                        case "Los Angeles":
                            rutaimagen = "C:\\Users\\52871\\Desktop\\ProyectoED_0017_0276_3B\\Dessauly Falcon 7X.jpg";
                            lbPrecio.Text = "$16,500";
                            break;
                        case "New York":
                            rutaimagen = "C:\\Users\\52871\\Desktop\\ProyectoED_0017_0276_3B\\Dessauly Falcon 7X.jpg";
                            lbPrecio.Text = "$34,500";
                            break;
                    }
                    break;
                case "Toronto":
                    switch (destino)
                    {
                        case "Ciudad de Mexico":
                            rutaimagen = "C:\\Users\\52871\\Desktop\\ProyectoED_0017_0276_3B\\Gulfstram G7001.jpg";
                            lbPrecio.Text = "$40,500";
                            break;
                        case "Culiacan":
                            rutaimagen = "C:\\Users\\52871\\Desktop\\ProyectoED_0017_0276_3B\\Gulfstram G7001.jpg";
                            lbPrecio.Text = "$40,500";
                            break;
                        case "Monterrey":
                            rutaimagen = "C:\\Users\\52871\\Desktop\\ProyectoED_0017_0276_3B\\Bormbardier Global-8000-landing-shot.jpg";
                            lbPrecio.Text = "$24,750";
                            break;
                        case "Los Angeles":
                            rutaimagen = "C:\\Users\\52871\\Desktop\\ProyectoED_0017_0276_3B\\Dessauly Falcon 7X.jpg";
                            lbPrecio.Text = "$30,000";
                            break;
                        case "New York":
                            rutaimagen = "C:\\Users\\52871\\Desktop\\ProyectoED_0017_0276_3B\\Dessauly Falcon 7X.jpg";
                            lbPrecio.Text = "$9,000";
                            break;
                    }
                    break;
                case "Los Angeles":
                    switch (destino)
                    {
                        case "Ciudad de Mexico":
                            rutaimagen = "C:\\Users\\52871\\Desktop\\ProyectoED_0017_0276_3B\\Gulfstram G7001.jpg";
                            lbPrecio.Text = "$31,500";
                            break;
                        case "Culiacan":
                            rutaimagen = "C:\\Users\\52871\\Desktop\\ProyectoED_0017_0276_3B\\Gulfstram G7001.jpg";
                            lbPrecio.Text = "$16,500";
                            break;
                        case "Toronto":
                            rutaimagen = "C:\\Users\\52871\\Desktop\\ProyectoED_0017_0276_3B\\Bormbardier Global-8000-landing-shot.jpg";
                            lbPrecio.Text = "$30,000";
                            break;
                        case "Monterrey":
                            rutaimagen = "C:\\Users\\52871\\Desktop\\ProyectoED_0017_0276_3B\\Dessauly Falcon 7X.jpg";
                            lbPrecio.Text = "$21,000";
                            break;
                        case "New York":
                            rutaimagen = "C:\\Users\\52871\\Desktop\\ProyectoED_0017_0276_3B\\Dessauly Falcon 7X.jpg";
                            lbPrecio.Text = "$33,000";
                            break;
                    }
                    break;
                case "New York":
                    switch (destino)
                    {
                        case "Ciudad de Mexico":
                            rutaimagen = "C:\\Users\\52871\\Desktop\\ProyectoED_0017_0276_3B\\Gulfstram G7001.jpg";
                            lbPrecio.Text = "$22,500";
                            break;
                        case "Culiacan":
                            rutaimagen = "C:\\Users\\52871\\Desktop\\ProyectoED_0017_0276_3B\\Gulfstram G7001.jpg";
                            lbPrecio.Text = "$34,500";
                            break;
                        case "Toronto":
                            rutaimagen = "C:\\Users\\52871\\Desktop\\ProyectoED_0017_0276_3B\\Bormbardier Global-8000-landing-shot.jpg";
                            lbPrecio.Text = "$9,000";
                            break;
                        case "Los Angeles":
                            rutaimagen = "C:\\Users\\52871\\Desktop\\ProyectoED_0017_0276_3B\\Dessauly Falcon 7X.jpg";
                            lbPrecio.Text = "$33,000";
                            break;
                        case "Monterrey":
                            rutaimagen = "C:\\Users\\52871\\Desktop\\ProyectoED_0017_0276_3B\\Dessauly Falcon 7X.jpg";
                            lbPrecio.Text = "40,500";
                            break;
                    }
                    break;
                default:
                     rutaimagen = "C:\\Users\\52871\\Desktop\\ProyectoED_0017_0276_3B\\tacha.jpeg";
                    break;

            }
            try
            {
                if (!string.IsNullOrEmpty(rutaimagen))
                {
                    return Image.FromFile(rutaimagen);
                }
                else
                {
                    throw new FileNotFoundException("Ruta de imagen no encontrada.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la imagen: " + ex.Message);
                return new Bitmap(1, 1);
            }
        }
    }
}
