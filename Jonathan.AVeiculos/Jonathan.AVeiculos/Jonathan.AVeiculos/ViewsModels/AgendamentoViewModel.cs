using Jonathan.AVeiculos.Model.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jonathan.AVeiculos.ViewsModels
{
    public class AgendamentoViewModel
    {
        public Agendamento Agendamento { get; set; }
        public VeiculoViewModel Veiculo { get; set; }
        public ClienteViewModel Cliente { get; set; }
        public DateTime Data { get; set; }
        public TimeSpan Hora { get; set; }

        public AgendamentoViewModel(VeiculoViewModel veiculo)
        {

            Data = DateTime.Now;
            Hora = new TimeSpan(DateTime.Now.Hour,DateTime.Now.Minute, DateTime.Now.Second);
            
            this.Veiculo = veiculo;
            Cliente = new ClienteViewModel();

        }



    }



};


