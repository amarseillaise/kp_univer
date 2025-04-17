using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Univer.Models
{
    public class UserContext : DbContext
    {
        public UserContext() :
            base("Db")//DB.MDF
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
    }
    public class UserDbInitializer : DropCreateDatabaseAlways<UserContext>
    {
        protected override void Seed(UserContext Db)
        {
            Db.Roles.Add(new Role { Id = 1, Name = "Admin" });
            Db.Roles.Add(new Role { Id = 2, Name = "Prepod" });
            Db.Roles.Add(new Role { Id = 3, Name = "Student" });
            Db.Users.Add(new User
            {
                Id = 1,
                Login = "Admin_01",
                Password = "12345678",
                RoleId = 1
            });
            base.Seed(Db);
        }
    }
}