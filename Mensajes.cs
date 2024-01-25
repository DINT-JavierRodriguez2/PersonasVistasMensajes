using CommunityToolkit.Mvvm.Messaging.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonasVistas
{
    //Difusion
    public class NuevaNacionalidadMessages : ValueChangedMessage<string>
    {
        public NuevaNacionalidadMessages(string nuevaNacionalidad) : base(nuevaNacionalidad) { }
    }

    //Difusion
    public class NuevaPersonaMessage : ValueChangedMessage<Persona>
    {
        public NuevaPersonaMessage(Persona nuevaPersona) : base(nuevaPersona) { }
    }

    //Solicitud
    public class PersonaSeleccionadaMessage : RequestMessage<Persona> { }
   
}
