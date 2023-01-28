using System.ComponentModel.DataAnnotations;

namespace WebApi.Model;

public class Course
{
    [Key]
    public int Id {get;set;}

    [Required(ErrorMessage ="Name field is required")]
    public string Name {get;set;}

    [Required(ErrorMessage ="Description is required")]
    public string Description {get;set;}
}