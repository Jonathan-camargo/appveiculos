
namespace Jonathan.AVeiculos
{
    public class Veiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public decimal Valor { get; set; }

        public bool TemAirbag { get; set; }
        public bool TemArCondicionado { get; set; }
        public bool TemABS { get; set; }

        public decimal ValorAirbag { get; set; }
        public decimal ValorArCondicionado { get; set; }
        public decimal ValorABS { get; set; }
        public Veiculo()
        {
            TemABS = false;
            TemAirbag = false;
            TemArCondicionado = false;

            ValorABS = 3000;
            ValorAirbag = 5000;
            ValorArCondicionado = 3500;
        }
            public decimal ValorOpcionais{ get {
                return (TemABS ? ValorABS : 0) +
                     (TemArCondicionado ? ValorArCondicionado : 0) +
                     (TemAirbag ? ValorAirbag : 0);
        }
        }

        public decimal ValorTotal
        {
            get
            {
                return Valor + ValorOpcionais;
            }
        }




    }
}
