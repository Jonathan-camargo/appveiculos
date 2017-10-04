
using System.ComponentModel;
using System.Globalization;

namespace Jonathan.AVeiculos.ViewsModels
{
    public class VeiculoViewModel : INotifyPropertyChanged
    {
        public Veiculo Veiculo { get; set; }

        public VeiculoViewModel(Veiculo veiculo)
        {
            Veiculo = veiculo;
        }
        public string ValorFormatado
        {
            get
            {
                return Veiculo.Valor.ToString("C", CultureInfo.CurrentCulture);
            }
        }
        public string ValorAirbag
        {
            get
            {
                return Veiculo.ValorAirbag.ToString("C", CultureInfo.CurrentCulture);
            }
        }
        public string ValorArCondicionado
        {
            get
            {
                return Veiculo.ValorArCondicionado.ToString("C", CultureInfo.CurrentCulture);
            }
        }
        public string ValorABS
        {
            get
            {
                return Veiculo.ValorABS.ToString("C", CultureInfo.CurrentCulture);
            }
        }
        public string Descricao
        {
            get
            {
                return string.Format($"{Veiculo.Marca} {Veiculo.Modelo}");
            }
        }
        public string ValorOpcionaisFormatado
        {
            get
            {
                return Veiculo.ValorOpcionais.ToString("C", CultureInfo.CurrentCulture);
            }
        }
        public string ValorTotalFormatado
        {
            get
            {
                return Veiculo.ValorTotal.ToString("C", CultureInfo.CurrentCulture);
            }
        }
        public bool TemABS
        {
            get { return Veiculo.TemABS; }
            set
            {
                Veiculo.TemABS = value;
                OnPropertyChanged("ValorOpcionaisFormatado");
                OnPropertyChanged("ValorTotalFormatado");
            }
        }
        public bool TemAirbag
        {
            get { return Veiculo.TemAirbag; }
            set
            {
                Veiculo.TemAirbag = value;

                OnPropertyChanged("ValorOpcionaisFormatado");
                OnPropertyChanged("ValorTotalFormatado");
            }
        }
        public bool TemArCondicionado
        {
            get { return Veiculo.TemArCondicionado; }
            set
            {
                Veiculo.TemArCondicionado = value;
                OnPropertyChanged("ValorOpcionaisFormatado");
                OnPropertyChanged("ValorTotalFormatado");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}



