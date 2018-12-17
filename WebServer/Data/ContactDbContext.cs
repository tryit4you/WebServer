using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebServer.Data.Models;

namespace WebServer.Data
{
    public class ContactDbContext:DbContext
    {
        public ContactDbContext(DbContextOptions options) : base(options) { }
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Answer> Answers { get; set; }
        public virtual DbSet<Question> Questions { get; set; }

    }
}
