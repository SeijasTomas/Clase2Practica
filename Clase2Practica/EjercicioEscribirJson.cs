using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Clase2Practica
{
    class EjercicioEscribirJson
    {
        public static void Ejecutar(List<Orden> ordenes, string nombreArchivo)
        {
            string jsonText = "{\"ordenes\":";
            jsonText += JsonSerializer.Serialize(ordenes);
            jsonText += "}";

            File.WriteAllText(@$"..\.\..\..\..\{nombreArchivo}.json" , jsonText);
        }
    }
}
