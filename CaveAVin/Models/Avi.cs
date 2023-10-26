using System;
using System.Collections.Generic;

namespace CaveAVin.Models;

public partial class Avi
{
    public int IdAvis { get; set; }

    public int Note { get; set; }

    public string Texte { get; set; } = null!;

    public int? IdBouteille { get; set; }

    public int? IdUtilisateur { get; set; }

    public virtual Bouteille? IdBouteilleNavigation { get; set; }

    public virtual Utilisateur? IdUtilisateurNavigation { get; set; }
}
