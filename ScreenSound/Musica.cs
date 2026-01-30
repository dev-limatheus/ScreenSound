class Musica
{
    public string nome;
    public string artista;
    public int duracao;
    public bool disponivel;

    public void ExibirFicha()
    {
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Nome: {artista}");
        Console.WriteLine($"Nome: {duracao}");
        if (disponivel)
        {
            Console.WriteLine("Disponível no plano.");
        }
        else
        {
            Console.WriteLine("Adquira o plano Premium.");
        }
    }
}
