using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediateq_AP_SIO2.metier
{
    /// <summary>
    /// Représente une parution d'une revue.
    /// </summary>
     class Parution
    {
        private int numero;
        private DateTime dateParution;
        private string photo;
        private string idRevue;

        /// <summary>
        /// Initialise une nouvelle instance de la classe Parution avec les valeurs spécifiées.
        /// </summary>
        /// <param name="numero"></param>
        /// <param name="dateParution"></param>
        /// <param name="photo"></param>
        /// <param name="idRevue"></param>
        public Parution(int numero, DateTime dateParution, string photo, string idRevue)
        {
            this.numero = numero;
            this.dateParution = dateParution;
            this.photo = photo;
            this.idRevue = idRevue;
        }

        /// <summary>
        /// Obtient ou définit le numéro de la parution.
        /// </summary>
        public int Numero { get => numero; set => numero = value; }

        /// <summary>
        /// Obtient ou définit la date de parution.
        /// </summary>
        public DateTime DateParution { get => dateParution; set => dateParution = value; }

        /// <summary>
        /// Obtient ou définit le chemin de la photo associée à la parution.
        /// </summary>
        public string Photo { get => photo; set => photo = value; }

        /// <summary>
        /// Obtient ou définit l'identifiant de la revue associée à la parution.
        /// </summary>
        public string IdRevue { get => idRevue; set => idRevue = value; }
    }

}
