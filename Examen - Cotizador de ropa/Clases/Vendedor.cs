using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen___Cotizador_de_ropa
{
    class Vendedor
    {
        private string _nombre;
        private string _apellido;
        private int _codigoDeVendedor;

        public Vendedor(string nombre, string apellido, int codigoDeVendedor)
        {
            _nombre = nombre;
            _apellido = apellido;
            _codigoDeVendedor = codigoDeVendedor;
        }

        public string Nombre { get => _nombre; }
        public string Apellido { get => _apellido; }
        public int CodigoDeVendedor { get => _codigoDeVendedor; }
    }
}
