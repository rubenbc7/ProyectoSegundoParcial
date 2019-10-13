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

namespace ProyectoSegundoParcial
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

        private void CbProducto_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            grdParametros.Children.Clear();
            switch (cbProducto.SelectedIndex)
            {
                case 0:
                    grdParametros.Children.Add(new ParametrosCamisa());
                    grdParametros.Visibility = Visibility.Hidden;
                    break;

                case 1:
                    grdParametros.Children.Add(new ParametrosSudadera());
                    grdParametros.Visibility = Visibility.Hidden;
                    break;
                case 2:
                    grdParametros.Children.Add(new ParametrosPantalon());
                    grdParametros.Visibility = Visibility.Hidden;
                    break;
                case 3:
                    grdParametros.Children.Add(new ParametrosGorra());
                    grdParametros.Visibility = Visibility.Hidden;
                    break;
                case 4:
                    grdParametros.Children.Add(new ParametrosAccesorio());
                    grdParametros.Visibility = Visibility.Hidden;
                    break;
                case 5:
                    grdParametros.Children.Add(new ParametrosCalzado());
                    grdParametros.Visibility = Visibility.Hidden;
                    break;
                default:
                    break;

            }
        }

        private void BtnAgregar_Click(object sender, RoutedEventArgs e)
        {
            grdParametros.Visibility = Visibility.Visible;
            btnCancelar.Visibility = Visibility.Visible;
            btnGuardar.Visibility = Visibility.Visible;
            if(cbProducto.SelectedItem == null)
            {
                btnCancelar.Visibility = Visibility.Hidden;
                btnGuardar.Visibility = Visibility.Hidden;

            }
        }

        private void BtnGuardar_Click(object sender, RoutedEventArgs e)
        {

            switch (cbProducto.SelectedIndex)
            {
                case 0:
                    if (string.IsNullOrEmpty(((ParametrosCamisa)(grdParametros.Children[0])).PCamiCodigo.Text) ||
            string.IsNullOrEmpty(((ParametrosCamisa)(grdParametros.Children[0])).PCamiDescrip.Text) ||
            string.IsNullOrEmpty(((ParametrosCamisa)(grdParametros.Children[0])).PCamiPrecio.Text) ||
            string.IsNullOrEmpty(((ParametrosCamisa)(grdParametros.Children[0])).PCamiCole.Text)
            || ((ParametrosCamisa)(grdParametros.Children[0])).PCamiCombo.SelectedIndex == 0
            || (((ParametrosCamisa)(grdParametros.Children[0])).PCamiR1.IsChecked == false &&
            ((ParametrosCamisa)(grdParametros.Children[0])).PCamiR2.IsChecked == false &&
            ((ParametrosCamisa)(grdParametros.Children[0])).PCamiR3.IsChecked == false &&
            ((ParametrosCamisa)(grdParametros.Children[0])).PCamiR4.IsChecked == false) ||
            (((ParametrosCamisa)(grdParametros.Children[0])).PCamiC1.IsChecked == false &&
            ((ParametrosCamisa)(grdParametros.Children[0])).PCamiC2.IsChecked == false &&
            ((ParametrosCamisa)(grdParametros.Children[0])).PCamiC3.IsChecked == false) ||
            (((ParametrosCamisa)(grdParametros.Children[0])).PCamiB1.IsChecked == false &&
            ((ParametrosCamisa)(grdParametros.Children[0])).PCamiB2.IsChecked == false &&
            ((ParametrosCamisa)(grdParametros.Children[0])).PCamiB3.IsChecked == false &&
            ((ParametrosCamisa)(grdParametros.Children[0])).PCamiB4.IsChecked == false &&
            ((ParametrosCamisa)(grdParametros.Children[0])).PCamiB5.IsChecked == false &&
            ((ParametrosCamisa)(grdParametros.Children[0])).PCamiB6.IsChecked == false &&
            ((ParametrosCamisa)(grdParametros.Children[0])).PCamiB7.IsChecked == false))
                    {
                        txtReq.Visibility = Visibility.Visible;
                    }

                    else
                    {
                        txtReq.Visibility = Visibility.Hidden;
                        grdParametros.Children.Clear();
                        grdParametros.Visibility = Visibility.Hidden;
                        btnCancelar.Visibility = Visibility.Hidden;
                        btnGuardar.Visibility = Visibility.Hidden;
                        cbProducto.SelectedItem = null;
                    }
                    break;

                case 1:
                    if (string.IsNullOrEmpty(((ParametrosSudadera)(grdParametros.Children[0])).PSudaCodigo.Text) ||
     string.IsNullOrEmpty(((ParametrosSudadera)(grdParametros.Children[0])).PSudaDescrip.Text) ||
     string.IsNullOrEmpty(((ParametrosSudadera)(grdParametros.Children[0])).PSudaPrecio.Text) ||
     string.IsNullOrEmpty(((ParametrosSudadera)(grdParametros.Children[0])).PSudaCole.Text)
     || ((ParametrosSudadera)(grdParametros.Children[0])).PSudaCombo.SelectedIndex == 0
     || (((ParametrosSudadera)(grdParametros.Children[0])).PSudaR1.IsChecked == false &&
     ((ParametrosSudadera)(grdParametros.Children[0])).PSudaR2.IsChecked == false &&
     ((ParametrosSudadera)(grdParametros.Children[0])).PSudaR3.IsChecked == false &&
     ((ParametrosSudadera)(grdParametros.Children[0])).PSudaR4.IsChecked == false) ||
     (((ParametrosSudadera)(grdParametros.Children[0])).PSudaC1.IsChecked == false &&
     ((ParametrosSudadera)(grdParametros.Children[0])).PSudaC2.IsChecked == false &&
     ((ParametrosSudadera)(grdParametros.Children[0])).PSudaC3.IsChecked == false) ||
     (((ParametrosSudadera)(grdParametros.Children[0])).PSudaB1.IsChecked == false &&
     ((ParametrosSudadera)(grdParametros.Children[0])).PSudaB2.IsChecked == false &&
     ((ParametrosSudadera)(grdParametros.Children[0])).PSudaB3.IsChecked == false &&
     ((ParametrosSudadera)(grdParametros.Children[0])).PSudaB4.IsChecked == false &&
     ((ParametrosSudadera)(grdParametros.Children[0])).PSudaB5.IsChecked == false &&
     ((ParametrosSudadera)(grdParametros.Children[0])).PSudaB6.IsChecked == false &&
     ((ParametrosSudadera)(grdParametros.Children[0])).PSudaB7.IsChecked == false))
                    {
                        txtReq.Visibility = Visibility.Visible;
                    }

                    else
                    {
                        txtReq.Visibility = Visibility.Hidden;
                        grdParametros.Children.Clear();
                        grdParametros.Visibility = Visibility.Hidden;
                        btnCancelar.Visibility = Visibility.Hidden;
                        btnGuardar.Visibility = Visibility.Hidden;
                        cbProducto.SelectedItem = null;
                    }
                    break;
                case 2:
                    if (string.IsNullOrEmpty(((ParametrosPantalon)(grdParametros.Children[0])).PSudaCodigo.Text) ||
string.IsNullOrEmpty(((ParametrosPantalon)(grdParametros.Children[0])).PSudaDescrip.Text) ||
string.IsNullOrEmpty(((ParametrosPantalon)(grdParametros.Children[0])).PSudaPrecio.Text) ||
string.IsNullOrEmpty(((ParametrosPantalon)(grdParametros.Children[0])).PSudaCole.Text)
|| ((ParametrosPantalon)(grdParametros.Children[0])).PSudaCombo.SelectedIndex == 0
|| (((ParametrosPantalon)(grdParametros.Children[0])).PSudaR1.IsChecked == false &&
((ParametrosPantalon)(grdParametros.Children[0])).PSudaR2.IsChecked == false &&
((ParametrosPantalon)(grdParametros.Children[0])).PSudaR3.IsChecked == false &&
((ParametrosPantalon)(grdParametros.Children[0])).PSudaR4.IsChecked == false) ||
(((ParametrosPantalon)(grdParametros.Children[0])).PSudaC1.IsChecked == false &&
((ParametrosPantalon)(grdParametros.Children[0])).PSudaC2.IsChecked == false &&
((ParametrosPantalon)(grdParametros.Children[0])).PSudaC3.IsChecked == false) ||
(((ParametrosPantalon)(grdParametros.Children[0])).PSudaB1.IsChecked == false &&
((ParametrosPantalon)(grdParametros.Children[0])).PSudaB2.IsChecked == false &&
((ParametrosPantalon)(grdParametros.Children[0])).PSudaB3.IsChecked == false &&
((ParametrosPantalon)(grdParametros.Children[0])).PSudaB4.IsChecked == false &&
((ParametrosPantalon)(grdParametros.Children[0])).PSudaB5.IsChecked == false &&
((ParametrosPantalon)(grdParametros.Children[0])).PSudaB6.IsChecked == false &&
((ParametrosPantalon)(grdParametros.Children[0])).PSudaB7.IsChecked == false))
                    {
                        txtReq.Visibility = Visibility.Visible;
                    }

                    else
                    {
                        txtReq.Visibility = Visibility.Hidden;
                        grdParametros.Children.Clear();
                        grdParametros.Visibility = Visibility.Hidden;
                        btnCancelar.Visibility = Visibility.Hidden;
                        btnGuardar.Visibility = Visibility.Hidden;
                        cbProducto.SelectedItem = null;
                    }
                    break;
                case 3:
                    if (string.IsNullOrEmpty(((ParametrosGorra)(grdParametros.Children[0])).PSudaCodigo.Text) ||
string.IsNullOrEmpty(((ParametrosGorra)(grdParametros.Children[0])).PSudaDescrip.Text) ||
string.IsNullOrEmpty(((ParametrosGorra)(grdParametros.Children[0])).PSudaPrecio.Text) ||
string.IsNullOrEmpty(((ParametrosGorra)(grdParametros.Children[0])).PSudaCole.Text)
|| ((ParametrosGorra)(grdParametros.Children[0])).PSudaCombo.SelectedIndex == 0
|| (((ParametrosGorra)(grdParametros.Children[0])).PSudaR1.IsChecked == false &&
((ParametrosGorra)(grdParametros.Children[0])).PSudaR2.IsChecked == false &&
((ParametrosGorra)(grdParametros.Children[0])).PSudaR3.IsChecked == false &&
((ParametrosGorra)(grdParametros.Children[0])).PSudaR4.IsChecked == false) ||
(((ParametrosGorra)(grdParametros.Children[0])).PSudaC1.IsChecked == false &&
((ParametrosGorra)(grdParametros.Children[0])).PSudaC2.IsChecked == false &&
((ParametrosGorra)(grdParametros.Children[0])).PSudaC3.IsChecked == false) ||
(((ParametrosGorra)(grdParametros.Children[0])).PSudaB1.IsChecked == false &&
((ParametrosGorra)(grdParametros.Children[0])).PSudaB2.IsChecked == false &&
((ParametrosGorra)(grdParametros.Children[0])).PSudaB3.IsChecked == false &&
((ParametrosGorra)(grdParametros.Children[0])).PSudaB4.IsChecked == false &&
((ParametrosGorra)(grdParametros.Children[0])).PSudaB5.IsChecked == false &&
((ParametrosGorra)(grdParametros.Children[0])).PSudaB6.IsChecked == false &&
((ParametrosGorra)(grdParametros.Children[0])).PSudaB7.IsChecked == false))
                    {
                        txtReq.Visibility = Visibility.Visible;
                    }

                    else
                    {
                        txtReq.Visibility = Visibility.Hidden;
                        grdParametros.Children.Clear();
                        grdParametros.Visibility = Visibility.Hidden;
                        btnCancelar.Visibility = Visibility.Hidden;
                        btnGuardar.Visibility = Visibility.Hidden;
                        cbProducto.SelectedItem = null;
                    }
                    break;
                case 4:
                    if (string.IsNullOrEmpty(((ParametrosAccesorio)(grdParametros.Children[0])).PSudaCodigo.Text) ||
string.IsNullOrEmpty(((ParametrosAccesorio)(grdParametros.Children[0])).PSudaDescrip.Text) ||
string.IsNullOrEmpty(((ParametrosAccesorio)(grdParametros.Children[0])).PSudaPrecio.Text) ||
string.IsNullOrEmpty(((ParametrosAccesorio)(grdParametros.Children[0])).PSudaCole.Text)
|| ((ParametrosAccesorio)(grdParametros.Children[0])).PSudaCombo.SelectedIndex == 0
|| (((ParametrosAccesorio)(grdParametros.Children[0])).PSudaR1.IsChecked == false &&
((ParametrosAccesorio)(grdParametros.Children[0])).PSudaR2.IsChecked == false &&
((ParametrosAccesorio)(grdParametros.Children[0])).PSudaR3.IsChecked == false &&
((ParametrosAccesorio)(grdParametros.Children[0])).PSudaR4.IsChecked == false) ||
(((ParametrosAccesorio)(grdParametros.Children[0])).PSudaC1.IsChecked == false &&
((ParametrosAccesorio)(grdParametros.Children[0])).PSudaC2.IsChecked == false &&
((ParametrosAccesorio)(grdParametros.Children[0])).PSudaC3.IsChecked == false) ||
(((ParametrosAccesorio)(grdParametros.Children[0])).PSudaB1.IsChecked == false &&
((ParametrosAccesorio)(grdParametros.Children[0])).PSudaB2.IsChecked == false &&
((ParametrosAccesorio)(grdParametros.Children[0])).PSudaB3.IsChecked == false &&
((ParametrosAccesorio)(grdParametros.Children[0])).PSudaB4.IsChecked == false &&
((ParametrosAccesorio)(grdParametros.Children[0])).PSudaB5.IsChecked == false &&
((ParametrosAccesorio)(grdParametros.Children[0])).PSudaB6.IsChecked == false &&
((ParametrosAccesorio)(grdParametros.Children[0])).PSudaB7.IsChecked == false))
                    {
                        txtReq.Visibility = Visibility.Visible;
                    }

                    else
                    {
                        txtReq.Visibility = Visibility.Hidden;
                        grdParametros.Children.Clear();
                        grdParametros.Visibility = Visibility.Hidden;
                        btnCancelar.Visibility = Visibility.Hidden;
                        btnGuardar.Visibility = Visibility.Hidden;
                        cbProducto.SelectedItem = null;
                    }
                    break;
                case 5:
                    if (string.IsNullOrEmpty(((ParametrosCalzado)(grdParametros.Children[0])).PSudaCodigo.Text) ||
string.IsNullOrEmpty(((ParametrosCalzado)(grdParametros.Children[0])).PSudaDescrip.Text) ||
string.IsNullOrEmpty(((ParametrosCalzado)(grdParametros.Children[0])).PSudaPrecio.Text) ||
string.IsNullOrEmpty(((ParametrosCalzado)(grdParametros.Children[0])).PSudaCole.Text)
|| ((ParametrosCalzado)(grdParametros.Children[0])).PSudaCombo.SelectedIndex == 0
|| (((ParametrosCalzado)(grdParametros.Children[0])).PSudaR1.IsChecked == false &&
((ParametrosCalzado)(grdParametros.Children[0])).PSudaR2.IsChecked == false &&
((ParametrosCalzado)(grdParametros.Children[0])).PSudaR3.IsChecked == false &&
((ParametrosCalzado)(grdParametros.Children[0])).PSudaR4.IsChecked == false) ||
(((ParametrosCalzado)(grdParametros.Children[0])).PSudaC1.IsChecked == false &&
((ParametrosCalzado)(grdParametros.Children[0])).PSudaC2.IsChecked == false &&
((ParametrosCalzado)(grdParametros.Children[0])).PSudaC3.IsChecked == false) ||
(((ParametrosCalzado)(grdParametros.Children[0])).PSudaB1.IsChecked == false &&
((ParametrosCalzado)(grdParametros.Children[0])).PSudaB2.IsChecked == false &&
((ParametrosCalzado)(grdParametros.Children[0])).PSudaB3.IsChecked == false &&
((ParametrosCalzado)(grdParametros.Children[0])).PSudaB4.IsChecked == false &&
((ParametrosCalzado)(grdParametros.Children[0])).PSudaB5.IsChecked == false &&
((ParametrosCalzado)(grdParametros.Children[0])).PSudaB6.IsChecked == false &&
((ParametrosCalzado)(grdParametros.Children[0])).PSudaB7.IsChecked == false))
                    {
                        txtReq.Visibility = Visibility.Visible;
                    }

                    else
                    {
                        txtReq.Visibility = Visibility.Hidden;
                        grdParametros.Children.Clear();
                        grdParametros.Visibility = Visibility.Hidden;
                        btnCancelar.Visibility = Visibility.Hidden;
                        btnGuardar.Visibility = Visibility.Hidden;
                        cbProducto.SelectedItem = null;
                    }

                    break;
                default:
                    break;

            }
        }

        private void BtnCancelar_Click(object sender, RoutedEventArgs e)
        {
            grdParametros.Children.Clear();
            grdParametros.Visibility = Visibility.Hidden;
            btnCancelar.Visibility = Visibility.Hidden;
            btnGuardar.Visibility = Visibility.Hidden;
            txtReq.Visibility = Visibility.Hidden;
            cbProducto.SelectedItem = null;
        }
    }
}
