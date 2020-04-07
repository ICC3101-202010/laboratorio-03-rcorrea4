using System;

namespace Laboratorio3
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Bienvenido al Supermercado");

            string opt = null;
            Producto[] vectorProductos=null;
            Trabajador trabajador1=null;
            Persona persona1=null;
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
                        vectorProductos = vectProductos;
                        break;

                    case "2":
                        Console.WriteLine("Ingrese Empleado");
                        string nE, lnE, bE, cE, chE, hE, rE;
                        int sE;
                        Console.WriteLine( "Nombre" );
                        nE = Console.ReadLine();
                        Console.WriteLine("Apellido");
                        lnE = Console.ReadLine();
                        Console.WriteLine("Nacimineto");
                        bE = Console.ReadLine();
                        Console.WriteLine("Pais");
                        cE = Console.ReadLine();
                        Console.WriteLine("Cargo");
                        chE = Console.ReadLine();
                        Console.WriteLine("Rut");
                        rE = Console.ReadLine();
                        Console.WriteLine("Horario");
                        hE = Console.ReadLine();
                        Console.WriteLine("Salario");
                        sE = int.Parse(Console.ReadLine());
                        Trabajador trabajador = new Trabajador(nE, lnE, rE, bE, cE, chE, sE, hE);
                        trabajador1 = trabajador;
                        break;

                    case "3":
                        Console.WriteLine("Ingrese Cliente");
                        string nC, lnC, bC, cC, rC;
                        
                        Console.WriteLine("Nombre");
                        nC = Console.ReadLine();
                        Console.WriteLine("Apellido");
                        lnC = Console.ReadLine();
                        Console.WriteLine("Nacimineto");
                        bC = Console.ReadLine();
                        Console.WriteLine("Pais");
                        cC = Console.ReadLine();
                        Console.WriteLine("Rut");
                        rC = Console.ReadLine();
                        Persona cliente = new Persona(nC,lnC,rC,bC,cC);
                        persona1 = cliente;
                        break;

                    case "4":
                        Console.WriteLine("Productos:");
                        
                        if (vectorProductos == null)
                        {
                            Console.WriteLine("No Hay Productos");
                        }
                        else
                        {
                            int f = 0;
                            while (f < vectorProductos.Length)
                            {
                                Console.WriteLine("Producto"+(f+1));
                                Console.WriteLine(vectorProductos[f].NameP);
                                Console.WriteLine(vectorProductos[f].Brand);
                                Console.WriteLine(vectorProductos[f].Price);
                                Console.WriteLine(vectorProductos[f].Stock);
                                Console.WriteLine(vectorProductos[f].Id);
                                f++;
                            }

                        }
                        if (trabajador1 == null)
                        {
                            Console.WriteLine("No Hay Empleado");
                        }
                        else
                        {
                            Console.WriteLine("Empleado:");
                            Console.WriteLine(trabajador1.Name);
                            Console.WriteLine(trabajador1.LastName);
                            Console.WriteLine(trabajador1.Rut);
                            Console.WriteLine(trabajador1.Birth);
                            Console.WriteLine(trabajador1.Country);
                            Console.WriteLine(trabajador1.charge);
                            Console.WriteLine(trabajador1.salary);
                            Console.WriteLine(trabajador1.horario);
                        }
                        if (persona1 == null)
                        {
                            Console.WriteLine("No hay cliente");
                        }
                        else
                        {
                            Console.WriteLine("Cliente");
                            Console.WriteLine(persona1.Name);
                            Console.WriteLine(persona1.LastName);
                            Console.WriteLine(persona1.Rut);
                            Console.WriteLine(persona1.Birth);
                            Console.WriteLine(persona1.Country);

                        }
                       

                        break;
                }
               

            }

               







                
        }
            
        

          
            
            
    }
}

