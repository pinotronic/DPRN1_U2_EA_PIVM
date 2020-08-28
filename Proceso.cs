using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.IO;


namespace Nomina
{
    public class Pagos
    {
        public String NumTrabajador { get; set; }
        public String NombreCompleto { get; set; }
        public String Cargo { get; set; }
        public String Sueldo { get; set; }
        public String PagoXHoraExtra { get; set; }
        public String EstadoCivil { get; set; }
        public String NumHijos { get; set; }
        public String IRPF { get; set; }

    }
    class Proceso
    {
        Menu menu = new Menu();

        private List<Empleado> listaEmpleados;
        Empleado empleado = new Empleado();

        private Dato dato;

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
                    Console.WriteLine("\n1. ");

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
                        // => Mostrar listado de Empleado

                        Console.Clear();
                        menu.menu();
                        ListarEmpleados();
                        //SolicitarOpciones();*//
                        break;

                    case 3:
                        // = Modificar Datos del Empleado

                        /*MostrarInformacionBasica();
                        Console.Clear();
                        menu.menu();
                        SolicitarOpciones();*/
                        Console.WriteLine("Introdusca el numero de empleado: ");
                        int idBuscar = Convert.ToInt32(Console.ReadLine());

                        foreach (Empleado empleado in listaEmpleados)
                        {
                            if (int.Parse(empleado.NumTrabajador) == idBuscar)
                            {
                                Console.WriteLine("Numero del Trabajador: " + empleado.NumTrabajador);
                                Console.WriteLine("Nombre Completo: " + empleado.NombreCompleto);
                                Console.WriteLine("Cargo: " + empleado.Cargo);
                                Console.WriteLine("Sueldo: " + empleado.Sueldo);
                                Console.WriteLine("PagoXHoraExtra: " + empleado.PagoXHoraExtra);
                                Console.WriteLine("EstadoCivil: " + empleado.EstadoCivil);
                                Console.WriteLine("NumHijos: " + empleado.NumHijos);
                                Console.WriteLine("IRPF: " + empleado.IRPF);
                            }
                        }
                        break;
                    case 4:
                        // => Mostrar Informacion Basica del Empleado
                        MostrarInformacionCompleta();
                        Console.Clear();
                        menu.menu();
                        SolicitarOpciones();
                        break;
                    case 5:
                        // => Mostrar Informacion Completa del Empleado

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
            
            Empleado empleado = new Empleado();
            menu.menu();
            //int id;
            Console.WriteLine("Me proporciona un numero de empleado");
            empleado.NumTrabajador = Console.ReadLine();
            Console.WriteLine("Me proporciona el nombre Completo del empleado");
            empleado.NombreCompleto = Console.ReadLine();
            Console.WriteLine("Me proporciona el Cargo del empleado");
            empleado.Cargo = Console.ReadLine();
            Console.WriteLine("Me proporciona el Sueldo del empleado");
            empleado.Sueldo = Console.ReadLine();
            Console.WriteLine("Me proporciona las Horas Extras del empleado");
            empleado.PagoXHoraExtra = Console.ReadLine();
            Console.WriteLine("nMe proporciona el EstadoCivil del empleado");
            empleado.EstadoCivil = Console.ReadLine();
            Console.WriteLine("Me proporciona el numero de Hijos del empleado");
            empleado.NumHijos = Console.ReadLine();
            Console.WriteLine("Me proporciona el  IRPF del empleado");
            empleado.IRPF = Console.ReadLine();
            Console.WriteLine("\nLos Datos Fueron Guardados, ");
            Console.WriteLine("Para su modificacion en el apartado correspondiente");
            Console.WriteLine("\nPresione una Tecla Para el menu de Opciones.");

            listaEmpleados.Add(empleado);
            dato.serializar(listaEmpleados);
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
            String ValorEntrada;
            int encontrado = 0;
            Console.WriteLine("Me proporciona un numero de empleado");
            ValorEntrada = Console.ReadLine();

            PropertyInfo[] lst = typeof(Empleado).GetProperties();
            foreach (PropertyInfo oProperty in lst)
            {
                string NombreAtributo = oProperty.Name;
                string Valor = oProperty.GetValue(empleado).ToString();

                if (NombreAtributo == "NumTrabajador" & ValorEntrada == "NumeroEmpleado")
                {
                    encontrado = 1;
                }

                if (int.Parse(ValorEntrada) == 1)
                {
                    switch (NombreAtributo)
                    {
                        case "NombreCompleto":
                            String NombreCompleto = Valor;
                            break;
                        case "Cargo":
                            String Cargo = Valor;
                            break;
                        case "Sueldo":
                            String Sueldo = Valor;
                            break;
                        case "PagoXHoraExtra":
                            String PagoXHoraExtra = Valor;
                            break;
                        case "EstadoCivil":
                            String EstadoCivil = Valor;
                            break;
                        case "NumHijos":
                            String NumHijos = Valor;
                            break;
                        case "IRPF":
                            String IRPF = Valor;
                            encontrado = 0;
                            break;
                    }
                }
            }
            //Console.WriteLine("\nEl atributo " + NombreAtributo + " tiene el valor: " + Valor); ;
            Console.WriteLine("\nÑPresione una Tecla Para el menu de Opciones.");
            Console.ReadKey();
        }
        public void MostrarInformacionBasica()
        {
            menu.menu();
            Console.WriteLine("\nEsta es la Informacion Basica del empleado\n");
            String ValorEntrada;
            int Encontrado = 0;
            Console.WriteLine("Me proporciona un numero de empleado");
            ValorEntrada = Console.ReadLine();

            PropertyInfo[] lst = typeof(Empleado).GetProperties();
            foreach (PropertyInfo oProperty in lst)
            {
                string NombreAtributo = oProperty.Name;
                string Valor = oProperty.GetValue(empleado).ToString();

                if (NombreAtributo == "NumTrabajador" & ValorEntrada == "NumeroEmpleado")
                {
                    Encontrado = 1;
                }

                if (int.Parse(ValorEntrada) == 1)
                {
                    Console.WriteLine("\nEl atributo " + NombreAtributo + " tiene el valor: " + Valor);
                    Encontrado = 0;
                }
            }

            Console.ReadKey();
            Console.WriteLine("\nÑPresione una Tecla Para el menu de Opciones.");
            Console.ReadKey();
        }
        public void MostrarInformacionCompleta()
        {
            menu.menu();
            Console.WriteLine("\nEsta es la Informacion Completa del empleado\n");
            String ValorEntrada;
            int Encontrado = 0;
            Console.WriteLine("Me proporciona un numero de empleado");
            ValorEntrada = Console.ReadLine();

            PropertyInfo[] lst = typeof(Empleado).GetProperties();
            foreach (PropertyInfo oProperty in lst)
            {
                string NombreAtributo = oProperty.Name;
                string Valor = oProperty.GetValue(empleado).ToString();

                if (NombreAtributo == "NumTrabajador" & ValorEntrada == "NumeroEmpleado")
                {
                    Encontrado = 1;
                }

                if (int.Parse(ValorEntrada) == 1)
                {
                    switch (NombreAtributo)
                    {
                        case "NombreCompleto":
                            String NombreCompleto = Valor;
                            break;
                        case "Cargo":
                            String Cargo = Valor;
                            break;
                        case "Sueldo":
                            String Sueldo = Valor;
                            break;
                        case "PagoXHoraExtra":
                            String PagoXHoraExtra = Valor;
                            break;
                        case "EstadoCivil":
                            String EstadoCivil = Valor;
                            break;
                        case "NumHijos":
                            String NumHijos = Valor;
                            break;
                        case "IRPF":
                            String IRPF = Valor;
                            Encontrado = 0;
                            break;
                    }
                }
            }
            //Console.WriteLine("\nEl atributo " + NombreAtributo + " tiene el valor: " + Valor); ;
            Console.WriteLine("\nPresione una Tecla Para el menu de Opciones.");
            Console.ReadKey();
            Console.WriteLine("\nPresione una Tecla Para el menu de Opciones.");
            Console.ReadKey();
        }
        public void Calculos()
        {

            /*
            paga el 8% si sueldo base es menor o igual 7500
            paga el 13% si es mayor 7500 y menor o igual 32000
            paga el 20% si es mayor 32000
            o Cálculo y devolución del complemento correspondiente a las 
            horas extra realizadas.
            o Cálculo y devolución del sueldo bruto.
            o Cálculo y devolución de las retenciones(IRPF) a partir del tipo, 
            teniendo en cuenta que el porcentaje de retención que hay que aplicar 
            es el tipo menos 2 puntos si el empleado está casado y menos 1 punto 
            por cada hijo que tenga; el porcentaje se aplica sobre todo el sueldo 
            bruto.
             */
            Double aPagar;
            Double impuesto;
            Double sueldo = 0;

            if (sueldo <= 7500)
            {
                aPagar = (sueldo * 8) / 10;
                impuesto = sueldo - aPagar;
                ImprimirSueldo(sueldo, impuesto, aPagar);
            }
            if (sueldo > 7500 & sueldo <= 32000)
            {
                aPagar = (sueldo * 13) / 10;
                impuesto = sueldo - aPagar;
                ImprimirSueldo(sueldo, impuesto, aPagar);
            }
            if (sueldo > 32000)
            {
                aPagar = (sueldo * 20) / 10;
                impuesto = sueldo - aPagar;
                ImprimirSueldo(sueldo, impuesto, aPagar);
            }
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

