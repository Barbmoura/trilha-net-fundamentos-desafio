public class SistemaPagamentoEstacionamento
{
    private readonly decimal precoInicial = 6;
    private readonly decimal precoPorHora = 1;
    private readonly List<string> listaVeiculos = [];

    public void CadastrarVeiculo()
    {
        Console.WriteLine("Digite a placa do seu veículo para poder estacionar:");
        listaVeiculos.Add(Console.ReadLine());
    }

    public void RemoverVeiculo()
    {
        Console.WriteLine("Digite a placa do veículo para sair do estacionamento:");

        string placa = Console.ReadLine();

        if (listaVeiculos.Any(x => x.Equals(placa, StringComparison.OrdinalIgnoreCase)))
        {
            Console.WriteLine("Informe quantas horas seu veículo permaneceu estacionado:");
            int tempoDePermanencia = Convert.ToInt32(Console.ReadLine());

            decimal valorTotal = precoInicial + precoPorHora * (tempoDePermanencia - 1);

            listaVeiculos.Remove(placa);

            Console.WriteLine($"Seu veículo de placa {placa} foi removido e o preço total foi de R${valorTotal}");
        }
        else
        {
            Console.WriteLine("Desculpe, esse veículo não encontra-se estacionado aqui. Confira se digitou a placa corretamente.");
        }
    }

    public void ListarVeiculos()
    {
        if (listaVeiculos.Any())
        {
            Console.WriteLine("Os veículos estacionados são:");
            foreach (var veiculo in listaVeiculos)
            {
                Console.WriteLine(veiculo.ToString());
            }
        }
        else
        {
            Console.WriteLine("Não há veículos estacionados.");
        }
    }
}