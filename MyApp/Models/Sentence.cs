using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace MyApp.Models
{
    [Table("sentences")]
    public partial class Sentence
    {
        [Key]
        public int Id { get; set; }
        [StringLength(500)]
        public string SentenceText { get; set; }
    }
}
