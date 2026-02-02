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
    public int TotalEpisodios { get; set; }


    public void AdicionarEpisodio(Episodio episodio)
    {
        listaEps.Add(episodio);
    }

    public void ExibirDetalhes()
    {

        foreach (Episodio episodio in listaEps) 
        { 
            Console.WriteLine($"Podcast {Nome} apresentado por {Host}");
            Console.WriteLine($"Episodio número: {episodio.Ordem}");
            Console.WriteLine($"Total de eps: {listaEps.Count}");
        }
        
    }
}