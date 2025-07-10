using Microsoft.AspNetCore.Identity;

namespace MovieApi.Persistence.Identity
{
    public class AppUser : IdentityUser
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string? ImageUrl { get; set; }
    }
}
