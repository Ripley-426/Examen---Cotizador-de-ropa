using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen___Cotizador_de_ropa
{
    class Cotizacion
    {
        private int _idNumber;
        private DateTime _fechaHora;
        private int _codigoDeVendedor;
        private Prenda _prenda;
        private int _cantPrendas;
        private float _valorCotizado;

        public Cotizacion(int nroCotizacion, int idVendedor, Prenda prenda, float valorCotizado )
        {
            _idNumber = nroCotizacion;
            _fechaHora = DateTime.Now;
            _codigoDeVendedor = idVendedor;
            _prenda = prenda;
            _cantPrendas = prenda.Cantidad;
            _valorCotizado = valorCotizado;
        }

        public string GetCotizacion()
        {
            return $"------------------------------\n{_fechaHora.ToString("F")} \n {_prenda.GetInformacion()} | Cotizacion : {_valorCotizado} \n";
        }
    }
}
