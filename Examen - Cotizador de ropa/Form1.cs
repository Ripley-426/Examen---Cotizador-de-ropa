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
            if (radioPantalon.Checked == true)
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
            if (radioStandard.Checked == true)
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
            try
            {
                labelErrorPrecio.Visible = false;
                float precioIngresado = float.Parse(textBoxPrecio.Text);
                if (precioIngresado > 0)
                {
                    coti.Precio = precioIngresado;
                    if (textBoxCantidad.Text != "")
                    {
                        ControlarCantidad();
                    }
                }
                else
                {
                    throw new Exception("El numero debe ser positivo");
                }
            }
            catch (FormatException)
            {
                labelErrorPrecio.Text = "Formato incorrecto.";
                labelErrorPrecio.Visible = true;
                buttonCotizar.Enabled = false;
            }
            catch (Exception exc)
            {
                labelErrorPrecio.Text = exc.Message;
                labelErrorPrecio.Visible = true;
                buttonCotizar.Enabled = false;
            }
        }

        private void textBoxCantidad_TextChanged(object sender, EventArgs e)
        {
            try
            {
                labelErrorCanti.Visible = false;
                int CantidadIngresada = int.Parse(textBoxCantidad.Text);
                if (CantidadIngresada > 0)
                {
                    if (CantidadIngresada <= int.Parse(labelStock.Text))
                    {
                        coti.Cantidad = CantidadIngresada;
                        if (textBoxPrecio.Text != "")
                        {
                            buttonCotizar.Enabled = true;
                        }
                    }
                    else
                    {
                        throw new Exception("Cantidad mayor al stock");
                    }
                }
                else
                {
                    throw new Exception("El numero debe ser positivo");
                }
            }
            catch (FormatException)
            {
                labelErrorCanti.Text = "Formato incorrecto.";
                labelErrorCanti.Visible = true;
                buttonCotizar.Enabled = false;
            }
            catch (Exception exc)
            {
                labelErrorCanti.Text = exc.Message;
                labelErrorCanti.Visible = true;
                buttonCotizar.Enabled = false;
            }
        }

        private void buttonCotizar_Click(object sender, EventArgs e)
        {
            labelPrecioCotizado.Text = ct.Cotizar(coti).ToString();
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
            LimpiarCotizacion();
            labelStock.Text = ct.VerificarStock(coti).ToString();
            ControlarCantidad();
        }

        private void textBoxCantidad_Leave(object sender, EventArgs e)
        {
            if(coti.Cantidad == 0)
            {
                coti.Cantidad = 1;
            }
            textBoxCantidad.Text = coti.Cantidad.ToString();
        }

        private void textBoxPrecio_Leave(object sender, EventArgs e)
        {
            if(coti.Precio == 0)
            {
                coti.Precio = 1;
            }
            textBoxPrecio.Text = coti.Precio.ToString();
            ControlarCantidad();
        }

        private void linkCotizaciones_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show(ct.HistorialCotizador());
        }

        private void linkLabelLimpiar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ct.LimpiarCotizaciones();
        }


        //Impide que se registren cotizaciones visualmente erroneas en el programa
        //(Luego de hacer una cotizacion y mover los valores, si uno no esta atento puede confundirse de cotizacion).
        private void LimpiarCotizacion()
        {
            labelPrecioCotizado.Text = "";
        }

        private void textBoxPrecio_Enter(object sender, EventArgs e)
        {
            LimpiarCotizacion();
        }

        private void textBoxCantidad_Enter(object sender, EventArgs e)
        {
            LimpiarCotizacion();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ControlarCantidad()
        {
            if(textBoxCantidad.Text != "" && labelStock.Text !="")
            {
                try
                {
                    if (int.Parse(textBoxCantidad.Text) > int.Parse(labelStock.Text))
                    {
                        labelErrorCanti.Text = "Cantidad mayor al stock";
                        labelErrorCanti.Visible = true;
                        buttonCotizar.Enabled = false;
                    }
                    else
                    {
                        labelErrorCanti.Visible = false;
                        buttonCotizar.Enabled = true;
                    }
                }
                catch (Exception)
                {
                    labelErrorCanti.Text = "Formato incorrecto";
                    labelErrorCanti.Visible = true;
                    buttonCotizar.Enabled = false;
                }
                
            }
        }
    }
}
