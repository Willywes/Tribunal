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
using System.Windows.Shapes;
using tribunal.Negocio;


namespace WPF
{
    /// <summary>
    /// Lógica de interacción para Principal.xaml
    /// </summary>
    public partial class Principal : Window
    {
        public Principal()
        {
            InitializeComponent();
            runData();
          
        }

        private void runData() {

            dataGrid.ItemsSource = new Causas().All();
        }

        private void BtnBuscar_Click(object sender, RoutedEventArgs e)
        {
            string rol = txtRol.Text;
            DateTime? fecha = null;

            if (dpFecha.Text.Length > 0) {

                fecha = dpFecha.SelectedDate.Value.Date;
            
            }

            //Tribunal t = new Tribunal();
            //var comunas = t.GetComunas();

            dataGrid.ItemsSource = new Causas().Get(rol, fecha);


        }

        private void BtnLimpiar_Click(object sender, RoutedEventArgs e)
        {
            txtRol.Text = string.Empty;
            dpFecha.Text = string.Empty;

            runData();
        }
    }
}
