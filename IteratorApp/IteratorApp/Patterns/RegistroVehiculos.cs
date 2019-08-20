
namespace IteratorApp.Patterns
{
    using System;
    using System.Collections;
    using IteratorApp.Models;

    public class RegistroVehiculos : IRegistroVehiculos
    {
        private ArrayList listaVehiculos;

        public RegistroVehiculos()
        {
            this.listaVehiculos = new ArrayList();
        }

        public void InsertarVehiculo(string marca, string modelo, double precio,string img)
        {
            Vehiculo v = new Vehiculo(marca, modelo, DateTime.Now, precio,img);
            listaVehiculos.Add(v);
        }

        public Vehiculo MostrarInformacionVehiculo(int indice)
        {
            return (Vehiculo)listaVehiculos[indice];
        }

        public IIterator ObtenerIterator()
        {
            return new Iterator(listaVehiculos);
        }
        
    }
}
