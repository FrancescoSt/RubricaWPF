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
        List<Persona> Persone = new List<Persona>();
        List<Contatto> Contatti = new List<Contatto>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void StoppaWindow_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader("Persone.csv");
                sr.ReadLine();

                while (!sr.EndOfStream)
                {
                    string riga = sr.ReadLine();
                    Persona p = new Persona(riga);
                    Persone.Add(p);

                    dgContatti.ItemsSource = Contatti;
                }
            }
            catch(Exception ex)
            {
                
            }
        }
            
            

        

        private void dgDati_LoadingRow(object sender, System.Windows.Controls.DataGridRowEventArgs e)
        {
            Contatto contatto = e.Row.DataContext as Contatto;
            if (contatto != null && contatto.PK == 0) // Check if the contact is empty
            {
                e.Row.Background = Brushes.Red;
                e.Row.Background = Brushes.White;

            }

        }

        //sender serve per capire chi ha scatenato l'evento
        private void dgDati_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Trasformazione da object a Contatto
            Persona p = e.AddedItems[0] as Persona;
        }
    }
}
