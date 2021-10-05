using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LaiHopQuang_01.Data
{
    public class LaiHopQuang_01Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx

        public LaiHopQuang_01Context() : base("name=LaiHopQuang_01Context")
        {
        }

        public System.Data.Entity.DbSet<LaiHopQuang_01.Models.Lophoc> Lophoc { get; set; }
        public System.Data.Entity.DbSet<LaiHopQuang_01.Models.SinhVien> SinhVien { get; set; }
    }
}