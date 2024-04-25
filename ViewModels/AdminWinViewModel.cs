using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Practica5.ViewModels.Helpers;
using System.Windows.Controls;

namespace Practica5.ViewModels
{
    internal class AdminWinViewModel : BindingHelper
    {
        private Steam_Entities steam = new Steam_Entities();

        public BindableCommand Vova {  get; set; }

        public AdminWinViewModel()
        {
            Vova = new BindableCommand(_ => Button_Click());
        }
        private void Button_Click()
        {
            try
            {

                using (SqlConnection connection = new SqlConnection(steam.Database.Connection.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("BackupSteamDatabase", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Резервная копия базы данных успешно создана.", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при создании резервной копии базы данных: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }
    }  
}
