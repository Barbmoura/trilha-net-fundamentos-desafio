Menu();

static void Menu()
{
    Console.WriteLine("Seja bem vindo ao sistema de estacionamento!\n" +
                      "A primeira hora é R$6,00 e a cada 1h acrescenta R$1,00.");
    Console.WriteLine("");

    SistemaPagamentoEstacionamento estacionamento = new();

    bool exibirMenu = true;

    while (exibirMenu)
    {              
        Console.WriteLine("Digite a sua opção:");
        Console.WriteLine("1 - Cadastrar veículo");
        Console.WriteLine("2 - Remover veículo");
        Console.WriteLine("3 - Listar veículos");
        Console.WriteLine("4 - Encerrar");

        switch (short.Parse(Console.ReadLine()))
        {
            case 1: estacionamento.CadastrarVeiculo(); break;

            case 2: estacionamento.RemoverVeiculo(); break;

            case 3: estacionamento.ListarVeiculos(); break;

            case 4: Environment.Exit(0); break;
                
            default: Console.WriteLine("Opção inválida."); break;
        }

        Console.WriteLine("Pressione uma tecla para continuar.");
        Console.ReadLine();
    }   
}

Console.WriteLine("O programa se encerrou.");