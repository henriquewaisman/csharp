using FilmesApi.Models;
using Microsoft.AspNetCore.Mvc;
namespace FilmesApi.Controllers;

// Anotações de cabeçalho
[ApiController]
[Route("[controller]")]
public class FilmeController : ControllerBase
{
    private static List<Filme> filmes = new List<Filme>(); // Para armazenamento de filmes na classe
    private static int id = 0; // Id incremental único para cada filme

    [HttpPost] // Especificação do método http post
    public IActionResult AdicionaFilme([FromBody] Filme filme)
    {
        filme.Id = id; // Posta o filme com o Id e incrementa para o próximo
        id ++;
        filmes.Add(filme); // Adiciona o parâmtro à lista estática
        return CreatedAtAction(nameof(RecuperaFilmePorId), new {id = filme.Id}, filme);
    }

    [HttpGet] // Especificação do método http get
    public IEnumerable<Filme> RecuperaFilmes([FromQuery] int skip = 0,
    [FromQuery] int take = 50)
    {
        return filmes.Skip(skip).Take(take);
    }

    [HttpGet("{id}")] // Especifica o http e o segundo parâmetro da query
    public IActionResult RecuperaFilmePorId(int id)
    {
        var filme = filmes.FirstOrDefault(filme => filme.Id == id);
        if(filme == null)
        {
            return NotFound(filme);
        }
        return Ok(filme);
    }
}