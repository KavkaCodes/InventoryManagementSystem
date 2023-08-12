using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryManagementSystem.Models
{
    public partial class Products
    {
        public Products()
        {
            Inventory = new HashSet<Inventory>();
        }

        [Key]
        [Column("ProductID")]
        public int ProductId { get; set; }
        [StringLength(100)]
        public string ProductName { get; set; }
        [Column(TypeName = "text")]
        public string Description { get; set; }
        [StringLength(50)]
        public string Brand { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal? Price { get; set; }
        [StringLength(20)]
        public string Barcode { get; set; }
        public bool? IsSold { get; set; }

        [InverseProperty("Product")]
        public virtual ICollection<Inventory> Inventory { get; set; }
    }
}
