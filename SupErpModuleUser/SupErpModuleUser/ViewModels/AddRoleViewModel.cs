﻿using SupErpModuleUser.Helpers;
using SupErpModuleUser.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using SupErpModuleUser.Helpers;
using SupErpModuleUser.UserService;

namespace SupErpModuleUser.ViewModels
{
    public class AddRoleViewModel
    {
        public IHMRole Role { get; set; }

        public List<IHMModule> Modules { get; set; }

        public AddRoleViewModel()
        {
            Role = new IHMRole();
            //Modules = new UserService.UserServiceClient().GetModules();

            IHMModule module1 = new IHMModule();
            module1.Name = "Utilisateur";
            IHMModule module2 = new IHMModule();
            module2.Name = "Salaire";

            Modules = new List<IHMModule>();
            Modules.Add(module1);
            Modules.Add(module2);
        }

        public AddRoleViewModel(Role role)
        {
            Role = role.ToIHMRole();

            //Modules = new UserService.UserServiceClient().GetModules();

            IHMModule module1 = new IHMModule();
            module1.Name = "Utilisateur";
            IHMModule module2 = new IHMModule();
            module2.Name = "Salaire";

            Modules = new List<IHMModule>();
            Modules.Add(module1);
            Modules.Add(module2);
        }

        #region Commands

        public ICommand AddCommand { get { return new DelegateCommand(OnAddOrUpdate); } }
        public ICommand CancelCommand { get { return new DelegateCommand(OnCancel); } }

        #endregion

        #region Command Handlers
        private void OnAddOrUpdate()
        { }

        private void OnCancel() 
        { }

        #endregion
    }
}
