using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace _16125296_OnlineStore.Models
{
    public class ProductImageMapping
    {
        public int ID { get; set; }
        public int ImageNumber { get; set; }
        public int ProductID { get; set; }
        public int ProductImageID { get; set; }
        public virtual Product Product { get; set; }
        public virtual ProductImage ProductImage { get; set; }
    }
}