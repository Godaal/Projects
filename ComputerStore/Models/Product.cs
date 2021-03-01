using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
namespace Lab5.Models
{
    public class Product
    {
        [Key] [DatabaseGenerated(DatabaseGeneratedOption.None)] 
        [Required(ErrorMessage = "Идентификационният номер на продукт е задължителен"), 
            Display(Name = "Идентификационен номер"), 
            Range(1000, 1999, ErrorMessage = "Идентификационният номер на продукт трябва " + "да бъде между 1000 и 1999")] 
        public int? ProductID { get; set; }
        [Required(ErrorMessage = "Името на продукт е задължително"),
        StringLength(100), Display(Name = "Име")]
        public string ProductName { get; set; }
        [Required(ErrorMessage = "Описанието е задължително"),
        StringLength(10000), Display(Name = "Описание"),
        DataType(DataType.MultilineText)]
        public string Description { get; set; }
        [Display(Name = "Фотография")]
        public string ImagePath { get; set; }
        [Display(Name = "Цена")]
        public double? UnitPrice { get; set; }
        [Required(ErrorMessage = "Категорията е задължителна"), Display(Name = "Категория")] public int? CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
    }