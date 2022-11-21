using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tema5_Comida.modelo;

namespace Tema5_Comida.vista_modelo
{
    class MainWindowVM : INotifyPropertyChanged
    {
        private ObservableCollection<Plato> platos;

        public ObservableCollection<Plato> Platos
        {
            get => platos;
            set
            {
                platos = value;
                NotifyPropertyChanged("Platos");
            }
        }

        private Plato platoSeleccionado;

        public Plato PlatoSeleccionado
        {
            get => platoSeleccionado;
            set
            {
                platoSeleccionado = value;
                NotifyPropertyChanged("PlatoSeleccionado");
            }
        }

        private ObservableCollection<string> nacionalidades;

        public ObservableCollection<string> Nacionalidades
        {
            get => nacionalidades;
            set
            {
                nacionalidades = value;
                NotifyPropertyChanged("Nacionalidades");
            }
        }

        private string nacionalidadSeleccionada;

        public string NacionalidadSeleccionada
        {
            get => nacionalidadSeleccionada;
            set
            {
                nacionalidadSeleccionada = value;
                NotifyPropertyChanged("NacionalidadSeleccionada");
            }
        }

        public MainWindowVM()
        {
            Platos = Plato.GetSamples("E:\\DINT\\Tema 5\\Otros\\ut5_actv1_exe\\Imagenes\\");
            Nacionalidades = new ObservableCollection<string> { "China", "Americana", "Mexicana" };
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        public void LimpiarFormulario() => PlatoSeleccionado = null;
    }
}