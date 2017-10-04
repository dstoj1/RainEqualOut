using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;
using RainEqualsOut.Models;

[assembly: OwinStartupAttribute(typeof(RainEqualsOut.Startup))]
namespace RainEqualsOut
{
    public partial class Startup
    {
        ApplicationDbContext context;

        public void Configuration(IAppBuilder app)
        {
            context = new ApplicationDbContext();
            ConfigureAuth(app);
            CreateRoles();
        }

        private void CreateRoles()
        {
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));

            if (!roleManager.RoleExists("Admin"))
            {
                var role = new IdentityRole();
                role.Name = "Admin";
                roleManager.Create(role);
            }

            if (!roleManager.RoleExists("Customer"))
            {
                var role = new IdentityRole();
                role.Name = "Customer";
                roleManager.Create(role);
            }
        }
    }
}
