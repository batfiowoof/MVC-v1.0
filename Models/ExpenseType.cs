using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Models
{
    public class ExpenseType
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [Display(Name = "Expense type name")]
        public string ExpenseTypeName { get; set; }


    }
}
