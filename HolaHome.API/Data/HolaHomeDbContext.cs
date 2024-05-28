using HolaHome.API.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HolaHome.API.Data
{
    public class HolaHomeDbContext: IdentityDbContext<User>
    {
        public HolaHomeDbContext(DbContextOptions<HolaHomeDbContext> options) : base(options) {
        }

    }
}
