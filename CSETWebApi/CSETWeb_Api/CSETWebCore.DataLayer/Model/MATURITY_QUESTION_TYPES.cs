﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CSETWebCore.DataLayer.Model
{
    public partial class MATURITY_QUESTION_TYPES
    {
        public MATURITY_QUESTION_TYPES()
        {
            MATURITY_QUESTIONS = new HashSet<MATURITY_QUESTIONS>();
        }

        [Key]
        [StringLength(50)]
        public string Mat_Question_Type { get; set; }

        [InverseProperty("Mat_Question_TypeNavigation")]
        public virtual ICollection<MATURITY_QUESTIONS> MATURITY_QUESTIONS { get; set; }
    }
}