using System;

namespace clase_3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double cuentaPrincipal, cuentaSuma, cuentaHotDog, cuentaFrenchFries, cuentaSoda;
                int precioHotDog = 2;
                int precioFrenchFries = 1;
                double precioSoda = 0.85;

                Console.WriteLine("¿Cuántos hot dogs desea?");
                int cantidadHotDog = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("¿Cuántas french fries desea?");
                int cantidadFrenchFries = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("¿Cuántas sodas desea?");
                int cantidadSoda = Convert.ToInt32(Console.ReadLine());




                cuentaHotDog = precioHotDog * cantidadHotDog;
                cuentaFrenchFries = precioFrenchFries * cantidadFrenchFries;
                cuentaSoda = precioSoda * cantidadSoda;

                cuentaSuma = (cuentaHotDog + cuentaFrenchFries + cuentaSoda);
                cuentaPrincipal = cuentaSuma + (cuentaSuma * 0.1);

                Console.WriteLine($"Su cuenta es de: {cuentaPrincipal}");
                Console.ReadKey();
            }

            catch (Exception e)
            {
                Console.WriteLine("No has introducido un valor numérico válido.");
                Console.WriteLine(e.Message);
            }
        }
    }
}
           
           
            
