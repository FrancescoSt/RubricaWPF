using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace stoppa.francesco._4I.rubricaWPF
{
    internal class Contatto
    {
        private int _PK;
        private int _numero;
        private string _cognome;

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
        public string Citta { get; set; }
        public string CAP { get; set; }

        public string Cognome { get => _cognome; set => _cognome = value; }

        public int PK { get => this._PK; set => _PK = value; }

        public Contatto() { }

        //Costruisce un contatto, partendo da un csv
        public Contatto(string riga) 
        {
            string[] campi = riga.Split( ';' );
            if(campi.Length > 5)
            {
                if (int.TryParse(campi[0], out int res))
                {
                    this.PK = res;
                    this.Nome = campi[1];
                    this.Cognome = campi[2];
                    this.Telefono = campi[3];
                    this.EMail = campi[4];
                }
            }
           
        }

        public Contatto(int numero, string nome, string cognome)
        {
            Numero = numero;
            Nome = nome;
            Cognome = cognome;
        }

    }

}
