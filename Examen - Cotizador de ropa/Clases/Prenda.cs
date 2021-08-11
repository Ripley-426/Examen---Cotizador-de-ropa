using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen___Cotizador_de_ropa
{
    abstract class Prenda
    {
        public enum calidadRopa { Standard, Premium}
        protected calidadRopa _calidad;
        protected float _precio;
        protected int _cantidad;
        private string _nombre;

        public string Nombre { get => _nombre; set => _nombre = value; }

        public int Cantidad { get => _cantidad; set => _cantidad = value; }

        public float ObtieneModificadorDePrecioPrenda(float precioTotal)
        {
            if (_calidad == calidadRopa.Standard)
            {
                return precioTotal;
            }
            else
            {
                return (precioTotal * 1.3f);
            }
        }

        public abstract bool VerificarTipo(DatosCotizador coti);
    }
}
