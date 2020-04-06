using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio3
{
    class Compra
    {
        private Persona cliente;
        private Trabajador vendedor;
        private List<Producto> productos;
        private DateTime fecha;

        public Persona Cliente { get => cliente; set => cliente = value; }
        public Trabajador Vendedor { get => vendedor; set => vendedor = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public List<Producto> Productos { get => productos; set => productos = value; }

        public Compra(Persona cliente,Trabajador vendedor,List<Producto> productos, DateTime fecha)
        {
            this.cliente = cliente;
            this.fecha = fecha;
            this.vendedor = vendedor;
            this.productos = productos;
             
        }
        public void addProduct(Producto p)
        {
            Productos.Add(p);
        }

    }
}
