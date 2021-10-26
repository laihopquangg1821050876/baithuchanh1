using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LaiHopQuang_01.Models
{
    public class People
    {
        [Key] 
        public int PeopleId {get; set; }
        public string PeopleName { get; set; }
    }
}