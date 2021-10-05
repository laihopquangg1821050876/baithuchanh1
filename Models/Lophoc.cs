using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LaiHopQuang_01.Models
{
    [Table("Lophoc")]
    public partial class Lophoc
    {
        [Key] 
        public int Malop { get; set; }
        [Required]
        [StringLength(50)]
        public string Tenlop { get; set; }
    }
}