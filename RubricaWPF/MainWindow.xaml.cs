using System;
using System.Collections.Generic;
using System.IO;
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

namespace stoppa.francesco._4I.rubricaWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void StoppaWindow_Loaded(object sender, RoutedEventArgs e)
        {

            const int MAX = 100;
            int idx = 0;

            try
            {
                StreamReader sr = new StreamReader("Dati.csv");
                sr.ReadLine();
                string riga = string.Empty;

                Contatto[] Contatti = new Contatto[MAX];
                //for (int i = 0; i < Contatti.Length; i

                while (!sr.EndOfStream && idx < MAX)
                {

                    riga = sr.ReadLine();
                    Contatto c = new Contatto(riga);
                    Contatti[idx++] = new Contatto(riga);
                }
                while (idx < MAX)
                {
                    Contatti[idx++] = new();
                }
            

                idx = 0;
                dgDati.ItemsSource = Contatti;
                /*for(; idx < MAX; idx++)
                {
                    Contatti[idx++] = new Contatto();
                }
                */
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("No no!!\n" + ex.Message);
            }

            private void dgDati_LoadingRow(object sender, System.Windows.Controls.DataGridRowEventArgs e)
            {
                Contatto prova = e.Row.DataContext as Contatto;
                if(prova != null && prova.PK == 0)
                {
                    e.Row.Background = Brushes.Red;
                    e.Row.Foreground = Brushes.White;
                }
            }



            /*
            try
            {
                Contatto c = new Contatto();
                c.Numero = 1;
                c.Nome = "Maurizio";
                c.Cognome = "Conti";
                c.EMail = "maurizio.conti@ittsrimini.edu.it";
                c.Telefono = "3337722";
                c.CAP = "47923";

                Contatti[0] = c;

                Contatto c1 = new Contatto { Numero = 2, Nome = "Riccardo", Cognome = "Bianchi" };
                Contatti[0] = c1;

                Contatto c2 = new Contatto(2, "Antonio", "Vallone");
                Contatti[2] = c2;

                Contatto c3 = new Contatto(2, "Antonio", "Vallone");
                Contatti[2] = c3;


            }
            catch (Exception err)
            {
                MessageBox.Show("No no!!\n" + err.Message);
            }
            */


        }


    }
    }
