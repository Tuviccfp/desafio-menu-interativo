using System;
using MenuInterativo.Models;

while (true)
{
    Console.WriteLine("Escolha uma das opções abaixo:");
    Console.WriteLine("1 - Cadastrar os clientes");
    Console.WriteLine("2 - Buscar cliente");
    Console.WriteLine("3 - Apagar cliente");
    Console.WriteLine("4 - Encerrar");
    string? option = Console.ReadLine();

    switch (option)
    {
        case "1":
            Console.WriteLine("Digite a quantidade de usuários a serem cadastrados:");
            string? quantClient = Console.ReadLine();
            if (int.TryParse(quantClient, out int clientCount) && clientCount > 0)
            {
                for (int i = 0; i < clientCount; i++)
                {
                    Console.WriteLine("Digite o nome do funcionário:");
                    string? name = Console.ReadLine();

                    Console.WriteLine("Digite a função do funcionário:");
                    string? func = Console.ReadLine();

                    Console.WriteLine("Digite a matrícula do funcionário:");
                    string? matricula = Console.ReadLine();

                    if (int.TryParse(matricula, out int matri) && matri > 0)
                    {
                        Client client1 = new Client(name, func, matri);
                        Console.WriteLine($"Cliente cadastrado com sucesso:\n{client1}");
                    }
                    else
                    {
                        Console.WriteLine("Matrícula inválida. Certifique-se de inserir um número positivo.");
                    }
                }
            }
            else
            {
                Console.WriteLine("Quantidade de clientes inválida. Certifique-se de inserir um número positivo.");
            }
            break;
        case "2":
            Console.WriteLine("");
            break;
        case "3":

            break;
        case "4":

            break;
    }

}