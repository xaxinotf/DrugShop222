﻿using System;
using System.Collections.Generic;

namespace DrugShop222;

public partial class ShipType
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public virtual ICollection<Order> Orders { get; } = new List<Order>();
}
