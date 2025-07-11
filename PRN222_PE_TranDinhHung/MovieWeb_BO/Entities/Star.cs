﻿using System;
using System.Collections.Generic;

namespace MovieWeb_BO.Entities;

public partial class Star
{
    public int Id { get; set; }

    public string FullName { get; set; } = null!;

    public bool? Male { get; set; }

    public DateOnly? Dob { get; set; }

    public string? Description { get; set; }

    public string? Nationality { get; set; }

    public virtual ICollection<Movie> Movies { get; set; } = new List<Movie>();
}
