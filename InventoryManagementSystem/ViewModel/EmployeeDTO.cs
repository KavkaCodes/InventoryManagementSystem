using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace InventoryManagementSystem.ViewModel
{
    public class EmployeeDTO
    {
        public string EmployeeId { get; set; }
        
        public string Name { get; set; }
       
        public string Email { get; set; }
       
        public string Password { get; set; }
    }
}
