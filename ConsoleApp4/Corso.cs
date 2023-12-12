using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Corso
    {
        public string Nome { get; set; }
        public int Edizione { get; set; }
        public List<Lezione> Lezioni { get; set; }
        public List<Studente> Studenti { get; set; }
        public List<Corso> ListaCorsi { get; set; }

        public Corso (string nome, int edizione)
        {
            Nome = nome;
            Edizione = edizione;
        }
        public void AggiungiLezione (Lezione lezione)
        {
            Lezioni.Add(lezione);
        }
        public void AggiungiStudenti (Studente studente)
        {
            Studenti.Add(studente);
        }
    }
}
