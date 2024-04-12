using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using HTTPupt;
using System.Net.Http;

namespace consumir_api
{
    public partial class MainPage : ContentPage
    {
        PeticionHTTP _cliente = new PeticionHTTP("http://localhost:5276/api/");
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            //_cliente.PedirComunicacion("/api/Concatenar?concatenacion=" + texto.Text, MetodoHTTP.GET, TipoContenido.JSON);
            //string respuesta = _cliente.ObtenerJson();
            //if (respuesta != null)
            //{
            //    LabelUno.Text = respuesta;
            //}
            //else { LabelUno.Text = "al consumir la api algo sucedio mal"; }

        }
    }
}
