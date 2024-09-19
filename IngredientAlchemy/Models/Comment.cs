using System;
using System.Collections.Generic;

namespace IngredientAlchemy.Models;

public partial class Comment
{
    public int CommentId { get; set; }

    public int RecipeId { get; set; }

    public int? UserId { get; set; }

    public string Content { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }

    public virtual Recipe Recipe { get; set; } = null!;

    public virtual User? User { get; set; }
}
