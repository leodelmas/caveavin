using System;
using System.Collections.Generic;

namespace CaveAVin.Models;

public partial class Utilisateur
{
    public int IdUtilisateur { get; set; }

    public string Email { get; set; } = null!;

    public string MotDePasse { get; set; } = null!;

    public virtual ICollection<Avi> Avis { get; set; } = new List<Avi>();

    public virtual ICollection<Cave> Caves { get; set; } = new List<Cave>();
}
