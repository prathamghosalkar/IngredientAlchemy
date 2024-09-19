using System;
using System.Collections.Generic;

namespace IngredientAlchemy.Models;

public partial class Category
{
    public int CategoryId { get; set; }

    public string Name { get; set; } = null!;

    public byte[]? ImageCategory { get; set; }

    public virtual ICollection<Recipe> Recipes { get; set; } = new List<Recipe>();
}
