using System;
using System.Collections.Generic;
using System.Text;

namespace Nomina
{
    public class Empleado
    {
        private int _id;
        private String _NumTrabajador;
        private String _NombreCompleto;
        private String _Cargo;
        private String _Sueldo;
        private String _PagoXHoraExtra;
        private String _EstadoCivil;
        private String _NumHijos;
        private String _IRPF;
        public Empleado(int id, String NumTrabajador, String NombreCompleto, String Cargo, String Sueldo, String PagoXHoraExtra, String EstadoCivil, String NumHijos, String IRPF)
        {
            this._id = id;
            this._NumTrabajador = NumTrabajador;
            this._NombreCompleto = NombreCompleto;
            this._Cargo = Cargo;
            this._Sueldo = Sueldo;
            this._PagoXHoraExtra = PagoXHoraExtra;
            this._EstadoCivil = EstadoCivil;
            this._NumHijos = NumHijos;
            this._IRPF = IRPF;

        }
        public int id { get => _id; set => _id = value; }
        public String NumTrabajador { get => _NumTrabajador; set => _NumTrabajador = value; }
        public String NombreCompleto { get => _NombreCompleto; set => _NombreCompleto = value; }
        public String Cargo { get => _Cargo; set => _Cargo = value; }
        public String Sueldo { get => _Sueldo; set => _Sueldo = value; }
        public String PagoXHoraExtra { get => _PagoXHoraExtra; set => _PagoXHoraExtra = value; ; }
        public String EstadoCivil { get => _EstadoCivil; set => _EstadoCivil = value; }
        public String NumHijos { get => _NumHijos; set => _NumHijos = value; }
        public String IRPF { get => _IRPF; set => _IRPF = value; }

    }
}
