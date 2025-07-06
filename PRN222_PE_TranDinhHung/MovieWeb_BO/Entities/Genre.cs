using System;
using System.Collections.Generic;

namespace MovieWeb_BO.Entities;

public partial class Genre
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public virtual ICollection<Movie> Movies { get; set; } = new List<Movie>();
}
