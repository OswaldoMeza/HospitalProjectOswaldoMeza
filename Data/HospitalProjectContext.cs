using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.ComponentModel.DataAnnotations.Schema;
//using Emergency.Models;
using System.ComponentModel.DataAnnotations;

namespace HospitalProject.Data
{
    public class HospitalProjectContext : DbContext
    {

        public HospitalProjectContext() : base("name=HospitalProjectContext")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<HospitalProjectContext>());
        }

        public System.Data.Entity.DbSet<HospitalProject.Models.Emergency> Emergency { get; set; }

        public System.Data.Entity.DbSet<HospitalProject.Models.Appointment> Appointments { get; set; }
    }

}
