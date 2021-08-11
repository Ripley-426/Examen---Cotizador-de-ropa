using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen___Cotizador_de_ropa
{
    class DatosCotizador
    {
        private string _tipoDeCalidad;
        private string _tipoDePrenda;
        private string _tipoDeManga = "Larga";
        private string _tipoDeCuello = "Comun";
        private string _tipoDeCorte = "Comunes";

        public string TipoDeCalidad { get => _tipoDeCalidad; set => _tipoDeCalidad = value; }
        public string TipoDePrenda { get => _tipoDePrenda; set => _tipoDePrenda = value; }
        public string TipoDeManga { get => _tipoDeManga; set => _tipoDeManga = value; }
        public string TipoDeCuello { get => _tipoDeCuello; set => _tipoDeCuello = value; }
        public string TipoDeCorte { get => _tipoDeCorte; set => _tipoDeCorte = value; }
    }
}
