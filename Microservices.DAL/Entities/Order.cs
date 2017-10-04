using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Microservices.DAL.Entities
{
    public class Order
    {
        [Key]
        public Guid OrderId { get; set; }
        public List<Product> Items { get; set; }
        public string DeliveryAddress { get; set; }
        public User Owner { get; set; }
    }
}
