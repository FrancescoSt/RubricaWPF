﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stoppa.francesco._4I.rubricaWPF
{
    public class Persona
    {
        public int idPersona { get; set; }
        public TipoContatto Tipo { get; set; }
        public string Valore { get; set; }
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

            this.Valore = campi[2];

        }
    }
}
