using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryManagementSystem.Models
{
    public partial class Employees
    {
        [Key]
        [Column("EmployeeID")]
        public int EmployeeId { get; set; }
        [StringLength(100)]
        public string Password { get; set; }
        [StringLength(50)]
        public string NameFirst { get; set; }
        [StringLength(50)]
        public string NameLast { get; set; }
        [StringLength(20)]
        public string ContactPhone { get; set; }
        [StringLength(100)]
        public string ContactEmail { get; set; }
        [StringLength(20)]
        public string Status { get; set; }
    }
}
