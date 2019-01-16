using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace _16125296_OnlineStore.Models
{
    public partial class Category
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}