using System;

namespace EsercizioArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Citta Bassano = new("Bassano", 40000);
            Cittadino Artur = new("Artur", "Gusuila", Bassano);
            Bassano.AggiungiCittadino(Artur);
            Console.WriteLine(Bassano._listCittadini);

        }
    }
}
