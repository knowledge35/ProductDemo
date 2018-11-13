using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProductDemo.Data.Model
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        public string  ProductName { get; set; }
        public virtual ICollection<ProductFeature> FeatureImages { get; set; }
        public virtual ICollection<ProductFeature> ProductFeatures { get; set; }

        [Required]
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

    }
}
