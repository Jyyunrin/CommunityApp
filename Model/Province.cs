using System;
using System.ComponentModel.DataAnnotations;

namespace CommunityApp.Model;

public class Province
{
    [Key]
    [MaxLength(2)]
    [Display(Name ="Province Code")]
    public string? ProvinceCode {get; set;}

    [Display(Name ="Province Name")]
    public string? ProvinceName {get; set;}

    public List<City>? Cities {get; set;}

    

}
