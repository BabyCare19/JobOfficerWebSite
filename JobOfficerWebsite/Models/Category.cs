﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JobOfficerWebsite.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        [Display(Name ="نوع الوظيفة")]
        public string CategoryName { get; set; }
        [Required]
        [Display(Name ="وصف الوظيفة")]
        public string CategoryDescription { get; set; }
        public virtual ICollection<Job> jobs { get; set; }

    }
}