using System;
using System.Collections.Generic;

namespace DrugShop222;

public partial class Payment
{
    public string PaymentId { get; set; } = null!;

    public string? Cash { get; set; }

    public string? Card { get; set; }

    public int? OrderId { get; set; }

    public virtual Order? Order { get; set; }
}
