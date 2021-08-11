using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen___Cotizador_de_ropa
{
    public partial class Form1 : Form
    {
        ControladorTienda ct = new ControladorTienda();
        DatosCotizador coti = new DatosCotizador();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ct.CrearTiendaVendedor();
            ActualizarDatos(ct);
        }

        private void ActualizarDatos(ControladorTienda ct)
        {
            ActualizarDatosTienda(ct);
            ActualizarDatosVendedor(ct);
        }

        private void ActualizarDatosTienda(ControladorTienda ct)
        {
            labelNombreTienda.Text = ct.GetNombreTienda();
            labelDireccionTienda.Text = ct.GetDireccionTienda();
        }

        private void ActualizarDatosVendedor(ControladorTienda ct)
        {
            labelNombreVendedor.Text = ct.GetDatosVendedor();
        }

        private void radioCamisa_CheckedChanged(object sender, EventArgs e)
        {
            if(radioCamisa.Checked == true)
            {
                checkChupin.Enabled = false;
                checkManga.Enabled = true;
                checkCuello.Enabled = true;
                textBoxPrecio.Enabled = true;
                coti.TipoDePrenda = "Camisa";
                VerificarStock();
            }
        }

        private void radioPantalon_CheckedChanged(object sender, EventArgs e)
        {
            if(radioPantalon.Checked == true)
            {
                checkManga.Enabled = false;
                checkCuello.Enabled = false;
                checkChupin.Enabled = true;
                textBoxPrecio.Enabled = true;
                coti.TipoDePrenda = "Pantalon";
                VerificarStock();
            }
        }

        private void radioStandard_CheckedChanged(object sender, EventArgs e)
        {
            if(radioStandard.Checked == true)
            {
                radioCamisa.Enabled = true;
                radioPantalon.Enabled = true;
                coti.TipoDeCalidad = "Standard";
                if (radioCamisa.Checked == true || radioPantalon.Checked == true)
                {
                    VerificarStock();
                }
            }
        }

        private void radioPremium_CheckedChanged(object sender, EventArgs e)
        {
            if (radioPremium.Checked == true)
            {
                radioCamisa.Enabled = true;
                radioPantalon.Enabled = true;
                coti.TipoDeCalidad = "Premium";
                if (radioCamisa.Checked == true || radioPantalon.Checked == true)
                {
                    VerificarStock();
                }
            }
        }

        private void textBoxPrecio_TextChanged(object sender, EventArgs e)
        {
            textBoxCantidad.Enabled = true;
        }

        private void textBoxCantidad_TextChanged(object sender, EventArgs e)
        {
            buttonCotizar.Enabled = true;
        }

        private void buttonCotizar_Click(object sender, EventArgs e)
        {

        }

        private void checkManga_CheckedChanged(object sender, EventArgs e)
        {
            if (checkManga.Checked == true )
            {
                coti.TipoDeManga = "Corta";
            }
            else
            {
                coti.TipoDeManga = "Larga";
            }
            VerificarStock();
        }

        private void checkCuello_CheckedChanged(object sender, EventArgs e)
        {
            if (checkCuello.Checked == true)
            {
                coti.TipoDeCuello = "Mao";
            }
            else
            {
                coti.TipoDeCuello = "Comun";
            }
            VerificarStock();
        }

        private void checkChupin_CheckedChanged(object sender, EventArgs e)
        {
            if (checkChupin.Checked == true)
            {
                coti.TipoDeCorte = "Chupines";
            }
            else
            {
                coti.TipoDeCorte = "Comunes";
            }
            VerificarStock();
        }

        private void VerificarStock()
        {
            labelStock.Text = $"Unidades de stock disponibles: {ct.VerificarStock(coti).ToString()}";
        }
    }
}
