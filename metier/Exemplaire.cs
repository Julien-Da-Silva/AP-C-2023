using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediateq_AP_SIO2.metier
{
    class Exemplaire
    {
        private string idDoc;
        private string numero;
        private DateTime dateAchat;
        private string idRayon;
        private string idEtat;

        public Exemplaire(string idDoc, string numero, DateTime dateAchat, string idRayon)
        {
            this.idDoc = idDoc;
            this.numero = numero;
            this.dateAchat = dateAchat;
            this.idRayon = idRayon;
        }

        public string IdDoc { get => idDoc; set => idDoc = value; }
        public string Numero { get => numero; set => numero = value; }
        public DateTime DateAchat { get => dateAchat; set => dateAchat = value; }
        public string IdRayon { get => idRayon; set => idRayon = value; }
        public string IdEtat { get => idEtat; set => idEtat = value; }


    }
}
