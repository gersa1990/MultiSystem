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
using System.Drawing;
using MultiSystem.app.Core.System.Screen;
using MultiSystem.app.Library.view.Login;
using MultiSystem.app.Library.Controllers;
using MultiSystem.app.Biblioteca.Views;
namespace MultiSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Screener screen = new Screener();
        private AdminController admin;
        public MainWindow()
        {
            this.Width = this.MinWidth = screen.fullWidth;
            this.Height = this.MinHeight = screen.fullHeight+25;
            
            //ONLY FOR TEST
            this.loginDiscrete();
        }

        //ONLY FOR TEST
        private void loginDiscrete()
        {
            admin = new AdminController();
            admin.UserName = "admin";
            admin.PasswordName = "admin";

            var response = admin.Login();
            LibraryHome home = new LibraryHome(response);
            home.Show();
            this.Close();
        }

		private void goToOther(object sender, System.Windows.RoutedEventArgs e)
		{
            LoginLibrary login = new LoginLibrary();
            login.appendChild(this);
            login.Show();
		}
    }
}
