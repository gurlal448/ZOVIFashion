using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Zovi_Fashion.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }

        [Required]
        [StringLength(200)]
        public string ProductName { get; set; }

        [StringLength(400)]
        public string Fabric { get; set; }

        [StringLength(400)]
        public string ManufacturingYear { get; set; }

        [StringLength(400)]
        public string Description { get; set; }

        [StringLength(400)]
        public string Color { get; set; }

        [StringLength(400)]
        public string Fit { get; set; }

        [StringLength(400)]
        public string SleveLength { get; set; }

        [StringLength(400)]
        public string Occasion { get; set; }

        [StringLength(400)]
        public string PatternType { get; set; }

        [StringLength(400)]
        public string Size { get; set; }

        [StringLength(400)]
        public string Neck { get; set; }

        [StringLength(400)]
        public string WashCare { get; set; }

        [StringLength(400)]
        public string SoldBy { get; set; }

        [StringLength(400)]
        public string Price { get; set; }

        [Required]
        [StringLength(20)]
        public string Extension { get; set; }

        [Required]
        public int BrandID { get; set; }

        [ForeignKey("BrandID")]
        [InverseProperty("BrandProducts")]
        public virtual Brand Brand { get; set; }

        public virtual ICollection<ProductReview> ProductReviews { get; set; }

        [NotMapped]
        public SingleFileUpload File { get; set; }
    }

    public class SingleFileUpload
    {
        [Required]
        [Display(Name = "File")]
        public IFormFile FormFile { get; set; }
    }
}
