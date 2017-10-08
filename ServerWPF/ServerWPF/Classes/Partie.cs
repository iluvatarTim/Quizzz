using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerWPF.Classes
{
    public class Partie
    {
        public Partie(int id, string type, List<Question> listeQuestion)
        {
            Id = id;
            Type = type;
            ListeQuestion = listeQuestion;
        }

        public int Id { get; set; }
        public string Type { get; set; }
        public List<Question> ListeQuestion { get; set; }
    }
}
