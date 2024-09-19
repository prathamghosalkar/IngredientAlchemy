using System;
using System.Collections.Generic;

namespace IngredientAlchemy.Models;

public partial class Recipe
{
    public int RecipeId { get; set; }

    public string Title { get; set; } = null!;

    public string Type { get; set; } = null!;

    public int CategoryId { get; set; }

    public int AdminId { get; set; }

    public byte[]? ImageData { get; set; }

    public string Ingredients { get; set; } = null!;

    public string Steps { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Admin Admin { get; set; } = null!;

    public virtual Category Category { get; set; } = null!;

    public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();

    public virtual ICollection<Rating> Ratings { get; set; } = new List<Rating>();
}
