﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MyEFDataLibrary.Models;

public partial class Workspace : MyEntity
{
    [Key]
    [Column("WorkspaceID")]
    public int WorkspaceId { get; set; }

    [Required]
    public string Name { get; set; }

    public string Description { get; set; }

    [Column("PBI_WorkspaceID")]
    public Guid? PbiWorkspaceId { get; set; }

    [InverseProperty("Workspace")]
    public virtual ICollection<ReportRole> ReportRoles { get; set; } = new List<ReportRole>();
}