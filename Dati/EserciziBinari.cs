using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dati
{
    class EserciziBinari
    {
        static void Main(string[] args)
        {
            int a = int.MaxValue;
            Console.WriteLine(a);//Qui stampa il numero Max di 2.147.483.647;
            while (a != int.MaxValue)
            {
                Console.WriteLine(a + 1);//Qui esecuzionesi rova in stackoverflow,quindi da come risultato il suo reciproco aggiungendo 1(-);
            }
            int b = -128;//Valore assegnato alla variabile b;
            int c = -b;//Valore assegnato dovrà essere l' opposto alla variabile b;
            Console.WriteLine(Convert.ToString(b, 2));//Valore b converito in binario;
            Console.WriteLine(Convert.ToString(c, 2));//valore c convertito in binario;
            Console.WriteLine("Inserisci un numero intero: ");
            int value = int.Parse(Console.ReadLine());
            int somma = value;
            value = ~value + 1; //NOT
            //value=value+1;
            somma = somma + value;
            Console.WriteLine($"l'opposto del numero inserito{value} e la somma tra value + somma(tra numero inserito e quello opposto){somma}");
            long number = 55555;
            Console.WriteLine(Convert.ToString(number, 2));//Il numero(number) viene convertito in binario;
            short number1 = (short)number;//poi da tipo long viene trasformato a tipo short;
            Console.WriteLine(number1);//viene letto il numero;
            Console.ReadLine();


        }
    }
}
