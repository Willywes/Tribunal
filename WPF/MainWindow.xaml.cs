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

namespace WPF
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            string user = txtUser.Text;
            string pass = txtPass.Password.ToString();

            if (user.Equals("admin"))
            {
                if (pass.Equals("admin123"))
                {
                    Principal principal = new Principal();
                    principal.Show();
                    this.Close();
                }
                else
                {
                    lblMessage.Content = "La combinación de usuario y contraseña no son correctas.";
                }
            }
            else {
                lblMessage.Content = "Usuario no encontrado.";
            }

        }

     
    }
}
