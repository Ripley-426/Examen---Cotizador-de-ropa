using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen___Cotizador_de_ropa
{
    class Camisa: Prenda
    {
        public enum tipoDeManga { Corta, Larga}
        public enum tipoDeCuello { Mao, Comun}
        private tipoDeManga _manga;
        private tipoDeCuello _cuello;

        public Camisa(int cantidad, tipoDeManga manga, tipoDeCuello cuello, calidadRopa calidad, float precio)
        {
            _cantidad = cantidad;
            _manga = manga;
            _cuello = cuello;
            _calidad = calidad;
            _precio = precio;
        }

        public float ObtieneModificadorDePrecio(float precioTotal)
        {
            if (_manga == tipoDeManga.Corta)
            {
                precioTotal *= 0.9f;
            }
            if(_cuello == tipoDeCuello.Mao)
            {
                precioTotal *= 1.03f;
            }
            base.ObtieneModificadorDePrecioPrenda(precioTotal);

            return precioTotal;
        }
    }
}
