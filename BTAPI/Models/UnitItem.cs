using System;
using System.Collections.Generic;

namespace BTAPI.Models;

public partial class UnitItem
{
    public int Id { get; set; }

    public int? UnitId { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public int? Conversion { get; set; }

    public virtual Unit? Unit { get; set; }
}
