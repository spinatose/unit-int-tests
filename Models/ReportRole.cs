﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MyEFDataLibrary.Models;

[Index("BusinessUnitId", Name = "IX_ReportRoles_BusinessUnitID")]
[Index("ReportId", Name = "IX_ReportRoles_ReportID")]
[Index("RoleId", Name = "IX_ReportRoles_RoleID")]
[Index("WorkspaceId", Name = "IX_ReportRoles_WorkspaceID")]
public partial class ReportRole : MyEntity
{
    [Key]
    [Column("ReportRoleID")]
    public int ReportRoleId { get; set; }

    [Column("RoleID")]
    public int RoleId { get; set; }

    [Column("BusinessUnitID")]
    public int BusinessUnitId { get; set; }

    [Column("WorkspaceID")]
    public int WorkspaceId { get; set; }

    [Column("ReportID")]
    public int ReportId { get; set; }

    [ForeignKey("BusinessUnitId")]
    [InverseProperty("ReportRoles")]
    public virtual BusinessUnit BusinessUnit { get; set; }

    [ForeignKey("ReportId")]
    [InverseProperty("ReportRoles")]
    public virtual Report Report { get; set; }

    [ForeignKey("RoleId")]
    [InverseProperty("ReportRoles")]
    public virtual Role Role { get; set; }

    [ForeignKey("WorkspaceId")]
    [InverseProperty("ReportRoles")]
    public virtual Workspace Workspace { get; set; }
}