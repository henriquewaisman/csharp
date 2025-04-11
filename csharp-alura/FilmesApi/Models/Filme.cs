using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Models;

public class Filme
{
    [Required]
    [MaxLength(255, ErrorMessage = "Tamanho de título inválido.")]
    public string Titulo { get; set; }
    [Required]
    [MaxLength(255, ErrorMessage = "Tamanho de título inválido.")]
    public string Genero { get; set; }
    [Required]
    [Range(70, 600, ErrorMessage = "Duração deve ter entre 60 e 700 minutos.")]
    public int Duracao { get; set; }
}