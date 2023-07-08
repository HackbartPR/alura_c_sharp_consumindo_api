using Consumindo_API_de_Musicas.Filtros;
using Consumindo_API_de_Musicas.Modelos;
using System.Text.Json;

using (HttpClient cliente = new HttpClient())
{
    try
    {
        string resposta = await cliente.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");

        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        
        //musicas.ForEach(musica => Console.WriteLine($"Artista: {musica.Artista} -> Genero: {musica.Genero}"));

        //musicas[0].ExibirDetalhes();

        //LinqFilter.MostrarGenerosMusicais(musicas);

        //LinqFilter.MostrarArtistaOrdenadosAsc(musicas);

        //Console.Write("\nDigite o gênero musical dos artistas que deseja visualizar: ");
        //string genero = Console.ReadLine()!;
        //LinqFilter.MostrarArtistaPorGeneroMusicalEspecifico(musicas, genero);

        //Console.Write("\nDigite o nome do artista que deseja visualizar as músicas: ");
        //string artista = Console.ReadLine()!;
        //LinqFilter.MostrarMusicasPorArtistaEspecifico(musicas, artista);

        MusicasFavoritas musicasFavoritas = new("Carlos");
        musicasFavoritas.AdicionarMusica(musicas[356]);
        musicasFavoritas.AdicionarMusica(musicas[18]);
        musicasFavoritas.AdicionarMusica(musicas[15]);
        musicasFavoritas.AdicionarMusica(musicas[1996]);
        musicasFavoritas.AdicionarMusica(musicas[734]);

        musicasFavoritas.MostrarListaDeMusicas();
        musicasFavoritas.GerarArquivoJson();
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}

