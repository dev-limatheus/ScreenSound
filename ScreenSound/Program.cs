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



Episodio epsisodio1 = new("O inicio", 1, 2);
epsisodio1.AdicionarCondidados("Rage");
epsisodio1.AdicionarCondidados("Lima");

Episodio epsisodio2 = new("Começando novamente", 2, 4);
epsisodio2.AdicionarCondidados("Mat");
epsisodio2.AdicionarCondidados("Lima");

Podcast podtech = new Podcast("Matheus", "PodTech");
podtech.AdicionarEpisodio(epsisodio1);
podtech.AdicionarEpisodio(epsisodio2);
podtech.ExibirDetalhes();



// albumQueen.AdicionarMusica(musica1);
// albumQueen.AdicionarMusica(musica2);
// queen.AdicionarAlbums(albumQueen);

// musica1.ExibirFicha();
// musica2.ExibirFicha();
// albumQueen.ExibirMusicasDoAlbum();
// queen.ExibirDiscografia();