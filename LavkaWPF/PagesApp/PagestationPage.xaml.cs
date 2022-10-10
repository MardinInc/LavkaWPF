using LavkaWPF.ADOApp;
using LavkaWPF.ClassApp;
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

namespace LavkaWPF.PagesApp
{
    /// <summary>
    /// Логика взаимодействия для PagestationPage.xaml
    /// </summary>
    public partial class PagestationPage : Page
    {
        public PagestationPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                if ((TxtLogin.Text != "") && (TxtName.Text != "") && (TxtPassword.Text != ""))
                {
                    if (DBConnection.Connection.Login.Where(z => z.Login1 == TxtLogin.Text).FirstOrDefault() == null)
                    {
                        User NewUser = new User();
                        Login NewLogin = new Login()
                        {
                            Login1 = TxtLogin.Text,
                            Password = TxtPassword.Text
                        };
                        NewUser.Login.Add(NewLogin);
                        NewUser.User_Name = TxtName.Text;
                        NewUser.Type_ID = 1;
                        DBConnection.Connection.User.Add(NewUser);
                        DBConnection.Connection.SaveChanges();
                        MessageBox.Show("Успешно!");
                    }
                    else
                    {
                        MessageBox.Show("Такой логин уже существует!");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
