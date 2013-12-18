using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class Message
    {
        [Key]
        public long ID { get; set; }
        public long SenderID { get; set; }
        [ForeignKey("SenderID")]
        public virtual Person Sender { get; set; }
        [InverseProperty("ID")]
        public IEnumerable<Person> Recipients { get; set; }
        [MaxLength(60)]
        public string FilePath { get; set; }
        public double Length { get; set; }
        public bool Public { get; set; }
    }
}