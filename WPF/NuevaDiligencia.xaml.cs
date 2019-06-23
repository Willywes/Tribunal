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
    public partial class NuevaDiligencia : Window
    {
        private Causas causa;
        private Detalle detalle;

        public NuevaDiligencia()
        {
            InitializeComponent();   
          
        }

        public NuevaDiligencia(Causas causa, Detalle detalle) {
            InitializeComponent();
            runData(causa);
            this.detalle = detalle;
        }

        private void runData(Causas causa) {
            this.causa = causa;
            lblRol.Content = causa.Rol;
            lblCaratula.Content = causa.Caratula;

        }

        private void BtnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnGuardar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Diligencias dili = new Diligencias();
                dili.Descripcion = txtDescription.Text;
                dili.IdCausa = causa.Id;
                var f = dili.Store(dili);
                MessageBox.Show("Listo Ctm");
                detalle.runData(causa);
                this.Close();
                
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
