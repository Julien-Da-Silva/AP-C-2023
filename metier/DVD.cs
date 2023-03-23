﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediateq_AP_SIO2.metier
{
    class DVD : Document
    {
        private string synopsis;
        private string realisateur;
        private int duree;


        public DVD(string unId, string unTitre, string unSynopsis, string unRealisateur, int uneDuree, string uneImage, Categorie uneCategorie ) : base(unId, unTitre, uneImage, uneCategorie)
        {
            Synopsis = unSynopsis;
            Realisateur = unRealisateur;
            Duree = uneDuree;
        }

        public string Synopsis { get => synopsis; set => synopsis = value; }
        public string Realisateur { get => realisateur; set => realisateur = value; }
        public int Duree { get => duree; set => duree = value; }
    }
}
