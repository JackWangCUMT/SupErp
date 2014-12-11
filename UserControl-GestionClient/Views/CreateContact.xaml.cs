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
using UserControl_GestionClient.Helpers;

namespace UserControl_GestionClient.Views
{
    /// <summary>
    /// Logique d'interaction pour CreateContact.xaml
    /// </summary>
    public partial class CreateContact : UserControl
    {
        public CreateContact()
        {
            InitializeComponent();
        }

        private void Retour(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new AccueilGestionClient());
        }
    }
}
