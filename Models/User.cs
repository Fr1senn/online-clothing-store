using System;
using System.Collections.Generic;

namespace OnlineClothingStore.Models;

public partial class User
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public DateOnly BirthDate { get; set; }

    public DateOnly? RegistrationDate { get; set; }

    public string Email { get; set; } = null!;

    public string? Address { get; set; }

    public string HashedPassword { get; set; } = null!;

    public int RoleId { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    public virtual ICollection<Review> Reviews { get; set; } = new List<Review>();

    public virtual Role Role { get; set; } = null!;

    public virtual ICollection<WishList> WishLists { get; set; } = new List<WishList>();
}
