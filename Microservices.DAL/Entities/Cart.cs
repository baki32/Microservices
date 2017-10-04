using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Microservices.DAL.Entities
{
    public class Cart
    {
        [Key]
        public Guid CartId { get; set; }
        public User Owner { get; set; }
        public List<Product> Products { get; set; }
    }
}
