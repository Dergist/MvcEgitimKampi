﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Writer
    {
        [Key]
        public int WriterID { get; set; }
        [StringLength(50)]
        public String WriterName { get; set; }
        [StringLength(50)]
        public string WriterSurname { get; set; }
        [StringLength(100)]
        public string WriterImage1 { get; set; }
        [StringLength(100)]
        public string WriterMail { get; set; }
        [StringLength(20)]
        public String WriterPassword { get; set; }

        //Burda da hangi tablo ile ilişkilendirecek isek onlara gönderiyoruz
        public ICollection<Heading> Headings { get; set; }
      public ICollection<Content> Contents { get; set; }
    }
}
