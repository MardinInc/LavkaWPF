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
using LavkaWPF.ClassApp;
using LavkaWPF.PagesApp;

namespace LavkaWPF.PagesApp
{
    /// <summary>
    /// Логика взаимодействия для AutoPage.xaml
    /// </summary>
    public partial class AutoPage : Page
    {
        public AutoPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if ((TxtLogin.Text != "") && (TxtPassword.Password != ""))
            {
                var DataLogin = DBConnection.Connection.Login.Where(z => z.Login1 == TxtLogin.Text &&
                    z.Password == TxtPassword.Password).FirstOrDefault();
                if (DataLogin != null)
                {
                    MessageBox.Show(DataLogin.User.User_Name);
                }
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PagestationPage());
        }
    }
}
