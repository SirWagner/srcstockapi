using System;
using System.Collections.Generic;

namespace BTAPI.Models;

public partial class Unit
{
    public int Id { get; set; }

    public string? Base { get; set; }

    public string? Sale { get; set; }

    public string? Purchase { get; set; }

    public virtual ICollection<UnitItem> UnitItems { get; set; } = new List<UnitItem>();
}
