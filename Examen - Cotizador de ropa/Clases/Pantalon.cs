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

        public Pantalon(int cantidad, cortePantalon corte, calidadRopa calidad, float precio)
        {
            _cantidad = cantidad;
            _corte = corte;
            _calidad = calidad;
            _precio = precio;
        }

        public float ObtieneModificadorDePrecio(float precioTotal)
        {
            if (_corte == cortePantalon.Chupines)
            {
                precioTotal *= 0.88f;
            }
            base.ObtieneModificadorDePrecioPrenda(precioTotal);

            return precioTotal;
        }
    }
}
