using System;
using System.Collections.Generic;

namespace IngredientAlchemy.Models;

public partial class Rating
{
    public int RatingId { get; set; }

    public int RecipeId { get; set; }

    public int? UserId { get; set; }

    public int Rating1 { get; set; }

    public DateTime? CreatedAt { get; set; }

    public virtual Recipe Recipe { get; set; } = null!;

    public virtual User? User { get; set; }
}
