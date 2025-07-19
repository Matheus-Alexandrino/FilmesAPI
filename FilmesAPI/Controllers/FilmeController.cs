using FilmesAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace FilmesAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class FilmeController : ControllerBase
{
    private static List<Filme> filmes = new List<Filme>();
    [HttpPost]
    public void AdicionaFilme([FromBody] Filme filme) //Anotacao FromBody explicita que vem do body da req
    {   
        //if (!string.IsNullOrEmpty(filme.Titulo) &&
        //    filme.Titulo.Length <= 200)
        //    !string.IsNullOrEmpty(filme.Genero) &&
        //    filme.Duracao >= 70)
        //{ 
            filmes.Add(filme);
            Console.WriteLine(filme.Titulo);
            Console.WriteLine(filme.Duracao);
            Console.WriteLine(filme.Genero);
        //}
    }    
}
