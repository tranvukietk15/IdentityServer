using System;
using Microsoft.AspNetCore.Identity;

namespace IdentityServer.Models
{
    /// <summary>
    /// Custom role id string to guid 
    /// </summary>
    public class Role : IdentityRole<Guid>
    {
    }
}
