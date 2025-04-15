using FilmesApi.Models;
using Microsoft.EntityFrameworkCore;

namespace FilmesApi.Data;

public class FilmeContexto : DbContext
{
    public FilmeContexto(DbContextOptions<FilmeContexto> opts) : base(opts)
    {
                
    }

    public DbSet<Filme> Filmes { get; set; }
}