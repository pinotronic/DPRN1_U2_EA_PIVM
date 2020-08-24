namespace Nomina
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            menu.menu();
            Empleado empleado = new Empleado() { };
            Proceso solicitarOpciones = new Proceso();
            solicitarOpciones.SolicitarOpciones();


        }
    }
}
