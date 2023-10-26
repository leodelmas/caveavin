using System;
using System.Collections.Generic;

namespace CaveAVin.Models;

public partial class Appellation
{
    public int IdAppellation { get; set; }

    public string Nom { get; set; } = null!;

    public virtual ICollection<Bouteille> Bouteilles { get; set; } = new List<Bouteille>();
}
