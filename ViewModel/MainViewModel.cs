﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PrototypeEDUCOM.ViewModel
{
    class MainViewModel : BaseViewModel
    {

        public String login { get; set; }

        public String pass { get; set; }

        public String message { get; set; }

        public ICommand btnLogin { get; set; }

        public Action CloseAction { get; set; }

        public MainViewModel()
        {
            btnLogin = new RelayCommand<object>(actLogin);
        }

        private void actLogin(object arg)
        {
            // login admin@admin.com pass admin
            // login test@testcom pass test
            if (login.Length != 0 && pass.Length != 0)
            {
                int nbrUser = db.users.Where(u => u.email == login && u.password == pass).Count();

                if (nbrUser == 1)
                {
                    View.RequestsView requestsView = new View.RequestsView();
                    requestsView.Show();

                    CloseAction();
                }
                else
                {
                    message = "Login ou mot de passe incorrect";
                    NotifyPropertyChanged("message");
                }
            }
            else
            {
                message = "Login ou mot de passe vide";
                NotifyPropertyChanged("message");
            }    
        }
    }
}
