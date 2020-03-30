using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Futbolista
{
    class Program
    {
        static void Main(string[] args)
        {
            Futbolista miJugador = new Futbolista("Maradona", 33, "delantero", 1.65, 8);

            miJugador.mostrarJugador();


            miJugador.correr();

            miJugador.pasar();

            miJugador.mostrarCantGoles();

            miJugador.mostrarCantAsistencias();

            miJugador.asistencia();

            miJugador.mostrarCantAsistencias();

            miJugador.asistencia();

            miJugador.mostrarCantAsistencias();

            miJugador.patear();

            miJugador.mostrarCantGoles();

            miJugador.patear();

            miJugador.mostrarCantGoles();

            Console.ReadKey();
        }
    }
}
