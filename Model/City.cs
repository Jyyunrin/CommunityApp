using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CommunityApp.Model;

public class City
{

    [Display(Name ="Id")]
    public int CityId { get; set;}

    [Display(Name ="City Name")]
    public string? CityName {get; set;}

    public int Population {get; set;}

    [Required]
    [MaxLength(2)]
    [Display(Name ="Province Code")]
    public string? ProvinceCode {get; set;}

    [ForeignKey("ProvinceCode")]
    public Province? Province {get; set;}

}
