class Pais
{
    public string Nome { get; set; }
    public string Continente { get; set; }
    public int Populacao { get; set; }
    public string Capital { get; set; }
    public double ProdutoInternoBruto { get; set; }
    public double PibPerCapita { get; set; }

    public Pais() { }

    public Pais(string nome, string continente, int populacao, string capital, double produtoInternoBruto, double pibPerCapita)
    {
        Nome = nome;
        Continente = continente;
        Populacao = populacao;
        Capital = capital;
        ProdutoInternoBruto = produtoInternoBruto;
        PibPerCapita = pibPerCapita;
    }

    public override string ToString()
    {
        return $"\nNome: {Nome}" +
               $"\nContinente: {Continente}" +
               $"\nPopulação: {Populacao}" +
               $"\nCapital: {Capital}" +
               $"\nPIB: {ProdutoInternoBruto}" +
               $"\nPIB per capita: {PibPerCapita}";
    }

}

