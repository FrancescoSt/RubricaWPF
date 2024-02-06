# rubricaWPF
## Descrizione 
Questo programma scritto in WPF simula e gestisce una rubrica, con una capacità massima 'MAX' Contatti. I dati che vengono visualizzati sono: Nome,Cognome,Numero di telefono, Email.


## File esterni
Per la scrittura delle righe, viene utilizzato un file esterno: "Dati.csv". Da questo file il codice va a leggere le righe, la riga vuota è definita dal colore rosso come sfondo.
Esempio righe:
``` c#
Nome;Cognome;Telefono;Email
Francesco;Stoppa;728678781;francescoadrian.stoppa@studenti.ittsrimini.edu.it
Elettra;Tegon;234567891;elettra.tegon@studenti.ittsrimini.edu.it
```
Da questo esempio qua, ogni blocco della riga è data da un ';': quindi sarà: Nome|Cognome|Telefono|Mail (La divisione delle celle verrà ripetuto in ogni riga).


