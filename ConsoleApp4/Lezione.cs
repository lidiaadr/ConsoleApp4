using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Lezione
    {
        public string Descrizione { get; set; }
        public DateTime Data { get; set; }
        public TimeSpan OrarioInizio { get; set; }
        public TimeSpan Durata { get; set; }
        public string Docente { get; set; }
        public string Aula { get; set; }
        public List<Studente> Presenti { get; set; }

        public void RegistraAssenti (Studente studente)
        {
            foreach (var item in Presenti) //item, alunno che ha appena chiesto 
            {
                if (item == null)
                {
                    Presenti.Remove(studente);
                }
            }

            
        }

    }
}
