using System.Text.Json.Serialization;

namespace ScreenSound_04.Models;

internal class Musica
{
    [JsonPropertyName("song")]
    public string Nome { get; set; }

    [JsonPropertyName("artist")]
    public string Artista { get; set; }

    [JsonPropertyName("duration_ms")]
    public int Duracao { get; set; }

    [JsonPropertyName("genre")]
    public string Genero { get; set; }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Música: {Nome}");
        Console.WriteLine($"Duração: {Duracao / 1000}");
        Console.WriteLine($"Gênero: {Genero}");
    }
}
