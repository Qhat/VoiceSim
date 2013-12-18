using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class Person
    {
        [Key]
        public long ID { get; set; }
        [MaxLength(20)]
        public string UserName { get; set; }
        public virtual IEnumerable<Person> Contacts { get; set; }
        public string Bio { get; set; }
    }
}