using System;
using System.Collections.Generic;
using System.Text;

namespace Nomina
{
    public class Empleado
    {
        public String NumTrabajador { get; set; }
        public String NombreCompleto { get; set; }
        public String Cargo { get; set; }
        public String Sueldo { get; set; }
        public String PagoXHoraExtra { get; set; }
        public String EstadoCivil { get; set; }
        public String NumHijos { get; set; }
        public String IRPF { get; set; }

        public Empleado(String _numTrabajador, String _nombreCompleto, String _cargo, String _sueldo, String _pagoXHoraExtra, String _estadoCivil, String _numHijos, String _iRPF)
        {
            NumTrabajador = _numTrabajador;
            NombreCompleto = _nombreCompleto;
            Cargo = _cargo;
            Sueldo = _sueldo;
            PagoXHoraExtra = _pagoXHoraExtra;
            EstadoCivil = _estadoCivil;
            NumHijos = _numHijos;
            IRPF = _iRPF;


        }

    }
}
