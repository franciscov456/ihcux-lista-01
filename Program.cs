using System;

class Program
{
    static void Main()
    {
        // Heurística #1: Visibilidade do Status
        // → Mostra em qual passo o usuário está

        // Heurística #3: Controle e Liberdade
        // → Usuário pode digitar "voltar" ou "cancelar"

        // Heurística #9: Ajuda e Erros
        // → Mensagens claras quando ocorre erro

        int codigoProduto = 0;
        int quantidade = 0;
        string entrada;

        // PASSO 1 - Código do Produto
        while (true)
        {
            Console.Clear();
            Console.WriteLine("[Passo 1 de 3] - Seleção de Produto");
            Console.WriteLine("Digite o código do produto (1 a 10)");
            Console.WriteLine("Digite 'cancelar' para sair");

            entrada = Console.ReadLine();

            if (entrada.ToLower() == "cancelar")
            {
                Console.WriteLine("Pedido cancelado.");
                return;
            }

            if (!int.TryParse(entrada, out codigoProduto))
            {
                Console.WriteLine("Entrada inválida! Digite apenas números.");
                Console.ReadKey();
                continue;
            }

            if (codigoProduto < 1 || codigoProduto > 10)
            {
                Console.WriteLine($"Código {codigoProduto} não encontrado. Nossos códigos vão de 1 a 10.");
                Console.ReadKey();
                continue;
            }

            break;
        }

        // PASSO 2 - Quantidade
        while (true)
        {
            Console.Clear();
            Console.WriteLine("[Passo 2 de 3] - Quantidade");
            Console.WriteLine("Digite a quantidade desejada");
            Console.WriteLine("Digite 'voltar' para retornar ou 'cancelar'");

            entrada = Console.ReadLine();

            if (entrada.ToLower() == "cancelar")
            {
                Console.WriteLine("Pedido cancelado.");
                return;
            }

            if (entrada.ToLower() == "voltar")
            {
                Main();
                return;
            }

            if (!int.TryParse(entrada, out quantidade))
            {
                Console.WriteLine("Quantidade inválida! Digite apenas números.");
                Console.ReadKey();
                continue;
            }

            if (quantidade <= 0)
            {
                Console.WriteLine("A quantidade deve ser maior que zero.");
                Console.ReadKey();
                continue;
            }

            break;
        }

        // PASSO 3 - Confirmação
        while (true)
        {
            Console.Clear();
            Console.WriteLine("[Passo 3 de 3] - Confirmação");
            Console.WriteLine($"Produto: {codigoProduto}");
            Console.WriteLine($"Quantidade: {quantidade}");
            Console.WriteLine("Confirmar pedido? (sim/voltar/cancelar)");

            entrada = Console.ReadLine().ToLower();

            if (entrada == "cancelar")
            {
                Console.WriteLine("Pedido cancelado.");
                return;
            }

            if (entrada == "voltar")
            {
                Main();
                return;
            }

            if (entrada == "sim")
            {
                Console.WriteLine("Pedido realizado com sucesso!");
                break;
            }

            Console.WriteLine("Opção inválida!");
            Console.ReadKey();
        }
    }
}
