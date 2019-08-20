

namespace IteratorApp.Patterns
{
    using IteratorApp.Models;
    public interface IRegistroVehiculos
    {
        void InsertarVehiculo(string marca, string modelo, double precio,string img);
        Vehiculo MostrarInformacionVehiculo(int indice);
        IIterator ObtenerIterator();
    }
}
