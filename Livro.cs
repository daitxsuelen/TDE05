class Livro
{
    public string titulo;

    public string autor;

    public int paginas;

    void ExibirInformacoes()
    {
        Console.WriteLine($"Titulo:  {titulo}, autor: {autor}, páginas: {paginas}");
    }

    public bool VerificarTrezentos()
    {
        return (paginas > 300);
    }

    
}