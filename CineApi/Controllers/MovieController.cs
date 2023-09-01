using Microsoft.AspNetCore.Mvc;
using CineApi.Models;

namespace CineApi.Controllers;

[ApiController]
[Route("[controller]")]
public class MovieController: ControllerBase
{
    // static to remain the class to the object
    private static List<Movie> movies = new List<Movie>();

    [HttpPost]
    public void CreateMovie([FromBody] Movie movie)
    {
        movies.Add(movie);
        Console.WriteLine(movie.Title);
        Console.WriteLine(movie.Genre);
        Console.WriteLine(movie.Duration);
    }
}
