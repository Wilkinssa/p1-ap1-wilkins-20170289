using System;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Collections.Generic;
using p1_ap1_wilkins_20170289.BLL;
using p1_ap1_wilkins_20170289.Entidades;

namespace p1_ap1_wilkins_20170289.UI.Consultas
{
    public partial class C_Aportes : Window
    {
        public C_Aportes()
        {
            InitializeComponent();
            DatosDataGrid.ItemsSource = AportesBLL.GetList(c => true);
        }
        private void ConsultarButton_Click(object sender, RoutedEventArgs e)
        {
            var listado = new List<Aportes>();

            if (CriterioTextBox.Text.Trim().Length > 0)
            {
                switch (FiltroComboBox.SelectedIndex)
                {
                    case 0:
                        try
                        {
                            listado = AportesBLL.GetList(c => c.Persona.ToLower().Contains(CriterioTextBox.Text.ToLower()));
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("Debes ingresar un Critero valido para aplicar este filtro.", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
                        }
                        break;
                    //———————————————————————————————————————————————————[ Filtro — Nombre ]———————————————————————————————————————————————————
                    case 1:
                        try
                        {
                            listado = AportesBLL.GetList(c => c.Concepto.ToLower().Contains(CriterioTextBox.Text.ToLower()));
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("Debes ingresar un Critero valido para aplicar este filtro.", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
                        }
                        break;
                }
            }
            else
            {
                listado = AportesBLL.GetList(c => true);
            }

            if (DesdeDatePicker.SelectedDate != null)
            listado = AportesBLL.GetList(c => c.Fecha.Date >= DesdeDatePicker.SelectedDate);

            if (HastaDatePicker.SelectedDate != null)
            listado = AportesBLL.GetList(c => c.Fecha.Date <= HastaDatePicker.SelectedDate);

            DatosDataGrid.ItemsSource = null;
            DatosDataGrid.ItemsSource = listado;
        }

        private void ConteoTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            ConteoTextBox.Text = Convert.ToString(DatosDataGrid.Columns.Count);
        }
    }
}
