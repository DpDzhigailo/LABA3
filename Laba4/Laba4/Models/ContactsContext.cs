using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laba4.Models
{
    public class ContactsContext : DbContext
    {
        public DbSet<Contact> Contacts { get; set; }
        public ContactsContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=ADCLG1;Database=Lab44;Trusted_Connection=True;");
        }
    }
}
