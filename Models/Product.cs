using System;
using System.Collections.Generic;

namespace OnlineClothingStore.Models;

public partial class Product
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public decimal Price { get; set; }

    public int? Rating { get; set; }

    public int ManufacturerId { get; set; }

    public int CategoryId { get; set; }

    public int DiscountId { get; set; }

    public virtual Category Category { get; set; } = null!;

    public virtual Discount Discount { get; set; } = null!;

    public virtual Manufacturer Manufacturer { get; set; } = null!;

    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

    public virtual ICollection<Review> Reviews { get; set; } = new List<Review>();

    public virtual ICollection<WishList> WishLists { get; set; } = new List<WishList>();
}
