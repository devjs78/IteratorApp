using Android.Widget;
using IteratorApp.Models;
using IteratorApp.Patterns;
using System;
using System.Diagnostics;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace IteratorApp
{
    public partial class MainPage : ContentPage
    {
        IIterator iterator;
        Vehiculo vehiculoActual;
        public MainPage()
        {
            InitializeComponent();
            IRegistroVehiculos reg;

            reg = new RegistroVehiculos();

            reg.InsertarVehiculo("Mazda", "3", 12000, "Car1.png");
            reg.InsertarVehiculo("Ferrary", "Mux", 55000, "Car2.png");
            reg.InsertarVehiculo("BMW", "SkyNight", 24000, "Car3.png");

            iterator = reg.ObtenerIterator();
            vehiculoActual = (Vehiculo)iterator.Actual();

            ActualizarDatosVehiculo();


            //while (iterator.QuedanElementos())
            //{
            //    Vehiculo v = (Vehiculo)iterator.Siguiente();
            //    Debug.Print(v.Marca + " "
            //      + v.Modelo + " fabricado el " +
            //      v.FechaFabricacion.ToShortDateString() +
            //      " (" + v.Precio + " euros) ");
            //}


        }

        public void ActualizarDatosVehiculo()
        {
            vehiculoActual = (Vehiculo)iterator.Actual();
            txtDescripcion.Text = vehiculoActual.CaracteristicasVehiculo();
            imgPhoto.Source = vehiculoActual.Img;
        }


        private void BtnPrimero_Clicked(object sender, EventArgs e)
        {
            iterator.Primero();
            ActualizarDatosVehiculo();
        }

        private async void BtnHasNext_Clicked(object sender, EventArgs e)
        {
            if (iterator.QuedanElementos())
            {
                Toast.MakeText(Android.App.Application.Context, "AÚN QUEDAN AUTOS", ToastLength.Short).Show();
            }
            else
            {
                RegresarAlPrimeroPregunta();
            }
        }

        private void BtnNext_Clicked(object sender, EventArgs e)
        {
            if (iterator.QuedanElementos())
            {
                iterator.Siguiente();
                ActualizarDatosVehiculo();
                return;
            }
            else
            {
                RegresarAlPrimeroPregunta();
            }

        }

        private async void RegresarAlPrimeroPregunta() {
            var respuesta = await DisplayAlert("No quedan más elementos", "¿Regresar al primero?", "Sí", "No");
            if (respuesta)
            {
                iterator.Primero();
                ActualizarDatosVehiculo();
            }
        }
    }
}
