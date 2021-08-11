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
    }
}
