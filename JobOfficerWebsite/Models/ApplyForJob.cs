using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JobOfficerWebsite.Models
{
    public class ApplyForJob
    {
        [Key]
        public int Id { get; set; }
        public string Message { get; set; }
        public DateTime ApplyDate { get; set; }
        //add id  job& id user (realationship Many to many)
        //create prop from job & user (from calss that represent from class Applicationuser)
        
        public int JobId { get; set; }
        public string  UserId { get; set; }
        //[ForeignKey("Id")]
        public virtual  Job   job { get; set; }
        //[ForeignKey("JobId")]
       public virtual  ApplicationUser user { get; set; }
    }
}