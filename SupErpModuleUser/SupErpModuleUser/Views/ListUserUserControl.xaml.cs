﻿using SupErp.Shared;
using System;
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

namespace SupErpModuleUser
{
    /// <summary>
    /// Logique d'interaction pour ListUserUserControl.xaml
    /// </summary>
    public partial class ListUserUserControl : UserControl, ISubMenu
    {
        public ListUserUserControl()
        {
            InitializeComponent();
        }

        public string SubMenuName
        {
            get { return "Afficher les utilisateurs"; }
        }

        public List<ISubMenu> SubMenus
        {
            get
            {
                return null;
            }
        }

        public bool CanWrite
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
