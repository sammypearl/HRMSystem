using Application.Common;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Persistence
{
    public class HRMContext : DbContext
    {
        public HRMContext(DbContextOptions<HRMContext> options) : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmpAttachment> EmpAttachments { get; set; }

        public DbSet<EmpCertificate> EmpCertificates { get; set; }
        public DbSet<EmpEducation> EmpEducations { get; set; }


        public DbSet<EmpEmergCall> EmpEmergCalls { get; set; }

        public DbSet<EmpLanguage> EmpLanguages { get; set; }

        public DbSet<EmpProject> EmpProjects { get; set; }

        public DbSet<EmpQuit> EmpQuits { get; set; }

        public DbSet<EmpTechSkill> EmpTechSkills { get; set; }

        public DbSet<EmpTraining> EmpTrainings { get; set; }

        //public void SaveChanges(CancellationToken cancellationToken)
        //{
        //    throw new NotImplementedException();
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(HRMContext).Assembly);

            

        }

    }
}
