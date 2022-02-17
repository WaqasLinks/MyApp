using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace MyApp.Models
{
    [Table("aspnetuserclaims")]
    [Index(nameof(UserId), Name = "IX_AspNetUserClaims_UserId")]
    public partial class Aspnetuserclaim
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string UserId { get; set; }
        public string ClaimType { get; set; }
        public string ClaimValue { get; set; }

        [ForeignKey(nameof(UserId))]
        [InverseProperty(nameof(Aspnetuser.Aspnetuserclaims))]
        public virtual Aspnetuser User { get; set; }
    }
}
