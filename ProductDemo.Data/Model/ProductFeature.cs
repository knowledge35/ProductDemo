using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProductDemo.Data.Model
{
    public class ProductFeature
    {
        [Key]
        public int ProductFeatureId { get; set; }
        [Required]
        public string FeatureName { get; set; }
        [Required]
        public string FeatureValue { get; set; }

        [Required]
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }

    }
}
