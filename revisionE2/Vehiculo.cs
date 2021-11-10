using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revisionE2
{
    class Vehiculo
    {
        //atributos o características
        /*private*/string marca;
        private string modelo;
        private double precio;
        private int stock;
        private int id;

        public Vehiculo(string marca, string modelo, double precio, int stock, int id)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.precio = precio;
            this.stock = stock;
            this.id = id;
        }

        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public double Precio { get => precio; set => precio = value; }
        public int Stock { get => stock; set => stock = value; }
        public int Id { get => id; set => id = value; }

        public override string ToString()
        {
            return Marca + " " + Modelo;
        }
    }
}
