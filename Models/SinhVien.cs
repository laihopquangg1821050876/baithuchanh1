using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LaiHopQuang_01.Models
{
    [Table("SinhVien")]
    public  partial class SinhVien
    {
        [Key]
       
        public int Masinhvien { get; set; }
        [Required]
        [StringLength(50)]
        public string Hovaten { get; set; }
        public int Malop { get; set; }
    }
}