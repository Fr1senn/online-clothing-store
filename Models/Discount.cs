using System;
using System.Collections.Generic;

namespace OnlineClothingStore.Models;

public partial class Discount
{
    public int Id { get; set; }

    public int Percentage { get; set; }

    public DateOnly BeginDate { get; set; }

    public DateOnly EndDate { get; set; }

    public bool IsAcitive { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
