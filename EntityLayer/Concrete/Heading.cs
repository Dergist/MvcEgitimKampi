using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Heading
    {
        [Key]
        public int HeadingID { get; set; }
        [StringLength(50)]
        public string HeadingName { get; set; }
        
        public DateTime HeadingDate { get; set; }
       
        //yazar tablosu ile ilişkilendiriyoruz ve burda yazarın Id sını göreceğiz yani yazarı burdan karşılayacağız
        public int WriterID { get; set; }
        public virtual Writer Writer { get; set; }

        //Category Tablosu ile ilişkilendiğini ve ordaki CategoryID ile ilişkilendirip
        //Anahtar kelimemin Category olduğunu belirtiyorum
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }

        //Başlık ile açıklamayı ilişkilendiriyoruz
        public ICollection<Content> Contents { get; set; }
        
    }
}
