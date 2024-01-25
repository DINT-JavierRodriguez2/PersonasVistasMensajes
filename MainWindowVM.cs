using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace PersonasVistas
{
    
    class MainWindowVM :  ObservableObject
    {
        private UserControl contenidoVista;
        public UserControl ContenidoVista
        {
            get { return contenidoVista; }
            set { SetProperty(ref contenidoVista, value); }
        }
        public RelayCommand VistaNewPersona { get; set; }
        public RelayCommand VistaPersonaList { get; set; }   
        public RelayCommand VistaConsultaPersona { get; set; }

        private NavegacionService servicioPersonaControl;   

        public MainWindowVM()
        {
            servicioPersonaControl = new NavegacionService();
            VistaNewPersona = new RelayCommand(CargaNewPersona);
            VistaPersonaList = new RelayCommand(CargaPersonaList);
            VistaConsultaPersona = new RelayCommand(CargarConsultaPersona);
            
        }

        private void CargaNewPersona()
        {
            ContenidoVista = servicioPersonaControl.CargarNewPersonControl();
        }

        private void CargaPersonaList()
        {
            ContenidoVista = servicioPersonaControl.CargarPersonaListControl();
        }

        private void CargarConsultaPersona()
        {
            ContenidoVista = servicioPersonaControl.CargaConsultaPersonaControl();
        }

        
    }
}
