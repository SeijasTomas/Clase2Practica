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
        public static void Ejecutar(JsonRoot jsonObj, string nombreArchivo)
        {
            string jsonText = JsonSerializer.Serialize(jsonObj);

            File.WriteAllText(@$"..\.\..\..\..\{nombreArchivo}.json" , jsonText);
        }
    }
}
