using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Nomina
{
    class Dato
    {
        private String ruta;
        public Dato(String ruta)
        {
            this.ruta = ruta;
        }
        public void serializar(List<Empleado> lista)
        {
            Stream flujo = File.Open(ruta,FileMode.Create);
            BinaryFormatter bin = new BinaryFormatter();
            bin.Serialize(flujo, lista);

        }
        public List<Empleado> deserializar()
        {
            Stream flujo = File.Open(ruta, FileMode.Open);
            BinaryFormatter bin = new BinaryFormatter();
            return (List<Empleado>) bin.Deserialize(flujo);
        }
    }
}
