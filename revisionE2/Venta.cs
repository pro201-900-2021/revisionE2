using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revisionE2
{
    class Venta
    {
        private string marca;
        private string modelo;
        private double precio;
        private int cantidad;

        public Venta(string marca, string modelo, double precio, int cantidad)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.precio = precio;
            this.cantidad = cantidad;
        }

        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public double Precio { get => precio; set => precio = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }

        public override string ToString()
        {
            return $"Venta realizada: {marca} {modelo}. {cantidad} unidades han sido vendidas. Total: ${precio*cantidad}.";
        }
    }
}
