using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jonathan.AVeiculos.Model.Domain
{
    public class Cliente
    {
        public string nome { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }

        public Cliente()
        {
            this.nome = nome;
            this.telefone = telefone;
            this.email = email;
        }
    }
}
