using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace PersonasVistas
{
    internal class NavegacionService
    {
        private static PersonaListControl listaPersonas = new PersonaListControl();
        internal UserControl CargarNewPersonControl()
        {
            return new NewPersonControl();
        }

        internal UserControl CargarPersonaListControl()
        {
            return listaPersonas;
        }

        internal UserControl CargaConsultaPersonaControl()
        {
            return new ConsultaPersonaUControl();
        }

        public void AbrirVentanaHija()
        {
            VentanaNacionalidad nuevaVentana = new VentanaNacionalidad();           
            // Cuando es una ventana normal
            // NuevaVentana.Show()

            // Cuando es un diálogo:
            nuevaVentana.ShowDialog();

        }

        public bool? AbrirDialogoNacionalidad()
        {
            VentanaNacionalidad dialogo = new VentanaNacionalidad();
            return dialogo.ShowDialog();
        }
    }
}
