using System;
using System.Collections.Generic;

namespace BTAPI.Models;

public partial class UserForLogin
{
    public int Id { get; set; }

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;
}
