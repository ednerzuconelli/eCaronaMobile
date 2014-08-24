using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using eCarona.Resources;
using eCarona.Modelo;
using Newtonsoft.Json;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;


namespace eCarona
{
    public partial class Detalhes : PhoneApplicationPage
    {
        Pessoa _pessoa = new Pessoa();

        public Detalhes()
        {
            InitializeComponent();            
        }

        private void CarregaPessoa()
        {
            _pessoa = App.pessoa_detalhe;
            ContentPanel.DataContext = _pessoa;
        }

      

        private void percursoRad_A_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            arruma_objetos_horarios();
        }

        private void arruma_objetos_horarios()
        {
            if (percursoRad_A.IsChecked == true) //Somente ida
            {
                tblHorarioIda.Visibility = System.Windows.Visibility.Visible;
                tblHorarioIda.Visibility = System.Windows.Visibility.Visible;
                tbHorarioVolta.Visibility = System.Windows.Visibility.Collapsed;
                tblHorarioVolta.Visibility = System.Windows.Visibility.Collapsed;
                tblHorarioIda.Margin = new Thickness(10, 959, 0, 0);
                tbHorarioIda.Margin = new Thickness(-2, 986, 0, 0);
            }
            else
            {
                if (percursoRad_B.IsChecked == true) //Somente volta
                {
                    tblHorarioIda.Visibility = System.Windows.Visibility.Collapsed;
                    tblHorarioIda.Visibility = System.Windows.Visibility.Collapsed;
                    tbHorarioVolta.Visibility = System.Windows.Visibility.Visible;
                    tblHorarioVolta.Visibility = System.Windows.Visibility.Visible;
                    tblHorarioVolta.Margin = new Thickness(10, 959, 0, 0);
                    tbHorarioVolta.Margin = new Thickness(-2, 986, 0, 0);
                }
                else //Ida e Volta
                {
                    tblHorarioIda.Visibility = System.Windows.Visibility.Visible;
                    tblHorarioIda.Visibility = System.Windows.Visibility.Visible;
                    tbHorarioVolta.Visibility = System.Windows.Visibility.Visible;
                    tblHorarioVolta.Visibility = System.Windows.Visibility.Visible;
                    tblHorarioIda.Margin = new Thickness(10, 959, 0, 0);
                    tbHorarioIda.Margin = new Thickness(-2, 986, 0, 0);
                    tblHorarioVolta.Margin = new Thickness(171, 959, 0, 0);
                    tbHorarioVolta.Margin = new Thickness(160, 986, 0, 0);
                }
            }
        }


        private void percursoRad_B_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            arruma_objetos_horarios();
        }

        private void percursoRad_C_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            arruma_objetos_horarios();
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            arruma_objetos_horarios();
            CarregaPessoa();
        }

    }
}