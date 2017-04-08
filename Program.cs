using System;
using System.Numerics;

namespace UnicamFattoriale
{
    class Program
    {
        static void Main(string[] args)
        {
            //Stampo dei messaggi di cortesia per l'utente, così lo guido all'utilizzo del programma
            Console.WriteLine("Questo programma calcola il fattoriale di un numero");
            
            
            Console.Write("Digita un numero intero e premi invio: ");

            //Console.ReadLine si mette in attesa che l'utente digiti qualcosa e prema invio.
            //Quando ha premuto invio, il testo che ha digitato lo assegno ad una variabile di tipo string.
            string testoDigitatoDallUtente = Console.ReadLine();
            
            //Interpreto il testo come un numero intero
            //Attenzione: questa istruzione fallirà se l'utente ha digitato un testo
            //che non è interpretabile come un numero! (Es. ABCD)
            bool controlloVariabileInt = false;
            while(controlloVariabileInt = int.TryParse(testoDigitatoDallUtente, out int numero )){

                BigInteger risultato = numero;            
                int i = numero-1;            
                if(numero!=0){
                    while (i > 0) {
                        risultato *= i;
                        i--;                                
                    }
                }
                else{
                    risultato = 1;
                }
                //Stampo il risultato
                Console.WriteLine($"Il fattoriale di {numero} e' {risultato}");

                Console.Write("Digita un numero intero e premi invio: ");

                testoDigitatoDallUtente = Console.ReadLine();
            }
            if(!controlloVariabileInt)
                Console.WriteLine("Spiacente, non posso calcolare il fattoriale per questo valore.");
            //Attendo che l'utente prema un tasto prima di uscire, altrimenti 
            Console.ReadKey();
        }
    }
}
