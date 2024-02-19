# rubricaWPF
## Descrizione 
Questo programma scritto in WPF gestisce una rubrica, con una capacità massima 'MAX' Contatti. I dati che vengono visualizzati sono: Nome,Cognome,Numero di telefono, Email, Facebook, Instagram.

## File esterni
Viene fatta la lettura dei contatti vengono utilizzati due file.
### Persone.csv
In questo file, vengono caricati e copiati i seguneti campi inseriti: Nome, Cognome.
Esempio:
``` c#
0;Nome;Cognome;
1;Francesco;Stoppa;
2;Elettra;Tegon;
3;Antonio;Vallone;
``` 
### Contatti.csv
In questo file, vengono caricati e copiati i seguneti campi inseriti: idPersona,Tipo,Valore.
Esempio:
``` c#
idPersona;Tipo;Valore;
1;Email;francescoadrian.stoppa@studenti.ittsrimini.edu.it
1;Telefono;123456789
1;facebook;Francesco Stoppa
2;Email;elettra.tegon@studenti.ittsrimini.edu.it
2;telefono;123456789
2;Web;www.elettrategon.it
``` 


