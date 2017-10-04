using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jonathan.AVeiculos.Model.Domain
{
    public class Agendamento
    {
        public Veiculo veiculo { get; set; }
        public Cliente cliente { get; set; }

        public DateTime data { get; set; }
        public TimeSpan hora { get; set; }

        public Agendamento()
        {
            this.cliente = new Cliente();
            this.veiculo = veiculo;
        }
    }
}
