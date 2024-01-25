using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonasVistas
{
    class VentanaNacionalidadVM : ObservableObject
    {
        private string nacionalidad;

        public string Nacionalidad
        {
            get {  return nacionalidad; }
            set { SetProperty(ref nacionalidad, value); }
        }

        public void Aceptar()
        {
            WeakReferenceMessenger.Default.Send(new NuevaNacionalidadMessages(Nacionalidad));
        }

    }

    
}
