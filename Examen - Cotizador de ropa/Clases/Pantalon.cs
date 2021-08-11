using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen___Cotizador_de_ropa
{
    class Pantalon : Prenda
    {
        public enum cortePantalon { Comunes, Chupines}
        private cortePantalon _corte;

        public cortePantalon Corte { get => _corte; set => _corte = value; }

        public Pantalon(int cantidad, cortePantalon corte, calidadRopa calidad, float precio)
        {
            _cantidad = cantidad;
            _corte = corte;
            _calidad = calidad;
            _precio = precio;
            Nombre = "Pantalon";
        }

        public Pantalon(int cantidad, string corte, string calidad, float precio)
        {
            _cantidad = cantidad;
            _precio = precio;
            Nombre = "Pantalon";
            if(corte == "Comunes")
            {
                _corte = cortePantalon.Comunes;
            }
            else
            {
                _corte = cortePantalon.Chupines;
            }
            if(calidad == "Standard")
            {
                _calidad = calidadRopa.Standard;
            }
            else
            {
                _calidad = calidadRopa.Premium;
            }
        }

        public float ObtieneModificadorDePrecio()
        {
            float precioTotal = _precio * _cantidad;

            if (_corte == cortePantalon.Chupines)
            {
                precioTotal *= 0.88f;
            }
            base.ObtieneModificadorDePrecioPrenda(precioTotal);

            return precioTotal;
        }

        public override bool VerificarTipo(DatosCotizador coti)
        {
            if (coti.TipoDeCalidad == _calidad.ToString() &&
                coti.TipoDeCorte == _corte.ToString())
            {
                return true;
            }
            return false;
        }
    }
}
