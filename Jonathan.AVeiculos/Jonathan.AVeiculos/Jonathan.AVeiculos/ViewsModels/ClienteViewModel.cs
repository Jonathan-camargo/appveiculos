using Jonathan.AVeiculos.Model.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jonathan.AVeiculos.ViewsModels
{
    public class ClienteViewModel
    {
        public VeiculoViewModel Veiculo { get; set; }
        public AgendamentoViewModel Agendamento { get; set; }
        public Cliente Cliente { get; set; }
        public string nome { get
            {
                return Cliente.nome;
            }

            set
            {
                Cliente.nome = value;
            }

        }
        public string telefone { get
            {
                return Cliente.telefone;
            } set
            {
                Cliente.telefone = value;
            }
        }
        public string email { get
            {
                return Cliente.email;
            } set
            {
                Cliente.email = value;
            }
        }


        public ClienteViewModel()
        {
            Cliente = new Cliente()
            {
                nome = "Jonathan",
                telefone = "123",
                email = "aaa"
            };
        }

        


    }
}
    

