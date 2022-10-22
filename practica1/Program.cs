using System;

namespace practica1
{
   class Program
    {
        static void Main(string[] args)
        {
            

            Comprador compra = new Comprador(12345567, 1316718111,"Anthony", "ajmc1316718111@gmail.com", 0981851234, 21,  "leonidas proaño", "1233343434", "300");
            compra.imprimir();   
            compra.elegir_vehiculo();
            compra.probar_vehiculo();
            compra.comprar_vehiculo();
            compra.usar();
            Vendedor vendedor = new Vendedor(123456, 1316718118, "Juan", "joel1316718118@gmail.com", 0969242642, 40, "Manta", "136792468", "600");
            vendedor.imprimir();





        }
    }
}
