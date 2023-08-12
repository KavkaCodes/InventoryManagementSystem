using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryManagementSystem.Models
{
    public partial class Locations
    {
        public Locations()
        {
            Inventory = new HashSet<Inventory>();
        }

        [Key]
        [Column("LocationID")]
        public int LocationId { get; set; }
        [StringLength(100)]
        public string LocationName { get; set; }
        [Column(TypeName = "text")]
        public string Description { get; set; }

        [InverseProperty("Location")]
        public virtual ICollection<Inventory> Inventory { get; set; }
    }
}
