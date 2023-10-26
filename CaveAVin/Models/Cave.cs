using System;
using System.Collections.Generic;

namespace CaveAVin.Models;

public partial class Cave
{
    public int IdCave { get; set; }

    public string Designation { get; set; } = null!;

    public int NbTiroirs { get; set; }

    public int NbBouteillesParTiroir { get; set; }

    public decimal TemperatureFonctionnement { get; set; }

    public int? IdFabricant { get; set; }

    public int? IdFamille { get; set; }

    public int? IdUtilisateur { get; set; }

    public virtual ICollection<Bouteille> Bouteilles { get; set; } = new List<Bouteille>();

    public virtual Fabricant? IdFabricantNavigation { get; set; }

    public virtual Famille? IdFamilleNavigation { get; set; }

    public virtual Utilisateur? IdUtilisateurNavigation { get; set; }
}
