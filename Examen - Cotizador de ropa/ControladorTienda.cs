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
            if (coti.TipoDePrenda == "Pantalon")
            {
                Pantalon pantalon = new Pantalon(coti.Cantidad, coti.TipoDeCorte, coti.TipoDeCalidad, precio);
                precio = pantalon.ObtieneModificadorDePrecio();
            }
            else
            {
                Camisa camisa = new Camisa(coti.Cantidad, coti.TipoDeManga, coti.TipoDeCuello, coti.TipoDeCalidad, coti.Precio);
                precio = camisa.ObtieneModificadorDePrecio();
            }
            return precio;
        }
    }
}
