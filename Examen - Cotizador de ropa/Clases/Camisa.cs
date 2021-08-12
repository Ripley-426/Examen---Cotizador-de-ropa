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
            Nombre = "Camisa";
        }

        public Camisa(int cantidad, string manga, string cuello, string calidad, float precio)
        {
            _cantidad = cantidad;
            _precio = precio;
            Nombre = "Camisa";
            if (manga == "Larga")
            {
                _manga = tipoDeManga.Larga;
            }
            else
            {
                _manga = tipoDeManga.Corta;
            }
            if (calidad == "Standard")
            {
                _calidad = calidadRopa.Standard;
            }
            else
            {
                _calidad = calidadRopa.Premium;
            }
            if (cuello == "Mao")
            {
                _cuello = tipoDeCuello.Mao;
            }
            else
            {
                _cuello = tipoDeCuello.Comun;
            }
        }

        public float ModificaPrecio()
        {
            float precioTotal = _precio * _cantidad;

            if (_manga == tipoDeManga.Corta)
            {
                precioTotal *= 0.9f;
            }
            if(_cuello == tipoDeCuello.Mao)
            {
                precioTotal *= 1.03f;
            }
            precioTotal = base.ModificaPrecio(precioTotal);

            return precioTotal;
        }
        public override bool VerificarTipo(DatosCotizador coti)
        {
            if (coti.TipoDeCalidad == _calidad.ToString() &&
                coti.TipoDeManga == _manga.ToString() &&
                coti.TipoDeCuello == _cuello.ToString())
            {
                return true;
            }
            return false;
        }

        public override string GetInformacion()
        {
            return $"- {Nombre} | Cuello: {_cuello.ToString()} | Manga: {_manga.ToString()} | Calidad: {_calidad.ToString()} \n x{_cantidad} unidades a ${_precio}";
        }
    }
}
