using Jonathan.AVeiculos.ViewsModels;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Jonathan.AVeiculos
{
    public partial class MainPage : ContentPage
    {
        public List<VeiculoViewModel> Veiculos { get; set; }
        public MainPage()
        {
            InitializeComponent();
            Veiculos = new List<VeiculoViewModel>()
            {
                new VeiculoViewModel(
                    new Veiculo() {
                    Marca = "Fiat",
                    Modelo = "Palio",
                    Valor = 30000
                }),
                new VeiculoViewModel(
                    new Veiculo() {
                    Marca = "Volkswagen",
                    Modelo = "Gol",
                    Valor = 35000
                }),                
                new VeiculoViewModel(
                    new Veiculo() {
                    Marca = "Renault",
                    Modelo = "Clio",
                    Valor = 28000
                }),
            };
            this.BindingContext = this;
            

        }

        private void Lista_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Navigation.PushAsync(new Configuracao((VeiculoViewModel)e.Item));
            Lista.SelectedItem = null;
        }
    }
}
