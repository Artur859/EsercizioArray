using System;
using System.Collections.Generic;

namespace EsercizioArray
{
    public class Citta
    {
        public string _nome;
        public int _numeroabitantiAllmax;
        public List<Cittadino> _listCittadini = new();
        public Citta(string nome, int numeroabitantiAllmax)
        {
            _nome = nome;
            _numeroabitantiAllmax = numeroabitantiAllmax;
        }

        public void AggiungiCittadino(Cittadino nuovoCittadino)
        {
            if (_listCittadini.IndexOf(nuovoCittadino) == -1 && _listCittadini.Count < _numeroabitantiAllmax)
            {
                _listCittadini.Add(nuovoCittadino);
                Console.WriteLine("Cittadini : " + _listCittadini.Count);
                Console.WriteLine("Spazio disponibile: " + (_numeroabitantiAllmax - _listCittadini.Count));
            }
            else
            {
                Console.WriteLine("La città è al massimo ");
            }
        }
    }
}
