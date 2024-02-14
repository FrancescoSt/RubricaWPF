using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace stoppa.francesco._4I.rubricaWPF
{
    /// <summary>
      /// Interaction logic for MainWindow.xaml
      /// </summary>
    public partial class MainWindow : Window
    {
        Contatti contatti;
        Persone persone;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void StoppaWindow_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                persone = new Persone("Persone.csv");
                dgPersone.ItemsSource = persone;
                contatti = new Contatti("Contatti.csv");

                StatusBar.Text = $"Ho letto dal file " +
                $"{persone.Count} persone " +
                $"e {contatti.Count} contatti";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }
            
        private void dgDati_LoadingRow(object sender, System.Windows.Controls.DataGridRowEventArgs e)
        {
            Persona p= e.Row.DataContext as Persona;
            if (p.idPersona == 1) // Check if the contact is empty
            {
                e.Row.Background = Brushes.Red;
                e.Row.Background = Brushes.White;

            }

        }
        
    
        private void dgPersone_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Trasformazione da object a Contatto
            Persona p = e.AddedItems[0] as Persona;
            StatusBar.Text = $"{p.Cognome}";

            List<Contatto> ContattiFiiltrati = new List<Contatto>();
            foreach (var item in contatti)
            {
                if (item.idPersona == p.idPersona)
                {
                    ContattiFiiltrati.Add(item);

                    dgContatti.ItemsSource = ContattiFiiltrati;
                     
                }
            }   
        } 
    }
}