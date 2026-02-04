class Podcast
{
    private List<Episodio> listaEps = new List<Episodio>();
    public Podcast(string host, string nome)
    {
        Host = host;
        Nome = nome;
    }

    public string Host { get;  }
    public string Nome { get; }
    public int TotalEpisodios => listaEps.Count;


    public void AdicionarEpisodio(Episodio episodio)
    {
        listaEps.Add(episodio);
    }

    public void ExibirDetalhes()
    {

        foreach (Episodio episodio in listaEps.OrderBy(e => e.Ordem)) 
        { 
            Console.WriteLine(episodio.Resumo);
        }
        Console.WriteLine($"\nEste Podcast possui {TotalEpisodios} episodios");
        
    }
}