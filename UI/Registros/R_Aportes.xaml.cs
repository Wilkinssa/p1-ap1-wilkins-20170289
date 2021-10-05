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
using p1_ap1_wilkins_20170289.BLL;
using p1_ap1_wilkins_20170289.Entidades;

namespace p1_ap1_wilkins_20170289.UI.Registros
{
    public partial class R_Aportes : Window
    {
        private Aportes aportes = new Aportes();
        public R_Aportes()
        {
            InitializeComponent();
            this.DataContext = aportes;
        }
        //Cargar
        private void Cargar()
        {
            this.DataContext = null;
            this.DataContext = aportes;
        }
        //Limpiar
        private void Limpiar()
        {
            this.aportes = new Aportes();
            this.DataContext = aportes;
        }
        //Validar
        private bool Validar()
        {
            bool Validado = true;
            if (AporteIdTextBox.Text.Length == 0)
            {
                Validado = false;
                MessageBox.Show("Transacción Fallida", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            return Validado;
        }
        //Buscar
        private void BuscarButton_Click(object sender, RoutedEventArgs e)
        {
            Aportes encontrado = AportesBLL.Buscar(Convert.ToInt32(AporteIdTextBox.Text));

            if (encontrado != null)
            {
                this.aportes = encontrado;
                Cargar();
            }
            else
            {
                this.aportes = new Aportes();
                this.DataContext = this.aportes;
                MessageBox.Show($"Este aporte no fue encontrado.", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                Limpiar();
                AporteIdTextBox.SelectAll();
                AporteIdTextBox.Focus();
            }
        }
        //——————————————————————————————————————————————————————————————[ Nuevo ]———————————————————————————————————————————————————————————————
        private void NuevoButton_Click(object sender, RoutedEventArgs e)
        {
            Limpiar();
        }
        //Guardar
        private void GuardarButton_Click(object sender, RoutedEventArgs e)
        {
            {
                if (!Validar())
                    return;

                var paso = AportesBLL.Guardar(aportes);
                if (paso)
                {
                    Limpiar();
                    MessageBox.Show("Transacción Exitosa", "Éxito", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                    MessageBox.Show("Transacción Fallida", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        //Eliminar
        private void EliminarButton_Click(object sender, RoutedEventArgs e)
        {
            {
                if (AportesBLL.Eliminar(Convert.ToInt32(AporteIdTextBox.Text)))
                {
                    Limpiar();
                    MessageBox.Show("Registro Eliminado", "Éxito", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                    MessageBox.Show("No se pudo eliminar el registro", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}