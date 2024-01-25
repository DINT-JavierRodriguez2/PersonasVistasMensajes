using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace PersonasVistas
{
    class NewPersonaControlVM : ObservableObject
    {
        private NavegacionService servicioNavegacion;

        private Persona nuevaPersona;

        public Persona NuevaPersona
        {
            get { return nuevaPersona; }
            set
            {
                SetProperty(ref nuevaPersona, value);
            }
        }
        private ObservableCollection<String> tiposNacionalidad;
        public ObservableCollection<String> TiposNacionalidad

        {
            get { return tiposNacionalidad; }
            set
            {
                SetProperty(ref tiposNacionalidad, value);
            }
        }

        public RelayCommand AbrirVentanaNacionalidadCommand { get; set; }

        public RelayCommand AñadirNacionalidadCommand { get; set; }

        public RelayCommand AceptarNuevaPersonaCommand { get; set; }

        public NewPersonaControlVM() {
            NuevaPersona = new Persona();
            servicioNavegacion = new NavegacionService();
            TiposNacionalidad = new ObservableCollection<string> { "Italiana", "Española", "Francesa" };
            AbrirVentanaNacionalidadCommand = new RelayCommand(AbrirVentanaNacionalidad);
            AñadirNacionalidadCommand = new RelayCommand(AñadirNacionalidad);
            AceptarNuevaPersonaCommand = new RelayCommand(AñadirPersona);

            WeakReferenceMessenger.Default.Register<NuevaNacionalidadMessages>(this, (r, m) => {

                TiposNacionalidad.Add(m.Value);
            });
        }

        

        private void AñadirNacionalidad()
        {
            servicioNavegacion.AbrirDialogoNacionalidad();
        }
        private void AbrirVentanaNacionalidad()
        {
            servicioNavegacion.AbrirVentanaHija();
        }

        private void AñadirPersona()
        {
            WeakReferenceMessenger.Default.Send(new NuevaPersonaMessage(NuevaPersona));
        }
    }
}
