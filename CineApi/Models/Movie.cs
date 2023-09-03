using System.ComponentModel.DataAnnotations;

namespace CineApi.Models;

public class Movie
{
    [Required(ErrorMessage = "A movie must have a title!")]
    [StringLength(30, ErrorMessage ="A movies max length is 30 chars!")]
    public string Title { get; set; }
    [Required(ErrorMessage = "A movie must have a genre!")]
    [MaxLength(50, ErrorMessage = "The genre max length is 50 chars!")]
    public string Genre { get; set; }
    [Required(ErrorMessage = "A movie must have some time in minute!")]
    [Range(70, 600, ErrorMessage ="The duration of the movie must be between 70 and 600 minutes")]
    public int Duration { get; set; }
}
