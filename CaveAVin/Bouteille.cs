using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CaveAVin.Models
{
    public partial class Bouteille
    {
        public bool EstApogee()
        {
            int anneeActuelle = DateTime.Now.Year;
            int anneeFinApogee = Millesime + AnneeGardeMax;

            // Vérifie si l'année actuelle est entre l'année de début et de fin de l'apogée
            return anneeActuelle >= (Millesime + AnneeGardeMin) && anneeActuelle <= anneeFinApogee;
        }

        public List<string> ToCsvRow()
        {
            return new List<string>
            {
                NomComplet,
                Millesime.ToString(),
                AnneeGardeMin.ToString(),
                AnneeGardeMax.ToString(),
                NumTiroir.ToString(),
                NumEmplacement.ToString(),
                IdCouleurNavigation.Nom,
                IdAppellationNavigation.Nom
            };
        }
    }
}
