using System;
using System.Collections.Generic;

namespace CaveAVin.Models;

public partial class Famille
{
    public int IdFamille { get; set; }

    public string Nom { get; set; } = null!;

    public virtual ICollection<Cave> Caves { get; set; } = new List<Cave>();
}
