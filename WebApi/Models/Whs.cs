﻿using NanoidDotNet;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApi.Models
{
    [Table("WHOUSE")]
    public class Whs
    {
        [Key, Column("FCSKID")]
        public string Fcskid { get; set; } = Nanoid.Generate(size: 8);

        [Column("FCCODE")]
        public string? Fccode { get; set; }

        [Column("FCNAME")]
        public string? Fcname { get; set; }
    }
}
