using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Models
{
    public class Expense
    {
        [Key]
      public int ID { get; set; }

        [Required]
        [Display(Name = "Expense name")]
        public string ExpenseName { get; set; }

        [Required]
      public  double Amount { get; set; }
    }
}
