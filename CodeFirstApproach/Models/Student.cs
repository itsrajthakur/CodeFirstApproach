using System;
using System.Collections.Generic;

namespace CodeFirstApproach.Models;

public partial class Student
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int Standerd { get; set; }

    public string Contact { get; set; } = null!;
}
