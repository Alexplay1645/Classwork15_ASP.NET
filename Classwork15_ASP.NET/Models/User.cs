using Microsoft.AspNetCore.Identity;

namespace Classwork15_ASP.NET.Models
{
    public class User : IdentityUser
    {
        public int PulicationsCount { get; set; }
        public string? Name { get; set; }
    }
}
