using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Lab5.Models
{
    public class Order
    {
        [Key]
        public int ContactID { get; set; }
        [Required(ErrorMessage = "Моля, въведете собствено име!"),
        Display(Name = "Собствено име:")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Моля, въведете фамилно име!"),
        Display(Name = "Фамилно име:")]
        public string FamilyName { get; set; }
        [Required(ErrorMessage = "Моля, въведете адрес за електронна поща!"),
        Display(Name = "Електронна поща:"),
        RegularExpression(@"^([0-9a-zA-Z]([\+\-_\.][0-9a-zA-Z]+)*)+@(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]*\.)+[a-zA-Z0-9]{2,3})$",
        ErrorMessage = "Моля, въведете валиден адрес за електронна поща!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Моля, изберете продукт!"),
        Display(Name = "Продукти:")]
        public string Product { get; set; }
        [Required(ErrorMessage = "Моля, изберете доставчик!"),
        Display(Name = "Доставчик:")]
        public string Deliever { get; set; }
        [Required(ErrorMessage = "Моля, въведете адрес!"),
        Display(Name = "Адрес:")]
        public string Address { get; set; }
        [NotMapped]
        public List<SelectListItem> Products { get; } =
        new List<SelectListItem> {
        new SelectListItem { Value = "AMD CPU Athlon 200GE", Text = "AMD CPU Athlon 200GE"},
        new SelectListItem { Value = "Intel CPU Pentium G5400", Text = "Intel CPU Pentium G5400"},
        new SelectListItem { Value = "Intel CPU Core i3 9100F", Text = "Intel CPU Core i3 9100F" },
        new SelectListItem { Value = "AMD CPU Ryzen 3 3200G", Text = "AMD CPU Ryzen 3 3200G"},
        new SelectListItem { Value = "Intel CPU Core i7 7740X", Text = "Intel CPU Core i7 7740X"},
        new SelectListItem { Value = "MSI VGA GeForce GT 710 1GB", Text = "MSI VGA GeForce GT 710 1GB"},
        new SelectListItem { Value = "Sapphire PCI-E R5 230 2GB", Text = "Sapphire PCI-E R5 230 2GB"},
        new SelectListItem { Value = "Gigabyte VGA GeForce GTX 1650 Windforce 4GB", Text = "Gigabyte VGA GeForce GTX 1650 Windforce 4GB"},
        new SelectListItem { Value = "Asrock VGA Radeon RX 570 8GB Phantom Gaming", Text = "Asrock VGA Radeon RX 570 8GB Phantom Gaming"},
        new SelectListItem { Value = "1Sapphire VGA Radeon RX 590 8GB", Text = "Sapphire VGA Radeon RX 590 8GB"},
        new SelectListItem { Value = "TeamGroup RAM DDR 1GB Dimm 400MHz", Text = "TeamGroup RAM DDR 1GB Dimm 400MHz"},
        new SelectListItem { Value = "GoldKey Desktop RAM Value 4GB 1600MHz DDR3", Text = "GoldKey Desktop RAM Value 4GB 1600MHz DDR3"},
        new SelectListItem { Value = "GoldKey RAM DDR2 2GB Dimm 800MHz", Text = "GoldKey RAM DDR2 2GB Dimm 800MHz"},
        new SelectListItem { Value = "Corsair Desktop RAM Vengeance 4GB 2400MHz DDR4", Text = "Corsair Desktop RAM Vengeance 4GB 2400MHz DDR4"},
        new SelectListItem { Value = "GoldKey Desktop RAM Value 2GB 1600MHz DDR3", Text = "GoldKey Desktop RAM Value 2GB 1600MHz DDR3"},
        };
        [NotMapped]
        public List<SelectListItem> Delievers { get; } =
        new List<SelectListItem> {
        new SelectListItem { Value = "Techspeed", Text = "Techspeed"},
        new SelectListItem { Value = "Arkspeed", Text = "Arkspeed"},
        new SelectListItem { Value = "Speedy", Text = "Speedy" },
        new SelectListItem { Value = "Techpanda", Text = "Techpanda"}
        };

    }
}
