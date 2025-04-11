using System.ComponentModel.Design;

class PaisesRepository
{

    List<Pais> paises = new List<Pais>
{
    new Pais
    {
        Nome = "Brasil",
        Continente = "América do Sul",
        Populacao = 214000000,
        Capital = "Brasília",
        ProdutoInternoBruto = 1847000000000, // 1.847 tri USD
        PibPerCapita = 1847000000000 / 214000000.0
    },
    new Pais
    {
        Nome = "Estados Unidos",
        Continente = "América do Norte",
        Populacao = 331000000,
        Capital = "Washington, D.C.",
        ProdutoInternoBruto = 26800000000000, // 26.8 tri USD
        PibPerCapita = 26800000000000 / 331000000.0
    },
    new Pais
    {
        Nome = "Japão",
        Continente = "Ásia",
        Populacao = 125800000,
        Capital = "Tóquio",
        ProdutoInternoBruto = 4937000000000, // 4.937 tri USD
        PibPerCapita = 4937000000000 / 125800000.0
    },
    new Pais
    {
        Nome = "Alemanha",
        Continente = "Europa",
        Populacao = 83200000,
        Capital = "Berlim",
        ProdutoInternoBruto = 4214000000000, // 4.214 tri USD
        PibPerCapita = 4214000000000 / 83200000.0
    },
    new Pais
    {
        Nome = "Nigéria",
        Continente = "África",
        Populacao = 223800000,
        Capital = "Abuja",
        ProdutoInternoBruto = 477400000000, // 477.4 bi USD
        PibPerCapita = 477400000000 / 223800000.0
    }
};




    public void AddPais()
    {
        Pais pais = new Pais();

        Console.WriteLine("Informe o nome do país: ");
        pais.Nome = Console.ReadLine();

        Console.WriteLine("Informe a população do país: ");
        pais.Populacao = int.Parse(Console.ReadLine());

        Console.WriteLine("Informe o continente do país: ");
        pais.Continente = Console.ReadLine();

        Console.WriteLine("Informe a capital do país: ");
        pais.Capital = Console.ReadLine();

        Console.WriteLine("Informe o PIB do país: ");
        pais.ProdutoInternoBruto = double.Parse(Console.ReadLine());

        paises.Add(pais);

        pais.PibPerCapita = pais.ProdutoInternoBruto / pais.Populacao;


        Console.Clear();
        Console.WriteLine($"País {pais.Nome} com sucesso!");
    }

    public void ListarPaises()
    {
        Console.Clear();
        foreach (Pais pais in paises)
        {
            Console.WriteLine($"Nome do País: {pais.Nome} \n PIB/perCapita:  {pais.PibPerCapita} \n");
        }


    }

    public void RemoverPaises()
    {
        Console.Clear();
        Console.WriteLine("Informe o nome do Páis a ser removido: ");
        String nome = Console.ReadLine();
        Pais paisEncontrado = paises.FirstOrDefault(p => p.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));


        if (paisEncontrado != null)
        {
            paises.Remove(paisEncontrado);
            Console.WriteLine($"O país {paisEncontrado} foi removido com sucesso");
        }
        else
        {
            Console.WriteLine("País não encontrado");
        }
    }


    public void PesquisarPaieses()
    {
        Console.Clear();
        Console.WriteLine("Escreva o nome do País: ");
        string nomePesquisado = Console.ReadLine();

        foreach (Pais pais in paises)
        {
            if (pais.Nome.Equals(nomePesquisado, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine(pais);
                break;
            }
            else { Console.WriteLine("País não encontrado na base de dados"); }

        }
    }

    public void PesquisarPaisesContinente()
    {

        Console.Clear();
        Console.WriteLine("Digite uma opção a ser pesquisado: \n 1-África \n 2-America do Norte \n 3-America do Sul \n 4-Asia  \n 5-Europa");


        string continente = "";
        continente = Console.ReadLine();
        Console.Clear();



        string continenteEscolhido = "";
        switch (continente)
        {

            case "1":
                continenteEscolhido = "África";
                break;
            case "2":
                continenteEscolhido = "América do Norte";
                break;
            case "3":
                continenteEscolhido = "América do Sul";
                break;
            case "4":
                continenteEscolhido = "Ásia";
                break;
            case "5":
                continenteEscolhido = "Europa";
                break;
            default:
                Console.WriteLine("Opção inválida.");
                return;






        }

        {
            bool status = false;
            foreach (Pais pais in paises)
            {
                if (pais.Continente.Equals(continenteEscolhido, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Lista de Paises da ({continenteEscolhido})");
                    Console.WriteLine(pais.Nome);
                    status = true;


                }


            }
            if (!status)
            {
                Console.WriteLine("Nenhum País encontradado na base de dados");

            }

        }


    }
}

