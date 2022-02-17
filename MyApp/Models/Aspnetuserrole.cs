using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace MyApp.Models
{
    [Table("aspnetuserroles")]
    [Index(nameof(RoleId), Name = "IX_AspNetUserRoles_RoleId")]
    public partial class Aspnetuserrole
    {
        [Key]
        public string UserId { get; set; }
        [Key]
        public string RoleId { get; set; }

        [ForeignKey(nameof(RoleId))]
        [InverseProperty(nameof(Aspnetrole.Aspnetuserroles))]
        public virtual Aspnetrole Role { get; set; }
        [ForeignKey(nameof(UserId))]
        [InverseProperty(nameof(Aspnetuser.Aspnetuserroles))]
        public virtual Aspnetuser User { get; set; }
    }
}
