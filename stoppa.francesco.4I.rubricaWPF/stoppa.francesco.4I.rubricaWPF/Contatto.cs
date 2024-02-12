using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace stoppa.francesco._4I.rubricaWPF
{
    public enum TipoContatto { nessuno, Email, Telefono, Web, Instagram, Facebook }
    internal class Contatto { 
    
        public int idPersona { get; set; }
        public TipoContatto Tipo { get; set; }
        public string Valore { get; set; }

        private string _cognome;

        private int _numero;
        public int PK;

        public int Numero
        {
            get
            {
                return _numero;
            }

            set
            {
                if (value < 0 || value > 100)
                    throw new ArgumentOutOfRangeException();

                _numero = value;
            }
        }

        public string Nome { get; set; }
        public string EMail { get; set; }
        public string Telefono { get; set; }
        public string Cognome { get => _cognome; set => _cognome = value; }

        public Contatto() 
        {
            Tipo = TipoContatto.nessuno;
        }

        //Costruisce un contatto, partendo da un csv
        public Contatto(string riga) 
        {
            string[] campi = riga.Split( ';' );

            if (campi.Count() != 3)
            {
                throw new Exception("Le righe devono essere di tre colonne");
            }

            //da stringa a intero
            int id = 0;
            int.TryParse(campi[0], out id);
            idPersona = id;

            
            //Conversione da stringa a enum
            TipoContatto c;
            Enum.TryParse(campi[1], out c);
            this.Tipo = c;

            this.Valore = campi[2];

            }
           

        }


        /*public (int numero, string nome, string cognome)
        {
        this.numero = numero;
        }
        */
    }



