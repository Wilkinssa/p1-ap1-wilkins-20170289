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
using p1_ap1_wilkins_20170289.UI.Registros;
using p1_ap1_wilkins_20170289.UI.Consultas;

namespace p1_ap1_wilkins_20170289
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RegistrarButton_Click(object sender, RoutedEventArgs e)
        {
            R_Aportes R_Aportes = new R_Aportes();
            R_Aportes.Show();
        }

        private void ConsultarButton_Click(object sender, RoutedEventArgs e)
        {
            C_Aportes C_Aportes = new C_Aportes();
            C_Aportes.Show();
        }
    }
}