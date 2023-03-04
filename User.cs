using System;
using System.Collections.Generic;

namespace DrugShop222;

public partial class User
{
    public int UserId { get; set; }

    public string Name { get; set; } = null!;

    public string Surname { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Workaddress { get; set; } = null!;

    public string Homeaddress { get; set; } = null!;

    public int? OrderId { get; set; }

    public virtual ICollection<Order> Orders { get; } = new List<Order>();
}
