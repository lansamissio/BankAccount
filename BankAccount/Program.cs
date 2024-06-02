using System;

class Program
{
    static void Main()
    {
        // Solicita o nome do usuário
        Console.Write("Digite seu nome: ");
        string nome = Console.ReadLine();

        // Solicita a data de nascimento do usuário
        Console.Write("Digite sua data de nascimento (dd/mm/aaaa): ");
        string dataNascimentoStr = Console.ReadLine();

        // Converte a data de nascimento para DateTime
        DateTime dataNascimento;
        if (!DateTime.TryParseExact(dataNascimentoStr, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out dataNascimento))
        {
            Console.WriteLine("Data de nascimento inválida. Por favor, use o formato dd/mm/aaaa.");
            return;
        }

        // Solicita o CPF do usuário
        Console.Write("Digite seu CPF: ");
        string cpf = Console.ReadLine();

        // Exibe os dados de volta para o usuário
        Console.WriteLine("\nInformações fornecidas:");
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Data de Nascimento: {dataNascimento.ToString("dd/MM/yyyy")}");
        Console.WriteLine($"CPF: {cpf}");
    }
}
