using EntityLayer.Concrate;
using Grantor.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcessLayer.Concrete
{
  public  class Context:IdentityDbContext<AppUser,AppRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-U9NQ17S;database=GrantorDB; integrated security= true;");


        }
      
        public DbSet<About> Abouts { get; set; }
        public DbSet<Admin> Admins  { get; set; }
        public DbSet<City> Cities  { get; set; }
        public DbSet<Contact> Contacts  { get; set; }
        public DbSet<Donor> Donors  { get; set; }
        public DbSet<Faculty> Faculties  { get; set; }
        public DbSet<Student> Students  { get; set; }
        public DbSet<University> Universities  { get; set; }
        public DbSet<Section> Sections  { get; set; }
        public DbSet<Gallery> Galleries { get; set; }

    }

}
