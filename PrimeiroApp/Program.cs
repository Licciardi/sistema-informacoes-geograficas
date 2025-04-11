//InfoCountry
String mensagem = @"
██╗███╗░░██╗███████╗░█████╗░░█████╗░░█████╗░██╗░░░██╗███╗░░██╗████████╗██████╗░██╗░░░██╗
██║████╗░██║██╔════╝██╔══██╗██╔══██╗██╔══██╗██║░░░██║████╗░██║╚══██╔══╝██╔══██╗╚██╗░██╔╝
██║██╔██╗██║█████╗░░██║░░██║██║░░╚═╝██║░░██║██║░░░██║██╔██╗██║░░░██║░░░██████╔╝░╚████╔╝░
██║██║╚████║██╔══╝░░██║░░██║██║░░██╗██║░░██║██║░░░██║██║╚████║░░░██║░░░██╔══██╗░░╚██╔╝░░
██║██║░╚███║██║░░░░░╚█████╔╝╚█████╔╝╚█████╔╝╚██████╔╝██║░╚███║░░░██║░░░██║░░██║░░░██║░░░
╚═╝╚═╝░░╚══╝╚═╝░░░░░░╚════╝░░╚════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝░░░╚═╝░░░╚═╝░░╚═╝░░░╚═╝░░░";
PaisesRepository paisesRepository = new PaisesRepository();


void exibirMensagemDeBoasVindas()
{ 
      Console.WriteLine(mensagem);
}
void exibirMenu()

    
{
    int opcao = 0;

    do
    {

   


    Console.WriteLine("\n=== Menu de Países ===");
    Console.WriteLine("1 - Adicionar um país");
    Console.WriteLine("2 - Listar países");
    Console.WriteLine("3 - Remover um país");
    Console.WriteLine("4 - Procurar um país");
    Console.WriteLine("5 - Listar países por continente");
    Console.WriteLine("6 - Atualizar dados de um país");
    Console.WriteLine("7 - Sair do menu");
    Console.Write("\nEscolha uma opção: ");

    

    if(int.TryParse(Console.ReadLine(), out opcao))
    {

    
    switch (opcao)
    {
        case 1:
                paisesRepository.AddPais();
                break;
        case 2:
                  paisesRepository.ListarPaises();
                 break;
        case 3:
                    paisesRepository.RemoverPaises();
            break;
        case 4:
                    paisesRepository.PesquisarPaieses();
            break;
        case 5:
                paisesRepository.PesquisarPaisesContinente();
            break;
        case 6:
            Console.WriteLine("Atualizar dados de um País");
            break;
        case 7:
            Console.WriteLine("Sair do Menu");
            break;
        default:
            Console.WriteLine("Comando Invalido");
            break;
    }
    }
    else
    {
        Console.Clear();
        Console.WriteLine("COMANDO INVALIDO");
        exibirMenu();
    }
    } while (opcao != 7);


}

exibirMensagemDeBoasVindas();
exibirMenu();



