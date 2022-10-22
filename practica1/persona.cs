using System;
using System.Collections.Generic;
using System.Text;

namespace practica1
{
    class persona
    {

        public int ID { get; set; }
        public int Cedula { get; set; }
        public string Nombre { get; set; }
        public string correo { get; set; }
        public double Telefono { get; set; }
        public persona(int ID, int Cedula, string Nombre, string correo, double Telefono)
        {

            this.ID = ID;
            this.Cedula = Cedula;
            this.Nombre = Nombre;
            this.correo = correo;
            this.Telefono = Telefono;
        }
        public void  comer ()
        {

        }
        public void caminar()
        {

        }
        public void respirar()
        {

        }
        public void dormir()
        {

        }
    }
    }

