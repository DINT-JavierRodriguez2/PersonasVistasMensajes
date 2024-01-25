using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Messaging;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonasVistas
{
    class PersonaListControlVM : ObservableObject
    {
        private ObservableCollection<Persona> listaPersonas;
        public ObservableCollection<Persona> ListaPersonas
        {
            get { return listaPersonas; }
            set
            {
                SetProperty(ref listaPersonas, value);
            }
        }

        private Persona personaSeleccionada;

        public Persona PersonaSeleccionada
        {
            get {return personaSeleccionada;}
            set
            {
                SetProperty(ref  personaSeleccionada, value);
            }
        }
        private PersonaService servicio;

        public PersonaListControlVM() {
            
            servicio = new PersonaService();
            ListaPersonas = servicio.GetSamples();
           
            // Subscrito al mensaje de DIFUSIÓN del UserControl NuevaPersona.
            WeakReferenceMessenger.Default.Register<NuevaPersonaMessage>(this, (r, m) => {
                ListaPersonas.Add(m.Value);
            });

            //Viene de Consulta, devuelve información
            WeakReferenceMessenger.Default.Register<PersonaListControlVM, PersonaSeleccionadaMessage>(this, (r, m) =>
            {
                m.Reply(PersonaSeleccionada);
            });
        }
    }
}
