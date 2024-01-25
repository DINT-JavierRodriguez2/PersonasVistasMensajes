using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonasVistas
{
    internal class ConsultaPersonaUControlVM : ObservableRecipient
    {
        private Persona personaSeleccionada;

        public Persona PersonaSeleccionada
        {
            get { return personaSeleccionada; }
            set
            {
                SetProperty(ref personaSeleccionada, value);
            }
        }

            public ConsultaPersonaUControlVM()
        {
            PersonaSeleccionada = WeakReferenceMessenger.Default.Send<PersonaSeleccionadaMessage>();

        }

    }
        
    
}
