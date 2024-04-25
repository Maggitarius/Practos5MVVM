using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Practica5.ViewModels.Helpers;

namespace Practica5.ViewModels
{
    internal class MainWindowViewModel : BindingHelper
    {
        public string Login { get; set; }
        public string Password { get; set; }

        public BindableCommand Vova { get; set; }

        public MainWindowViewModel() 
        {
            Vova = new BindableCommand(_ => Button_Click());
        }
        private void Button_Click()
        {
            var login = Login;
            var password = Password;
            if (login == "admin" && password == "987654321")
            {
                AdminMain adminMain = new AdminMain();
                adminMain.Show();
            }
            else if (login == "user" && password == "123456789")
            {
                UserMain userMain = new UserMain();
                userMain.Show();
            }
            else
            {
                MessageBox.Show("Ты лох, введи нормально!");
            }
        }
    }
}
