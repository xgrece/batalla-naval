using battalaNaval.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace batallaNaval.Models
{
    class Bloque
    {
        public int largo { get; set; }
        public int ancho { get; set; }
        public int alto { get; set;}

        public Bloque(int largo, int ancho, int alto)
        {
           this.largo = largo;
            this.ancho = ancho; 
            this.alto = alto;
        }
        public void obtenerLargo()
        {
            Console.WriteLine("\n--------------------------------\n");
            Console.WriteLine($"El largo es de: {largo} metros");
        }
            public void obtenerAncho()
        {
            Console.WriteLine($"El ancho es de: {ancho} metros");
        }
            public void obtenerAlto()
        {
            Console.WriteLine($"El alto es de: {alto} metros");
        }
        public double ObtenerVolumen()
        {
            return largo * ancho * alto;
        }

        public double ObtenerAreaSuperficie()
        {
            return 2 * (largo * ancho + largo * alto + ancho * alto);
        }
    }

}
