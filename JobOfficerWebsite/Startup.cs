using JobOfficerWebsite.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JobOfficerWebsite.Startup))]
namespace JobOfficerWebsite
{
    public partial class Startup
    {
        private ApplicationDbContext context = new ApplicationDbContext();
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            CreateDefaultRolesAndUser();
        }
        public void CreateDefaultRolesAndUser()
        {
            var roleManger = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            var userManger = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            IdentityRole role = new IdentityRole();
            if(! roleManger.RoleExists("Admins"))
            {
                role.Name = "Admins";
                roleManger.Create(role);
                ApplicationUser user = new ApplicationUser();
                user.UserName = "folan22";
                user.Email = "folan33@gmail.com";
                var Check = userManger.Create(user, "Folan123@");
                if(Check.Succeeded)
                {
                    userManger.AddToRole(user.Id, "Admins");
                }
            }


        }
    }
}
