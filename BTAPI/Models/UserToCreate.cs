using System;
using System.Collections.Generic;

namespace BTAPI.Models;

public partial class UserToCreate
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string? LastName { get; set; }

    public string? PhoneNumber1 { get; set; }

    public string? PhoneNumber2 { get; set; }

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string? ConfirmPassword { get; set; }
    public object PasswordHash { get; internal set; }
}
