// Banda queen = new Banda("Queen");

// Album albumQueen = new Album("A night at the opera");

// Musica musica1 = new Musica(queen, "Love of my life")
// {
//     Duracao = 213,
//     Disponivel = true,
// };

// Musica musica2 = new Musica(queen, "Bohemian Rhapsody")
// {
//     Duracao = 354,
//     Disponivel = false,
// };


Podcast podtech = new Podcast("Matheus", "PodTech");

Episodio epsisodio1 = new("O inicio", 1, 2);

epsisodio1.AdicionarCondidados("Rage");
epsisodio1.AdicionarCondidados("Lima");

podtech.AdicionarEpisodio(epsisodio1);
Console.WriteLine(epsisodio1.Resumo);
podtech.ExibirDetalhes();


// albumQueen.AdicionarMusica(musica1);
// albumQueen.AdicionarMusica(musica2);
// queen.AdicionarAlbums(albumQueen);

// musica1.ExibirFicha();
// musica2.ExibirFicha();
// albumQueen.ExibirMusicasDoAlbum();
// queen.ExibirDiscografia();