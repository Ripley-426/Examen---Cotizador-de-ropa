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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ControladorTienda ct = new ControladorTienda();
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
    }
}
