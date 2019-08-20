using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorApp.Models
{
    public class Vehiculo
    {
        #region Propiedades de Clase
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public DateTime FechaFabricacion { get; set; }
        public double Precio { get; set; }
        public string Img { get; set; }
        #endregion

        #region Constructor
        public Vehiculo(string marca, string modelo, DateTime fechaFabricacion, double precio,string img)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.FechaFabricacion = fechaFabricacion;
            this.Precio = precio;
            this.Img = img;
        }
        #endregion

        #region Metodo
        public string CaracteristicasVehiculo()
        {
            return Marca + " " +
              Modelo + "Fabricado en " +
              FechaFabricacion.ToShortDateString() + " con un precio de ($): " +
              Precio + "Dolares. \n";
        }
        #endregion

    }
}
