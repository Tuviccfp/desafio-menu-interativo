using System;
using MenuInterativo.Models;


internal class Program
{
    static List<Client> clients = new List<Client>();
    private static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Escolha uma das opções abaixo:");
            Console.WriteLine("1 - Cadastrar funcionário\n");
            Console.WriteLine("2 - Buscar todos os funcionários\n");
            Console.WriteLine("3 - Buscar um funcionário\n");
            Console.WriteLine("4 - Editar um funcionário\n");
            Console.WriteLine("5 - Apagar um funcionário\n");
            Console.WriteLine("6 - Encerrar um programa\n");
            string? option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Console.WriteLine("Digite a quantidade de usuários a serem cadastrados:");
                    if (int.TryParse(Console.ReadLine(), out int clientCount) && clientCount > 0)
                    {
                        for (int i = 0; i < clientCount; i++)
                        {
                            Console.WriteLine($"\nDigite o nome do {i + 1} funcionário:");
                            string? name = Console.ReadLine();

                            Console.WriteLine($"\nDigite a função do {i + 1} funcionário:");
                            string? func = Console.ReadLine();

                            Console.WriteLine($"\nDigite a matrícula do {i + 1} funcionário:");
                            if (int.TryParse(Console.ReadLine(), out int matri) && matri > 0)
                            {
                                Client client1 = new Client(name, func, matri);
                                clients.Add(client1);
                                Console.WriteLine($"\nCliente cadastrado com sucesso: \n {client1} \n");
                            }
                            else
                            {
                                Console.WriteLine("Matrícula inválida. Certifique-se de inserir a matrícula correta.");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Quantidade de clientes inválida. Certifique-se de inserir um número positivo.");
                    }
                    break;
                case "2":
                        if (clients.Count > 0)
                        {
                            foreach (Client client in clients)
                            {
                                Console.WriteLine("\nLista de usuários: \n");
                                Console.WriteLine(client);
                            }
                        }
                        else
                        {
                            Console.WriteLine("\nNão existe nenhum usuário cadastrado para ser listado. \n");
                        }
                    break;
                case "3":
                    Console.WriteLine("\nDigite o número da matricula: ");
                    if (int.TryParse(Console.ReadLine(), out int value))
                    {
                        Client? searchClient = clients.Find(client => client.Matricula == value);
                        if (searchClient != null)
                        {
                            Console.WriteLine($"Cliente encontrado: \n {searchClient}");
                        }
                        else
                        {
                            Console.WriteLine("Não é possível localizar o usuário");
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nDigite um número válido ou positivo.");
                    }
                    break;
                case "4":
                    Console.WriteLine("Digite o número da matricula: ");
                    if(int.TryParse(Console.ReadLine(), out int mat)) {
                        Client? searchClient = clients.Find(client => client.Matricula == mat);
                        if (searchClient != null)
                        {
                            Console.WriteLine("Digite o nome do funcionário: ");
                            string? newName = Console.ReadLine();
                            Console.WriteLine("Digite a nova função do funcionário: ");
                            string? newFunc = Console.ReadLine();
                            searchClient.Name = newName;
                            searchClient.FuncStaff = newFunc;
                            Console.WriteLine($"Confirma a alteração? \n{searchClient}");
                            if(bool.TryParse(Console.ReadLine(), out bool result)) {
                                if (result)
                                {
                                    Console.WriteLine("Alteração concluida com sucesso.");
                                    Console.WriteLine(searchClient.ToString());
                                }
                                else
                                {
                                 Console.WriteLine("Alteração cancelada.");   
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Cliente não encontrado.");
                        }
                    }
                    break;
                case "5":
                    Console.WriteLine("\nInforme a mátricula do usuário que será deletado:");
                    if (int.TryParse(Console.ReadLine(), out int valueDelete))
                    {
                        Client? searchClient = clients.Find(client => client.Matricula == valueDelete);
                        if (searchClient != null)
                        {
                            clients.Remove(searchClient);
                            Console.WriteLine($"Cliente deletado: {searchClient}");
                        }
                        else
                        {
                            Console.WriteLine("Cliente não encontrado");
                        }
                    }
                    break;
                case "6":
                    Console.WriteLine("Deseja mesmo encerrar o Programa?");
                    if(bool.TryParse(Console.ReadLine(), out bool exit)) 
                    Console.WriteLine("Programa encerrado com sucesso.");
                    Environment.Exit(0);
                    break;
            }

        }
    }
}