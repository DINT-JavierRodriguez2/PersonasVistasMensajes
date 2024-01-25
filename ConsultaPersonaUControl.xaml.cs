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

namespace PersonasVistas
{
    /// <summary>
    /// Lógica de interacción para ConsultaPersonaUControl.xaml
    /// </summary>
    public partial class ConsultaPersonaUControl : UserControl
    {
        private ConsultaPersonaUControlVM vm;
        public ConsultaPersonaUControl()
        {
            InitializeComponent();
            vm = new ConsultaPersonaUControlVM();
            this.DataContext = vm;
        }
        
    }
}
