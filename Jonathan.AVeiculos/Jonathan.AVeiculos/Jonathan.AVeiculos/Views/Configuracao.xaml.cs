using Jonathan.AVeiculos.ViewsModels;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Jonathan.AVeiculos
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Configuracao : ContentPage
    {
        public VeiculoViewModel Veiculo { get; set; }
        public Configuracao(VeiculoViewModel veiculo)
        {
            InitializeComponent();
            Veiculo = veiculo;
            BindingContext = Veiculo;
        }

      
        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Formulario((this.Veiculo)));
        }
    }
}