using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.IO;
using System.Security.Permissions;

namespace Nomina
{

    class Proceso
    {
        Menu menu = new Menu();

        private List<Empleado> listaEmpleados;
        private Dato dato;
        private Empleado empleado;

        public void SolicitarOpciones()
        {
            listaEmpleados = new List<Empleado>();

            int Opcion;
            String _distancia;
            String destino;

            dato = new Dato("Empleado.bd");

            do
            {
                do
                {
                    if (File.Exists("Empleado.bd"))
                    {
                        listaEmpleados = dato.deserializar();
                        Console.WriteLine("\n1. hay empleados previamente registrados ");
                    }

                    Console.WriteLine("\n1. Registrar Empleado");
                    Console.WriteLine("2. Mostrar listado de Empleado");
                    Console.WriteLine("3. Modificar Datos del Empleado");
                    Console.WriteLine("4. Mostrar Informacion Basica del Empleado");
                    Console.WriteLine("5. Mostrar Informacion Completa del Empleado");
                    Console.WriteLine("6. Salir");
                    Console.WriteLine("\nSeria tan amable de Seleccionar una opcion");
                    Opcion = int.Parse(Console.ReadLine());
                    Console.Clear();

                    if (Opcion < 1 || Opcion > 6)
                    {
                        Console.WriteLine("Ingrese una opción válida [1-6]");
                    }

                } while (Opcion < 1 || Opcion > 6);

                switch (Opcion)
                {
                    case 1:
                        // => Registrar Empleado
                        RegistrarEmpleado();
                        Console.Clear();
                        menu.menu();
                        SolicitarOpciones();
                        break;

                    case 2:
                        // => // => Mostrar Informacion Basica del Empleado

                        Console.Clear();
                        menu.menu();
                        ListarEmpleados();
                        Console.Clear();
                        menu.menu();

                        break;

                    case 3:
                        // = Modificar Datos del Empleado

                        ModificarDatosEmpleado();
                        break;
                    case 4:
                        // => Mostrar Informacion Basica del Empleado
                        MostrarInformacionBasica();
                        Console.Clear();
                        menu.menu();
                        SolicitarOpciones();
                        break;
                    case 5:
                        // => Mostrar Informacion Completa del Empleado
                        MostrarInformacionCompleta();
                        Console.Clear();
                        menu.menu();
                        SolicitarOpciones();
                        break;

                    case 6:
                        // => Exit
                        Console.WriteLine("\nGracias por utilizar nuestros servicios\n");
                        Environment.Exit(0);
                        break;

                }

            } while (Opcion != 6);
        }
        public void RegistrarEmpleado()
        {
            menu.menu();
            Empleado empleado = new Empleado();

            Console.Write("Me proporciona un numero de empleado: ");
            empleado.NumTrabajador = Convert.ToInt32(Console.ReadLine());

            Console.Write("Me proporciona el nombre Completo del empleado: ");
            empleado.NombreCompleto = Console.ReadLine();

            Console.Write("Me proporciona el Cargo del empleado: ");
            empleado.Cargo = Console.ReadLine();

            Console.Write("Me proporciona el Sueldo del empleado: ");
            empleado.Sueldo = Console.ReadLine();

            Console.Write("Me proporciona las Horas Extras del empleado: ");
            empleado.PagoXHoraExtra = Console.ReadLine();

            Console.Write("Me proporciona el EstadoCivil del empleado: ");
            empleado.EstadoCivil = Console.ReadLine();

            Console.Write("Me proporciona el numero de Hijos del empleado: ");
            empleado.NumHijos = Console.ReadLine();

            Console.Write("Me proporciona el  IRPF del empleado: ");
            empleado.IRPF = Console.ReadLine();

            listaEmpleados.Add(empleado);
            dato.serializar(listaEmpleados);

            Console.WriteLine("\nLos Datos Fueron Guardados, ");
            Console.WriteLine("Para su modificacion en el apartado correspondiente");
            Console.WriteLine("\nPresione una Tecla Para el menu de Opciones.");

            Console.ReadKey();
        }

        public void ListarEmpleados()
        {
            Console.WriteLine("-Lista de Empleados");
            Console.ReadKey();
            foreach (Empleado b in listaEmpleados)
            {
                Console.WriteLine("------------------------");
                Console.WriteLine("ID: " + b.NumTrabajador);
                Console.WriteLine("Nombre: " + b.NombreCompleto);
                Console.WriteLine("Cargo: " + b.Cargo);
                Console.WriteLine("Sueldo: $" + b.Sueldo);
                Console.WriteLine("HoraExtra: " + b.PagoXHoraExtra);
                Console.WriteLine("EstadoCivil: " + b.EstadoCivil);
                Console.WriteLine("# Hijos: " + b.NumHijos);
                Console.WriteLine("RFC: " + b.IRPF);
                Console.ReadKey();

            }
        }
        public void ModificarDatosEmpleado()
        {
            Console.WriteLine("Me proporciona un numero de empleado");
            String ValorEntrada = Console.ReadLine();

            if (int.Parse(ValorEntrada) == 0 || ValorEntrada == null)
            {
                Console.WriteLine("**** Me proporciona un numero de empleado ****");
                ValorEntrada = Console.ReadLine();
            }
            foreach (Empleado b in listaEmpleados)
            {
                if (b.NumTrabajador == int.Parse(ValorEntrada))
                {
                    Console.WriteLine("------------------------");
                    Console.WriteLine("ID: " + b.NumTrabajador);
                    Console.WriteLine("1.- Nombre: " + b.NombreCompleto);
                    Console.WriteLine("2.- Cargo: " + b.Cargo);
                    Console.WriteLine("3.- Sueldo: $" + b.Sueldo);
                    Console.WriteLine("4.- Hora Extra: " + b.PagoXHoraExtra);
                    Console.WriteLine("5.- Estado Civil: " + b.EstadoCivil);
                    Console.WriteLine("6.- # Hijos: " + b.NumHijos);
                    Console.WriteLine("7.- RFC: " + b.IRPF);
                    Console.WriteLine("8.- Elija una opcion a modificar");
                    int Opcion = int.Parse(Console.ReadLine());

                    switch (Opcion)
                    {
                        case 1:
                            Console.WriteLine("Introdusca Nombre");
                            String nombre = Console.ReadLine();
                            b.NombreCompleto = nombre;
                            break;
                        case 2:
                            Console.WriteLine("Introdusca Cargo");
                            String cargo = Console.ReadLine();
                            b.Cargo = cargo;
                            break;
                        case 3:
                            Console.WriteLine("Introdusca Sueldo");
                            String sueldo = Console.ReadLine();
                            b.Sueldo = sueldo;
                            break;
                        case 4:
                            Console.WriteLine("Introdusca Hora Extra");
                            String horaExtra = Console.ReadLine();
                            b.PagoXHoraExtra = horaExtra;
                            break;
                        case 5:
                            Console.WriteLine("Introdusca Estado Civil");
                            String EstadoCivil = Console.ReadLine();
                            b.EstadoCivil = EstadoCivil;
                            break;
                        case 6:
                            Console.WriteLine("Introdusca # Hijos");
                            String NumHijos = Console.ReadLine();
                            b.NumHijos = NumHijos;
                            break;
                        case 7:
                            Console.WriteLine("Introdusca RFC");
                            String RFC = Console.ReadLine();
                            b.IRPF = RFC;
                            break;

                    }
                    Console.ReadKey();

                }
            }

            Console.WriteLine("\nÑPresione una Tecla Para el menu de Opciones.");
            Console.ReadKey();
        }
        public void MostrarInformacionBasica()
        {
            menu.menu();
            Console.WriteLine("\nEsta es la Informacion Basica del empleado\n");

            Console.WriteLine("Me proporciona un numero de empleado");
            String ValorEntrada = Console.ReadLine();

            if (int.Parse(ValorEntrada) == 0 || ValorEntrada == null)
            {
                Console.WriteLine("**** Me proporciona un numero de empleado ****");
                ValorEntrada = Console.ReadLine();
            }
            foreach (Empleado b in listaEmpleados)
            {
                if (b.NumTrabajador == int.Parse(ValorEntrada))
                {
                    Console.WriteLine("ID: " + b.NumTrabajador);
                    Console.WriteLine("Nombre: " + b.NombreCompleto);
                    Console.WriteLine("Cargo: " + b.Cargo);
                    Console.WriteLine("Sueldo: $" + b.Sueldo);
                    Console.WriteLine("HoraExtra: " + b.PagoXHoraExtra);
                    Console.WriteLine("EstadoCivil: " + b.EstadoCivil);
                    Console.WriteLine("# Hijos: " + b.NumHijos);
                    Console.WriteLine("RFC: " + b.IRPF);
                    Console.ReadKey();
                }
            }

            Console.WriteLine("\nPresione una Tecla Para el menu de Opciones.");
            Console.ReadKey();
        }
        public void MostrarInformacionCompleta()
        {
            menu.menu();
            Console.WriteLine("\nEsta es la Informacion Completa del empleado\n");
            String ValorEntrada;
            Console.WriteLine("**** Me proporciona un numero de empleado ****");
            ValorEntrada = Console.ReadLine();

            if (int.Parse(ValorEntrada) == 0 || ValorEntrada == null)
            {
                Console.WriteLine("**** Me proporciona un numero de empleado ****");
                ValorEntrada = Console.ReadLine();
            }

            foreach (Empleado b in listaEmpleados)
            {
                if (b.NumTrabajador == int.Parse(ValorEntrada))
                {
                    Console.WriteLine("ID: " + b.NumTrabajador);
                    Console.WriteLine("Nombre: " + b.NombreCompleto);

                    String sueldo = b.Sueldo;
                    String horasExtras = b.PagoXHoraExtra;
                    String Hijos = b.NumHijos;
                    String estadoCivil = b.EstadoCivil;

                    Calculos(sueldo, horasExtras, Hijos, estadoCivil);
                }
            }

            Console.WriteLine("\nPresione una Tecla Para el menu de Opciones.");
            Console.ReadKey();
        }
        public void Calculos(String sueldo, String horasExtras, String Hijos, String estadoCivil)
        {
            Double impuesto = 0.0;

            Console.WriteLine("\nSu sueldo es: $" + sueldo);
            Console.WriteLine("Su estado Civil es: " + estadoCivil);
            Console.WriteLine("Cuenta con " + Hijos + " hijos.");
            Console.WriteLine("Trabajo " + horasExtras + " Horas extras.");

            // CALCULO DE IMPUESTOS
            // paga el 8% si sueldo base es menor o igual 7500

            if (int.Parse(sueldo) <= 7500)
            {
                impuesto = 0.08;
            }

            // paga el 13% si es mayor 7500 y menor o igual 32000
            if (int.Parse(sueldo) > 7500 && int.Parse(sueldo) <= 32000)
            {
                impuesto = 0.13;
            }

            // paga el 20% si es mayor 32000
            if (int.Parse(sueldo) > 32000)
            {
                impuesto = 0.20;
            }
            Double impuestoDescuetoHijos = 0.0;
            Double impuestoDescuentoCasado = 0.0;

            //checar si tiene hijos y si esta casado
            Double descuentoPorHijo = 0.0;

            if (int.Parse(Hijos) > 0)
            {
                descuentoPorHijo = 0.01;
                Double numeroHijos = Double.Parse(Hijos) * descuentoPorHijo;
                impuestoDescuetoHijos = impuesto - numeroHijos;
            }

            if (estadoCivil == "casado")
            {
                impuestoDescuentoCasado = impuesto - 0.02;
            }

            Double impuestoCorrespondiente = 0.0;
            impuestoCorrespondiente = (impuestoDescuetoHijos + impuestoDescuentoCasado) - impuesto;

            // checar horas extras
            Double pagoHorasExtras = 0.0;
            pagoHorasExtras = int.Parse(horasExtras) * ((Double.Parse(sueldo) / 25) / 8);

            // Calculo de lo que se le pagara
            Double subTotal;
            Double total;
            subTotal = Double.Parse(sueldo) - pagoHorasExtras;
            Double impuestoadescontar = subTotal * impuestoCorrespondiente;
            total = subTotal - impuestoCorrespondiente;

            Console.WriteLine("El impuesto que le corresponde es de: " + impuesto);

            Console.WriteLine("por tener " + Hijos + " hijos, se realiza un descuento de impuesto: " + Double.Parse(Hijos) * descuentoPorHijo);
            Console.WriteLine("por estar Casado obtiena un descuento de impuesto: " + "0.02");
            Console.WriteLine("Las horas extras trabajadas son: " + horasExtras + " trabajadas, lo que corresponde a: $" + pagoHorasExtras + " Pesos.");
            Console.WriteLine("El Impuesto sera de: " + impuestoCorrespondiente + "\n");
            Console.WriteLine("                   Sueldo => " + sueldo);
            Console.WriteLine("$ Horas Extras trabajadas => " + pagoHorasExtras);
            Console.WriteLine("                             -----------");
            Console.WriteLine("                 Subtotal => " + subTotal);
            Console.WriteLine("                 Impuesto => " + impuestoadescontar);
            Console.WriteLine("                             -----------");
            Console.WriteLine("                    Total => " + total);
            Console.WriteLine("\nEl El empleado recibira un pago de: $" + total);
            Console.ReadKey();
        }
        public void ImprimirSueldo(Double sueldo, Double impuesto, Double aPagar)
        {
            Console.WriteLine("Su sueldo es: " + sueldo);
            Console.WriteLine("El Impuesto es: " + impuesto);
            Console.WriteLine("Se le pagara: " + aPagar);
        }
    }
}

