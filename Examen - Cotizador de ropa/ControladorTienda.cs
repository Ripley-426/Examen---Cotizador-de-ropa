using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen___Cotizador_de_ropa
{
    class ControladorTienda
    {
        Tienda tienda;
        Vendedor vendedor;
        List<Cotizacion> cotizaciones = new List<Cotizacion>();
        private int nroCotizacion = 0;

        public void CrearTiendaVendedor()
        {
            tienda = new Tienda("Casa de ropa", "Calle falsa 123");
            vendedor = new Vendedor("Juan", "Perez", 3590);
            AgregarPrendasEnTienda();
        }

        public void AgregarPrendasEnTienda()
        {
            //Camisas
            tienda.AgregarPrenda(new Camisa(100, Camisa.tipoDeManga.Corta, Camisa.tipoDeCuello.Mao, Prenda.calidadRopa.Standard, 0));
            tienda.AgregarPrenda(new Camisa(100, Camisa.tipoDeManga.Corta, Camisa.tipoDeCuello.Mao, Prenda.calidadRopa.Premium, 0));
            tienda.AgregarPrenda(new Camisa(150, Camisa.tipoDeManga.Corta, Camisa.tipoDeCuello.Comun, Prenda.calidadRopa.Standard, 0));
            tienda.AgregarPrenda(new Camisa(150, Camisa.tipoDeManga.Corta, Camisa.tipoDeCuello.Comun, Prenda.calidadRopa.Premium, 0));
            tienda.AgregarPrenda(new Camisa(75, Camisa.tipoDeManga.Larga, Camisa.tipoDeCuello.Mao, Prenda.calidadRopa.Standard, 0));
            tienda.AgregarPrenda(new Camisa(75, Camisa.tipoDeManga.Larga, Camisa.tipoDeCuello.Mao, Prenda.calidadRopa.Premium, 0));
            tienda.AgregarPrenda(new Camisa(175, Camisa.tipoDeManga.Larga, Camisa.tipoDeCuello.Comun, Prenda.calidadRopa.Standard, 0));
            tienda.AgregarPrenda(new Camisa(175, Camisa.tipoDeManga.Larga, Camisa.tipoDeCuello.Comun, Prenda.calidadRopa.Premium, 0));
            //Pantalones
            tienda.AgregarPrenda(new Pantalon(750, Pantalon.cortePantalon.Chupines, Prenda.calidadRopa.Standard, 0));
            tienda.AgregarPrenda(new Pantalon(750, Pantalon.cortePantalon.Chupines, Prenda.calidadRopa.Premium, 0));
            tienda.AgregarPrenda(new Pantalon(250, Pantalon.cortePantalon.Comunes, Prenda.calidadRopa.Standard, 0));
            tienda.AgregarPrenda(new Pantalon(250, Pantalon.cortePantalon.Comunes, Prenda.calidadRopa.Premium, 0));
        }

        public string GetNombreTienda()
        {
            return tienda.Nombre;
        }
        
        public string GetDireccionTienda()
        {
            return tienda.Direccion;
        }

        public string GetDatosVendedor()
        {
            return $"{vendedor.Nombre} {vendedor.Apellido} | {vendedor.CodigoDeVendedor}";
        }

        public int VerificarStock(DatosCotizador coti)
        {
            int cantidad = 0;
            foreach (var prenda in tienda.Prendas)
            {
                if (prenda.Nombre == coti.TipoDePrenda)
                {
                    if (coti.TipoDePrenda == "Pantalon")
                    {
                        if (prenda.VerificarTipo(coti))
                        {
                            cantidad += prenda.Cantidad;
                        }
                    }
                    else
                    {
                        if (prenda.VerificarTipo(coti))
                        {
                            cantidad += prenda.Cantidad;
                        }
                    }
                }  
            }
            return cantidad;
        }

        public float Cotizar(DatosCotizador coti)
        {
            float precio = coti.Precio;
            nroCotizacion += 1;

            if (coti.TipoDePrenda == "Pantalon")
            {
                Pantalon pantalon = new Pantalon(coti.Cantidad, coti.TipoDeCorte, coti.TipoDeCalidad, precio);
                precio = pantalon.ModificaPrecio();
                cotizaciones.Add(new Cotizacion(nroCotizacion, vendedor.CodigoDeVendedor, pantalon, precio));
            }
            else
            {
                Camisa camisa = new Camisa(coti.Cantidad, coti.TipoDeManga, coti.TipoDeCuello, coti.TipoDeCalidad, coti.Precio);
                precio = camisa.ModificaPrecio();
                cotizaciones.Add(new Cotizacion(nroCotizacion, vendedor.CodigoDeVendedor, camisa, precio));
            }
            return precio;
        }

        public string HistorialCotizador()
        {
            string historial = "";
            foreach (var cotizacion in cotizaciones)
            {
                historial += cotizacion.GetCotizacion();
            }
            return historial;
        }

        public void LimpiarCotizaciones()
        {
            cotizaciones.Clear();
        }
    }
}
