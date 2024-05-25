using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace battalaNaval.Models

{
    internal class Barco
    {
        public int Cargamento { get; set; }
        public int Tripulacion { get; set; }
        public Barco(int cargamento, int tripulacion)
        {
            this.Cargamento = cargamento;
            this.Tripulacion = tripulacion;
        }
        public bool valeLaPenaSaquear() {
            int pesorestante = Cargamento - Tripulacion;
            return pesorestante > 20;
        }
    }

}
