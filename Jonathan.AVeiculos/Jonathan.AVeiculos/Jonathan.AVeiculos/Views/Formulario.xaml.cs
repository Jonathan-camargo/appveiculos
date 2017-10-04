using Jonathan.AVeiculos.Model.Domain;
using Jonathan.AVeiculos.ViewsModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Jonathan.AVeiculos
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Formulario : ContentPage
    {
        
        public AgendamentoViewModel Agendamento { get; set; }
        public Formulario(VeiculoViewModel veiculo)
        {
            InitializeComponent();
            Agendamento = new AgendamentoViewModel(veiculo);
            this.BindingContext = Agendamento;
           
        }

      

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Agendamento.Agendamento = new Agendamento()
            {
                cliente = this.Agendamento.Cliente.Cliente,
                data = this.Agendamento.Data,
                hora = this.Agendamento.Hora,
                veiculo = this.Agendamento.Veiculo.Veiculo

            };

            

        }
    }
}