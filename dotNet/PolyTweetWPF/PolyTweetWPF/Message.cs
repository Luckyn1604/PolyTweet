using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyTweetWPF
{
    public class Message
    {
        public long id { get; set; }
        public string auteur { get; set; }
        public string date { get; set; }
        public string texte { get; set; }
        public Message(string auteur, string date, string texte)
        {
            id = 0;
            this.auteur = auteur;
            this.texte = texte;
            this.date = date;
        }
        public Message(long id, string auteur, string date, string texte)
        {
            this.id = id;
            this.auteur = auteur;
            this.texte = texte;
            this.date = date;
        }
    }
}
