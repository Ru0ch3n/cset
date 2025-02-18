﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace CSETWebCore.DataLayer.Model
{
    /// <summary>
    /// A collection of REQUIREMENT_SOURCE_FILES records
    /// </summary>
    public partial class REQUIREMENT_SOURCE_FILES
    {
        [Key]
        public int Requirement_Id { get; set; }
        [Key]
        public int Gen_File_Id { get; set; }
        [Key]
        [StringLength(850)]
        public string Section_Ref { get; set; }
        public int? Page_Number { get; set; }
        [StringLength(2000)]
        public string Destination_String { get; set; }

        [ForeignKey(nameof(Gen_File_Id))]
        [InverseProperty(nameof(GEN_FILE.REQUIREMENT_SOURCE_FILES))]
        public virtual GEN_FILE Gen_File { get; set; }
        [ForeignKey(nameof(Requirement_Id))]
        [InverseProperty(nameof(NEW_REQUIREMENT.REQUIREMENT_SOURCE_FILES))]
        public virtual NEW_REQUIREMENT Requirement { get; set; }
    }
}