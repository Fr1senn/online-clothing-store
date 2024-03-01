using System;
using System.Collections.Generic;

namespace OnlineClothingStore.Models;

public partial class Order
{
    public int Id { get; set; }

    public DateOnly OrderDate { get; set; }

    public int StatusId { get; set; }

    public int UserId { get; set; }

    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

    public virtual Status Status { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
