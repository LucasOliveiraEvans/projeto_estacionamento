public class Estacionamento
{
    static void Main(string[] args)
    {
        List<string> listaVeiculos = new List<string>();
        
        string veiculoRemovido;
        double precoInicial;
        double precoHora;
        string opcao;
        int quantidadeHoras;

        Console.WriteLine("seja bem vindo ao sistema de estacionamento!");
        Console.WriteLine("Digite o preco inicial:");
        precoInicial = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Agora digite o preco por hora:");
        precoHora = Convert.ToDouble(Console.ReadLine());

        bool whileTrue = true;
        while(whileTrue)
        {
            Console.Clear();
            Console.WriteLine("Digite a sua opcao:");
            Console.WriteLine("1 - Cadastrar veiculo");
            Console.WriteLine("2 - Remover veiculo");
            Console.WriteLine("3 - Listar veiculo");
            Console.WriteLine("4 - Encerrar");
            
            opcao = Console.ReadLine();
            switch(opcao)
            {
                case "1":
                    Console.WriteLine("Digite a placa do veiculo para estacionar");
                    listaVeiculos.Add(Console.ReadLine());
                    break;
                
                case "2":
                    Console.WriteLine("Remover veiculo");
                    Console.WriteLine("Digite a placa do veiculo para remover:");
                    veiculoRemovido = Console.ReadLine();
                    if (listaVeiculos.Contains(veiculoRemovido))
                    {
                        listaVeiculos.Remove(veiculoRemovido);
                        Console.WriteLine("Digite a quantidade de horas que o veiculo permaneceu estacionado:");
                        quantidadeHoras = Convert.ToInt32(Console.ReadLine());
                        double precoPagamento = quantidadeHoras * precoHora + precoInicial;
                        Console.WriteLine($"O veiculo {veiculoRemovido} foi removido e o preco total foi de: R${precoPagamento}");
                    }
                    else
                    {
                        Console.WriteLine("Desculpe, esse veiculo nao está estacionado aqui.");
                    }
                    break;            

                case "3":
                    Console.WriteLine("Listar veiculos");
                    Console.WriteLine("Os veiculos estacionados sao:");
                    if(listaVeiculos.Count > 0)
                    {
                        for(int i = 0; i < listaVeiculos.Count; i++)
                        {
                            Console.WriteLine($"{listaVeiculos[i]}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Nenhum veiculo estacionado");
                    }
                    break;
                
                case "4":
                    Console.WriteLine("Encerrado sistema");
                    whileTrue = false;
                    break;

                default:
                    Console.WriteLine("opcao invalida!");
                    break;
            }
            Console.WriteLine("Pressione uma tecla para continuar");
            Console.ReadLine();
        }
    }
}