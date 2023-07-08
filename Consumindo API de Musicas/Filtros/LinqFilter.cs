using Consumindo_API_de_Musicas.Modelos;

namespace Consumindo_API_de_Musicas.Filtros;

internal class LinqFilter
{
    public static void MostrarGenerosMusicais(List<Musica> musicas)
    {
        List<string?> generos = musicas.Select(musica => musica.Genero)
                                        .Distinct()
                                        .ToList();

        Console.WriteLine("Generos:\n");
        generos.ForEach(genero => Console.WriteLine($"- {genero}"));
    }

    public static void MostrarArtistaOrdenadosAsc(List<Musica> musicas)
    {
        List<string?> artistas = musicas.OrderBy(musica => musica.Artista)
                                        .Select(musica => musica.Artista)
                                        .Distinct()
                                        .ToList();

        Console.WriteLine("Artistas Ordenados Asc:\n");
        artistas.ForEach(artista => Console.WriteLine($"- {artista}"));
    }

    public static void MostrarArtistaPorGeneroMusicalEspecifico(List<Musica> musicas, string genero)
    {
        List<string?> artistas = musicas.Where(musica => musica.Genero!.Contains(genero))
                                        .OrderBy(musica => musica.Artista)
                                        .Select(musica => musica.Artista)
                                        .Distinct()
                                        .ToList();

        Console.WriteLine($"Artistas Do Gênero {genero}:\n");
        artistas.ForEach(artista => Console.WriteLine($"- {artista}"));
    }

    public static void MostrarMusicasPorArtistaEspecifico(List<Musica> musicas, string artista)
    {
        List<string> musicasFiltradas = musicas.Where(musica => musica.Artista!.Equals(artista))
                                               .OrderBy(musica => musica.Artista)
                                               .Select(musica => musica.Nome!)
                                               .Distinct()
                                               .ToList();

        Console.WriteLine($"Musicas do Artista {artista}:\n");
        musicasFiltradas.ForEach(musicas => Console.WriteLine($"- {musicas}"));
    }
}
