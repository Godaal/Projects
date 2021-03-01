using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Lab5.Models
{
    public class Category {[Key] [DatabaseGenerated(DatabaseGeneratedOption.None)] 
        public int? CategoryID { get; set; }
        [Required(ErrorMessage = "Името на категория е задължително"), 
            StringLength(100), Display(Name = "Име")] 
        public string CategoryName { get; set; } 
        public virtual ICollection<Product> Products { get; set; } }
}