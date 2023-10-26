using System;
using System.Collections.Generic;

namespace CaveAVin.Models;

public partial class Fabricant
{
    public int IdFabricant { get; set; }

    public string Nom { get; set; } = null!;

    public virtual ICollection<Cave> Caves { get; set; } = new List<Cave>();
}
