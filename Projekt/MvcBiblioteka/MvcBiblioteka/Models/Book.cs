using System.ComponentModel.DataAnnotations;

namespace MvcBook.Models;

public class Book
{
    public int Id { get; set; }

    [Display(Name = "Tytuł")]
    [Required(ErrorMessage ="Tytuł jest wymagany.")]
    [StringLength(100,MinimumLength=2,ErrorMessage="Tytuł musi mieć od 2 do 100 znaków.")]
public string? Title { get; set; }
    [Display(Name = "Autor")]
    [Required(ErrorMessage = "Autor jest wymagany.")]
    [StringLength(80, MinimumLength = 2, ErrorMessage = "Pole Autor musi mieć od 2 do 80 znaków.")]
    public string? Author { get; set; }
    [Display(Name = "Rok Wydania")]
    [Required(ErrorMessage = "Rok Wydania jest wymagany.")]
    [Range(-5000,2026, ErrorMessage = "Zły rok wydania. Podaj rok z przedziału -5000 - 2026")]
    public int ReleaseYear { get; set; }
}