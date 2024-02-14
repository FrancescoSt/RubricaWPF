using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace stoppa.francesco._4I.rubricaWPF
{
    public class Persona
    {
        public int idPersona { get; set; }
        public TipoContatto Tipo { get; set; }
        public string Nome { get; set; }
        public object Cognome { get; internal set; }

        public Persona(string riga)
        {
            string[] campi = riga.Split(';');

            if (campi.Count() != 3)
            {
                throw new Exception("Le righe devono essere di tre colonne");
            }

            //Conversione da stringa a intero
            int id = 0;
            int.TryParse(campi[0], out id);
            idPersona = id;

            this.Nome = campi[1];
            this.Cognome = campi[2];

        }
    }

    public class Persone : List<Persona>
    {
        public Persone() { }

        public Persone(string nomeFile)
        {
            StreamReader sr = new StreamReader("Persone.csv");
            sr.ReadLine();

            while (!sr.EndOfStream)
            {
                base.Add(new Persona(sr.ReadLine()));

                sr.Close();
            }


        }
    }
}
