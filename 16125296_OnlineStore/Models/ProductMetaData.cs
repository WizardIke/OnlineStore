using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _16125296_OnlineStore.Models
{
    [MetadataType(typeof(ProductMetaData))]
    public partial class Product
    {
    }
    public class ProductMetaData
    {
        [Required(ErrorMessage = "The Product name cannot be blank")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Please enter a product name between 3 and 50 characters in length")]
        [RegularExpression(@"^[a-zA-z0-9'-'\s]*$", ErrorMessage = "Please enter a product name made up of only letters, numbers and spaces")]
        [Display(Name = "Product Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "The Product description cannot be blank")]
        [StringLength(500, MinimumLength = 5, ErrorMessage = "Please enter a product description between 5 and 500 characters in length")]
        [RegularExpression(@"^[a-zA-z0-9'-'\s\p{P}]*$", ErrorMessage = "Please enter a product description made up of only letters, numbers and spaces")]
        public string Description { get; set; }
        
        [Required(ErrorMessage = "The Product price cannot be blank")]
        [Range(0.10, 100000000, ErrorMessage = "Please enter a product price between 0.10 and 100000000")]
        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal Price { get; set; }
    }
}