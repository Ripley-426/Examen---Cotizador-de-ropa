using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen___Cotizador_de_ropa
{
    class Tienda
    {
        private string _nombre;
        private string _direccion;
        private List<Prenda> prendas = new List<Prenda>();


        public Tienda(string nombre, string direccion)
        {
            _nombre = nombre;
            _direccion = direccion;
        }

        public string Nombre { get => _nombre; }
        public string Direccion { get => _direccion; }
        public List<Prenda> Prendas { get => prendas; }

        public void AgregarPrenda(Prenda prenda)
        {
            prendas.Add(prenda);
        }
    }
}
