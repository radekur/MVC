using System.ComponentModel.DataAnnotations;

namespace MvcBook.Models;

public class Book
{
    public int Id { get; set; }
    [Display(Name = "Tytuł")]
public string? Title { get; set; }
    [Display(Name = "Autor")]
    public string? Author { get; set; }
    [Display(Name = "Rok Wydania")]
    public int ReleaseYear { get; set; }
}