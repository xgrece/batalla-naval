using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace batallaNaval.Models
{
  
    class Tanque
    {
        public string Nombre { get; set; }
        public string Pais { get; set; }
        public int año { get; set; }
        public int peso { get; set; }
        public List<string> Aliados { get; set; }

        public Tanque(string nombre, string pais, int año, int peso, List<string>aliados)
        {
            this.Nombre = nombre;
            this.Pais = pais;
            this.año = año;
            this.peso = peso;
            this.Aliados = aliados;
        }
        public void MostrarInfo()
        {

            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Pais: {Pais}");
            Console.WriteLine($"Año: {año}");
            Console.WriteLine($"Peso: {peso}");
            Console.WriteLine("Aliados: " + string.Join(", ", this.Aliados));
            Console.WriteLine("\n--------------------------------\n");
        }
        public void batalla(Tanque otroTanque)
        {
            Console.WriteLine($"Tanque 1: ");
            MostrarInfo();
            Console.WriteLine($"Tanque 2: ");
            otroTanque.MostrarInfo();

            if(this.año > otroTanque.año && this.peso > otroTanque.peso)
            {
                Console.WriteLine($"\nEl tanque {this.Nombre} gana la batalla!");
            }
            if(this.año< otroTanque.año && this.peso < otroTanque.peso)
            {
                Console.WriteLine($"\nEl tanque {otroTanque.Nombre} gana la batalla!");
            }
            else
            {
                Console.WriteLine("\nLa batalla termina en empate.");
            }

        }

    }
}
