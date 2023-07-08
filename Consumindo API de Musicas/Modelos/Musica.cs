using System.Text.Json.Serialization;

namespace Consumindo_API_de_Musicas.Modelos;

internal class Musica
{
    [JsonPropertyName("artist")]    
    public string? Artista { get; set; }

    [JsonPropertyName("song")]
    public string? Nome { get; set; }

    [JsonPropertyName("duration_ms")]
    public int Duracao { get; set; }

    [JsonPropertyName("genre")]
    public string? Genero { get; set; }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"\nNome: {this.Nome}");
        Console.WriteLine($"\nArtista: {this.Artista}");
        Console.WriteLine($"\nDuração (s): {this.Duracao / 1000}");
        Console.WriteLine($"\nGênero: {this.Genero}");
    }
}
