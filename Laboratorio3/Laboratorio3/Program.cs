using System;

namespace Laboratorio3
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Bienvenido al Supermercado");

            string opt = null;
            while (opt != "6")
            {


                Console.WriteLine("1- Ingresar Productos");
                Console.WriteLine("2- Ingresar Empleado");
                Console.WriteLine("3- Ingresar Cliente");
                Console.WriteLine("4- Ver detalles");
                Console.WriteLine("5- Bonus");
                Console.WriteLine("6- Salir");

                opt = Console.ReadLine();

                switch (opt)
                {
                    case "1":
                        Console.WriteLine("Ingrese Los Productos que desea comprar");
                        int tProducto, pP, sP, iP;
                        string nP, bP;


                        Console.WriteLine("Ingrese cantidad de productos a registrar");
                        tProducto = int.Parse(Console.ReadLine());
                        int i = 0;
                        Producto[] vectProductos = new Producto[tProducto];
                        while (i < tProducto)
                        {
                            Console.WriteLine("Nombre");
                            nP = Console.ReadLine();
                            Console.WriteLine("Precio");
                            pP = int.Parse(Console.ReadLine());
                            Console.WriteLine("Marca");
                            bP = Console.ReadLine();
                            Console.WriteLine("Stock");
                            sP = int.Parse(Console.ReadLine());
                            Console.WriteLine("Id");
                            iP = int.Parse(Console.ReadLine());

                            Producto objProducto = new Producto(nP, pP, bP, sP, iP);
                            vectProductos[i] = objProducto;
                            i++;
                        }
                        break;

                    case "2":
                        Console.WriteLine("Ingrese Empleado");
                        string nE, lnE, bE, cE, chE, hE, rE;
                        int sE;
                        Console.WriteLine( "Nombre" );
                        nE = Console.ReadLine();
                        Console.WriteLine("Apellido");
                        lnE = Console.ReadLine();
                        break;
                }

            }

               







                
        }
            
        

          
            
            
    }
}

