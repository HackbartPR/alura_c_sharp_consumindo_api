using System.Text.Json;

namespace Consumindo_API_de_Musicas.Modelos;

internal class MusicasFavoritas
{
    public string Nome { get; }
    public List<Musica> ListaDeMusicas { get; } = new List<Musica>();

    public MusicasFavoritas(string nome)
    {
        Nome = nome;
    }

    public void AdicionarMusica(Musica musica)
    {
        ListaDeMusicas.Add(musica);
    }

    public void MostrarListaDeMusicas()
    {
        ListaDeMusicas.ForEach(musica => Console.WriteLine($"- {musica.Nome} de {musica.Artista}"));
    }

    public void GerarArquivoJson()
    {
        string caminho = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory)!;
        string nomeArquivo = $"musicas-favoritas-{Nome}.json";
        string caminhoCompleto = $"{caminho}\\{nomeArquivo}";

        string conteudo = JsonSerializer.Serialize(new
        {
            nome = Nome,
            musicas = ListaDeMusicas
        });

        File.WriteAllTextAsync(caminhoCompleto, conteudo);
    }
}
