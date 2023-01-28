using System.ComponentModel.DataAnnotations;

namespace WebApi.Model;

public class Category
{
    [Key]
    public int Id {get;set;}

    [Required(ErrorMessage ="Title is compulsory")]
    public string Title {get;set;}

    [Required(ErrorMessage ="Category name is compulsory")]
    public string CategoryName {get;set;}
}