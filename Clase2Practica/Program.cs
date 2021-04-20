using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Clase2Practica
{
    class Program
    {
        static void Main(string[] args)
        {
            EjercicioLeerJson.Ejecutar("ordenes");

            EjercicioEscribirJson.Ejecutar(GenerarListaOrdenes(),"nuevasOrdenes");

        }

        private static List<Orden> GenerarListaOrdenes()
        {
            Orden orden1 = new Orden();
            Orden orden2 = new Orden();

            orden1.nroOrden = 5;
            orden2.nroOrden = 89;
            orden1.descripcion = "vasos";
            orden2.descripcion = "cubiertos";
            orden1.cantidad = 2;
            orden2.cantidad = 5;
            orden1.precio = 500;
            orden2.precio = 700;
            orden1.entregada = false;
            orden2.entregada = true;

            List<Orden> ordenes = new List<Orden>();
            ordenes.Add(orden1);
            ordenes.Add(orden2);

            return ordenes;

        }
    }
}
