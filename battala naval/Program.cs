using batallaNaval.Models;
using battalaNaval.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        //datos de persona
        Persona persona1 = new Persona("Juan", 21, "hombre");
        persona1.Hablar();
        Console.WriteLine("\n--------------------------------\n");

        //saquear barco
        Barco barco1 = new Barco(50, 20);
      bool saquear =  barco1.valeLaPenaSaquear();
        Console.WriteLine($"Vale la pena saquear? { saquear}");
        Console.WriteLine("\n--------------------------------\n");

        //cargar tanques
        List<string> aliado1 = new List<string> { "Pepe", "Juan" };
        List<string> aliado2 = new List<string> { "Jose", "Raul" };

        Tanque tanque1 = new Tanque("Villeros", "Italia", 1980, 200, aliado1);
        Tanque tanque2 = new Tanque("pipas", "Frances", 1990, 220, aliado2);

        tanque1.batalla(tanque2);

        //Info Bloque
        Bloque Bloque1 = new Bloque(200,60,5);

        //llamadas a los metodos
        Bloque1.obtenerLargo();
        Bloque1.obtenerAncho();
        Bloque1.obtenerAlto();
        Bloque1.ObtenerAreaSuperficie();
        Bloque1.ObtenerVolumen();
        Console.WriteLine("\n--------------------------------\n");
        Console.WriteLine($"El volumen del barco es de {Bloque1.ObtenerVolumen()} m³");
        Console.WriteLine("\n--------------------------------\n");
        Console.WriteLine($"El area superficial del barco es de {Bloque1.ObtenerAreaSuperficie()} m²");
    }
}
