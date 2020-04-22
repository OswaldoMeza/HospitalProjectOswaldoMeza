using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using DHTMLX.Scheduler;

namespace HospitalProject.Models
{
    public class Appointment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DHXJson(Alias = "id")]
        public int Id { get; set; }
        [DHXJson(Alias = "start_date")]
        public DateTime StartDate { get; set; }
        [DHXJson(Alias = "end_date")]
        public DateTime EndDate { get; set; }
        [DHXJson(Alias = "text")]
        public string Time { get; set; }

///////Doctor, Patient and Description are foreign keys to other tables created by the other members./////////
        [DHXJson(Alias = "text")]
        public string Doctor { get; set; }
        //public ICollection<Account> Doctors { get; set; }
        [DHXJson(Alias = "text")]
        public string Patient { get; set; }
        //public ICollection<Account> Patient { get; set; }
        [DHXJson(Alias = "text")]
        public string Description { get; set; }
        //public ICollection<Service> Service { get; set; }

    }
}