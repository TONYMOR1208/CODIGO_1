using System;
using System.Collections.Generic;
using System.Text;

namespace practica1
{
    class Vendedor:persona
    {
        public int edad { get; set; }
        public string cantidad_ventas { get; set; }
        public string direccion { get; set; }
        public string codigo_postal { get; set; }

        public Vendedor(int ID, int Cedula, string Nombre, string correo, int telefono, int edad, string cantidad_ventas, string direccion, string codigo_postal)
           :base(ID, Cedula, Nombre, correo, telefono)
        {
            this.edad = edad;
            this.cantidad_ventas = cantidad_ventas;
            this.direccion = direccion;
            this.codigo_postal = codigo_postal;

        }
            public void imprimir()
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("FICHA DEL VENDEDOR");
            Console.WriteLine("----------------------");
            Console.WriteLine("Identificacion: " + ID);
            Console.WriteLine("Numero de Cedula " + Cedula);
            Console.WriteLine("Nombre : " + Nombre);
            Console.WriteLine("Apellidos :");
            Console.WriteLine("Edad  :" + edad);
            Console.WriteLine("Correo Electronico :" + correo);
            Console.WriteLine("Numero de telefono :" + Telefono);
            Console.WriteLine("Direccion del domicilio :" + direccion);
            Console.WriteLine("Codigo postal :" + codigo_postal);
            Console.WriteLine("Ventas realizadas " + cantidad_ventas);
        }
            public void mostrar_vehiculo()
            {
            }
            public void explicar_capacidad()
            {
            }
            public void vender_vehiculo()
            {

            }
            public void cobrar()
            {

            }
        }

    }