using System;
using System.Collections.Generic;

namespace CodeFirstApproach.Models;

public partial class Product
{
    public int Id { get; set; }

    public string? ProductName { get; set; }

    public string? Brand { get; set; }

    public int? Price { get; set; }
}
