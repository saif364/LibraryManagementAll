﻿using LibraryManagementModels.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace LibraryManagementRepository.DbConfigure
{
    public class LibraryDbContext : IdentityDbContext<ApplicationUser>
    {
       
        public LibraryDbContext(DbContextOptions<LibraryDbContext> options) : base(options)
        {
            
        }
        public DbSet<Library> Librarys { get; set; }
        public DbSet<AuditLog> AuditLogs { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Course> Courses { get; set; }

        //auditTrial
        public DbSet<StudentAuditTrial> StudentAuditTrials { get; set; }

    }
}
