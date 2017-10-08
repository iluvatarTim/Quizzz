using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerWPF.Classes
{
    public class Reponse
    {
        public Reponse(int id, string intitule, bool isReponse, int idQuestion)
        {
            Id = id;
            this.intitule = intitule;
            IsReponse = isReponse;
            IdQuestion = idQuestion;
        }

        public int Id { get; set; }
        public string intitule { get; set; }
        public bool IsReponse { get; set; }
        public int IdQuestion { get; set; }
    }
}
