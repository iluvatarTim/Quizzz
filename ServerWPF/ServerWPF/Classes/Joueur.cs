using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerWPF.Classes
{
    public class Joueur
    {
        public Joueur(int id, string nom, int score)
        {
            this.Id = id;
            this.Nom = nom;
            this.Score = score;
        }

        public int Id { get; set; }
        public string Nom { get; set; }
        public int Score { get; set; }

        public override string ToString()
        {
            return "Nom: " + Nom + Environment.NewLine + "Score: " + Score; 
        }
    }
}
