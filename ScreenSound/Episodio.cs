class Episodio
{
    private List<string> convidados = new List<string>();
    public Episodio(string titulo, int ordem, int duracao)
    {
        Titulo = titulo;
        Ordem = ordem;
        DuracaoEp = duracao;
    }

    public int Ordem { get;  }
    public string Titulo { get;  }
    public int DuracaoEp { get;  }
    public string Resumo => $"Episodio {Ordem} - {Titulo} com {string.Join(", ", convidados)} tem a duração de {DuracaoEp} horas.  ";

    public void AdicionarCondidados(string convidado)
    {
        convidados.Add(convidado);
    }


}