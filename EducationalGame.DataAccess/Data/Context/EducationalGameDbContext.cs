using EducationGame.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EducationalGame.DataAccess.Data.Context
{
    public class EducationalGameDbContext :DbContext
    {
        public EducationalGameDbContext(DbContextOptions<EducationalGameDbContext> options) : base(options)
        {

        }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        public DbSet<ContactInfo> ContactInfos { get; set; }

        public DbSet<Email> Emails { get; set; }
    }
}
