using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using System.Windows;
using System.Xml;
using Practica5.ViewModels.Helpers;
using System.IO;

namespace Practica5.ViewModels
{
    internal class GamesBuyWinViewModel : BindingHelper
    {
        public Games SelectedGame { get; set; }
        public BindableCommand Vova { get; set; }

        private Steam_Entities steam = new Steam_Entities();

        public List<Games> Hyi { get; set; }

        public GamesBuyWinViewModel()
        {
            Hyi = steam.Games.ToList();

            Vova = new BindableCommand(_ => Add_Click());
        }
        private void Add_Click()
        {
            Games selectedgame = SelectedGame;

            if (selectedgame != null)
            {
                BuyGame(selectedgame);
            }
            else
            {
                MessageBox.Show("Выберай игру", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void BuyGame(Games game)
        {
            try
            {
                string check = GenerateCheck(game);

                SaveCheckToFile(check);

                MessageBox.Show("Все прошло четенька, гоняй в новуй игрульку");
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибочка вышла");
            }
        }

        private string GenerateCheck(Games game)
        {
            string check = $"<Steam>\nКассовый чек №{game.ID_Game}\n\n{game.Name_Game} - {game.Price}\n\nИтог к оплате:{game.Price}\n";
            return check;
        }


        private void SaveCheckToFile(string check)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Text Files (*.txt)|*.txt",
                Title = "Сохранить чек"
            };

            if (saveFileDialog.ShowDialog() == true)
            {
                File.WriteAllText(saveFileDialog.FileName, check);
            }
        }
    }
}
