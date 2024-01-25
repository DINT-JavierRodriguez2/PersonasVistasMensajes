using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonasVistas
{
    internal class PersonaService
    {
        public ObservableCollection<Persona> GetSamples()
        {
            ObservableCollection<Persona> ejemplos = new ObservableCollection<Persona>();
            ejemplos.Add(new Persona("Pietro", 30, "Italiana"));
            ejemplos.Add(new Persona("Julia", 25, "Española"));
            ejemplos.Add(new Persona("Sophie", 35, "Francesa"));

            return ejemplos;
        }
    }
}
