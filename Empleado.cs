using System;
using System.Collections.Generic;
using System.Text;

namespace Nomina
{
    public class Empleado
    {
        
        private String _NumTrabajador;
        private String _NombreCompleto;
        private String _Cargo;
        private String _Sueldo;
        private String _PagoXHoraExtra;
        private String _EstadoCivil;
        private String _NumHijos;
        private String _IRPF;

        
        public string NumTrabajador { get => _NumTrabajador; set => _NumTrabajador = value; }
        public string NombreCompleto { get => _NombreCompleto; set => _NombreCompleto = value; }
        public string Cargo { get => _Cargo; set => _Cargo = value; }
        public string Sueldo { get => _Sueldo; set => _Sueldo = value; }
        public string PagoXHoraExtra { get => _PagoXHoraExtra; set => _PagoXHoraExtra = value; }
        public string EstadoCivil { get => _EstadoCivil; set => _EstadoCivil = value; }
        public string NumHijos { get => _NumHijos; set => _NumHijos = value; }
        public string IRPF { get => _IRPF; set => _IRPF = value; }
    }
}
