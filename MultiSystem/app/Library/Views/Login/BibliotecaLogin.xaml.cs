using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MultiSystem.app.Library.Controllers;
using System.Runtime.InteropServices;

namespace MultiSystem.app.Library.view.Login
{
	/// <summary>
	/// 
	/// </summary>
	public partial class LoginLibrary : Window
	{
		public AdminController controller;
        private List<Dictionary<string, string>> response;
        MainWindow windowPrivate;
        public LoginLibrary()
		{
			this.InitializeComponent();
		}

        public void appendChild(MainWindow mainWindow)
        {
            windowPrivate = mainWindow;
        }

        private void actionClick(object sender, System.Windows.RoutedEventArgs e)
        {
            Window.messageLogin.Content = "";
            controller = new AdminController();

            IntPtr unsecured = IntPtr.Zero;
            try
            {
                unsecured = Marshal.SecureStringToGlobalAllocUnicode(passWordNameBookStore.SecurePassword);
                controller.PasswordName = Marshal.PtrToStringUni(unsecured);
            }
            finally
            {
                Marshal.ZeroFreeGlobalAllocUnicode(unsecured);
            }
            controller.UserName = userNameBookStore.Text;

            Console.WriteLine(controller.PasswordName.Length);

            if (!controller.UserName.Equals("") && controller.PasswordName.Length > 0)
            {
                this.response = controller.Login();
                if (response == null)
                {
                    Window.messageLogin.Content = "Usuario o contraseña incorrectos.";
                }
                else
                {
                    Window.messageLogin.Content = "Bienvenido";
                    MultiSystem.app.Biblioteca.Views.LibraryHome home = new MultiSystem.app.Biblioteca.Views.LibraryHome(this.response);
                    home.Show();
                    this.Close();
                    windowPrivate.Close();
                    MainWindow window = new MainWindow();
                    window.Close();
                }
            }
            else
            {
                MessageBox.Show("Completa todos los campos requeridos.");
            }
        }

        private void returnToHome(object sender, System.Windows.RoutedEventArgs e)
        {
        	this.Close();
        }
    }
}