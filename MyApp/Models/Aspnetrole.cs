using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace MyApp.Models
{
    [Table("aspnetroles")]
    [Index(nameof(NormalizedName), Name = "RoleNameIndex", IsUnique = true)]
    public partial class Aspnetrole
    {
        public Aspnetrole()
        {
            Aspnetroleclaims = new HashSet<Aspnetroleclaim>();
            Aspnetuserroles = new HashSet<Aspnetuserrole>();
        }

        [Key]
        public string Id { get; set; }
        [StringLength(256)]
        public string Name { get; set; }
        [StringLength(256)]
        public string NormalizedName { get; set; }
        public string ConcurrencyStamp { get; set; }

        [InverseProperty(nameof(Aspnetroleclaim.Role))]
        public virtual ICollection<Aspnetroleclaim> Aspnetroleclaims { get; set; }
        [InverseProperty(nameof(Aspnetuserrole.Role))]
        public virtual ICollection<Aspnetuserrole> Aspnetuserroles { get; set; }
    }
}
