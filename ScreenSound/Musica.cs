class Musica
{
    public string Nome { get; set; }
    public string Artista { get; set; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public string DescricaoResumida  => $"A música {Nome} pertence à banda {Artista}";
    

    public void ExibirFicha()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Nome: {Artista}");
        Console.WriteLine($"Nome: {Duracao}");
        if (Disponivel)
        {
            Console.WriteLine("Disponível no plano.");
        }
        else
        {
            Console.WriteLine("Adquira o plano Premium.");
        }
    }
}
