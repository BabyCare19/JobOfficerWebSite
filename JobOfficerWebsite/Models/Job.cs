using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JobOfficerWebsite.Models
{
    public class Job
    {
       
        public int Id { get; set; }
        [DisplayName("اسم الوظيفة")]
        public string JobTitle { get; set; }
        [DisplayName("وصف الوظيفة")]
        [AllowHtml]
        public string JobContent { get; set; }
        [DisplayName("صورة الوظيفة")]
        public string JobImage { get; set; }

        [DisplayName("نوع الوظيفة")]
        [ForeignKey("catId")]
        public Category category { get; set; }
        public int catId { get; set; }
        public string UserID { get; set; }
        public virtual ApplicationUser User { get; set; }

        //public ICollection<Job> jobs { get; set; }
    }
}