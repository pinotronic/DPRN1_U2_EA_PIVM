using System;
using System.Collections.Generic;
using System.Text;

namespace Nomina
{
    class Proceso
    {
        Menu menu = new Menu();
        Empleado empleado = new Empleado("","","","","","","","");
        public void SolicitarOpciones()
        {
            int Opcion;
            String _distancia;
            String destino;


            Console.WriteLine("\n1. Registrar Empleado");
            Console.WriteLine("2. Modificar Datos del Empleado");
            Console.WriteLine("3. Mostrar Informacion Basica del Empleado");
            Console.WriteLine("4. Mostrar Informacion Completa del Empleado");
            Console.WriteLine("5. Salir");
            Console.WriteLine("\nSeria tan amable de Seleccionar una opcion");
            Opcion = int.Parse(Console.ReadLine());



            switch (Opcion)
            {
                case 1:
                    RegistrarEmpleado();
                    Console.Clear();
                    menu.menu();
                    SolicitarOpciones();
                    break;

                case 2:
                    ModificarDatosEmpleado();
                    Console.Clear();
                    menu.menu();
                    SolicitarOpciones();
                    break;

                case 3:
                    MostrarInformacionBasica();
                    Console.Clear();
                    menu.menu();
                    SolicitarOpciones();
                    break;
                case 4:
                    MostrarInformacionCompleta();
                    Console.Clear();
                    menu.menu();
                    SolicitarOpciones();
                    break;
                case 5:
                    Console.WriteLine("\nGracias por utilizar nuestros servicios\n");
                    Environment.Exit(0);
                    break;
            }

        }
        public void RegistrarEmpleado()
        {
            menu.menu();
            Console.WriteLine("\nMe proporciona un numero de empleado");
            empleado.NumTrabajador = Console.ReadLine();
            Console.WriteLine("\nMe proporciona el nombre Completo del empleado");
            empleado.NombreCompleto = Console.ReadLine();
            Console.WriteLine("\nMe proporciona el Cargo del empleado");
            empleado.Cargo = Console.ReadLine();
            Console.WriteLine("\nMe proporciona el Sueldo del empleado");
            empleado.Sueldo = Console.ReadLine();
            Console.WriteLine("\nMe proporciona el Sueldo del empleado");
            empleado.PagoXHoraExtra = Console.ReadLine();
            Console.WriteLine("\nMe proporciona el EstadoCivil del empleado");
            empleado.EstadoCivil = Console.ReadLine();
            Console.WriteLine("\nMe proporciona el numero de Hijos del empleado");
            empleado.NumHijos = Console.ReadLine();
            Console.WriteLine("\nMe proporciona el  IRPF del empleado");
            empleado.IRPF= Console.ReadLine();
            Console.WriteLine("\nLos Datos Fueron Guardados, ");
            Console.WriteLine("\nPara su modificacion en el apartado correspondiente");
            
            Console.ReadKey();
        }
        public void ModificarDatosEmpleado()
        {
            String numempleado;
            Console.WriteLine("\nSi desea modificar los datos de un empleado\n");
            Console.WriteLine("\nProporcione el numero de empleado\n");
            numempleado = Console.ReadLine();
            Console.WriteLine("\nNombre: " + empleado.NumTrabajador);
            Console.ReadKey();
        }

        public void MostrarInformacionBasica()
        {
            String numempleado;
            Console.WriteLine("\nSi ver la informacion Basica de un empleado\n");
            Console.WriteLine("\nProporcione el numero de empleado\n");
            numempleado = Console.ReadLine();
            Console.WriteLine("\nNombre: " + empleado.NumTrabajador);
            Console.ReadKey();
        }
        public void MostrarInformacionCompleta()
        {
            String numempleado;
            Console.WriteLine("\nSi ver la informacion Completa de un empleado\n");
            Console.WriteLine("\nProporcione el numero de empleado\n");
            numempleado = Console.ReadLine();
            Console.WriteLine("\nNombre: " + empleado.NumTrabajador);
            Console.ReadKey();
        }
        public void Calculos()
        {
            /*
            o Cálculo y devolución del complemento correspondiente a las horas extra realizadas.
            o Cálculo y devolución del sueldo bruto.
            o Cálculo y devolución de las retenciones(IRPF) a partir del tipo, teniendo en cuenta que el porcentaje de retención que hay que aplicar es el tipo menos 2 puntos si el empleado está casado y menos 1 punto por cada hijo que tenga; el porcentaje se aplica sobre todo el sueldo bruto.
            paga el 8% si sueldo base es menor o igual 7500
            paga el 13% si es mayor 7500 y menor o igual 32000
            paga el 20% si es mayor 32000

             */
            Console.ReadKey();
        }
    }
}
