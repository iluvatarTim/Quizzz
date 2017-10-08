using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerWPF.Classes
{
    public class Question
    {
        public Question(int id, string intitule, int idReponse)
        {
            Id = id;
            Intitule = intitule;
            IdReponse = idReponse;
        }

        public int Id { get; set; }
        public string Intitule { get; set; }
        public int IdReponse { get; set; }
    }
}
