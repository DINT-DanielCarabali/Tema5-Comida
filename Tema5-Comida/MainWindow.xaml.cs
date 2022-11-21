using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Tema5_Comida.vista_modelo;

namespace Tema5_Comida
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly MainWindowVM vm;

        public MainWindow()
        {
            InitializeComponent();
            vm = new MainWindowVM();
            DataContext = vm;
        }

        private void LimpiarFormularioButton_Click(object sender, RoutedEventArgs e)
        {
            vm.LimpiarFormulario();
        }
    }
}
