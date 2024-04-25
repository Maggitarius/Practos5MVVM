using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Shapes;
using Microsoft.Win32;
using Practica5.ViewModels;

namespace Practica5
{
    public partial class GamesBuyWin : Window
    {
        private Steam_Entities steam = new Steam_Entities();
        public GamesBuyWin()
        {
            InitializeComponent();
            DataContext = new GamesBuyWinViewModel();
        }
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            UserMain user = new UserMain();
            user.Show();
            this.Close();
        }
    }
}
