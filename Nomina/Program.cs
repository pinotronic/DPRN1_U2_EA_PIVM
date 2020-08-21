using System;

namespace Nomina
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            menu.menu();
            Proceso solicitarOpciones = new Proceso();
            solicitarOpciones.SolicitarOpciones();


        }
    }
}
