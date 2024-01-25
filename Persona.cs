using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonasVistas
{
    public class Persona : ObservableObject
    {
        private string nombre;
        private int edad;
        private string nacionalidad;

        public string Nombre
        {
            get { return nombre; } 
            set { SetProperty(ref nombre, value);}
        }

        public int Edad
        {
            get { return edad; }
            set { SetProperty(ref edad, value);}
        }

        public string Nacionalidad
        {
            get { return nacionalidad; }
            set { SetProperty(ref nacionalidad, value); }
        }

        public Persona() { }
        public Persona(string nombre, int edad, string nacionalidad)
        {
            Nombre = nombre;
            Edad = edad;
            Nacionalidad = nacionalidad;            
        }
    }
}
