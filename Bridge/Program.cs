﻿using System;
using System.Collections.Generic;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> productos = new Dictionary<string, double>();
            //Productos a usar
            productos.Add("M101", 56.32);
            productos.Add("M234", 23.88);
            productos.Add("C654", 974.96);
            productos.Add("M401", 43.28);
            productos.Add("C345", 785.12);
            productos.Add("D567", 432.56);
            productos.Add("M103", 874.54);
            productos.Add("D901", 23.18);
            productos.Add("C732", 43.12);
            productos.Add("M056", 21.42);

            //Creamos el Bridge
            //CAbstracion bridge = new CAbstracion(new CImplementacion1(), productos);
            //CAbstracion bridge = new CAbstracion(new CImplementacion2(), productos);
            CAbstracion bridge = new CAbstracion(new CImplementacion3(), productos);
            bridge.ListarProductos();
            bridge.MostrarTotales();
        }
    }
}
