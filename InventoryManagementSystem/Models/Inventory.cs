using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryManagementSystem.Models
{
    public partial class Inventory
    {
        [Key]
        [Column("ProductID")]
        public int ProductId { get; set; }
        [Key]
        [Column("LocationID")]
        public int LocationId { get; set; }
        public bool? HasDisplayModel { get; set; }
        public int? QuantityOnHand { get; set; }
        public int? QuantityForSale { get; set; }
        public int? QuantityNotForSale { get; set; }
        public int? QuantityBin { get; set; }

        [ForeignKey(nameof(LocationId))]
        [InverseProperty(nameof(Locations.Inventory))]
        public virtual Locations Location { get; set; }
        [ForeignKey(nameof(ProductId))]
        [InverseProperty(nameof(Products.Inventory))]
        public virtual Products Product { get; set; }
    }
}
