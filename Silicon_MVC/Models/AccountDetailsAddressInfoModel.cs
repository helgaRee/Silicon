﻿using System.ComponentModel.DataAnnotations;

namespace Silicon_MVC.Models;

public class AccountDetailsAddressInfoModel
{

    [Display(Name = "Address Line 1", Prompt = "Enter your Address", Order = 0)]
    [Required(ErrorMessage = "Address is required")]
    public string AddressLine_1 { get; set; } = null!;


    [Display(Name = "Address Line 2", Prompt = "Enter your Address (optional)", Order = 1)]
    public string? AddressLine_2 { get; set; }



    [Display(Name = "Postal code", Prompt = "Enter your postal code", Order = 2)]
    [DataType(DataType.PostalCode)]
    [Required(ErrorMessage = "Postal code is required")]
    public string PostalCode { get; set; } = null!;



    [Display(Name = "City", Prompt = "Enter your city", Order = 3)]
    [Required(ErrorMessage = "City is required")]
    public string City { get; set; } = null!;
}
