﻿using System;
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
    /// Lógica de interacción para NewPersonControl.xaml
    /// </summary>
    public partial class NewPersonControl : UserControl
    {
        private NewPersonaControlVM vm;
        public NewPersonControl()
        {
            InitializeComponent();
            vm = new NewPersonaControlVM();
            this.DataContext = vm;
           

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Persona creada.", "Información", MessageBoxButton.OK, MessageBoxImage.Information);


        }
    }
}
