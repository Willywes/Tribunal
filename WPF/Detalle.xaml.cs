using System;
using System.Collections.Generic;
using System.Data;
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
    public partial class Detalle : Window
    {
        private Causas causa;

        public Detalle()
        {
            InitializeComponent();
            //runData();
          
        }

        public Detalle(Causas causa) {
            InitializeComponent();
            runData(causa);
        }

        public void runData(Causas causa) {
            this.causa = causa;
            lblRol.Content = causa.Rol;
            lblFecha.Content = causa.Fecha;
            lblCaratula.Content = causa.Caratula;
            lblTribunal.Content = causa.Tribunal;
            lblComuna.Content = causa.Comuna;

            List<Diligencias> diligencias = new Diligencias().GetByCausa(causa.Id);

            dataGrid.ItemsSource = diligencias;
        }

        private void BtnBuscar_Click(object sender, RoutedEventArgs e)
        {
            //string rol = txtRol.Text;
            //DateTime? fecha = null;

            //if (dpFecha.Text.Length > 0) {

            //    fecha = dpFecha.SelectedDate.Value.Date;
            
            //}

            //dataGrid.ItemsSource = new Causas().Get(rol, fecha);


        }

        private void BtnLimpiar_Click(object sender, RoutedEventArgs e)
        {
            //txtRol.Text = string.Empty;
            //dpFecha.Text = string.Empty;

            //runData();
        }

        private void btnView_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Causas data = (Causas)((Button)e.Source).DataContext;
                int id = data.Id;
                MessageBox.Show("Id : " + id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void BtnNuevo_Click(object sender, RoutedEventArgs e)
        {
            NuevaDiligencia nuevaDiligencia = new NuevaDiligencia(causa, this);
            nuevaDiligencia.Show();
        }

        private void BtnCerrar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
