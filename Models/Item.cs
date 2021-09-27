using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Models
{
    public class Item
    {
        [Key]
        public int ID { get; set; }

        [Display(Name = "Item name")] [Required] 
        public string ItemName { get; set; }

        [Required]
        public string Borrower { get; set; }

        [Required]
        public string Lender { get; set; }
    }
}
