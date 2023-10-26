using System;
using System.Collections.Generic;

namespace CaveAVin.Models;

public partial class Bouteille
{
    public int IdBouteille { get; set; }

    public string NomComplet { get; set; } = null!;

    public int Millesime { get; set; }

    public int AnneeGardeMin { get; set; }

    public int AnneeGardeMax { get; set; }

    public int NumTiroir { get; set; }

    public int NumEmplacement { get; set; }

    public int? IdCouleur { get; set; }

    public int? IdAppellation { get; set; }

    public int? IdCave { get; set; }

    public virtual ICollection<Avi> Avis { get; set; } = new List<Avi>();

    public virtual Appellation? IdAppellationNavigation { get; set; }

    public virtual Cave? IdCaveNavigation { get; set; }

    public virtual Couleur? IdCouleurNavigation { get; set; }
}
