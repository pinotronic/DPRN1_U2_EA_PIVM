using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Nomina
{
    public class RecursoHumano
    {
        private Empleado[] _empleados;
        private int _limite;
        private int _numEmpleados;
        public RecursoHumano(int limite)
        {
            this._empleados = new Empleado[limite];
            _limite = limite;
            _numEmpleados = 0;

        }

        public void anidarEmpleado(Empleado c)
        {
            if(c != null && _numEmpleados < _empleados.Length)
            {
                _empleados[_numEmpleados] = c;
                _numEmpleados++;
            }
        }
        public void mostrarEmpleado()
        {
            for(int i=0; i< _numEmpleados; i++)
            {
                Console.WriteLine(_empleados[i].ToString());
            }
        }

        public void vaciarEmpleado()
        {
            this._empleados = new Empleado[_limite];
            _numEmpleados = 0;
        }
        public void eliminarEmpleado(Empleado c)
        {
            if (c!= null && _numEmpleados != 0)
            {
                int posicion = -1;
                for (int i = 0; i < _numEmpleados;  i++) 
                {
                    if (c.id == _empleados[i].id)
                    {
                        posicion = i;
                    }
                }

                if(posicion == -1)
                {
                    Console.WriteLine("No existe el Empleado");
                }
                else
                {
                    _empleados[posicion] = null;

                    for(int i = posicion; i < _numEmpleados; i++)
                    {
                        _empleados[i] = _empleados[i + 1];
                    }
                    _numEmpleados--;
                }
            }
        }
    }
}
