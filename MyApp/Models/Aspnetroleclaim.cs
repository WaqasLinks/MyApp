using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace MyApp.Models
{
    [Table("aspnetroleclaims")]
    [Index(nameof(RoleId), Name = "IX_AspNetRoleClaims_RoleId")]
    public partial class Aspnetroleclaim
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string RoleId { get; set; }
        public string ClaimType { get; set; }
        public string ClaimValue { get; set; }

        [ForeignKey(nameof(RoleId))]
        [InverseProperty(nameof(Aspnetrole.Aspnetroleclaims))]
        public virtual Aspnetrole Role { get; set; }
    }
}
